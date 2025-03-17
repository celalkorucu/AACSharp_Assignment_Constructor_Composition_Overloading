using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Assignment_Constructor_Composition_Overloading.Classes
{
    public class Chassis
    {
        public string type {  get; set; }

        public Chassis(string type) {

            this.type = type;
        }
    }
}
