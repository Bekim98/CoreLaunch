// ✅ DOĞRU - using'ler EN ÜSTTE
using CoreLaunch.Application;
using CoreLaunch.Persistence;


var builder = WebApplication.CreateBuilder(args);

// 1. Adım: Connection String'i (Veritabanı adresini) ayarlar dosyasından al
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// 2. Adım: KATMANLARI SİSTEME ENJEKTE ET (En kritik nokta!)
// Bu satırlar, hazırladığımız o devasa mimariyi ayağa kaldıran anahtarlardır.
builder.Services.AddPersistenceServices(connectionString!); // Veritabanı ve UnitOfWork hazır!
builder.Services.AddApplicationServices();                 // MediatR ve Validatorlar hazır!

// 3. Adım: Web API Standart Servisleri (Swagger, Controller vb.)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Test ekranını (UI) açar

var app = builder.Build();

// 4. Adım: HTTP İstek Hattı (Middleware Pipeline)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();   // Swagger arayüzünü aktif et
    app.UseSwaggerUI(); // Swagger görselini göster
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers(); // Controller'larımızı (Endpoint) dünyaya aç!

app.Run();
