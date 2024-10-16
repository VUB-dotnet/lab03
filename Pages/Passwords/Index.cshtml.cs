using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PasswordsApp.Models;

namespace PasswordsApp.Pages;

public class IndexModel : PageModel
{
    [BindProperty(SupportsGet = true)]
    public Password Password { get; set; }

    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        Password = new Password();
    }

    public void OnGet()
    {
        Password.GeneratePassword();
    }

    // SLIM CONTROLLER, FAT MODEL
}
