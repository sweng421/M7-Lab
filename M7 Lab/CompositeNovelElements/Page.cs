using System;
using System.Collections.Generic;

namespace M7_Lab.CompositeNovelElements
{
    public class Page: CompositeNovelElement
    {
        List<NovelElement> elements = new List<NovelElement>();

        public override void Edit(NovelElement novelElement)
        {
            Edit();
        }

        public void Edit ()
        {
            string key;

            Console.WriteLine("What would you like to do:\n");
            Console.WriteLine("1. Add new column.\n");
            Console.WriteLine("2. Delete column.\n");
            Console.WriteLine("3. Add new frame.\n");
            Console.WriteLine("4. Delete frame.\n");
            key = Console.ReadLine();

            switch (key)
            {
                case "1":
                    Console.WriteLine("\nNew column has been saved\n");
                    break;
                case "2":
                    Console.WriteLine("\nColumn deleted\n");
                    break;
                case "3":
                    Console.WriteLine("\nNew frame has been saved\n");
                    break;
                case "4":
                    Console.WriteLine("\nFrame deleted\n");
                    break;
                default:
                    Console.WriteLine("\nInvalid option!\n");
                    break;
            }
        }

        public override void Retrieve(NovelElement novelElement)
        {
            Retrieve();
        }
        public void Retrieve()
        {
            Console.WriteLine(this.ToString() + " has been retrieved\n");
        }

        public override void View(NovelElement novelElement)
        {
            View();
        }

        public void View()
        {
            foreach (NovelElement var in elements)
            {
                Console.WriteLine("Viewing " + var);
            }
        }

        public override string ToString()
        {
            int val = GetHashCode();
            
            return ("Page " + val.ToString());
        }
    }
}
