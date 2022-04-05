using BudgetApi;
using BudgetApi.RequestHandlers;
using BudgetApi.RequestHandlers.Contracts;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IUserRequestHandler, UserRequestHandler>();
builder.Services.AddScoped<IBudgetRequestHandler, BudgetRequestHandler>();
builder.Services.AddScoped<IBudgetItemRequestHandler, BudgetItemRequestHandler>();
builder.Services.AddScoped<IMonthlyBudgetRequestHandler, MonthlyBudgetRequestHandler>();
builder.Services.AddScoped<IMonthlyBudgetItemRequestHandler, MonthlyBudgetItemRequestHandler>();

builder.Services.AddDbRepositories(builder.Configuration.GetSection("CosmosDb"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapEndpoints();

app.Run();
