using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Assignment_Constructor_Composition_Overloading.Classes
{
    public class Car
    {
        public Brand brand { get; set; }

        public Model model { get; set; }
        public Chassis chassis { get; set; }

        public Window window { get; set; }

        public Door door { get; set; }


        public double price { get; set; }

        public Car(Brand brand, Model model,Chassis chassis, Window window, Door door,double price)
        {
            this.brand = brand;
            this.model = model; 
            this.chassis = chassis;
            this.window = window;
            this.door = door;
            this.price = price;

            Console.WriteLine("Arabanın ; ");

            Console.WriteLine("Markası :" + brand.name);
            Console.WriteLine("Modeli :" + model.name);
            Console.WriteLine("Kapı Sayısı :" + door.piece);
            Console.WriteLine("Pencere Sayısı :" + window.piece);
            Console.WriteLine("Kasası :" + chassis.type);
            Console.WriteLine("Fiyatı :" + price);


        }
    }
}
