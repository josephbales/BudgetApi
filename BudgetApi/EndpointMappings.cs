using BudgetApi.ApiModels;
using BudgetApi.RequestHandlers.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BudgetApi
{
    internal static class EndpointMappings
    {
        private const string GuidRegex = "regex((?im)^[{{(]?[0-9A-F]{{8}}[-]?(?:[0-9A-F]{{4}}[-]?){{3}}[0-9A-F]{{12}}[)}}]?$)";

        internal static void MapEndpoints(this WebApplication app)
        {
            app.MapPost("/api/user/create",
                ([FromBody] User user, IUserRequestHandler userHandler) => userHandler.Create(user))
                .WithName("CreateUser")
                .WithTags(new[] { "User" });
            app.MapDelete($"/api/user/delete/{{userId:{GuidRegex}}}",
                ([FromRoute] Guid userId, IUserRequestHandler userHandler) => userHandler.Delete(userId))
                .WithName("DeleteUser")
                .WithTags(new[] { "User" });
            app.MapPut("/api/user/update",
                ([FromBody] User user, IUserRequestHandler userHandler) => userHandler.Update(user))
                .WithName("UpdateUser")
                .WithTags(new[] { "User" });
            app.MapGet($"/api/user/{{userId:{GuidRegex}}}",
                ([FromRoute] Guid userId, IUserRequestHandler userHandler) => userHandler.Read(userId))
                .WithName("GetUser")
                .WithTags(new[] { "User" });

            app.MapPost("/api/budget/create",
                ([FromBody] Budget budget, IBudgetRequestHandler budgetHandler) => budgetHandler.Create(budget))
                .WithName("CreateBudget")
                .WithTags(new[] { "Budget" });
            app.MapDelete($"/api/budget/delete/{{budgetId:{GuidRegex}}}",
                ([FromRoute] Guid budgetId, IBudgetRequestHandler budgetHandler) => budgetHandler.Delete(budgetId))
                .WithName("DeleteBudget")
                .WithTags(new[] { "Budget" });
            app.MapPut("/api/budget/update",
                ([FromBody] Budget budget, IBudgetRequestHandler budgetHandler) => budgetHandler.Update(budget))
                .WithName("UpdateBudget")
                .WithTags(new[] { "Budget" });
            app.MapGet($"/api/budget/{{budgetId:{GuidRegex}}}",
                ([FromRoute] Guid budgetId, IBudgetRequestHandler budgetHandler) => budgetHandler.Read(budgetId))
                .WithName("GetBudget")
                .WithTags(new[] { "Budget" });

            app.MapPost("/api/budget-item/create",
                ([FromBody] BudgetItem budgetItem, IBudgetItemRequestHandler budgetItemHandler) => budgetItemHandler.Create(budgetItem))
                .WithName("CreateBudgetItem")
                .WithTags(new[] { "BudgetItem" });
            app.MapDelete($"/api/budget-item/delete/{{budgetItemId:{GuidRegex}}}",
                ([FromRoute] Guid budgetItemId, IBudgetItemRequestHandler budgetItemHandler) => budgetItemHandler.Delete(budgetItemId))
                .WithName("DeleteBudgetItem")
                .WithTags(new[] { "BudgetItem" });
            app.MapPut("/api/budget-item/update",
                ([FromBody] BudgetItem budgetItem, IBudgetItemRequestHandler budgetItemHandler) => budgetItemHandler.Update(budgetItem))
                .WithName("UpdateBudgetItem")
                .WithTags(new[] { "BudgetItem" });
            app.MapGet($"/api/budget-item/{{budgetItemId:{GuidRegex}}}",
                ([FromRoute] Guid budgetItemId, IBudgetItemRequestHandler budgetItemHandler) => budgetItemHandler.Read(budgetItemId))
                .WithName("GetBudgetItem")
                .WithTags(new[] { "BudgetItem" });

            app.MapPost("/api/monthly-budget/create",
                ([FromBody] MonthlyBudget monthlyBudget, IMonthlyBudgetRequestHandler monthlyBudgetHandler) => monthlyBudgetHandler.Create(monthlyBudget))
                .WithName("CreateMonthlyBudget")
                .WithTags(new[] { "MonthlyBudget" });
            app.MapDelete($"/api/monthly-budget/delete/{{monthlyBudgetId:{GuidRegex}}}",
                ([FromRoute] Guid monthlyBudgetId, IMonthlyBudgetRequestHandler monthlyBudgetHandler) => monthlyBudgetHandler.Delete(monthlyBudgetId))
                .WithName("DeleteMonthlyBudget")
                .WithTags(new[] { "MonthlyBudget" });
            app.MapPut("/api/monthly-budget/update",
                ([FromBody] MonthlyBudget monthlyBudget, IMonthlyBudgetRequestHandler monthlyBudgetHandler) => monthlyBudgetHandler.Update(monthlyBudget))
                .WithName("UpdateMonthlyBudget")
                .WithTags(new[] { "MonthlyBudget" });
            app.MapGet($"/api/monthly-budget/{{monthlyBudgetId:{GuidRegex}}}",
                ([FromRoute] Guid monthlyBudgetId, IMonthlyBudgetRequestHandler monthlyBudgetHandler) => monthlyBudgetHandler.Read(monthlyBudgetId))
                .WithName("GetMonthlyBudget")
                .WithTags(new[] { "MonthlyBudget" });

            app.MapPost("/api/monthly-budget-item/create",
                ([FromBody] MonthlyBudgetItem monthlyBudgetItem, IMonthlyBudgetItemRequestHandler monthlyBudgetItemHandler) => monthlyBudgetItemHandler.Create(monthlyBudgetItem))
                .WithName("CreateMonthlyBudgetItem")
                .WithTags(new[] { "MonthlyBudgetItem" });
            app.MapDelete($"/api/monthly-budget-item/delete/{{monthlyBudgetItemId:{GuidRegex}}}",
                ([FromRoute] Guid monthlyBudgetItemId, IMonthlyBudgetItemRequestHandler monthlyBudgetItemHandler) => monthlyBudgetItemHandler.Delete(monthlyBudgetItemId))
                .WithName("DeleteMonthlyBudgetItem")
                .WithTags(new[] { "MonthlyBudgetItem" });
            app.MapPut("/api/monthly-budget-item/update",
                ([FromBody] MonthlyBudgetItem monthlyBudgetItem, IMonthlyBudgetItemRequestHandler monthlyBudgetItemHandler) => monthlyBudgetItemHandler.Update(monthlyBudgetItem))
                .WithName("UpdateMonthlyBudgetItem")
                .WithTags(new[] { "MonthlyBudgetItem" });
            app.MapGet($"/api/monthly-budget-item/{{monthlyBudgetItemId:{GuidRegex}}}",
                ([FromRoute] Guid monthlyBudgetItemId, IMonthlyBudgetItemRequestHandler monthlyBudgetItemHandler) => monthlyBudgetItemHandler.Read(monthlyBudgetItemId))
                .WithName("GetMonthlyBudgetItem")
                .WithTags(new[] { "MonthlyBudgetItem" });
        }
    }
}
