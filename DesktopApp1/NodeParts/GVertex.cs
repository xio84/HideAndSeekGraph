using System;
using System.Diagnostics;
using System.ComponentModel;

namespace HideAndSeekGraph.NodeParts
{
    /// 

    /// A simple identifiable vertex.
    /// 
    [DebuggerDisplay("{ID}-{IsMale}")]
    public class GVertex : INotifyPropertyChanged
    {
        public string ID { get; private set; }

        public GVertex(string id,string color)
        {
            ID = id;
            VertexColor = color;
        }

        private String vertexColor;

        public String VertexColor{ get { return vertexColor; }
            set { vertexColor = value;
                NotifyPropertyChanged("VertexColor");
            }
        }

        public override string ToString()
        {
            return string.Format("{0}", ID);
        }

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion
    }

}
