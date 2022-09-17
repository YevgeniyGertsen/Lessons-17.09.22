using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    /*
     1.	Создать абстрактный класс Trans с методами позволяющим вывести на экран информацию 
    о транспортном средстве, а также определить грузоподъемность транспортного средства.
2.	Создать производные классы: Легковая_машина (марка, номер, скорость, грузоподъемность), 
    Мотоцикл (марка, номер, скорость, грузоподъемность, наличие коляски, при этом если коляска
    отсутствует, то грузоподъемность равна 0), Грузовик (марка, номер, скорость, грузоподъемность,
    наличие прицепа, при этом если есть прицеп, то грузоподъемность увеличивается в два раза) со 
    своими методами вывода информации на экран, и определения грузоподъемности.
3.	Создать базу (массив) из n машин, вывести полную информацию из базы на экран, а также 
    организовать поиск машин, удовлетворяющих требованиям грузоподъемности.


     */
    public class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            CarRandom carRandom = new CarRandom();

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    var cr = new Car();
                    cr.CarType = "Car type #" + i;
                    cr.CarWeight = rnd.Next(500, 1700);
                    cr.MaxWeight = rnd.Next(1000, 2500);
                    cr.brand = "brand type #" + i;
                    cr.speed = rnd.Next(100, 500);


                    carRandom.AddTrans(cr);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
              
            }
            for (int i = 0; i < 5; i++)
            {
                var mc = new Motorcycle(rnd.Next(0, 2500), rnd.Next(0, 500));
                mc.CarType = "Motorcycle type #"+i;
                mc.CarWeight = 150;
                mc.MotoNumber = "MC" + rnd.Next(1, 895623);
                mc.MotoType = "MotoType #"+i;

                carRandom.AddTrans(mc);
            }

            carRandom.PrintInfo();
        }
    }
}
