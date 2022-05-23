using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity_Layer.Repo
{
    public class AccountRepo : IRepository<Account, int>
    {
        House_RentEntities db;

        public AccountRepo(House_RentEntities db)
        {
            this.db= db;
        }

        public void Add(Account e)
        {
            db.Accounts.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = db.Accounts.FirstOrDefault(x => x.Id == id);
            db.Accounts.Remove(data);
            db.SaveChanges();
        }

        public void Edit(Account e)
        {
            var data = db.Accounts.FirstOrDefault(x => x.Id == e.Id);
            db.Entry(data).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Account> Get()
        {
            return db.Accounts.ToList();
        }

        public Account Get(int id)
        {
            return db.Accounts.FirstOrDefault(x => x.Id == id);
        }
    }
}
