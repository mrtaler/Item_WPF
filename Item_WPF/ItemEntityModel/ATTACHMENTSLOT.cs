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
    
    public partial class ATTACHMENTSLOT : System.ComponentModel.INotifyPropertyChanged
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
        public ATTACHMENTSLOT()
        {
            this.Attachmentmounts = new HashSet<Attachmentmount>();
            this.G_SubAttachClass = new HashSet<G_SubAttachClass>();
        }
    
        private int _uiSlotIndex;
    	public int uiSlotIndex 
    	{ 
    		get
    		{
    			return _uiSlotIndex;
    		} 
    		set
    		{
    			if (_uiSlotIndex != value)
    			{
    				_uiSlotIndex = value;
    				OnPropertyChanged("uiSlotIndex");
    			}
    		}
    	}
        private string _szSlotName;
    	public string szSlotName 
    	{ 
    		get
    		{
    			return _szSlotName;
    		} 
    		set
    		{
    			if (_szSlotName != value)
    			{
    				_szSlotName = value;
    				OnPropertyChanged("szSlotName");
    			}
    		}
    	}
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        private ICollection<Attachmentmount> _Attachmentmounts;
            public virtual ICollection<Attachmentmount> Attachmentmounts
            {
                get { return _Attachmentmounts; }
                set
                { if(_Attachmentmounts != value)
                    {    _Attachmentmounts = value;    OnPropertyChanged("Attachmentmounts");   }
                }
            } 
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        private ICollection<G_SubAttachClass> _G_SubAttachClass;
            public virtual ICollection<G_SubAttachClass> G_SubAttachClass
            {
                get { return _G_SubAttachClass; }
                set
                { if(_G_SubAttachClass != value)
                    {    _G_SubAttachClass = value;    OnPropertyChanged("G_SubAttachClass");   }
                }
            } 
    }
}