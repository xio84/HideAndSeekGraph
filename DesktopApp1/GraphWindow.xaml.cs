using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GraphSharp.Controls;
using HideAndSeekGraph.ViewModel;

namespace HideAndSeekGraph
{
    public partial class MainWindow : Window
    {
        private MainViewModel vm;
        public ArrayList A;
        public MainWindow(MainViewModel v, ArrayList _A)
        {
            A = _A;
            vm = v;
            vm.ReLayoutGraph();
            this.DataContext = v;
            InitializeComponent();
            foreach (string a in A)
            {
                QueryList.Items.Add(a);
            }
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            QueryList.Items.Clear();
            foreach (string a in A)
            {
                QueryList.Items.Add(a);
            }
            vm.ReLayoutGraph();
        }

        private void Animation(object sender, RoutedEventArgs e)
        {
            vm.Animation(QueryList.SelectedValue.ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            QueryList.Items.Add(Query.Text);
            Query.Text = null;
        }
    }
}
