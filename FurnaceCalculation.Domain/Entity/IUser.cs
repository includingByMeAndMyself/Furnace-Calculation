﻿
namespace FurnaceCalculation.Domain.Entity
{
    public interface IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
    }
}
