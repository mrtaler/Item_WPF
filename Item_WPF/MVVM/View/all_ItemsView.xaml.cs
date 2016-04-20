﻿using Item_WPF.MVVM.ViewModels;
using System;
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

namespace Item_WPF.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для all_ItemsView.xaml
    /// </summary>
    public partial class all_ItemsView : Window
    {
        public all_ItemsViewModel _allItemsViewModel;
        public all_ItemsView(object parametr)
        {
            _allItemsViewModel = new all_ItemsViewModel(this, parametr);
            DataContext = _allItemsViewModel;
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }
    }
}
