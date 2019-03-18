﻿using System;
using System.Collections.Generic;
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
        public MainWindow(MainViewModel v)
        {
            vm = v;
            this.DataContext = v;
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.ReLayoutGraph();
        }
    }
}