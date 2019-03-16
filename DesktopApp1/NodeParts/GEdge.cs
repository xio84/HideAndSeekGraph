using System.Diagnostics;
using QuickGraph;
using System.ComponentModel;

namespace HideAndSeekGraph.NodeParts
{
    /// A simple identifiable edge.
    /// 
    [DebuggerDisplay("{Source.ID} -> {Target.ID}")]
    public class GEdge : Edge<GVertex>, INotifyPropertyChanged
    {
        private string id;

        public string ID
        {
            get { return id; }
            set
            {
                id = value;
                NotifyPropertyChanged("ID");
            }
        }

        public GEdge(string id, GVertex source, GVertex target)
            : base(source, target)
        {
            ID = id;
        }

        public bool ShowTooltip => true;


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
