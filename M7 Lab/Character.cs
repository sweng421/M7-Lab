using System;

namespace M7_Lab
{
    public class Character: NovelElement
    {
        private char character;

        public Character (char character)
        {
            this.character = character;
        }

        public void Delete(NovelElement novelElement)
        {
            Console.WriteLine("Feature not supported\n");
        }

        public void Edit(NovelElement novelElement)
        {
            novelElement.SetElement();
        }

        public void Retrieve(NovelElement novelElement)
        {
            Console.WriteLine("Character \"" + character + "\" was retrieved\n");
        }

        public void Save(NovelElement novelElement)
        {
            Console.WriteLine("Feature not supported\n");
        }

        public void SetElement() 
        {
            Console.WriteLine("Character has been edited\n");
        }

        public void View(NovelElement novelElement)
        {
            Console.WriteLine("\n" + character + "\n");
        }

        public override string ToString()
        {
            return character.ToString();
        }
    }
}
