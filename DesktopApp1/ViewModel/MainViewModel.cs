using System;
using System.Collections.Generic;
using System.ComponentModel;
using GraphSharp.Controls;
using HideAndSeekGraph.NodeParts;

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
        #endregion

        #region Ctor
        public MainViewModel()
        {
            Graph = new GGraph(true);


            List<GVertex> existingVertices = new List<GVertex>();
            existingVertices.Add(new GVertex("Sacha Barber", true)); //0
            existingVertices.Add(new GVertex("Sarah Barber", false)); //1
            existingVertices.Add(new GVertex("Marlon Grech", true)); //2


            foreach (GVertex vertex in existingVertices)
                Graph.AddVertex(vertex);


            //add some edges to the graph
            AddNewGraphEdge(existingVertices[0], existingVertices[1]);
            AddNewGraphEdge(existingVertices[0], existingVertices[2]);

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
            LayoutAlgorithmType = "LinLog";





        }
        #endregion


        public void ReLayoutGraph()
        {
            graph = new GGraph(true);
            count++;



            List<GVertex> existingVertices = new List<GVertex>();
            existingVertices.Add(new GVertex(String.Format("Barn Rubble{0}", count), true)); //0
            existingVertices.Add(new GVertex(String.Format("Frank Zappa{0}", count), false)); //1
            existingVertices.Add(new GVertex(String.Format("Gerty CrinckleBottom{0}", count), true)); //2


            foreach (GVertex vertex in existingVertices)
                Graph.AddVertex(vertex);


            //add some edges to the graph
            AddNewGraphEdge(existingVertices[0], existingVertices[1]);
            AddNewGraphEdge(existingVertices[0], existingVertices[2]);


            NotifyPropertyChanged("Graph");




        }



        #region Private Methods
        private GEdge AddNewGraphEdge(GVertex from, GVertex to)
        {
            string edgeString = string.Format("{0}-{1} Connected", from.ID, to.ID);

            GEdge newEdge = new GEdge(edgeString, from, to);
            Graph.AddEdge(newEdge);
            return newEdge;
        }


        #endregion

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
