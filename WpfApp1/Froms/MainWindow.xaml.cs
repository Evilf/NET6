﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Froms.ViewModels;

namespace WpfApp1.Forms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public VM_MainWindow VM_MainWindow { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(VM_MainWindow vM_MainWindow)
        {
            InitializeComponent();
            DataContext = vM_MainWindow;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}