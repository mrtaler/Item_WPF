//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Item_WPF
{
    using System;
    using System.Collections.Generic;

    public partial class ARMOUR : System.ComponentModel.INotifyPropertyChanged
    {

        #region Implement INotifyPropertyChanged

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        private int _uiIndex;
        public int uiIndex
        {
            get
            {
                return _uiIndex;
            }
            set
            {
                if (_uiIndex != value)
                {
                    _uiIndex = value;
                    OnPropertyChanged("uiIndex");
                }
            }
        }

        private int _ubArmourClass;
        public int ubArmourClass
        {
            get
            {
                return _ubArmourClass;
            }
            set
            {
                if (_ubArmourClass != value)
                {
                    _ubArmourClass = value;
                    OnPropertyChanged("ubArmourClass");
                }
            }
        }

        private int _ubProtection;
        public int ubProtection
        {
            get
            {
                return _ubProtection;
            }
            set
            {
                if (_ubProtection != value)
                {
                    _ubProtection = value;
                    OnPropertyChanged("ubProtection");
                }
            }
        }

        private int _ubCoverage;
        public int ubCoverage
        {
            get
            {
                return _ubCoverage;
            }
            set
            {
                if (_ubCoverage != value)
                {
                    _ubCoverage = value;
                    OnPropertyChanged("ubCoverage");
                }
            }
        }

        private int _ubDegradePercent;
        public int ubDegradePercent
        {
            get
            {
                return _ubDegradePercent;
            }
            set
            {
                if (_ubDegradePercent != value)
                {
                    _ubDegradePercent = value;
                    OnPropertyChanged("ubDegradePercent");
                }
            }
        }

        private bool _FlakJacket;
        public bool FlakJacket
        {
            get
            {
                return _FlakJacket;
            }
            set
            {
                if (_FlakJacket != value)
                {
                    _FlakJacket = value;
                    OnPropertyChanged("FlakJacket");
                }
            }
        }

        private bool _LeatherJacket;
        public bool LeatherJacket
        {
            get
            {
                return _LeatherJacket;
            }
            set
            {
                if (_LeatherJacket != value)
                {
                    _LeatherJacket = value;
                    OnPropertyChanged("LeatherJacket");
                }
            }
        }


        private ArmourClass _ArmourClass;
        public virtual ArmourClass ArmourClass
        {
            get
            { return _ArmourClass; }
            set
            {
                if (_ArmourClass != value)
                { _ArmourClass = value; OnPropertyChanged("ArmourClass"); }
            }
        }
    }
}
