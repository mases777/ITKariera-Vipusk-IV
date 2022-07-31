using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha06
{
    class Car
    {
        private Model carModel;

        public Model CarModel
        {
            get { return carModel; }
            set { carModel = value; }
        }
        private Tovar tovar;

        public Tovar Tovar
        {
            get { return tovar; }
            set { tovar = value; }
        }
        private Tyres[] carTyres;

        public Tyres[] CarTyres
        {
            get { return carTyres; }
            set { carTyres = value; }
        }

        public Car(Model carModel, Tovar tovar, Tyres[] carTyres)
        {
            this.carModel = carModel;
            this.tovar = tovar;
            this.carTyres = carTyres;
        }
    }
}
