using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BEL;
using BLL.MapperConfig;
using DAL;

namespace BLL
{
    public class DetailService
    {
        public static DetailModel GetDetailDetails(int id)
        {
            var data = DetailRepo.GetDetailDetails(id);
            var detailDetails = AutoMapper.Mapper.Map<Detail, DetailModel>(data);
            return detailDetails;
        }
        public static List<DetailModel> GetAllDetailDetails()
        {
            var data = DetailRepo.GetAllDetailDetails();
            var detailsDetails = AutoMapper.Mapper.Map<List<Detail>, List<DetailModel>>(data);
            return detailsDetails;
        }
        public static void AddDetail(DetailModel data)
        {
            var detailData = AutoMapper.Mapper.Map<DetailModel, Detail>(data);
            DetailRepo.AddDetail(detailData);
        }

        public static void UpdateDetailDetails(DetailModel newData)
        {
            var detailData = AutoMapper.Mapper.Map<DetailModel, Detail>(newData);
            DetailRepo.UpdateDetailDetails(detailData);
        }

        public static void DeleteDetail(int id)
        {
            DetailRepo.DeleteDetail(id);
        }
    }
}