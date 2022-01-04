using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SerilogDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("You've requested the Index Page.");

            try
            {
                for (var i = 0; i < 100; i++)
                {
                    if (i == 56)
                    {
                        throw new Exception("This is our demo exception.");
                    }
                    else
                    {
                        _logger.LogInformation("The value of i is {iVariable}.", i);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "We caught this exception in the Index Get Call.");
            }
        }
    }
}