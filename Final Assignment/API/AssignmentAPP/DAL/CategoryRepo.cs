using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryRepo
    {
        static PMSEntities context;
        static CategoryRepo()
        {
            context = new PMSEntities();
        }
        public static void AddCategory(category model)
        {
            context.categories.Add(model);
            context.SaveChanges();
        }
        public static List<category> GetAllCategories()
        {
            var data = context.categories.ToList();
            return data;
        }
        public static category GetCategory(int id)
        {
            var data = context.categories.FirstOrDefault(e => e.id == id);
            return data;
        }
    }
}
