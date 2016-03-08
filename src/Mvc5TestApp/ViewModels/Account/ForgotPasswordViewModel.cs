using System.ComponentModel.DataAnnotations;

namespace Mvc5TestApp.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
