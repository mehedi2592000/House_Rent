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

        public static OwnerModel GetId(int id)
        {
            var config=new MapperConfiguration(cfg => cfg.CreateMap<Owner, OwnerModel>());          
            var mapper=new Mapper(config);
            var data=mapper.Map<OwnerModel>(DataAccessFactory.OwnerDataAccess().Get(id));
            return data;

        }

        public static bool Edit(OwnerModel e)
        {
             

            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<OwnerModel, Owner>())).Map<Owner>(e);

            try
            {
                 DataAccessFactory.OwnerDataAccess().Edit(data);
                return true;    
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteOwner(int id)
        {
            try
            {
                DataAccessFactory.OwnerDataAccess().Delete(id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool AddOwner(OwnerModel e)
        {
            var data=new Mapper(new MapperConfiguration(cfg=>cfg.CreateMap<OwnerModel,Owner>())).Map<Owner>(e);

            try
            {
                DataAccessFactory.OwnerDataAccess().Add(data);
                return true;

            }
            catch
            {
                return false;
            }
        }
    }
}
