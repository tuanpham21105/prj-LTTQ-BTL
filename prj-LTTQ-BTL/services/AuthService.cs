using prj_LTTQ_BTL.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_LTTQ_BTL.Services
{
    internal class AuthService
    {
        private UserRepository _userRepository;
        public AuthService()
        {
            _userRepository = new UserRepository();
        }
        public string AuthenticateUser(string username, string password)
        {
            try
            {
                var user = _userRepository.GetUserByUsernameAndPassword(username, password);
                if (user != null)
                {
                    return user["role"].ToString();
                }
                return null;
            }
            catch(Exception ex)
            {
                throw new Exception($"Lỗi đăng nhập:{ex.Message}");
            }
        }
    }
}
