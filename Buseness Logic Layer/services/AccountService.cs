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
    public  class AccountService
    {
        public static List<AccountModel> GetCost()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Account, AccountModel>())).Map<List<AccountModel>>(DataAccessFactory.AccountDataAccess().Get());
            return data;
        }

        public static AccountModel GetAccounttId(int id)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Account, AccountModel>())).Map<AccountModel>(DataAccessFactory.AccountDataAccess().Get(id));
            return data;
        }

       

        public static bool DeleteAccount(int id)
        {
            try
            {
                DataAccessFactory.AccountDataAccess().Delete(id);
                return true;

            }
            catch
            {
                return false;
            }
        }

    }
}
