using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnaceCalculation.DAL.MSSQL.Entity
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
    }
}
