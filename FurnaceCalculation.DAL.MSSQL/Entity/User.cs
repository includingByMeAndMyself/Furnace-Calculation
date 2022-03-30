
using FurnaceCalculation.Domain.Entity;
using System.ComponentModel.DataAnnotations;

namespace FurnaceCalculation.DAL.MSSQL.Entity
{
    public class User : IUser
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Mail { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
