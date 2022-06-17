
using AutoMapper;
using SampleECommerce.Application.Constants;
using SampleECommerce.Application.Contracts.Persistence;
using Microsoft.AspNetCore.Http;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SampleECommerce.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly SampleECommerceDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;



        public UnitOfWork(SampleECommerceDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            this._httpContextAccessor = httpContextAccessor;
        }

  
        
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save() 
        {
            var username = _httpContextAccessor.HttpContext.User.FindFirst(CustomClaimTypes.Uid)?.Value;

            await _context.SaveChangesAsync(username);
        }
    }
}
