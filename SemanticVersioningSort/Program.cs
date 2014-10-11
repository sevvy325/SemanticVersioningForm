using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanticVersioningSort
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 2)
            {
                SemanticVersion[] workList = new SemanticVersion[args.Length - 1];
                SemanticVersion[] finalList = new SemanticVersion[args.Length - 1];
                for (int x = 0; x < finalList.Length; x++)
                {
                    workList[x] = new SemanticVersion(args[x + 1]);
                }
                for (int x = 0; x < finalList.Length; x++)
                {
                    int ind = getLeast(workList);
                    finalList[x] = workList[ind];
                    workList[ind].SetMajor(int.MaxValue);
                }
            }
            else
            {
                Console.WriteLine("Usage: name <numbertosort> <args...>");
                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }
        }

        private static int getLeast(SemanticVersion[] args)
        {
            SemanticVersion currMin = args[0];
            int c = 0;
            int i = c;
            foreach (SemanticVersion s in args)
            {
                if (s.CompareTo(currMin) > 0)
                {
                    currMin = s;
                    i = c;
                }
                c++;
            }
            return i;
        }
    }
}
