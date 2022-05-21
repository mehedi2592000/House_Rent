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
    public class BillService
    {
        public static List<BillModel> GetBill()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Bill, BillModel>())).Map<List<BillModel>>(DataAccessFactory.BillDataAccess().Get());
            return data;
        }

        public static BillModel GetBillId(int id)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Bill, BillModel>())).Map<BillModel>(DataAccessFactory.BillDataAccess().Get(id));
            return data;
        }

        public static bool EditBill(BillModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<BillModel, Bill>())).Map<Bill>(e);

            try
            {
                DataAccessFactory.BillDataAccess().Edit(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool AddBill(BillModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<BillModel, Bill>())).Map<Bill>(e);

            try
            {
                DataAccessFactory.BillDataAccess().Add(data);
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
                DataAccessFactory.BillDataAccess().Delete(id);
                return true;

            }
            catch
            {
                return false;
            }
        }

    }
}
