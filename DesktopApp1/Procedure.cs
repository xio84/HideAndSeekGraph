using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp1
{
    class Procedure
    {
        void MakeGraph(Node[] Nodes, int Curr, int Prev)
        {
            if (Nodes[Curr].Next.Count == 1 && Prev != 0)
            {
                // do nothing
            }
            else
            {
                for (int i = 0; i < Nodes[Curr].Next.Count; i++)
                {
                    if (Convert.ToInt32(Nodes[Curr].Next[i]) == Prev)
                    {
                        // do nothing
                    }
                    else
                    {
                        MakeGraph(Nodes, Convert.ToInt32(Nodes[Curr].Next[i]), Curr);
                    }
                }
                while (Convert.ToInt32(Nodes[Curr].Next.Count) != 0)
                {
                    Nodes[Curr].Next.RemoveAt(0);
                }
                if (Prev != 0)
                {
                    Nodes[Curr].Next.Add(Prev);
                }
            }
        }

        bool DFS(Node[] Nodes, int start, int finish, bool Found, ArrayList Answer)
        {
            if (Nodes[start].Next.Count == 0)
            {
                Answer.Add(1);
                if (finish == 0 || finish != 1)
                {
                    return Found;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                Answer.Add(start);
                if (start == finish)
                {
                    Found = true;
                    return DFS(Nodes, Convert.ToInt32(Nodes[start].Next[0]), 0, Found, Answer);
                }
                else
                {
                    Found = DFS(Nodes, Convert.ToInt32(Nodes[start].Next[0]), finish, Found, Answer);

                    return Found;
                }
            }
        }

        void PrintList(Node[] Nodes, int N)
        {
            Console.WriteLine("\nIsi ArrayList : ");
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
                Nodes[i].Print();
            }
        }

        void Start()
        {
            int N, Q;
            int from, to, dir, x, y;
            string[] inputs, lines;
            bool Found;

            lines = System.IO.File.ReadAllLines("graph.txt");
            N = Convert.ToInt32(lines[0]);
            Node[] Nodes = new Node[N + 1];
            for (int i = 0; i <= N; i++)
            {
                Nodes[i] = new Node();
            }

            for (int i = 1; i < N; i++)
            {
                inputs = lines[i].Split(' ');
                from = Convert.ToInt32(inputs[0]);
                to = Convert.ToInt32(inputs[1]);
                Nodes[from].AddElmt(to);
                Nodes[to].AddElmt(from);
            }
            Console.WriteLine("Graph loaded successfuly\n");

            MakeGraph(Nodes, 1, 0);

            lines = System.IO.File.ReadAllLines("query.txt");
            Q = Convert.ToInt32(lines[0]);
            Console.WriteLine("Queries loaded successfuly\n");

            Console.WriteLine("Results:");
            for (int i = 1; i <= Q; i++)
            {
                ArrayList Answer = new ArrayList();
                Found = false;
                inputs = lines[i].Split(' ');
                dir = Convert.ToInt32(inputs[0]);
                y = Convert.ToInt32(inputs[1]);
                x = Convert.ToInt32(inputs[2]);
                if (dir == 0)
                {
                    if (DFS(Nodes, x, y, Found, Answer))
                    {
                        Console.Write("YA ");
                        Console.Write(Answer[0]);
                        for (int j = 1; j < Answer.Count; j++)
                        {
                            Console.Write("->" + Answer[j]);
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("TIDAK");
                    }
                }
                else if (dir == 1)
                {
                    if (DFS(Nodes, y, x, Found, Answer))
                    {
                        Console.Write("YA ");
                        Console.Write(Answer[(Answer.Count) - 1]);
                        for (int j = (Answer.Count) - 2; j >= 0; j--)
                        {
                            Console.Write("->" + Answer[j]);
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("TIDAK");
                    }
                }
            }

            //PrintList(Nodes,N);
        }
    }
}
