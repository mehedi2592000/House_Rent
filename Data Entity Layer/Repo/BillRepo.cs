using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity_Layer.Repo
{
    public class BillRepo : IRepository<Bill, int>
    {
        House_RentEntities db;

        public BillRepo(House_RentEntities db)
        {
            this.db = db;
        }
        public void Add(Bill e)
        {
            db.Bills.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var data=db.Bills.FirstOrDefault(x=>x.Id==id);
            db.Bills.Remove(data);
            db.SaveChanges();
        }

        public void Edit(Bill e)
        {
            var data=db.Bills.FirstOrDefault(x=>x.Id == e.Id);
            db.Entry(data).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Bill> Get()
        {
            return db.Bills.ToList();
        }

        public Bill Get(int id)
        {
            return db.Bills.FirstOrDefault(x=>x.Id== id);   
        }
    }
}
