using FurnaceCalculation.BusinessLogic.Exceptions;
using FurnaceCalculation.BusinessLogic.Interface;
using FurnaceCalculation.DAL.MSSQL.Entity;
using FurnaceCalculation.DAL.MSSQL.Repository.Interface;
using System;


namespace FurnaceCalculation.BusinessLogic.Service
{
    public class AuthService : IAuthService<User>
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public string Login(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) && string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException(nameof(email));
            }

            var user = _userRepository.Get(email);

            if (user == null)
            {
                throw new NotFoundException($"User does not exist");
            }

            if(user.Password == password)
            {
                return "Добро пожаловать";
            }
            return "Пароли не совпадают";
        }

        public string Register(User user)
        {
            if (user != null)
            {
                _userRepository.Add(user);
                return "Successfully registed";
            }
            return "not Successfully registed";
        }
    }
}
