using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BEL;
using BLL.MapperConfig;
using DAL;

namespace BLL
{
    public class CourierService
    {
        public static CourierModel GetCourierDetails(string username)
        {
            var data = CourierRepo.GetCourierDetails(username);
            var courierDetails = AutoMapper.Mapper.Map<Courier, CourierModel>(data);
            return courierDetails;
        }
        public static List<CourierModel> GetAllCourierDetails()
        {
            var data = CourierRepo.GetAllCourierDetails();
            var couriersDetails = AutoMapper.Mapper.Map<List<Courier>, List<CourierModel>>(data);
            return couriersDetails;
        }
        public static void AddCourier(CourierModel data)
        {
            var courierData = AutoMapper.Mapper.Map<CourierModel, Courier>(data);
            CourierRepo.AddCourier(courierData);
        }

        public static void UpdateCourierDetails(CourierModel newData)
        {
            var courierData = AutoMapper.Mapper.Map<CourierModel, Courier>(newData);
            CourierRepo.UpdateCourierDetails(courierData);
        }

        public static void DeleteCourier(string username)
        {
            CourierRepo.DeleteCourier(username);
        }

        public static CourierDetail GetCourierFullDetails(string username)
        {
            var data = CourierRepo.GetCourierDetails(username);
            var courierDetail = AutoMapper.Mapper.Map<Courier, CourierDetail>(data);
            return courierDetail;
        }

        public static List<CourierDetail> GetAllCourierFullDetails()
        {
            var data = CourierRepo.GetAllCourierDetails();
            var courierDetails = AutoMapper.Mapper.Map<List<Courier>, List<CourierDetail>>(data);
            return courierDetails;
        }
    }
}