using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExample
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
      
        public virtual void Goes()
        {
            Console.WriteLine("Goes Goes");
        }

        public  void XX1()
        {
            Console.WriteLine("xxdad");
        }
    }
}
