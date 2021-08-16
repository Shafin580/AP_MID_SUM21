using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BEL;
using BLL.MapperConfig;
using DAL;

namespace BLL
{
    public class TypeService
    {
        public static TypeModel GetTypeDetails(int id)
        {
            var data = TypeRepo.GetTypeDetails(id);
            var typeDetails = AutoMapper.Mapper.Map<DAL.Type, TypeModel>(data);
            return typeDetails;
        }
        public static List<TypeModel> GetAllTypeDetails()
        {
            var data = TypeRepo.GetAllTypeDetails();
            var typesDetails = AutoMapper.Mapper.Map<List<DAL.Type>, List<TypeModel>>(data);
            return typesDetails;
        }

        public static TypeDetail GetTypeFullDetails(int id)
        {
            var data = TypeRepo.GetTypeDetails(id);
            var typeDetail = AutoMapper.Mapper.Map<DAL.Type, TypeDetail>(data);
            return typeDetail;
        }

        public static List<TypeDetail> GetAllTypeFullDetails()
        {
            var data = TypeRepo.GetAllTypeDetails();
            var typeDetails = AutoMapper.Mapper.Map<List<DAL.Type>, List<TypeDetail>>(data);
            return typeDetails;
        }
        public static void AddType(TypeModel data)
        {
            var typeData = AutoMapper.Mapper.Map<TypeModel, DAL.Type>(data);
            TypeRepo.AddType(typeData);
        }

        public static void UpdateTypeDetails(TypeModel newData)
        {
            var typeData = AutoMapper.Mapper.Map<TypeModel, DAL.Type>(newData);
            TypeRepo.UpdateTypeDetails(typeData);
        }

        public static void DeleteType(int id)
        {
            TypeRepo.DeleteType(id);
        }
    }
}