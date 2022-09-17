using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Trans
    {
        public Trans ():this(0, 0)
        {

        }
        public Trans(int CarWeight, int MaxWeight)
        {
            this.CarWeight = CarWeight;
            this.MaxWeight = MaxWeight;
        }


        public string CarType { get; set; }
        public int CarWeight { get; set; }
        public int MaxWeight { get; set; }


        public abstract void GetTransInfo();

        public virtual string WeightInfo()
        {
            return string.Format("Грузоподъемность равна: {0}", 
                (MaxWeight - CarWeight));
        }

        public virtual double WeightParam()
        {
            return (MaxWeight / CarWeight);
        }

    }
}
