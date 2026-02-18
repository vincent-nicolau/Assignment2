using Assignment2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        [BindProperty]
        public PersonModel? PersonModel { get; set; }
        public void OnGet()
        {
            _logger.LogInformation("Index - OnGet");
            if (PersonModel != null)
            {
                _logger.LogInformation("Name={Name}", PersonModel.Name);
                _logger.LogInformation("Age={Age}", PersonModel.Age);
            }
        }

        public IActionResult OnPost()
        {
            _logger.LogInformation("Index - OnPost");
            if (PersonModel != null)
            {
                _logger.LogInformation("Name={Name}", PersonModel.Name);
                _logger.LogInformation("Age={Age}", PersonModel.Age);
            }
            return RedirectToPage("/PostRedirect", new {Name = PersonModel?.Name, Age = PersonModel?.Age});
        }
    }
}
