//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Item_WPF.ItemEntityModel
{
    using System;
    using System.Collections.Generic;

    public sealed partial class CharSkill : System.ComponentModel.INotifyPropertyChanged
    {

        #region Implement INotifyPropertyChanged

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        private int _idSkill;
        public int idSkill
        {
            get
            {
                return _idSkill;
            }
            set
            {
                if (_idSkill != value)
                {
                    _idSkill = value;
                    OnPropertyChanged("idSkill");
                }
            }
        }
        private int _idChar;
        public int idChar
        {
            get
            {
                return _idChar;
            }
            set
            {
                if (_idChar != value)
                {
                    _idChar = value;
                    OnPropertyChanged("idChar");
                }
            }
        }
        private int _PointOfSkill;
        public int PointOfSkill
        {
            get
            {
                return _PointOfSkill;
            }
            set
            {
                if (_PointOfSkill != value)
                {
                    _PointOfSkill = value;
                    OnPropertyChanged("PointOfSkill");
                }
            }
        }
        private int _id;
        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged("id");
                }
            }
        }

        private CharacterDB _CharacterDB;
        public CharacterDB CharacterDB
        {
            get { return _CharacterDB; }
            set
            {
                if (_CharacterDB != value)
                { _CharacterDB = value; OnPropertyChanged("CharacterDB"); }
            }
        }
        private GurpsSkill _GurpsSkill;
        public GurpsSkill GurpsSkill
        {
            get { return _GurpsSkill; }
            set
            {
                if (_GurpsSkill != value)
                { _GurpsSkill = value; OnPropertyChanged("GurpsSkill"); }
            }
        }
    }
}
