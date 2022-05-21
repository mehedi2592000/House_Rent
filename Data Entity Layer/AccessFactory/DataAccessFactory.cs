using Data_Entity_Layer.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity_Layer.AccessFactory
{
    public class DataAccessFactory
    {
        static House_RentEntities db;

        static DataAccessFactory()
        {
            db = new House_RentEntities();
        }

        public static IRepository<Owner,int> OwnerDataAccess()
        {
            return new OwnerRepo(db);
        }

        public static IRepository<Caretaker,int>CaretakerDataAccess()
        {
            return new CaretakerRepo(db);   
        }

        public static IRepository<Cost,int>CostDataAccess()
        {
            return new CostRepo(db);
        }

        public static IRepository<Bill,int>BillDataAccess()
        {
            return new BillRepo(db);
        }

        public static IRepository<Tanant,int>TanatDataAccess()
        {
            return new TanantRepo(db);
        }


    }
}
