using CoffeeMachine.API.Model;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CoffeeMachine.API.CustomFilter
{
    public class APICountFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //_APICounter.Instance.APICount++;
            APICounter.APICount++;
        }
    }
}
