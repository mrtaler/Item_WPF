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

    public partial class Attribute : System.ComponentModel.INotifyPropertyChanged
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
        public Attribute()
        {
            this.AttributeBonus = new HashSet<AttributeBonu>();
            this.SkillDifficulties = new HashSet<SkillDifficulty>();
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
        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        private ICollection<AttributeBonu> _AttributeBonus;
        public virtual ICollection<AttributeBonu> AttributeBonus
        {
            get { return _AttributeBonus; }
            set
            {
                if (_AttributeBonus != value)
                { _AttributeBonus = value; OnPropertyChanged("AttributeBonus"); }
            }
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        private ICollection<SkillDifficulty> _SkillDifficulties;
        public virtual ICollection<SkillDifficulty> SkillDifficulties
        {
            get { return _SkillDifficulties; }
            set
            {
                if (_SkillDifficulties != value)
                { _SkillDifficulties = value; OnPropertyChanged("SkillDifficulties"); }
            }
        }
    }
}
