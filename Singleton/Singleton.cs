using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        public static Singleton instance = new Singleton();
        //dont forget that static methods cant call normal methods
        //but the other way is okay
        /*<summary>
         * This is the Singleton private constructor
         * </summary>
         */
        private Singleton()
        {
          
        }
        public static Singleton getInstance()
        {
            //if we do not initialize up top we do it here
            return instance;
        }
        public void showName()
        {
            Console.WriteLine("This is a Singleton");
        }
    }
}
