﻿using Item_WPF.addin;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_WPF.MVVM.ViewModels
{
    public class BoxItemViewModel : ViewModelBase
    {
        private item1Entities _context;
        public ObservableCollection<ItemClass> ItemsClass { get; set; }
        public AnyBoxNameType bx { get; set; }
        public BoxItem BoxItemforWork { get; set; }
        public ITEM itemtobox { get; set; }
        public ObservableCollection<BoxItem> boxItem { get; set; }
        #region public ObservableCollection<ITEM> ItemsFromDB
        public ObservableCollection<ITEM> ItemsFromDB
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
        public BoxItemViewModel(object parameter)
        {
            int Boxindex = Convert.ToInt32(parameter);
            _context = new item1Entities();
            bx = _context.AnyBoxNameTypes.First(p => p.id == Boxindex);
            boxItem = new ObservableCollection<BoxItem>(_context.BoxItems.Where(p => p.BoxName == Boxindex));
            ItemsClass = new ObservableCollection<ItemClass>(_context.ItemClasses);

            //BoxItem bv = new BoxItem();
            //bv.CountItems;
            boxItem.CollectionChanged+= new NotifyCollectionChangedEventHandler(boxItem_CollectionChanged);
            AddCommand = new ViewModelCommand(Add, true);
            RemCommand = new ViewModelCommand(Rem, true);
            Save = new DelegateCommand(SaveChanges);

            PropertyDependencyMap.Add("SelectedItClassforSort", new[] { "ItemsFromDB" });
        }
        #region Command
        #region Command public ViewModelCommand AddCommand { get; set; }
        private void Add(object parameter)
        {
            BoxItemforWork = null;
            BoxItemforWork = (from p in boxItem
                              where p.ITEM == itemtobox
                              select p).FirstOrDefault();
            if (BoxItemforWork == null)
            {
                boxItem.Add(new BoxItem { ITEM = itemtobox, BoxName = bx.id, CountItems = 1 });
                NotifyPropertyChanged("boxItem");
            }
            else
            {
                BoxItemforWork.CountItems+=1;
            }
        }
        public ViewModelCommand AddCommand { get; set; }
        #endregion
        #region public ViewModelCommand RemCommand { get; set; }
        private void Rem(object parameter)
        {
            if (BoxItemforWork.CountItems > 1)
            {
                BoxItemforWork.CountItems -= 1;
            }
            else {
                boxItem.Remove(BoxItemforWork);
            }

        }

        public ViewModelCommand RemCommand { get; set; }
        #endregion

        #endregion
        private void boxItem_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (BoxItem item in e.OldItems)
                {
                    _context.BoxItems.Remove(item);
                }
                //  SaveChanges();
            }
            else if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (BoxItem item in e.NewItems)
                {
                    _context.BoxItems.Add(item);
                }
            }
        }
        private void SaveChanges(object parameter)
        {
            _context.SaveChanges();
        }
        public DelegateCommand Save { get; set; }
    }
}
