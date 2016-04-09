﻿using Item_WPF.addin;
using Item_WPF.MVVM.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Item_WPF.MVVM.ViewModels
{
    class all_ItemsViewModel : ViewModelBase, IDisposable
    {
        protected Window Owner;
        private item1Entities _context;
        public string pass { get; set; }
        public ObservableCollection<ItemClass> ItemsClass { get; set; }
        #region  public ObservableCollection<ITEM> Items
        public ObservableCollection<ITEM> Items
        {
            get
            {
                if (SelectedItClassforSort == 1 || SelectedItClassforSort == 0 || SelectedItClassforSort == null)
                    return new ObservableCollection<ITEM>(_context.ITEMs);
                else return new ObservableCollection<ITEM>(_context.ITEMs.Where(p => p.usItemClass == SelectedItClassforSort));
            }
        }
        #endregion
        #region public int? SelectedItClassforSort
        private int? _SelectedItClassforSort;
        public int? SelectedItClassforSort
        {
            get
            {
                return _SelectedItClassforSort;
            }
            set
            {
                if (_SelectedItClassforSort != value)
                {
                    _SelectedItClassforSort = value;
                    NotifyPropertyChanged("SelectedItClassforSort");
                }
            }
        }
        #endregion
        #region public  ITEM SelectedItemForWork
        private ITEM _SelectedItemForWork;
        public ITEM SelectedItemForWork
        {
            get
            {
                return _SelectedItemForWork;
            }
            set
            {
                if (_SelectedItemForWork != value)
                {
                    _SelectedItemForWork = value;
                    NotifyPropertyChanged("SelectedItemForWork");
                }
            }
        }
        #endregion

        public all_ItemsViewModel(Window owner, object param)
        {
            Owner = owner;
            _context = new item1Entities();
            string Param = param as string;
            SelectedItClassforSort = _context.ItemClasses.FirstOrDefault(p => p.name.Contains(Param)).id;
            ItemsClass = new ObservableCollection<ItemClass>(_context.ItemClasses);

            Refresh = new ActionCommand(Refreshnew) { IsExecutable = true };
            CSelItem = new ActionCommand(CSelectedItem) { IsExecutable = true };
            Save = new ActionCommand(SaveChanges) { IsExecutable = true };
            CDelItem = new ActionCommand(DelItem) { IsExecutable = true };
            CNewItem = new ActionCommand(NewItem) { IsExecutable = true };
            PropertyDependencyMap.Add("SelectedItClassforSort", new[] { "Items" });
        }

        #region Command Refrekshnew
        private void Refreshnew()
        {
            _context?.Dispose();
            _context = new item1Entities();
            //  Items = new ObservableCollection<ITEM>(_context.ITEMs);
            SelectedItClassforSort = 1;
            //else Items = new ObservableCollection<ITEM>(_context.ITEMs.Where(p => p.usItemClass == SelectedItClassforSort));
        }
        public ActionCommand Refresh { get; set; }
        #endregion
        #region Command CSelectedItem
        private void CSelectedItem()
        {
            if (SelectedItemForWork != null)
            {
                // if (SelectedItemForWork.used == false)// созаем сущьность для сравнения
                //  {

                if (SelectedItemForWork.usItemClass == _context.ItemClasses.FirstOrDefault(p => p.name.Contains("Gun")).id
                       || SelectedItemForWork.usItemClass == _context.ItemClasses.FirstOrDefault(p => p.name.Contains("Knife")).id
                       || SelectedItemForWork.usItemClass == _context.ItemClasses.FirstOrDefault(p => p.name.Contains("Throwing Knife")).id
                       || SelectedItemForWork.usItemClass == _context.ItemClasses.FirstOrDefault(p => p.name.Contains("Launcher")).id
                       || SelectedItemForWork.usItemClass == _context.ItemClasses.FirstOrDefault(p => p.name.Contains("Thrown Weapon")).id
                       || SelectedItemForWork.usItemClass == _context.ItemClasses.FirstOrDefault(p => p.name.Contains("Blunt Weapon")).id)
                {
                    SelectedItemForWork.used = true;
                    SelectedItemForWork.dt = System.DateTime.UtcNow;
                    SaveChanges();

                    WeaponEditView avView = new WeaponEditView(SelectedItemForWork);
                    avView.Owner = Owner;
                    bool? result = avView.ShowDialog();
   
                    if (result.HasValue && (result == true))
                    {
                        _context?.Dispose();
                        _context = new item1Entities();
                        NotifyPropertyChanged("SelectedItClassforSort");

                    }
                }
                else if (SelectedItemForWork.usItemClass == _context.ItemClasses.FirstOrDefault(p => p.name.Contains("Attachment")).id)
                {
                    SelectedItemForWork.used = true;
                    SelectedItemForWork.dt = System.DateTime.UtcNow;
                    SaveChanges();

                    AttacmentEditView attachNr = new AttacmentEditView(SelectedItemForWork);
                    attachNr.ShowDialog();
                }
                //}
                //else MessageBox.Show("no");                
            }
        }

        public ActionCommand CSelItem { get; set; }
        #endregion
        #region Command DelItem
        private void DelItem()
        {
            //    if (item.used == false)
            //    {

            InputBoxView ib = new InputBoxView();
            InputBoxViewModel ib_datacontext = new InputBoxViewModel("Password for Del entity", "Type Password", "");
            ib.DataContext = ib_datacontext;
            ib.ShowDialog();
            pass = ib_datacontext.passinput;
            ib_datacontext.Dispose();
            if (pass == "123")
            {
                MessageBox.Show("Correct Pass");
                _context.ITEMs.Remove(SelectedItemForWork);
                Items.Remove(SelectedItemForWork);
                _context.SaveChanges();
            }
            else MessageBox.Show("This rows is used");
        }

        public ActionCommand CDelItem { get; set; }
        #endregion
        #region Command Save
        private void SaveChanges()
        {
            _context.SaveChanges();
        }
        public ActionCommand Save { get; set; }
        #endregion
        #region Command NewItem
        private void NewItem()
        {
            NewItemsView _newItemView = new NewItemsView();
            _newItemView.ShowDialog();
        }
        public ActionCommand CNewItem { get; set; }
        #endregion

        #region intrfeis       
        public void Dispose()
        {
            _context?.Dispose();
        }
        #endregion
    }
}
/*
        private void dataGridViewAllItems_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            bool ew2;
            //ITEM item1 = (ITEM)e.Row.Item;
            ITEM item1 = e.Row.DataContext as ITEM;
            if (item1 != null)
            {
                ew2 = item1.used;
                if (ew2) e.Row.Background = System.Windows.Media.Brushes.LightGreen;
                else e.Row.Background = System.Windows.Media.Brushes.White;
            }
        }
    }
}


*/
