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
    public class TanantService
    {
        public static List<TanantModel>GetTanant()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Tanant, TanantModel>())).Map<List<TanantModel>>(DataAccessFactory.TanatDataAccess().Get());
            return data;
        }

        public static TanantModel GetTanantId(int id)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Tanant, TanantModel>())).Map<TanantModel>(DataAccessFactory.TanatDataAccess().Get(id));
            return data;
        }

        public static bool EditTanant(TanantModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<TanantModel, Tanant>())).Map<Tanant>(e);

            try
            {
                DataAccessFactory.TanatDataAccess().Edit(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool AddTanant(TanantModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<TanantModel, Tanant>())).Map<Tanant>(e);

            try
            {
                DataAccessFactory.TanatDataAccess().Add(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteTanant(int id)
        {
            try
            {
                DataAccessFactory.TanatDataAccess().Delete(id);
                return true;

            }
            catch
            {
                return false;
            }
        }
    }
}
