
namespace FurnaceCalculation.BusinessLogic.Interface
{
    public interface IAuthService<T>
    {
        public string Login(string email, string password);
        public string Register(T user);
    }
}
