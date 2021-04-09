using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExample
{
   public class Bird : Animal
    {
        public override void Goes()
        {
            Console.WriteLine("Jib Jib");
            //base.Goes();
            //base.XX1();
        }

       
    }
}
