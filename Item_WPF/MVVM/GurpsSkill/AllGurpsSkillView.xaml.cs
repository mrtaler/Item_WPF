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

namespace Item_WPF.MVVM.GurpsSkill
{
    /// <summary>
    /// Логика взаимодействия для AllGurpsSkillView.xaml
    /// </summary>
    public partial class AllGurpsSkillView : Window
    {
        public AllGurpsSkillView()
        {
            InitializeComponent();
            DataContext = new AllGurpsSkillViewModel();
        }
    }
}