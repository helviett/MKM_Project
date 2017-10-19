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
using System.Windows.Shapes;
using MKM_Labs.ViewModels;

namespace MKM_Labs.Views
{
    public partial class FallModelingView : Window
    {
        public FallModelingView()
        {
            InitializeComponent();
            DataContext = new FallModelingViewModel();
        }

        private void CalculateBtnClick(object sender, RoutedEventArgs e)
        {
            var res = ((FallModelingViewModel) DataContext).Calculate();
            var viewRes = new FallModelingResultView();
            viewRes.Show();
            viewRes.DataContext = new FallModelingResultViewModel(res.Item1, res.Item2, res.Item3);
        }
    }
}
