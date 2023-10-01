using System;
using System.Collections.Generic;

namespace M7_Lab
{
    public class Novel : INovelElement
    {
        List<INovelElement> elements = new List<INovelElement>();

        public Novel(NovelElement element) 
        {
            elements.Add(element);
        }
        
        public void Delete(NovelElement novelElement)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] == novelElement)
                {
                    elements.RemoveAt(i);
                    break;
                }
            }
        }

        public void Edit(NovelElement novelElement)
        {
            Console.WriteLine(novelElement + " edited\n");
        }

        public void Retrieve(NovelElement novelElement)
        {
            Console.WriteLine(novelElement + " retrieved");
        }

        public void Save(NovelElement novelElement)
        {
            elements.Add(novelElement);
            Console.WriteLine(novelElement + " has been saved");
        }

        public void View(NovelElement novelElement)
        {
            foreach (NovelElement var in elements)
            {
                Console.WriteLine("Viewing " + var);
            }
        }

        public override string ToString()
        {
            int val = GetHashCode();

            return ("Novel " + val.ToString());
        }
    }
}
