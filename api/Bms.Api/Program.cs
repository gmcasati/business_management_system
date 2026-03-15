using Bms.Api.Features.Businesses;
using Bms.Api.Features.Businesses.CreateBusiness;
using Bms.Domain.Repositories;
using Bms.Infrastructure;
using Bms.Infrastructure.Persistence;
using Bms.Infrastructure.Persistence.Business;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi("v1", options =>
{
    options.AddDocumentTransformer((document, _, _) =>
    {
        document.Info.Title = "Business Management System API";
        document.Info.Description = "HTTP API for managing businesses and related operations.";
        document.Info.Version = "v1";
        return Task.CompletedTask;
    });
});
builder.Services.AddDbContext<BusinessesDbContext>(opt => opt.UseInMemoryDatabase("BusinessDb"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddScoped<CreateBusinessHandler>();
builder.Services.AddScoped<IBusinessRepository, BusinessInMemoryRepository>();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.DocumentTitle = "BMS API - Swagger UI";
        options.SwaggerEndpoint("/openapi/v1.json", "Business Management System API v1");
    });
}

app.MapBusinessesEndpoints();
app.UseHttpsRedirection();

app.Run();