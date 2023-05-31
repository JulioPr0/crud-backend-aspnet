using Backend.Common;
using Backend.Interface;
using Backend.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
configurationBuilder.AddJsonFile("AppSettings.json");
IConfiguration Configuration = configurationBuilder.Build();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
Global.ConnectionString = Configuration.GetConnectionString("DefaultConnections");
builder.Services.AddScoped<IJabatan, JabatanService>();

builder.Services.AddCors(p => p.AddPolicy("corspolicy", build =>
{
    build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();

}));

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: "AllowOrigin",
    builder =>
    {
        builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corspolicy");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

