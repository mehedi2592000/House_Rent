using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity_Layer.Repo
{
    public class CaretakerRepo : IRepository<Caretaker, int>
    {
        House_RentEntities db;

        public CaretakerRepo(House_RentEntities db)
        {
            this.db = db;
        }

        public void Add(Caretaker e)
        {
            db.Caretakers.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var data=db.Caretakers.FirstOrDefault(x=>x.Id==id);
            db.Caretakers.Remove(data);
            db.SaveChanges();
        }

        public void Edit(Caretaker e)
        {
            var data=db.Caretakers.FirstOrDefault(x=>x.Id==e.Id);
            db.Entry(data).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Caretaker> Get()
        {
            return db.Caretakers.ToList();
        }

        public Caretaker Get(int id)
        {
            return db.Caretakers.FirstOrDefault(x => x.Id == id);
        }
    }
}
