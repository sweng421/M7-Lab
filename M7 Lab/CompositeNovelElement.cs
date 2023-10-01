using System;
using System.Collections.Generic;

namespace M7_Lab
{
    public abstract class CompositeNovelElement: NovelElement
    {
        private List<NovelElement> elements = new List<NovelElement>();
        public virtual void Save(NovelElement novelElement)
        {
            elements.Add(novelElement);
            Console.WriteLine(novelElement + " has been saved");
        }
        public virtual void Retrieve(NovelElement novelElement)
        {
            if (novelElement != null)
                Console.WriteLine(this.ToString() + " has been retrieved\n");
            else
                Console.WriteLine("Element does not exist\n");
        }
        public abstract void View(NovelElement novelElement);
        public abstract void Edit(NovelElement novelElement);
        public void Delete(NovelElement novelElement)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] == novelElement)
                    elements.RemoveAt(i);          
            }
        }
        public void SetElement()
        {
            Console.WriteLine("Feature not supported\n");
        }
    }
}
