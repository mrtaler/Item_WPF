﻿using System.Windows;
using Item_WPF.ItemEntityModel;

namespace Item_WPF.MVVM.AddSkilltoChar
{
    /// <summary>
    /// Логика взаимодействия для AddSkilltoCharView.xaml
    /// </summary>
    public partial class AddSkilltoCharView : Window
    {
        public AddSkilltoCharView()
        {
            InitializeComponent();
        }

        public AddSkilltoCharView(CharacterDB Char, item1Entities context)
        //       :base()
        {
            DataContext = new AddSkilltoCharViewModel(Char, context);
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
