using System;

namespace M7_Lab
{
    public class Image : NovelElement
    {
        string image;

        public Image (string image)
        {
            this.image = image;
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
            Console.WriteLine("Image \"" + image + "\" was retrieved\n");
        }

        public void Save(NovelElement novelElement)
        {
            Console.WriteLine("Feature not supported\n");
        }

        public void SetElement()
        {
            Console.WriteLine("\nCharacter has been edited\n");
        }

        public void View(NovelElement novelElement)
        {
            Console.WriteLine("\n" + image + "\n");
        }

        public override string ToString()
        {
            int val = GetHashCode();

            return ("Image " + val.ToString());
        }
    }
}
