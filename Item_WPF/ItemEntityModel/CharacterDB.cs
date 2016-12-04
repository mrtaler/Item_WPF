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

    public partial class CharacterDB : System.ComponentModel.INotifyPropertyChanged
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CharacterDB()
        {
            this.CharSkills = new HashSet<CharSkill>();
            this.InventoryOfChars = new HashSet<InventoryOfChar>();
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
        private string _name;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("name");
                }
            }
        }
        private int _StrengthPoints;
        public int StrengthPoints
        {
            get
            {
                return _StrengthPoints;
            }
            set
            {
                if (_StrengthPoints != value)
                {
                    _StrengthPoints = value;
                    OnPropertyChanged("StrengthPoints");
                }
            }
        }
        private int _DexterityPoints;
        public int DexterityPoints
        {
            get
            {
                return _DexterityPoints;
            }
            set
            {
                if (_DexterityPoints != value)
                {
                    _DexterityPoints = value;
                    OnPropertyChanged("DexterityPoints");
                }
            }
        }
        private int _IntelligencePoints;
        public int IntelligencePoints
        {
            get
            {
                return _IntelligencePoints;
            }
            set
            {
                if (_IntelligencePoints != value)
                {
                    _IntelligencePoints = value;
                    OnPropertyChanged("IntelligencePoints");
                }
            }
        }
        private int _HealthPoints;
        public int HealthPoints
        {
            get
            {
                return _HealthPoints;
            }
            set
            {
                if (_HealthPoints != value)
                {
                    _HealthPoints = value;
                    OnPropertyChanged("HealthPoints");
                }
            }
        }
        private int _MaxHPPoints;
        public int MaxHPPoints
        {
            get
            {
                return _MaxHPPoints;
            }
            set
            {
                if (_MaxHPPoints != value)
                {
                    _MaxHPPoints = value;
                    OnPropertyChanged("MaxHPPoints");
                }
            }
        }
        private int _MaxFPPoints;
        public int MaxFPPoints
        {
            get
            {
                return _MaxFPPoints;
            }
            set
            {
                if (_MaxFPPoints != value)
                {
                    _MaxFPPoints = value;
                    OnPropertyChanged("MaxFPPoints");
                }
            }
        }
        private int _PerceptionPoints;
        public int PerceptionPoints
        {
            get
            {
                return _PerceptionPoints;
            }
            set
            {
                if (_PerceptionPoints != value)
                {
                    _PerceptionPoints = value;
                    OnPropertyChanged("PerceptionPoints");
                }
            }
        }
        private int _WillpowerPoints;
        public int WillpowerPoints
        {
            get
            {
                return _WillpowerPoints;
            }
            set
            {
                if (_WillpowerPoints != value)
                {
                    _WillpowerPoints = value;
                    OnPropertyChanged("WillpowerPoints");
                }
            }
        }
        private float _BasicSpeedPoints;
        public float BasicSpeedPoints
        {
            get
            {
                return _BasicSpeedPoints;
            }
            set
            {
                if (_BasicSpeedPoints != value)
                {
                    _BasicSpeedPoints = value;
                    OnPropertyChanged("BasicSpeedPoints");
                }
            }
        }
        private int _BasicMovePoints;
        public int BasicMovePoints
        {
            get
            {
                return _BasicMovePoints;
            }
            set
            {
                if (_BasicMovePoints != value)
                {
                    _BasicMovePoints = value;
                    OnPropertyChanged("BasicMovePoints");
                }
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        private ICollection<CharSkill> _CharSkills;
        public virtual ICollection<CharSkill> CharSkills
        {
            get { return _CharSkills; }
            set
            {
                if (_CharSkills != value)
                { _CharSkills = value; OnPropertyChanged("CharSkills"); }
            }
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        private ICollection<InventoryOfChar> _InventoryOfChars;
        public virtual ICollection<InventoryOfChar> InventoryOfChars
        {
            get { return _InventoryOfChars; }
            set
            {
                if (_InventoryOfChars != value)
                { _InventoryOfChars = value; OnPropertyChanged("InventoryOfChars"); }
            }
        }
    }
}
