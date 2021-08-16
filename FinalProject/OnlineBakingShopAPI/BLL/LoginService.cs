using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BEL;
using BLL.MapperConfig;
using DAL;

namespace BLL
{
    public class LoginService
    {
        public static List<LoginModel> GetAllLoginDetails()
        {
            var data = LoginRepo.GetAllLoginDetails();
            var loginsDetails = AutoMapper.Mapper.Map<List<Login>, List<LoginModel>>(data);
            return loginsDetails;
        }
        public static void AddLogin(LoginModel data)
        {
            var LoginData = AutoMapper.Mapper.Map<LoginModel, Login>(data);
            LoginRepo.AddLogin(LoginData);
        }

        public static void UpdateLoginDetails(LoginModel newData)
        {
            var LoginData = AutoMapper.Mapper.Map<LoginModel, Login>(newData);
            LoginRepo.UpdateLoginDetails(LoginData);
        }

        public static void DeleteLogin(string username)
        {
            LoginRepo.DeleteLogin(username);
        }
    }
}