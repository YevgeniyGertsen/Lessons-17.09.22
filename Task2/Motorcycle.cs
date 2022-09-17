using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Motorcycle:Trans
    {
        public Motorcycle(int CarWeigth, int MaxWeigth):base(CarWeigth, MaxWeigth)
        {
            
        }


        public string MotoType { get; set; }
        public string MotoNumber { get; set; }
        public int MotoSpeed { get; set; }
        public bool wheelChairs { get; set; }
        
        public  override void GetTransInfo()
        {
            Console.WriteLine("-");
        }

        public override string WeightInfo()
        {
            return string.Format("Грузоподъемность равна: {0}", 
                (MaxWeight - CarWeight)/0.25);
        }

        public override double WeightParam()
        {
            //return base.WeightParam()/0.25;
            return MaxWeight / 0.25;
        }
    }
}
