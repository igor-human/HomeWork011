using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class CarCollection
    {
        private List<Car> cars;

        public CarCollection()
        {
            this.cars = new List<Car>();
        }

        public void AddCar(string name, int year)
        {
            cars.Add(new Car(name, year));
        }

        public Car this[int index]
        {
            get
            {
                if(index < 0 ||  index >= cars.Count)
                {
                    throw new IndexOutOfRangeException("Індекс виходе за реально існуючі");
                }
                return cars[index];
            }
        }

        public int Count
        {
            get { return cars.Count; }
        }

        public void Clear()
        {
            cars.Clear();
        }
    }
}
