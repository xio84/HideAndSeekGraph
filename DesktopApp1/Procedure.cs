using System;
using System.Collections;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HideAndSeekGraph.ViewModel;
using HideAndSeekGraph.NodeParts;

namespace HideAndSeekGraph
{
    class Procedure
    {
        public static MainViewModel gg = new MainViewModel();
        static void MakeGraph(Node[] Nodes, int Curr, int Prev)
        {
            if (Nodes[Curr].Next.Count == 1 && Prev != 0)
            {
                Nodes[Curr].Next.RemoveAt(0);
            }
            else
            {
                Nodes[Curr].Next.Remove(Prev);
                for (int i = 0; i < Nodes[Curr].Next.Count; i++)
                {
                    MakeGraph(Nodes, Convert.ToInt32(Nodes[Curr].Next[i]), Curr);
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

        public MainViewModel Start(String graph, String query)
        {
            int N, Q;
            int from, to, dir, x, y;
            string[] inputs, lines;
            string outputs="";
            bool Found;



            lines = System.IO.File.ReadAllLines(graph);
            N = Convert.ToInt32(lines[0]);
            Node[] Nodes = new Node[N + 1];
            for (int i = 1; i <= N; i++)
            {
                gg.AddVertex(i.ToString(), "Black");
            }
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
                gg.AddEdge(from, to);
                //gg.AddEdge(to, from);
            }
            Console.WriteLine("Graph loaded successfuly\n");
            outputs+="Graph loaded successfuly\n"; 

            MakeGraph(Nodes, 1, 0);

            lines = System.IO.File.ReadAllLines(query);
            Q = Convert.ToInt32(lines[0]);
            Console.WriteLine("Queries loaded successfuly\n");
            outputs += "Queries loaded successfuly\n";

            Console.WriteLine("Results:");
            outputs += "Results:";
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
                        outputs += "YA ";
                        Console.Write(Answer[0]);
                        outputs += Answer[0];
                        for (int j = 1; j < Answer.Count; j++)
                        {
                            Console.Write("->" + Answer[j]);
                            outputs += "->" + Answer[j];
                        }
                        Console.WriteLine();
                        outputs += "\n";
                    }
                    else
                    {
                        Console.WriteLine("TIDAK");
                        outputs += "TIDAK\n";
                    }
                }
                else if (dir == 1)
                {
                    if (DFS(Nodes, y, x, Found, Answer))
                    {
                        Console.Write("YA ");
                        outputs += "YA ";
                        Console.Write(Answer[(Answer.Count) - 1]);
                        outputs += Answer[(Answer.Count) - 1];
                        for (int j = (Answer.Count) - 2; j >= 0; j--)
                        {
                            Console.Write("->" + Answer[j]);
                            outputs += "->" + Answer[j];
                        }
                        Console.WriteLine();
                        outputs += "\n";
                    }
                    else
                    {
                        Console.WriteLine("TIDAK");
                        outputs += "TIDAK\n";
                    }
                }
            }
            MessageBox.Show(outputs);
            return gg;
            //PrintList(Nodes,N);
        }
    }/*
        static bool DFS0(Node[] Nodes, int start, int finish, int goal, bool Found, ArrayList Answer)
        {
            if (start == finish) // basis 1 : Node sekarang adalah node finish
            {
                if (start == goal) // cek apakah node sekarang adalah node yang dicari
                {
                    return true;
                }
                else
                {
                    return Found;
                }
            }
            else if (Nodes[start].Next.Count == 0) // basis 2 : Node sekarang adalah node daun (Tidak memiliki child node lagi)
            {
                return false;
            }
            else
            {
                if (start == goal)
                {
                    Found = true;
                }

                int i = 0;
                int N = Nodes[start].Next.Count;
                bool FoundTemp = false;
                while (i < N && !FoundTemp)
                {
                    FoundTemp = DFS0(Nodes, Convert.ToInt32(Nodes[start].Next[i]), finish, goal, Found, Answer); // rekursi
                    i++;
                }

                return FoundTemp;
            }
        }

        static bool DFS1(Node[] Nodes, int start, int finish, int goal, bool Found, ArrayList Answer)
        {
            if (Nodes[start].Next.Count == 0) // basis : Node sekarang adalah node daun (Tidak memiliki child node lagi)
            {
                if (start == goal) // cek apakah node sekarang adalah node yang dicari
                {
                    return true;
                }
                else
                {
                    return Found;
                }
            }
            else
            {
                if (start == goal)
                {
                    Found = true;
                }

                int i = 0;
                int N = Nodes[start].Next.Count;
                bool FoundTemp = false;
                while (i < N && !FoundTemp)
                {
                    FoundTemp = DFS1(Nodes, Convert.ToInt32(Nodes[start].Next[i]), finish, goal, Found, Answer); // rekursi
                    i++;
                }

                return FoundTemp;
            }
        }

        static void PrintList(Node[] Nodes, int N)
        {
            Console.WriteLine("\nIsi ArrayList : ");
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
                Nodes[i].Print();
            }
        }

        static void Main()
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
                inputs = lines[i].Split(' ');
                Found = false;
                dir = Convert.ToInt32(inputs[0]);
                x = Convert.ToInt32(inputs[1]);
                y = Convert.ToInt32(inputs[2]);
                if (dir == 0)
                {
                    if (DFS0(Nodes, 1, y, x, Found, Answer))
                    {
                        Console.Write("YA ");
                        /*
                        Console.Write(Answer[0]);
                        for (int j = 1; j < Answer.Count; j++)
                        {
                            Console.Write("->" + Answer[j]);
                        }
                        *//*
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("TIDAK");
                    }
                }
                else if (dir == 1)
                {
                    if (DFS1(Nodes, y, 0, x, Found, Answer))
                    {
                        Console.Write("YA ");
                        /*
                        Console.Write(Answer[(Answer.Count)-1]);
                        for (int j = (Answer.Count)-2; j >= 0; j--)
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

            // PrintList(Nodes,N);
        }
    }*/
}
