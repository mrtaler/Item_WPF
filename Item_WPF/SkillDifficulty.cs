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
    
    public partial class SkillDifficulty : System.ComponentModel.INotifyPropertyChanged
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
        public SkillDifficulty()
        {
            this.GurpsSkills = new HashSet<GurpsSkill>();
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
        private Nullable<int> _idDefaultstat;
    	public Nullable<int> idDefaultstat 
    	{ 
    		get
    		{
    			return _idDefaultstat;
    		} 
    		set
    		{
    			if (_idDefaultstat != value)
    			{
    				_idDefaultstat = value;
    				OnPropertyChanged("idDefaultstat");
    			}
    		}
    	}
        private Nullable<int> _idDifficulty;
    	public Nullable<int> idDifficulty 
    	{ 
    		get
    		{
    			return _idDifficulty;
    		} 
    		set
    		{
    			if (_idDifficulty != value)
    			{
    				_idDifficulty = value;
    				OnPropertyChanged("idDifficulty");
    			}
    		}
    	}
        private string _De;
    	public string De 
    	{ 
    		get
    		{
    			return _De;
    		} 
    		set
    		{
    			if (_De != value)
    			{
    				_De = value;
    				OnPropertyChanged("De");
    			}
    		}
    	}
    
        private Attribute _Attribute;
            public virtual Attribute Attribute
            {
                get { return _Attribute; }
                set
                { if(_Attribute != value)
                    {    _Attribute = value;    OnPropertyChanged("Attribute");   }
                }
            } 
        private Difficulty _Difficulty;
            public virtual Difficulty Difficulty
            {
                get { return _Difficulty; }
                set
                { if(_Difficulty != value)
                    {    _Difficulty = value;    OnPropertyChanged("Difficulty");   }
                }
            } 
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        private ICollection<GurpsSkill> _GurpsSkills;
            public virtual ICollection<GurpsSkill> GurpsSkills
            {
                get { return _GurpsSkills; }
                set
                { if(_GurpsSkills != value)
                    {    _GurpsSkills = value;    OnPropertyChanged("GurpsSkills");   }
                }
            } 
    }
}
