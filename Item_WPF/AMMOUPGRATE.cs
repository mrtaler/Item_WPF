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
    
    public partial class AMMOUPGRATE : System.ComponentModel.INotifyPropertyChanged
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
        private string _shortname;
    	public string shortname 
    	{ 
    		get
    		{
    			return _shortname;
    		} 
    		set
    		{
    			if (_shortname != value)
    			{
    				_shortname = value;
    				OnPropertyChanged("shortname");
    			}
    		}
    	}
        private int _malf;
    	public int malf 
    	{ 
    		get
    		{
    			return _malf;
    		} 
    		set
    		{
    			if (_malf != value)
    			{
    				_malf = value;
    				OnPropertyChanged("malf");
    			}
    		}
    	}
        private decimal _AR_divX;
    	public decimal AR_divX 
    	{ 
    		get
    		{
    			return _AR_divX;
    		} 
    		set
    		{
    			if (_AR_divX != value)
    			{
    				_AR_divX = value;
    				OnPropertyChanged("AR_divX");
    			}
    		}
    	}
        private int _ACC_add;
    	public int ACC_add 
    	{ 
    		get
    		{
    			return _ACC_add;
    		} 
    		set
    		{
    			if (_ACC_add != value)
    			{
    				_ACC_add = value;
    				OnPropertyChanged("ACC_add");
    			}
    		}
    	}
        private decimal _ACC_x;
    	public decimal ACC_x 
    	{ 
    		get
    		{
    			return _ACC_x;
    		} 
    		set
    		{
    			if (_ACC_x != value)
    			{
    				_ACC_x = value;
    				OnPropertyChanged("ACC_x");
    			}
    		}
    	}
        private decimal _damage_x;
    	public decimal damage_x 
    	{ 
    		get
    		{
    			return _damage_x;
    		} 
    		set
    		{
    			if (_damage_x != value)
    			{
    				_damage_x = value;
    				OnPropertyChanged("damage_x");
    			}
    		}
    	}
        private string _Dam_Type;
    	public string Dam_Type 
    	{ 
    		get
    		{
    			return _Dam_Type;
    		} 
    		set
    		{
    			if (_Dam_Type != value)
    			{
    				_Dam_Type = value;
    				OnPropertyChanged("Dam_Type");
    			}
    		}
    	}
        private decimal _range_x12;
    	public decimal range_x12 
    	{ 
    		get
    		{
    			return _range_x12;
    		} 
    		set
    		{
    			if (_range_x12 != value)
    			{
    				_range_x12 = value;
    				OnPropertyChanged("range_x12");
    			}
    		}
    	}
        private decimal _range_x;
    	public decimal range_x 
    	{ 
    		get
    		{
    			return _range_x;
    		} 
    		set
    		{
    			if (_range_x != value)
    			{
    				_range_x = value;
    				OnPropertyChanged("range_x");
    			}
    		}
    	}
        private decimal _ST_x;
    	public decimal ST_x 
    	{ 
    		get
    		{
    			return _ST_x;
    		} 
    		set
    		{
    			if (_ST_x != value)
    			{
    				_ST_x = value;
    				OnPropertyChanged("ST_x");
    			}
    		}
    	}
        private decimal _WPS_x;
    	public decimal WPS_x 
    	{ 
    		get
    		{
    			return _WPS_x;
    		} 
    		set
    		{
    			if (_WPS_x != value)
    			{
    				_WPS_x = value;
    				OnPropertyChanged("WPS_x");
    			}
    		}
    	}
        private decimal _CPS_x;
    	public decimal CPS_x 
    	{ 
    		get
    		{
    			return _CPS_x;
    		} 
    		set
    		{
    			if (_CPS_x != value)
    			{
    				_CPS_x = value;
    				OnPropertyChanged("CPS_x");
    			}
    		}
    	}
        private int _Hearing;
    	public int Hearing 
    	{ 
    		get
    		{
    			return _Hearing;
    		} 
    		set
    		{
    			if (_Hearing != value)
    			{
    				_Hearing = value;
    				OnPropertyChanged("Hearing");
    			}
    		}
    	}
        private string _Ammo_Class;
    	public string Ammo_Class 
    	{ 
    		get
    		{
    			return _Ammo_Class;
    		} 
    		set
    		{
    			if (_Ammo_Class != value)
    			{
    				_Ammo_Class = value;
    				OnPropertyChanged("Ammo_Class");
    			}
    		}
    	}
        private Nullable<decimal> _min_Caliber;
    	public Nullable<decimal> min_Caliber 
    	{ 
    		get
    		{
    			return _min_Caliber;
    		} 
    		set
    		{
    			if (_min_Caliber != value)
    			{
    				_min_Caliber = value;
    				OnPropertyChanged("min_Caliber");
    			}
    		}
    	}
        private Nullable<decimal> _Max_Calider;
    	public Nullable<decimal> Max_Calider 
    	{ 
    		get
    		{
    			return _Max_Calider;
    		} 
    		set
    		{
    			if (_Max_Calider != value)
    			{
    				_Max_Calider = value;
    				OnPropertyChanged("Max_Calider");
    			}
    		}
    	}
        private Nullable<decimal> _DT_Min_Ammo_CAliber;
    	public Nullable<decimal> DT_Min_Ammo_CAliber 
    	{ 
    		get
    		{
    			return _DT_Min_Ammo_CAliber;
    		} 
    		set
    		{
    			if (_DT_Min_Ammo_CAliber != value)
    			{
    				_DT_Min_Ammo_CAliber = value;
    				OnPropertyChanged("DT_Min_Ammo_CAliber");
    			}
    		}
    	}
        private string _Condition_DT_Min_ammo_Cal;
    	public string Condition_DT_Min_ammo_Cal 
    	{ 
    		get
    		{
    			return _Condition_DT_Min_ammo_Cal;
    		} 
    		set
    		{
    			if (_Condition_DT_Min_ammo_Cal != value)
    			{
    				_Condition_DT_Min_ammo_Cal = value;
    				OnPropertyChanged("Condition_DT_Min_ammo_Cal");
    			}
    		}
    	}
        private int _hearing_table;
    	public int hearing_table 
    	{ 
    		get
    		{
    			return _hearing_table;
    		} 
    		set
    		{
    			if (_hearing_table != value)
    			{
    				_hearing_table = value;
    				OnPropertyChanged("hearing_table");
    			}
    		}
    	}
        private string _Upgrates;
    	public string Upgrates 
    	{ 
    		get
    		{
    			return _Upgrates;
    		} 
    		set
    		{
    			if (_Upgrates != value)
    			{
    				_Upgrates = value;
    				OnPropertyChanged("Upgrates");
    			}
    		}
    	}
        private string _Follow_Up;
    	public string Follow_Up 
    	{ 
    		get
    		{
    			return _Follow_Up;
    		} 
    		set
    		{
    			if (_Follow_Up != value)
    			{
    				_Follow_Up = value;
    				OnPropertyChanged("Follow_Up");
    			}
    		}
    	}
        private string _Linked;
    	public string Linked 
    	{ 
    		get
    		{
    			return _Linked;
    		} 
    		set
    		{
    			if (_Linked != value)
    			{
    				_Linked = value;
    				OnPropertyChanged("Linked");
    			}
    		}
    	}
    }
}
