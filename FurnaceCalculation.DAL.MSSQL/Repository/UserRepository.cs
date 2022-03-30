using FurnaceCalculation.DAL.MSSQL.Context;
using FurnaceCalculation.DAL.MSSQL.Entity;
using FurnaceCalculation.DAL.MSSQL.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace FurnaceCalculation.DAL.MSSQL.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly FurnaceCalculationContext _context;

        public UserRepository(FurnaceCalculationContext context)
        {
            _context = context;
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public bool Delete(string email)
        {
            var user = Get(email);
            if(user != null)
            {
                _context.Users.Remove(user);
                return true;
            }
            return false;
        }

        public User Get(string email) =>
            _context.Users.FirstOrDefault(user => user.Mail == email);

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public void Update(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}

