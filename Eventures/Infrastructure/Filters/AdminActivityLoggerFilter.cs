using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace Eventures.Infrastructure.Filters
{
    public class AdminActivityLoggerFilter : IActionFilter
    {
        private readonly ILogger<AdminActivityLoggerFilter> _logger;

        public AdminActivityLoggerFilter(ILogger<AdminActivityLoggerFilter> logger)
        {
            _logger = logger;
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ActionDescriptor.DisplayName.Contains("EventsController")&&
                context.ActionDescriptor.DisplayName.Contains("Create"))
            {
                _logger.LogInformation("Mina");
                
            }
            this._logger.LogInformation(context.ActionDescriptor.DisplayName);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}