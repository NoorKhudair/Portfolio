using System.ComponentModel.DataAnnotations;

namespace Portfolio.ViewModels
{
    public class RegisterViewModel
    {

        public string UserName { get; set; }
        [DataType(DataType.Password)]

        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Confirmation must be matched")]

        public string PasswordConfirmation { get; set; }
    }
}
