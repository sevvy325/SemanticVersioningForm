using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanticVersioningSort
{
    class SemanticVersion
    {
        private int major, minor, patch;
        private string label, meta;
        private string[] contents;
        private char[] cont = new char [] {'.', '.', '.', '-', '+' };

        public SemanticVersion(String s)
        {
            string[] array = new string[5];
            try
            {
                array = s.Split(new char[] { '.', '-', '+' });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            contents = new string[array.Length];
            major = int.Parse(array[0]);
            contents[0] = array[0];
            if (array.Length > 1)
            {
                minor = int.Parse(array[1]);
                contents[1] = array[1];
            }
            if (array.Length > 2)
            {
                patch = int.Parse(array[2]);
                contents[2] = array[2];
            }
            if (array.Length > 3)
            {
                label = array[3];
                contents[3] = array[3];
            }
            if (array.Length > 4)
            {
                meta = array[4];
                contents[4] = array[4];
            }
        }

        public void SetMajor(int i)
        {
            major = i;
        }

        override
        public string ToString()
        {
            string s = major.ToString(); ;
            for (int x = 1; x < contents.Length; x++)
                s += cont[x] + contents[x];
            return s.Trim();
        }

        public int CompareTo(Object obj)
        {
            SemanticVersion Comp;
            try
            {
                Comp = (SemanticVersion)obj;
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message + " Can only compare SymanticVersion Objects!");
            }
            if (Comp.major < major)
                return -10;
            else if (Comp.major > major)
                return 10;
            else
            {
                if (Comp.minor < minor)
                    return -10;
                else if (Comp.minor > minor)
                    return 10;
                else
                {
                    if (Comp.patch < minor)
                        return -10;
                    else if (Comp.patch > minor)
                        return 10;
                    else
                    {
                        if (Comp.label == null && label == null)
                            return 0;
                        else if (Comp.label != null && label == null)
                            return -10;
                        else if (Comp.label == null && label != null)
                            return 10;
                        else
                            return 0;
                    }
                }
            }
        }
 
    }
}
