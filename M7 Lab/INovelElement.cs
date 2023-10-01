using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace M7_Lab
{
    public interface INovelElement
    {
        void Save(NovelElement novelElement);
        void Retrieve(NovelElement novelElement);
        void View(NovelElement novelElement);
        void Edit(NovelElement novelElement);
        void Delete(NovelElement novelElement);
        string ToString();
    }
}
