using Assignment2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment2.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }
        [BindProperty]
        public PersonModel? PersonModel { get; set; }
        public void OnGet()
        {
            _logger.LogInformation("Privacy - OnGet");
            if (PersonModel != null)
            {
                _logger.LogInformation("Name={Name}", PersonModel.Name);
                _logger.LogInformation("Age={Age}", PersonModel.Age);
            }
        }

        public void OnPost()
        {
        }
    }
}