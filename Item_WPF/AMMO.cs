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
    
    public partial class AMMO : System.ComponentModel.INotifyPropertyChanged
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
        public AMMO()
        {
            this.WEAPONs = new HashSet<WEAPON>();
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
        private string _Caliber_name;
    	public string Caliber_name 
    	{ 
    		get
    		{
    			return _Caliber_name;
    		} 
    		set
    		{
    			if (_Caliber_name != value)
    			{
    				_Caliber_name = value;
    				OnPropertyChanged("Caliber_name");
    			}
    		}
    	}
        private string _alt_caliber_name;
    	public string alt_caliber_name 
    	{ 
    		get
    		{
    			return _alt_caliber_name;
    		} 
    		set
    		{
    			if (_alt_caliber_name != value)
    			{
    				_alt_caliber_name = value;
    				OnPropertyChanged("alt_caliber_name");
    			}
    		}
    	}
        private decimal _Dim_of_bullet_SI;
    	public decimal Dim_of_bullet_SI 
    	{ 
    		get
    		{
    			return _Dim_of_bullet_SI;
    		} 
    		set
    		{
    			if (_Dim_of_bullet_SI != value)
    			{
    				_Dim_of_bullet_SI = value;
    				OnPropertyChanged("Dim_of_bullet_SI");
    			}
    		}
    	}
        private decimal _Dim_of_bullet_US;
    	public decimal Dim_of_bullet_US 
    	{ 
    		get
    		{
    			return _Dim_of_bullet_US;
    		} 
    		set
    		{
    			if (_Dim_of_bullet_US != value)
    			{
    				_Dim_of_bullet_US = value;
    				OnPropertyChanged("Dim_of_bullet_US");
    			}
    		}
    	}
        private Nullable<int> _AV_Upgrates;
    	public Nullable<int> AV_Upgrates 
    	{ 
    		get
    		{
    			return _AV_Upgrates;
    		} 
    		set
    		{
    			if (_AV_Upgrates != value)
    			{
    				_AV_Upgrates = value;
    				OnPropertyChanged("AV_Upgrates");
    			}
    		}
    	}
        private Nullable<decimal> _WPS;
    	public Nullable<decimal> WPS 
    	{ 
    		get
    		{
    			return _WPS;
    		} 
    		set
    		{
    			if (_WPS != value)
    			{
    				_WPS = value;
    				OnPropertyChanged("WPS");
    			}
    		}
    	}
        private Nullable<decimal> _CPS;
    	public Nullable<decimal> CPS 
    	{ 
    		get
    		{
    			return _CPS;
    		} 
    		set
    		{
    			if (_CPS != value)
    			{
    				_CPS = value;
    				OnPropertyChanged("CPS");
    			}
    		}
    	}
        private string _Class_of_Ammo;
    	public string Class_of_Ammo 
    	{ 
    		get
    		{
    			return _Class_of_Ammo;
    		} 
    		set
    		{
    			if (_Class_of_Ammo != value)
    			{
    				_Class_of_Ammo = value;
    				OnPropertyChanged("Class_of_Ammo");
    			}
    		}
    	}
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        private ICollection<WEAPON> _WEAPONs;
            public virtual ICollection<WEAPON> WEAPONs
            {
                get { return _WEAPONs; }
                set
                { if(_WEAPONs != value)
                    {    _WEAPONs = value;    OnPropertyChanged("WEAPONs");   }
                }
            } 
    }
}
