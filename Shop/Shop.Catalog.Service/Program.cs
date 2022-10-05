using Shop.Catalog.Service.Entities;
using Shop.Common.Settings;
using Shop.Common.MongoDB;
using Shop.Common.MassTransit;

var builder = WebApplication.CreateBuilder(args);

const string AllowedOriginSettings = "AllowedOrigin";

// Add services to the container.

builder.Services.AddControllers(builder =>
{
    builder.SuppressAsyncSuffixInActionNames = false;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMongo()
    .AddMongoRepository<Item>("items")
    .AddMassTransitWithRabbitMq();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(cors =>
    {
        cors.WithOrigins(builder.Configuration[AllowedOriginSettings])
            .AllowAnyHeader().AllowAnyMethod();
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
