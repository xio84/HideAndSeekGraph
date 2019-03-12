using System;
using System.Collections;
using System.IO;


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

public class main
{

    static void MakeGraph(Node[] Nodes, int Curr, int Prev)
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

    static bool DFS(Node[] Nodes, int start, int finish, bool Found)
    {
        if (Nodes[start].Next.Count == 0)
        {
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
            if (start == finish)
            {
                Found = true;
                return DFS(Nodes, start, 0, Found);
            }
            else
            {
                int i = 0;
                while (i < Nodes[start].Next.Count && !Found)
                {
                    Found = DFS(Nodes, Convert.ToInt32(Nodes[start].Next[i]), finish, Found);
                    i++;
                }
                return Found;
            }
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
        int N,Q;
        int from,to,dir,x,y;
        string[] inputs, lines;
        bool Found;

        lines = System.IO.File.ReadAllLines("graph.txt");
        N = Convert.ToInt32(lines[0]);
        Node[] Nodes = new Node[N+1];
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

        MakeGraph(Nodes,1,0);

        lines = System.IO.File.ReadAllLines("query.txt");
        Q = Convert.ToInt32(lines[0]);
        Console.WriteLine("Queries loaded successfuly\n");

        Console.WriteLine("Results:");
        for (int i = 1; i <= Q; i++)
        {
            Found = false;
            inputs = lines[i].Split(' ');
            dir = Convert.ToInt32(inputs[0]);
            y = Convert.ToInt32(inputs[1]);
            x = Convert.ToInt32(inputs[2]);
            if (dir == 0)
            {
                if (DFS(Nodes, x, y, Found))
                {
                    Console.WriteLine("YA");
                }
                else
                {
                    Console.WriteLine("TIDAK");
                }
            }
            else if (dir == 1)
            {
                if (DFS(Nodes, y, x, Found))
                {
                    Console.WriteLine("YA");
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
