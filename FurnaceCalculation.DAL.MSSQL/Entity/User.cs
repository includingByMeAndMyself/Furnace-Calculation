
using FurnaceCalculation.Domain.Entity;
using System.ComponentModel.DataAnnotations;

namespace FurnaceCalculation.DAL.MSSQL.Entity
{
    public class User : IUser
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Mail { get; set; }

        public string Password { get; set; }
    }
}
