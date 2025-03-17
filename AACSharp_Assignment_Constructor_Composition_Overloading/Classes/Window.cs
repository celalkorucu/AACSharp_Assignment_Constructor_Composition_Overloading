using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Assignment_Constructor_Composition_Overloading.Classes
{
    public  class Window
    {
        public int piece {  get; set; }

        public Window(int piece) { 
            this.piece = piece;
        }
    }
}
