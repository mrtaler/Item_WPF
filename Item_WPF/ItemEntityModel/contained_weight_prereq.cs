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
    
    public partial class contained_weight_prereq : System.ComponentModel.INotifyPropertyChanged
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
        private string _has;
    	public string has 
    	{ 
    		get
    		{
    			return _has;
    		} 
    		set
    		{
    			if (_has != value)
    			{
    				_has = value;
    				OnPropertyChanged("has");
    			}
    		}
    	}
        private string _compare;
    	public string compare 
    	{ 
    		get
    		{
    			return _compare;
    		} 
    		set
    		{
    			if (_compare != value)
    			{
    				_compare = value;
    				OnPropertyChanged("compare");
    			}
    		}
    	}
        private string _Value;
    	public string Value 
    	{ 
    		get
    		{
    			return _Value;
    		} 
    		set
    		{
    			if (_Value != value)
    			{
    				_Value = value;
    				OnPropertyChanged("Value");
    			}
    		}
    	}
        private Nullable<int> _idPrqList;
    	public Nullable<int> idPrqList 
    	{ 
    		get
    		{
    			return _idPrqList;
    		} 
    		set
    		{
    			if (_idPrqList != value)
    			{
    				_idPrqList = value;
    				OnPropertyChanged("idPrqList");
    			}
    		}
    	}
    
        private prereq_listDB _prereq_listDB;
            public virtual prereq_listDB prereq_listDB
            {
                get { return _prereq_listDB; }
                set
                { if(_prereq_listDB != value)
                    {    _prereq_listDB = value;    OnPropertyChanged("prereq_listDB");   }
                }
            } 
    }
}
