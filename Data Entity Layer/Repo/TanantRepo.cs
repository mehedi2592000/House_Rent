using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity_Layer.Repo
{
    public class TanantRepo : IRepository<Tanant, int>
    {
        House_RentEntities db;

        public TanantRepo(House_RentEntities db)
        {
            this.db = db; 
        }

        public void Add(Tanant e)
        {
           db.Tanants.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var data=db.Tanants.FirstOrDefault(x=>x.Id==id);
            db.Tanants.Remove(data);
            db.SaveChanges();
        }

        public void Edit(Tanant e)
        {
            var data=db.Tanants.FirstOrDefault(x=>x.Id == e.Id);
            db.Entry(data).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Tanant> Get()
        {
            return db.Tanants.ToList();
        }

        public Tanant Get(int id)
        {
            return db.Tanants.FirstOrDefault(x => x.Id == id);
        }
    }
}
