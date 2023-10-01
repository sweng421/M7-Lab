using System;
using System.Collections.Generic;

namespace M7_Lab
{
    public abstract class CompositeNovelElement: NovelElement
    {
        IList<NovelElement> elements;
        public virtual void Save(NovelElement novelElement)
        {
            elements.Add(novelElement);
        }
        public abstract NovelElement Retrieve(NovelElement novelElement);
        public abstract void View(NovelElement novelElement);
        public abstract void Edit(NovelElement novelElement);
        public abstract void Delete(NovelElement novelElement);
    }
}
