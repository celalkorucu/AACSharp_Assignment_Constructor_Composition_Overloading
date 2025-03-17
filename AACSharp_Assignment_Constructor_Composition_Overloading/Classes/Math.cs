using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Assignment_Constructor_Composition_Overloading.Classes
{
    public class Math
    {

        public static double Calculate(double x, double y,char process)
        {
            switch (process)
            {
                case '+': return x + y;
                case '*': return x * y;
            }

            return 0;
        }

        public static double Calculate(double x , double y , double z , char process) {
                
            switch (process) {
                case '+': return x + y + z;
                case '*': return x * y * z;
            }

            return 0;

        }

        public static int Calculate(int x, int y, char process)
        {
            switch(process)
            {
                case '+': return x + y;
                case '*': return x * y;
            }

            return 0;
        }

        public static int Calculate(int x, int y, int z , char process)
        {
            switch (process) {
                case '+': return x + y + z;
                case '*': return x * y * z;
            }

            return 0;

        }


    }
}
