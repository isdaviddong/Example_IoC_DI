using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplicationLoggin.Pages
{
    public class indexModel : PageModel
    {
        private readonly ILogger _logger;

        public indexModel(ILogger<indexModel>  logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            _logger.LogTrace("------------> LogTrace被執行");
            _logger.LogDebug("------------> LogDebug被執行");
            _logger.LogInformation("------------> LogInformation被執行");
            _logger.LogWarning("------------> LogWarning被執行");
            _logger.LogError("------------> LogError被執行");
            _logger.LogCritical("------------> LogCritical被執行");
        }
    }
}