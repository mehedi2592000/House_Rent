using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity_Layer.Repo
{
    public class OwnerRepo : IRepository<Owner, int>
    {
        House_RentEntities db;

        public OwnerRepo(House_RentEntities db)
        {
            this.db = db;
        }

        public void Add(Owner e)
        {
            db.Owners.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = db.Owners.FirstOrDefault(x => x.Id == id);
            db.Owners.Remove(data);
            db.SaveChanges();
        }

        public void Edit(Owner e)
        {
            var data=db.Owners.FirstOrDefault(x => x.Id == e.Id);
            db.Entry(data).CurrentValues.SetValues(e);
            db.SaveChanges();

        }

        public List<Owner> Get()
        {
            var data = db.Owners.ToList();
            return data;
        }

        public Owner Get(int id)
        {
            return db.Owners.FirstOrDefault(x => x.Id == id);   
        }
    }
}
