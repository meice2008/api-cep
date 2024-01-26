using ApiCep.Interfaces;
using Refit;
using ApiCep.Services;
using ApiCep.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var apiBaseUrl = builder.Configuration["ServiceUrl:CepApiUrl"];

builder.Services.AddRefitClient<IApiCep>().ConfigureHttpClient(c => c.BaseAddress = new Uri(apiBaseUrl));

builder.Services.AddScoped<ICepService, CepService>();
builder.Services.AddScoped<IEnderecoService, EnderecoService>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
