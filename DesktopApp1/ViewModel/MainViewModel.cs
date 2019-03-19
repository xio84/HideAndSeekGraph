using System;
using System.Collections.Generic;
using System.ComponentModel;
using GraphSharp.Controls;
using HideAndSeekGraph.NodeParts;
using System.Threading;
using System.Windows.Forms;

namespace HideAndSeekGraph.ViewModel
{
    public class XGraphLayout : GraphLayout<GVertex, GEdge, GGraph> { }



    public class MainViewModel : INotifyPropertyChanged
    {
        #region Data

        private string layoutAlgorithmType;
        private GGraph graph;
        private List<String> layoutAlgorithmTypes = new List<string>();
        private int count;
        public List<GVertex> existingVertices;
        public List<GEdge> connections;
        #endregion

        #region Ctor
        public MainViewModel()
        {
            existingVertices = new List<GVertex>();
            connections = new List<GEdge>();

            Graph = new GGraph(true);

            //existingVertices.Add(new GVertex("Sarah Barber", "Red")); //1
            //existingVertices.Add(new GVertex("Marlon Grech", "Blue")); //2


            foreach (GVertex vertex in existingVertices)
            {
                Graph.AddVertex(vertex);
                //MessageBox.Show(vertex.ID);
            }


            //add some edges to the graph
            foreach (GEdge obj in connections)
            {
                Graph.AddEdge(obj);
            }

            //Add Layout Algorithm Types
            layoutAlgorithmTypes.Add("BoundedFR");
            layoutAlgorithmTypes.Add("Circular");
            layoutAlgorithmTypes.Add("CompoundFDP");
            layoutAlgorithmTypes.Add("EfficientSugiyama");
            layoutAlgorithmTypes.Add("FR");
            layoutAlgorithmTypes.Add("ISOM");
            layoutAlgorithmTypes.Add("KK");
            layoutAlgorithmTypes.Add("LinLog");
            layoutAlgorithmTypes.Add("Tree");

            //Pick a default Layout Algorithm Type
            LayoutAlgorithmType = "Tree";



        }
        #endregion

        public void AddVertex(String ID, String color)
        {
            existingVertices.Add(new GVertex(ID, color)); //0
        }

        public void AddEdge(int b, int e)
        {
            GVertex begin = existingVertices[b-1];
            GVertex end = existingVertices[e - 1];
            string edgeString = string.Format("{0}-{1} Connected", begin.ID, end.ID);

            connections.Add(new GEdge(edgeString, begin, end, "Black"));
        }

        public void DeleteEdge(int b)
        {
            GVertex begin = existingVertices[b - 1];
            int i = 0;
            while (i<connections.Count)
            {
                if (connections[i].Source == begin)
                {
                    connections.Remove(connections[i]);
                }
                else
                {
                    i++;
                }
            }
        }

        public void ReLayoutGraph()
        {
            /*graph = new GGraph(true);
            count++;





            foreach (GVertex vertex in existingVertices)
                Graph.AddVertex(vertex);


            //add some edges to the graph
            //AddNewGraphEdge(existingVertices[0], existingVertices[1]);
            //AddNewGraphEdge(existingVertices[0], existingVertices[2]);


            NotifyPropertyChanged("Graph");*/

            Graph = new GGraph(true);

            //existingVertices.Add(new GVertex("Sarah Barber", "Red")); //1
            //existingVertices.Add(new GVertex("Marlon Grech", "Blue")); //2


            foreach (GVertex vertex in existingVertices)
            {
                Graph.AddVertex(vertex);
                //MessageBox.Show(vertex.ID);
            }


            //add some edges to the graph
            foreach (GEdge obj in connections)
            {
                Graph.AddEdge(obj);
            }

            //Add Layout Algorithm Types
            layoutAlgorithmTypes.Add("BoundedFR");
            layoutAlgorithmTypes.Add("Circular");
            layoutAlgorithmTypes.Add("CompoundFDP");
            layoutAlgorithmTypes.Add("EfficientSugiyama");
            layoutAlgorithmTypes.Add("FR");
            layoutAlgorithmTypes.Add("ISOM");
            layoutAlgorithmTypes.Add("KK");
            layoutAlgorithmTypes.Add("LinLog");
            layoutAlgorithmTypes.Add("Tree");

            //Pick a default Layout Algorithm Type
            LayoutAlgorithmType = "Tree";


        }

        public void Animation(string Q)
        {
            //existingVertices[0].VertexColor="Red";
            //DFS0(0, 0);
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += delegate (object s, DoWorkEventArgs args)
            {
                bool Found = false;
                string[] inputs = Q.Split(' ');
                int dir = Convert.ToInt32(inputs[0]);
                int x = Convert.ToInt32(inputs[1]);
                int y = Convert.ToInt32(inputs[2]);
                if (dir == 0)
                {
                    if (DFS0(1, y, x, Found))
                    {
                        MessageBox.Show("Ditemukan", "Hasil Pencarian:");
                    }
                    else
                    {
                        MessageBox.Show("Tidak Ditemukan", "Hasil Pencarian:");
                    }
                }
            };

            worker.RunWorkerAsync();
        }

        bool DFS0(int start, int finish, int goal, bool Found)
        {
            //Variables
            GVertex S = existingVertices[start - 1];
            if (start == finish) // basis 1 : Node sekarang adalah node finish
            {
                S.VertexColor = "Yellow";
                Thread.Sleep(500);
                S.VertexColor = "Black";
                Thread.Sleep(500);
                if (start == goal) // cek apakah node sekarang adalah node yang dicari
                {
                    S.VertexColor = "Green";
                    Thread.Sleep(500);
                    S.VertexColor = "Black";
                    Thread.Sleep(500);
                    return true;
                }
                else
                {
                    if (Found)
                    {
                        S.VertexColor = "Green";
                        Thread.Sleep(500);
                    }
                    else
                    {
                        S.VertexColor = "Red";
                        Thread.Sleep(500);
                    }
                    S.VertexColor = "Black";
                    return Found;
                }
            }
            else if (graph.OutDegree(S) == 0) // basis 2 : Node sekarang adalah node daun (Tidak memiliki child node lagi)
            {
                S.VertexColor = "Red";
                Thread.Sleep(1000);
                S.VertexColor = "Black";
                return false;
            }
            else
            {
                if (start == goal)
                {
                    S.VertexColor = "Green";
                    Found = true;
                }


                S.VertexColor = "Blue";
                Thread.Sleep(500);
                int i = 0;
                int N = graph.OutDegree(S);
                bool FoundTemp = false;
                while (i < N && !FoundTemp)
                {
                    graph.OutEdge(S, i).EdgeColor = "Blue";
                    Thread.Sleep(500);
                    FoundTemp = DFS0(Convert.ToInt32(graph.OutEdge(S,i).Target.ID), finish, goal, Found); // rekursi
                    Thread.Sleep(500);
                    graph.OutEdge(S, i).EdgeColor = "Black";
                    Thread.Sleep(500);
                    i++;
                }
                S.VertexColor = "Black";
                return FoundTemp;
            }
        }
        

        /*#region Private Methods
        private GEdge AddNewGraphEdge(GVertex from, GVertex to, String Color)
        {
            string edgeString = string.Format("{0}-{1} Connected", from.ID, to.ID);

            GEdge newEdge = new GEdge(edgeString, from, to, Color);
            Graph.AddEdge(newEdge);
            return newEdge;
        }


        #endregion*/

        #region Public Properties

        public List<String> LayoutAlgorithmTypes
        {
            get { return layoutAlgorithmTypes; }
        }


        public string LayoutAlgorithmType
        {
            get { return layoutAlgorithmType; }
            set
            {
                layoutAlgorithmType = value;
                NotifyPropertyChanged("LayoutAlgorithmType");
            }
        }



        public GGraph Graph
        {
            get { return graph; }
            set
            {
                graph = value;
                NotifyPropertyChanged("Graph");
            }
        }
        #endregion

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        #endregion
    }
}
