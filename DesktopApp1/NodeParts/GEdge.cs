using System.Diagnostics;
using QuickGraph;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Media;
using System;


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

        private String edgeColor;

        public String EdgeColor { get { return edgeColor; }
            set {
                edgeColor = value;
                NotifyPropertyChanged("EdgeColor");
            }
        }

        public GEdge(string id, GVertex source, GVertex target, String EC)
            : base(source, target)
        {
            ID = id;
            EdgeColor = EC;
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


    /*public class EdgeColorConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return new SolidColorBrush((Color)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }*/

}
