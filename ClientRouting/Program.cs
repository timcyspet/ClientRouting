using Autofac;
using Autofac.Extensions.DependencyInjection;
using ClientRouting.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new ClientRouting.Business.AutofacBusinessModule());    
});
builder.Services.AddSwaggerGen(c =>
{
    // Add the authorization header to Swagger requests
    //c.OperationFilter<SwaggerAuthorizationFilter>();
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Client Routing API", Version = "v1" });
});
builder.Services.AddDbContext<ClientRoutingDBContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
