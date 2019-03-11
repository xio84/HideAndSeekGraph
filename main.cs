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
        if (Prev != 0)
        {
            Nodes[Curr].Next.Remove(Prev);
        }
        for (int i = 0; i < Nodes[Curr].Next.Count; i++)
        {
            MakeGraph(Nodes, Convert.ToInt32(Nodes[Curr].Next[i]), Curr);
        }
    }

    static bool DFS(Node[] Nodes, int start, int finish)
    {
        if (start == finish)
        {
            return true;
        }
        else
        {
            if (Nodes[start].Next.Count == 0)
            {
                return false;
            }
            else
            {
                int i = 0;
                bool Found = false;
                while (i < Nodes[start].Next.Count && !Found)
                {
                    Found = DFS(Nodes, Convert.ToInt32(Nodes[start].Next[i]), finish);
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
        string input;
        string[] inputs;

        Console.Write("Input N : ");
        N = Convert.ToInt32(Console.ReadLine());
        Node[] Nodes = new Node[N+1];
        for (int i = 0; i <= N; i++)
        {
            Nodes[i] = new Node();
        }


        Console.WriteLine("Input your ArrayList : ");
        for (int i = 0; i < N-1; i++)
        {
            input = Console.ReadLine();
            inputs = input.Split(' ');
            from = Convert.ToInt32(inputs[0]);
            to = Convert.ToInt32(inputs[1]);
            Nodes[from].AddElmt(to);
            Nodes[to].AddElmt(from);
        }

        MakeGraph(Nodes,1,0);

        Console.Write("Input Q : ");
        Q = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input your Queries : ");
        for (int i = 0; i < Q; i++)
        {
            input = Console.ReadLine();
            inputs = input.Split(' ');
            dir = Convert.ToInt32(inputs[0]);
            y = Convert.ToInt32(inputs[1]);
            x = Convert.ToInt32(inputs[2]);
            if (dir == 0)
            {
                if (DFS(Nodes, y, x))
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
                if (DFS(Nodes, x, y))
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
