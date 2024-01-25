using TodoApi.Interfaces;
using Refit;
using TodoApi.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var apiBaseUrl = builder.Configuration["ServiceUrl:CepApiUrl"];

builder.Services.AddRefitClient<IApiCep>().ConfigureHttpClient(c => c.BaseAddress = new Uri(apiBaseUrl));
builder.Services.AddScoped<ICepService, CepService>();


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
