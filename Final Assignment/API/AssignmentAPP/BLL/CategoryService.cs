using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using BLL.MapperConfig;
using DAL;
namespace BLL
{
    public class CategoryService
    {
        public static void AddCategory(CategoryDetail model)
        {
            var data = AutoMapper.Mapper.Map<CategoryDetail, category>(model);
            CategoryRepo.AddCategory(data);
        }

        public static CategoryDetail GetCategory(int id)
        {
            var data = CategoryRepo.GetCategory(id);
            var cat = AutoMapper.Mapper.Map<category, CategoryDetail>(data);
            return cat;
        }
        public static List<CategoryDetail> GetAllCategory()
        {
            var data = CategoryRepo.GetAllCategories();
            var cat = AutoMapper.Mapper.Map<List<category>, List<CategoryDetail>>(data);
            return cat;
        }
    }
}
