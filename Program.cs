var builder = WebApplication.CreateBuilder(args);

// Servisleri yapılandır
builder.Services.AddControllers();

var app = builder.Build();

// Ortam kontrolü
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Routing yapılandırması
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();