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
    
    public partial class skill_bonusDB : System.ComponentModel.INotifyPropertyChanged
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
        private string _namecompare;
    	public string namecompare 
    	{ 
    		get
    		{
    			return _namecompare;
    		} 
    		set
    		{
    			if (_namecompare != value)
    			{
    				_namecompare = value;
    				OnPropertyChanged("namecompare");
    			}
    		}
    	}
        private string _specialization;
    	public string specialization 
    	{ 
    		get
    		{
    			return _specialization;
    		} 
    		set
    		{
    			if (_specialization != value)
    			{
    				_specialization = value;
    				OnPropertyChanged("specialization");
    			}
    		}
    	}
        private string _specializationcompare;
    	public string specializationcompare 
    	{ 
    		get
    		{
    			return _specializationcompare;
    		} 
    		set
    		{
    			if (_specializationcompare != value)
    			{
    				_specializationcompare = value;
    				OnPropertyChanged("specializationcompare");
    			}
    		}
    	}
        private string _AmountPer_level;
    	public string AmountPer_level 
    	{ 
    		get
    		{
    			return _AmountPer_level;
    		} 
    		set
    		{
    			if (_AmountPer_level != value)
    			{
    				_AmountPer_level = value;
    				OnPropertyChanged("AmountPer_level");
    			}
    		}
    	}
        private string _AmountValue;
    	public string AmountValue 
    	{ 
    		get
    		{
    			return _AmountValue;
    		} 
    		set
    		{
    			if (_AmountValue != value)
    			{
    				_AmountValue = value;
    				OnPropertyChanged("AmountValue");
    			}
    		}
    	}
        private Nullable<int> _FK_Adv;
    	public Nullable<int> FK_Adv 
    	{ 
    		get
    		{
    			return _FK_Adv;
    		} 
    		set
    		{
    			if (_FK_Adv != value)
    			{
    				_FK_Adv = value;
    				OnPropertyChanged("FK_Adv");
    			}
    		}
    	}
    
        private Advantage _Advantage;
            public virtual Advantage Advantage
            {
                get { return _Advantage; }
                set
                { if(_Advantage != value)
                    {    _Advantage = value;    OnPropertyChanged("Advantage");   }
                }
            } 
    }
}
