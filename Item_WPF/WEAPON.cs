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
    
    public partial class WEAPON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WEAPON()
        {
            this.AvailableAttachSlots = new HashSet<AvailableAttachSlot>();
        }
    
        public int uiIndex { get; set; }
        public string szWeaponName { get; set; }
        public int ubWeaponClass { get; set; }
        public int ubWeaponType { get; set; }
        public int ubCalibre { get; set; }
        public string Damage { get; set; }
        public int ubTypeOfDamage { get; set; }
        public int DefACC { get; set; }
        public decimal Half_Range { get; set; }
        public decimal FullRange { get; set; }
        public decimal MinRange { get; set; }
        public decimal AWeight { get; set; }
        public decimal Arm_Division { get; set; }
        public int ROF { get; set; }
        public bool Full_auto { get; set; }
        public int ROF_for_Sh { get; set; }
        public int Shots { get; set; }
        public int Time_For_reload { get; set; }
        public bool single_reload { get; set; }
        public bool Mount { get; set; }
        public int Recoil { get; set; }
        public string Linked { get; set; }
        public string Follow_Up { get; set; }
        public bool HeavyWeapon { get; set; }
        public bool Add_in_Chamber { get; set; }
        public bool CutOff_shots { get; set; }
        public int CutOff_shotsCount { get; set; }
        public bool GrenadeLauncher { get; set; }
        public bool RocketLauncher { get; set; }
        public bool Mortar { get; set; }
        public bool Cannon { get; set; }
        public bool SingleShot_RocketLauncher { get; set; }
        public bool RocketRifle { get; set; }
        public bool Bulkfolded { get; set; }
    
        public virtual AMMO AMMO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AvailableAttachSlot> AvailableAttachSlots { get; set; }
        public virtual TypeOfDamage TypeOfDamage { get; set; }
        public virtual WeaponType WeaponType { get; set; }
    }
}
