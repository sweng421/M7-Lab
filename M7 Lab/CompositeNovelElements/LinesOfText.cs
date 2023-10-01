using System;
using System.Collections.Generic;

namespace M7_Lab.CompositeNovelElements
{
    public class LineOfText: CompositeNovelElement
    {
        IList<NovelElement> elements;
        private string lineOfText;

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
        public override NovelElement Retrieve (NovelElement element)
        {
            if (element != null && element == this)
                return this;
            else 
                return null;
        }

        public override void Delete (NovelElement element) 
        {
            if (element != null && element == this)
            {
                element = null;
            }
        }

        public override void View (NovelElement element)
        {
            foreach (NovelElement var in elements)
            {
                Console.WriteLine(var);
            }
        }

        public override void Edit (NovelElement element)
        {
            if (element != null && element == this)
            {
                string key, input;

                Console.WriteLine("What would you like to do:\n");
                Console.WriteLine("1. Append text.\n");
                Console.WriteLine("2. Delete text.\n");
                Console.WriteLine("3. Replace text.\n");
                key = Console.ReadLine();

                switch (key) 
                {
                    case "1":
                        {
                            Console.WriteLine("Enter text to append.\n");
                            input = Console.ReadLine();
                            lineOfText += " " + input;
                        }
                        break;
                    case "2":
                        {
                            string word;
                            int firstIndex, lastIndex;
                            Console.WriteLine("Enter text you want to delete");
                            word = Console.ReadLine();

                            for (int i = 0; i < lineOfText.Length; i++)
                            {   
                                if(lineOfText.Contains(word))
                                {
                                    firstIndex = lineOfText.IndexOf(word, 0);
                                    lastIndex = lineOfText.LastIndexOf(word, 0);

                                    if (firstIndex == lastIndex)
                                    {
                                        lineOfText.Remove(firstIndex, word.Length);
                                    }
                                    else
                                    {
                                        Console.WriteLine(lineOfText);
                                        Console.WriteLine("\nEnter starting position of text to delete.\n");
                                        input = Console.ReadLine();
                                        lineOfText.Remove(int.Parse(input), word.Length);
                                    }
                                }  
                            }
                        }
                        break;
                    case "3":
                        {
                            string word, replacement;
                            int firstIndex, lastIndex;
                            Console.WriteLine("Enter text you want to replace\n");
                            word = Console.ReadLine();

                            for (int i = 0; i < lineOfText.Length; i++)
                            {
                                if (lineOfText.Contains(word))
                                {
                                    firstIndex = lineOfText.IndexOf(word, 0);
                                    lastIndex = lineOfText.LastIndexOf(word, 0);

                                    if (firstIndex == lastIndex)
                                    {
                                        Console.WriteLine("Enter the new text\n");
                                        replacement = Console.ReadLine();

                                        lineOfText.Remove(firstIndex, word.Length);
                                        lineOfText.Insert(firstIndex, replacement);
                                    }
                                    else
                                    {
                                        Console.WriteLine(lineOfText);
                                        Console.WriteLine("Enter starting position of text to replace.\n");
                                        input = Console.ReadLine();
                                        Console.WriteLine("Enter the new text\n");
                                        replacement = Console.ReadLine();
                                        lineOfText.Remove(int.Parse(input), word.Length);
                                        lineOfText.Insert(int.Parse(input), replacement);

                                    }
                                }
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }

        }
    }
    
}
