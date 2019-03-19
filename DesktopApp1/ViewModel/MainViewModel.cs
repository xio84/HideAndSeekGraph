using System;
using System.Collections.Generic;
using System.ComponentModel;
using GraphSharp.Controls;
using HideAndSeekGraph.NodeParts;
using System.Windows.Forms;
using System.Windows.Media;

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
        public static List<GVertex> existingVertices;
        public static List<GEdge> connections;
        #endregion

        #region Ctor
        public MainViewModel()
        {
            if (existingVertices == null)
            {
                existingVertices = new List<GVertex>();
            }
            if (connections == null)
            {
                connections = new List<GEdge>();
            }

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

        public void Animation()
        {
            existingVertices[0].VertexColor="Red";
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
