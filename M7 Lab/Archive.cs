using System;
using System.Collections.Generic;

namespace M7_Lab
{
    public class Archive
    {
        List<INovelElement> novels = new List<INovelElement>();

        public void Add (INovelElement element)
        {
            novels.Add (element);
        }
        public void Remove (INovelElement element) 
        {
            if (element != null)
            {
                for (int i = 0; i < novels.Count; i++)
                {
                    if (element == novels[i])
                    {
                        novels.RemoveAt (i);
                    }
                }
            }
        }

        public void View ()
        {
            foreach (var element in novels) 
            {
                Console.WriteLine (element);
            }
        }

        public override string ToString()
        {
            int val = GetHashCode();
            
            return ("Archive novel: " + val.ToString());
        }
    }
}
