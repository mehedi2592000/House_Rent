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
    public class CostService
    {
        public static List<CostModel> GetCost()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Cost, CostModel>())).Map<List<CostModel>>(DataAccessFactory.CostDataAccess().Get());
            return data;
        }

        public static CostModel GetCostId(int id)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Cost, CostModel>())).Map<CostModel>(DataAccessFactory.CostDataAccess().Get(id));
            return data;
        }

        public static bool EditCost(CostModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CostModel, Cost>())).Map<Cost>(e);

            try
            {
                DataAccessFactory.CostDataAccess().Edit(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool AddCost(TanantModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CostModel, Cost>())).Map<Cost>(e);

            try
            {
                DataAccessFactory.CostDataAccess().Add(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteCost(int id)
        {
            try
            {
                DataAccessFactory.CostDataAccess().Delete(id);
                return true;

            }
            catch
            {
                return false;
            }
        }
    }
}
