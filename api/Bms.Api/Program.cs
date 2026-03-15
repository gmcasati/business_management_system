using Bms.Api.Features.Businesses;
using Bms.Api.Features.Businesses.BusinessDetail;
using Bms.Api.Features.Businesses.CreateBusiness;
using Bms.Api.Features.Businesses.DeleteBusiness;
using Bms.Api.Features.Businesses.ListBusinesses;
using Bms.Api.Features.Businesses.UpdateBusiness;
using Bms.Domain.Repositories;
using Bms.Infrastructure;
using Bms.Infrastructure.Persistence;
using Bms.Infrastructure.Persistence.Business;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<BusinessesDbContext>(opt => opt.UseInMemoryDatabase("BusinessDb"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddScoped<CreateBusinessHandler>();
builder.Services.AddScoped<ListBusinessesHandler>();
builder.Services.AddScoped<BusinessDetailHandler>();
builder.Services.AddScoped<UpdateBusinessHandler>();
builder.Services.AddScoped<DeleteBusinessHandler>();
builder.Services.AddScoped<IBusinessRepository, BusinessRepository>();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "v1");
    });
}

app.MapBusinessesEndpoints();
app.UseHttpsRedirection();

app.Run();