
using System.ComponentModel.DataAnnotations;

namespace FurnaceСalculation.API.Entity
{
    public class Register
    {
        [Required(ErrorMessage = "Не указана фамилия")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указан Email")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введен неверно")]
        public string ConfirmPassword { get; set; }
    }
}
