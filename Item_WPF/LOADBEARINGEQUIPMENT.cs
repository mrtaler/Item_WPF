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
    
    public partial class LOADBEARINGEQUIPMENT : System.ComponentModel.INotifyPropertyChanged
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
     
        private int _lbeIndex;
    	public int lbeIndex 
    	{ 
    		get
    		{
    			return _lbeIndex;
    		} 
    		set
    		{
    			if (_lbeIndex != value)
    			{
    				_lbeIndex = value;
    				OnPropertyChanged("lbeIndex");
    			}
    		}
    	}
        private int _LBEClass;
    	public int LBEClass 
    	{ 
    		get
    		{
    			return _LBEClass;
    		} 
    		set
    		{
    			if (_LBEClass != value)
    			{
    				_LBEClass = value;
    				OnPropertyChanged("LBEClass");
    			}
    		}
    	}
        private int _lbeCombo;
    	public int lbeCombo 
    	{ 
    		get
    		{
    			return _lbeCombo;
    		} 
    		set
    		{
    			if (_lbeCombo != value)
    			{
    				_lbeCombo = value;
    				OnPropertyChanged("lbeCombo");
    			}
    		}
    	}
        private int _lbeFilledSize;
    	public int lbeFilledSize 
    	{ 
    		get
    		{
    			return _lbeFilledSize;
    		} 
    		set
    		{
    			if (_lbeFilledSize != value)
    			{
    				_lbeFilledSize = value;
    				OnPropertyChanged("lbeFilledSize");
    			}
    		}
    	}
        private int _lbeAvailableVolume;
    	public int lbeAvailableVolume 
    	{ 
    		get
    		{
    			return _lbeAvailableVolume;
    		} 
    		set
    		{
    			if (_lbeAvailableVolume != value)
    			{
    				_lbeAvailableVolume = value;
    				OnPropertyChanged("lbeAvailableVolume");
    			}
    		}
    	}
        private int _lbePocketsAvailable;
    	public int lbePocketsAvailable 
    	{ 
    		get
    		{
    			return _lbePocketsAvailable;
    		} 
    		set
    		{
    			if (_lbePocketsAvailable != value)
    			{
    				_lbePocketsAvailable = value;
    				OnPropertyChanged("lbePocketsAvailable");
    			}
    		}
    	}
        private int _lbePocketIndex1;
    	public int lbePocketIndex1 
    	{ 
    		get
    		{
    			return _lbePocketIndex1;
    		} 
    		set
    		{
    			if (_lbePocketIndex1 != value)
    			{
    				_lbePocketIndex1 = value;
    				OnPropertyChanged("lbePocketIndex1");
    			}
    		}
    	}
        private int _lbePocketIndex2;
    	public int lbePocketIndex2 
    	{ 
    		get
    		{
    			return _lbePocketIndex2;
    		} 
    		set
    		{
    			if (_lbePocketIndex2 != value)
    			{
    				_lbePocketIndex2 = value;
    				OnPropertyChanged("lbePocketIndex2");
    			}
    		}
    	}
        private int _lbePocketIndex3;
    	public int lbePocketIndex3 
    	{ 
    		get
    		{
    			return _lbePocketIndex3;
    		} 
    		set
    		{
    			if (_lbePocketIndex3 != value)
    			{
    				_lbePocketIndex3 = value;
    				OnPropertyChanged("lbePocketIndex3");
    			}
    		}
    	}
        private int _lbePocketIndex4;
    	public int lbePocketIndex4 
    	{ 
    		get
    		{
    			return _lbePocketIndex4;
    		} 
    		set
    		{
    			if (_lbePocketIndex4 != value)
    			{
    				_lbePocketIndex4 = value;
    				OnPropertyChanged("lbePocketIndex4");
    			}
    		}
    	}
        private int _lbePocketIndex5;
    	public int lbePocketIndex5 
    	{ 
    		get
    		{
    			return _lbePocketIndex5;
    		} 
    		set
    		{
    			if (_lbePocketIndex5 != value)
    			{
    				_lbePocketIndex5 = value;
    				OnPropertyChanged("lbePocketIndex5");
    			}
    		}
    	}
        private int _lbePocketIndex6;
    	public int lbePocketIndex6 
    	{ 
    		get
    		{
    			return _lbePocketIndex6;
    		} 
    		set
    		{
    			if (_lbePocketIndex6 != value)
    			{
    				_lbePocketIndex6 = value;
    				OnPropertyChanged("lbePocketIndex6");
    			}
    		}
    	}
        private int _lbePocketIndex7;
    	public int lbePocketIndex7 
    	{ 
    		get
    		{
    			return _lbePocketIndex7;
    		} 
    		set
    		{
    			if (_lbePocketIndex7 != value)
    			{
    				_lbePocketIndex7 = value;
    				OnPropertyChanged("lbePocketIndex7");
    			}
    		}
    	}
        private int _lbePocketIndex8;
    	public int lbePocketIndex8 
    	{ 
    		get
    		{
    			return _lbePocketIndex8;
    		} 
    		set
    		{
    			if (_lbePocketIndex8 != value)
    			{
    				_lbePocketIndex8 = value;
    				OnPropertyChanged("lbePocketIndex8");
    			}
    		}
    	}
        private int _lbePocketIndex9;
    	public int lbePocketIndex9 
    	{ 
    		get
    		{
    			return _lbePocketIndex9;
    		} 
    		set
    		{
    			if (_lbePocketIndex9 != value)
    			{
    				_lbePocketIndex9 = value;
    				OnPropertyChanged("lbePocketIndex9");
    			}
    		}
    	}
        private int _lbePocketIndex10;
    	public int lbePocketIndex10 
    	{ 
    		get
    		{
    			return _lbePocketIndex10;
    		} 
    		set
    		{
    			if (_lbePocketIndex10 != value)
    			{
    				_lbePocketIndex10 = value;
    				OnPropertyChanged("lbePocketIndex10");
    			}
    		}
    	}
        private int _lbePocketIndex11;
    	public int lbePocketIndex11 
    	{ 
    		get
    		{
    			return _lbePocketIndex11;
    		} 
    		set
    		{
    			if (_lbePocketIndex11 != value)
    			{
    				_lbePocketIndex11 = value;
    				OnPropertyChanged("lbePocketIndex11");
    			}
    		}
    	}
        private int _lbePocketIndex12;
    	public int lbePocketIndex12 
    	{ 
    		get
    		{
    			return _lbePocketIndex12;
    		} 
    		set
    		{
    			if (_lbePocketIndex12 != value)
    			{
    				_lbePocketIndex12 = value;
    				OnPropertyChanged("lbePocketIndex12");
    			}
    		}
    	}
    
        private ITEM _ITEM;
            public virtual ITEM ITEM
            {
                get { return _ITEM; }
                set
                { if(_ITEM != value)
                    {    _ITEM = value;    OnPropertyChanged("ITEM");   }
                }
            } 
        private LBEClass _LBEClass1;
            public virtual LBEClass LBEClass1
            {
                get { return _LBEClass1; }
                set
                { if(_LBEClass1 != value)
                    {    _LBEClass1 = value;    OnPropertyChanged("LBEClass1");   }
                }
            } 
    }
}
