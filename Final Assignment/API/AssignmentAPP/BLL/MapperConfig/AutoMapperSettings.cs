using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BEL;
using DAL;

namespace BLL.MapperConfig
{
    public class AutoMapperSettings : Profile
    {
        public AutoMapperSettings()
        {
            CreateMap<ProductModel, product>().ForMember(e => e.category, d => d.Ignore());
            CreateMap<category, CategoryDetail>();
            CreateMap<order, OrderDetail>();
        }
        
    }
}
