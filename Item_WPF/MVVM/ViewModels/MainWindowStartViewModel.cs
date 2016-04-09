﻿using Item_WPF.addin;
using Item_WPF.MVVM.View;
using Microsoft.Windows.Controls.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Item_WPF.MVVM.ViewModels
{
    class MainWindowStartViewModel
    {

        protected RibbonWindow Owner;

        public DelegateCommand AboutCommand { get; private set; }
        public DelegateCommand DropDiceCommand { get; private set; }
        public DelegateCommand ShowAllItemsCommand { get; private set; }
        public DelegateCommand ShowCombineCommand { get; private set; }
        public DelegateCommand ShowCharacterCommand { get; private set; }
        public DelegateCommand OwnerCloseCommand { get; private set; }

        public MainWindowStartViewModel(RibbonWindow owner)
        {
            Owner = owner;

            // Create commands
            AboutCommand = new DelegateCommand(ShowAboutWindow);
            DropDiceCommand = new DelegateCommand(DropDice);//+
            ShowAllItemsCommand = new DelegateCommand(ShowAllItems);//+
            ShowCombineCommand = new DelegateCommand(ShowCombine);//+
            ShowCharacterCommand = new DelegateCommand(ShowCharacter);//+
            OwnerCloseCommand = new DelegateCommand(OwnerClose);//+
        }
        public void ShowAboutWindow(object parameter)
        {
            AboutWindowView window = new AboutWindowView();
            window.Owner = Owner;
            window.ShowDialog();
        }
        public void ShowCharacter(object parameter)
        {
            MainCharacterView window = new MainCharacterView();
            window.ShowDialog();
        }
        public void DropDice(object parameter)
        {
            MessageBox.Show(Dice.RollDie(6, 3).ToString());
        }

        public void ShowAllItems(object parameter)
        {
       
                all_ItemsView allItems = new all_ItemsView(parameter);
                allItems.Show();
            
        }
        public void OwnerClose(object parameter)
        {
            Owner.Close();
        }
        public void ShowCombine(object parameter)
        {

            CombineWeapView combine = new CombineWeapView();
            combine.Show();


        }
    }
}