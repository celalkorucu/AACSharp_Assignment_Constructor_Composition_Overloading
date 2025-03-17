using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Assignment_Constructor_Composition_Overloading.Classes
{
    public class Model
    {
        public string name {  get; set; }
        public Model(string name) { 
            this.name = name;
        }
    }
}
