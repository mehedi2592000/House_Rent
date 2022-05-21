using AutoMapper;
using Buseness_Entity_Layer;
using Data_Entity_Layer;
using Data_Entity_Layer.AccessFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buseness_Logic_Layer.services
{
    public class OwnerService
    {
        public static List<OwnerModel>GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Owner, OwnerModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<OwnerModel>>(DataAccessFactory.OwnerDataAccess().Get());
            return data;
        }
    }
}
