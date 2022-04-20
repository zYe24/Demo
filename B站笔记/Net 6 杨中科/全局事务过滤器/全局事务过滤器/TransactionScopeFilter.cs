using System.Transactions;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace 全局事务过滤器;

/// <summary>
/// 
/// </summary>
public class TransactionScopeFilter : IAsyncActionFilter
{
	public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
	{
		bool noTransaction = false;
		if (context.ActionDescriptor is ControllerActionDescriptor controllerActionDescriptor)
		{
			if (controllerActionDescriptor.MethodInfo.GetCustomAttributes(typeof(NoTransactionAttribute), true).Length > 0)
			{
				noTransaction = true;
			}
		}

		if (noTransaction)
		{
			await next();
			return;
		}

		using TransactionScope transaction = new TransactionScope();
		Console.WriteLine("开始事务");
		ActionExecutedContext result = await next();
		if (result.Exception is null)
		{
			transaction.Complete();
			Console.WriteLine("提交事务");
		}
		else
		{
			Console.WriteLine("回滚事务");
		}
	}
}