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
    public  class CaretakerService
    {
        public static List<CaretakerModel>GetCaretaker()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Caretaker, CaretakerModel>())).Map<List<CaretakerModel>>(DataAccessFactory.CaretakerDataAccess().Get());
            return data;
        }

        public static CaretakerModel GetCaretakerid(int id)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Caretaker, CaretakerModel>())).Map<CaretakerModel>(DataAccessFactory.CaretakerDataAccess().Get(id));
            return data;
        }

        public static bool AddCaretaker(CaretakerModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CaretakerModel, Caretaker>())).Map<Caretaker>(e);

            try
            {
                DataAccessFactory.CaretakerDataAccess().Add(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool EditCaretaker(CaretakerModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CaretakerModel, Caretaker>())).Map<Caretaker>(e);

            try
            {
                DataAccessFactory.CaretakerDataAccess().Edit(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool deleteCaretaker(int id)
        {
            try
            {
                DataAccessFactory.CaretakerDataAccess().Delete(id);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
