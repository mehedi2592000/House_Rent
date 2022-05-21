using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity_Layer.Repo
{
    public class CostRepo : IRepository<Cost, int>
    {
        House_RentEntities db;

        public CostRepo(House_RentEntities db)
        {
            this.db = db;
        }

        public void Add(Cost e)
        {
            var data=db.Costs.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var data=db.Costs.FirstOrDefault(x=>x.Id==id);  
            db.Costs.Remove(data);
            db.SaveChanges();
        }

        public void Edit(Cost e)
        {
            var data=db.Costs.FirstOrDefault(x=>x.Id==e.Id);
            db.Entry(data).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Cost> Get()
        {
            return db.Costs.ToList();
        }

        public Cost Get(int id)
        {
            return db.Costs.FirstOrDefault(x => x.Id == id);
        }
    }
}
