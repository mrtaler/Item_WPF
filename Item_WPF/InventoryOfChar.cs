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
    
    public partial class InventoryOfChar : System.ComponentModel.INotifyPropertyChanged
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
        private int _IdCharacter;
    	public int IdCharacter 
    	{ 
    		get
    		{
    			return _IdCharacter;
    		} 
    		set
    		{
    			if (_IdCharacter != value)
    			{
    				_IdCharacter = value;
    				OnPropertyChanged("IdCharacter");
    			}
    		}
    	}
        private int _IdItem;
    	public int IdItem 
    	{ 
    		get
    		{
    			return _IdItem;
    		} 
    		set
    		{
    			if (_IdItem != value)
    			{
    				_IdItem = value;
    				OnPropertyChanged("IdItem");
    			}
    		}
    	}
        private long _Count;
    	public long Count 
    	{ 
    		get
    		{
    			return _Count;
    		} 
    		set
    		{
    			if (_Count != value)
    			{
    				_Count = value;
    				OnPropertyChanged("Count");
    			}
    		}
    	}
    
        private CharacterDB _CharacterDB;
            public virtual CharacterDB CharacterDB
            {
                get { return _CharacterDB; }
                set
                { if(_CharacterDB != value)
                    {    _CharacterDB = value;    OnPropertyChanged("CharacterDB");   }
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
    }
}