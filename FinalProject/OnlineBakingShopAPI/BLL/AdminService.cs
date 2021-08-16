using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BEL;
using BLL.MapperConfig;
using DAL;

namespace BLL
{
    public class AdminService
    {
        public static AdminModel GetAdminDetails(string username)
        {
            var data = AdminRepo.GetAdminDetails(username);
            var adminDetails = AutoMapper.Mapper.Map<Admin, AdminModel>(data);
            return adminDetails;
        }
        public static List<AdminModel> GetAllAdminDetails()
        {
            var data = AdminRepo.GetAllAdminDetails();
            var adminsDetails = AutoMapper.Mapper.Map<List<Admin>, List<AdminModel>>(data);
            return adminsDetails;
        }
        public static void AddAdmin(AdminModel data)
        {
            var adminData = AutoMapper.Mapper.Map<AdminModel, Admin>(data);
            AdminRepo.AddAdmin(adminData);
        }

        public static void UpdateAdminDetails(AdminModel newData)
        {
            var adminData = AutoMapper.Mapper.Map<AdminModel, Admin>(newData);
            AdminRepo.UpdateAdminDetails(adminData);
        }

        public static void DeleteAdmin(string username)
        {
            AdminRepo.DeleteAdmin(username);
        }
    }
}