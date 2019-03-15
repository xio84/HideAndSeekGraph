using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp1
{
    class Node
    {
        public ArrayList Next;

        public Node()
        {
            Next = new ArrayList();
        }

        public void AddElmt(int el)
        {
            Next.Add(el);
        }

        public void Print()
        {
            Console.WriteLine("Trailer:");
            for (int i = 0; i < Next.Count; i++)
            {
                Console.WriteLine(Next[i]);
            }
            Console.WriteLine();
        }
    }
}
