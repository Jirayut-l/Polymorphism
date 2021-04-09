using System;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ////var animal = new Animal();
            //var dog = new Dog();
            //var bird = new Bird();
            ////animal.Goes();
            ////dog.Goes();

            //var zoo= new Zoo();
            //zoo.AddAnimals(dog);
            //zoo.AddAnimals(bird);
            //zoo.ShowAllAnimal();

            var sizeSquare = 5;
            var numLoopSquare = sizeSquare*2;
            var cursorPlus = 1;
            var cursorSubtract = 1;
            var cursorclass = sizeSquare;
            for (int h = 1; h <= numLoopSquare; h++)
            {
                for (int w = 1; w <= numLoopSquare; w++)
                {
                    if (w == 1 || w == numLoopSquare || h == numLoopSquare || h == 1)
                    {
                        Console.Write(sizeSquare);
                        cursorPlus = cursorPlus + 1;
                        cursorSubtract = cursorSubtract + 1;
                    }
                    else if (w == cursorPlus || w == numLoopSquare - cursorSubtract || h == numLoopSquare - cursorSubtract || h == cursorPlus)
                    {
                        var result = sizeSquare - cursorSubtract;
                        cursorPlus = cursorPlus + 1;
                        //cursorSubtract = cursorSubtract + 1;
                        Console.Write(result);
                    }

                }
                Console.WriteLine();
                cursorPlus = 1;
                cursorSubtract = 0;
            }


            //for (int h = 1; h <= numLoopSquare; h++)
            //{
            //    for (int w = 1; w <= numLoopSquare; w++)
            //    {
            //        if (w == 1 || w == numLoopSquare || h == numLoopSquare || h == 1)
            //        {
            //            Console.Write(sizeSquare);
            //        }
            //        else if (w == 2 || w == numLoopSquare - 1 || h == numLoopSquare - 1 || h == 2)
            //        {
            //            Console.Write(sizeSquare-1);
            //        }
            //        else if (w == 3 || w == numLoopSquare - 2 || h == numLoopSquare - 2|| h == 3)
            //        {
            //            Console.Write(sizeSquare - 2);
            //        }
            //        else if (w == 4 || w == numLoopSquare - 3 || h == numLoopSquare - 3 || h == 4)
            //        {
            //            Console.Write(sizeSquare - 3);
            //        }
            //        else
            //        {
            //            Console.Write("1");
            //        }

            //    }
            //    Console.WriteLine();
            //}

        }
    }
}
