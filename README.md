# SampleECommerce

## Setup (Proje Kurulumu & Ayağa Kaldırılması)
-Api projesinde bulunan "appsettings.json" dosyasında ConnectionString isteğe göre düzenlendikten sonra 

```
add-migration Initial -Context SampleECommerceIdentityDbContext
Update-database -Context SampleECommerceIdentityDbContext
```

komutları kullanılarak projenin Identity kısmı api üzerinden test edilebilir. Geriye kalan kısmı ne yazık ki henüz hazır değil.
