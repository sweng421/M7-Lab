using System;
using System.Collections.Generic;

namespace M7_Lab.CompositeNovelElements
{
    public class LineOfText : CompositeNovelElement
    {
        List<Character> elements = new List<Character>();

        public LineOfText()
        {
            string input;
            Console.WriteLine("Enter a new character to add (done to quit).\n");
            input = Console.ReadLine();

            while (!input.Equals("done"))
            {
                elements.Add(new Character(input[0]));
                Console.WriteLine("Enter a new character to add (done to quit).\n");
                input = Console.ReadLine();
            }
        }

        public override void View(NovelElement element)
        {
            View();
        }

        public void View()
        {
            foreach (var character in elements)
            {
                Console.Write(character);
            }
        }

        public override void Edit(NovelElement element)
        {
            Edit();
        }

        public void Edit()
        {
            string key;

            Console.WriteLine("What would you like to do:\n");
            Console.WriteLine("1. Append characters.\n");
            Console.WriteLine("2. Delete characters.\n");
            Console.WriteLine("3. Replace characters.\n");
            key = Console.ReadLine();

            switch (key)
            {
                case "1":
                    Console.WriteLine("New character has been saved.\n");
                    break;
                case "2":
                    Console.WriteLine("Character deleted\n");
                    break;
                case "3":
                    Console.WriteLine("Character has been replaced\n");
                    break;
                default:
                    Console.WriteLine("Invalid option!\n");
                    break;
            }
        }

        public override string ToString()
        {
            View();

            return "";
        }
    }
    
}
