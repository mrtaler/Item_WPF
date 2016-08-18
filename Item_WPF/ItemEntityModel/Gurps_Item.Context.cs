﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class item1Entities : DbContext
    {
        public item1Entities()
            : base("name=item1Entities")
        {
    
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Advantage> Advantages { get; set; }
        public virtual DbSet<Attribute> Attributes { get; set; }
        public virtual DbSet<CharacterDB> CharacterDBs { get; set; }
        public virtual DbSet<DifficultySkill> DifficultySkills { get; set; }
        public virtual DbSet<GurpsAdvCategory> GurpsAdvCategories { get; set; }
        public virtual DbSet<GurpsSkill> GurpsSkills { get; set; }
        public virtual DbSet<GurpsSkillCategory> GurpsSkillCategories { get; set; }
        public virtual DbSet<InventoryOfChar> InventoryOfChars { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<TypeAdv> TypeAdvs { get; set; }
        public virtual DbSet<AMMOUPGRATE> AMMOUPGRATES { get; set; }
        public virtual DbSet<AnyBoxNameType> AnyBoxNameTypes { get; set; }
        public virtual DbSet<ARMOUR> ARMOURs { get; set; }
        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<Attachmentmount> Attachmentmounts { get; set; }
        public virtual DbSet<ATTACHMENTSLOT> ATTACHMENTSLOTs { get; set; }
        public virtual DbSet<AvailableAttachSlot> AvailableAttachSlots { get; set; }
        public virtual DbSet<Battery> Batteries { get; set; }
        public virtual DbSet<BoxItem> BoxItems { get; set; }
        public virtual DbSet<Caliber> Calibers { get; set; }
        public virtual DbSet<Cloth> Clothes { get; set; }
        public virtual DbSet<CombineWeap> CombineWeaps { get; set; }
        public virtual DbSet<Drug> Drugs { get; set; }
        public virtual DbSet<EXPLOSIVE> EXPLOSIVEs { get; set; }
        public virtual DbSet<FOOD> FOODs { get; set; }
        public virtual DbSet<G_AttachClass> G_AttachClass { get; set; }
        public virtual DbSet<G_AvAttachClass> G_AvAttachClass { get; set; }
        public virtual DbSet<G_SubAttachClass> G_SubAttachClass { get; set; }
        public virtual DbSet<GurpsClass> GurpsClasses { get; set; }
        public virtual DbSet<ITEM> ITEMs { get; set; }
        public virtual DbSet<ItemClass> ItemClasses { get; set; }
        public virtual DbSet<ItemSubClass> ItemSubClasses { get; set; }
        public virtual DbSet<LaserColorEf> LaserColorEfs { get; set; }
        public virtual DbSet<LC> LCs { get; set; }
        public virtual DbSet<LOADBEARINGEQUIPMENT> LOADBEARINGEQUIPMENTs { get; set; }
        public virtual DbSet<TL> TLs { get; set; }
        public virtual DbSet<Type_of_Box> Type_of_Box { get; set; }
        public virtual DbSet<TypeOfDamage> TypeOfDamages { get; set; }
        public virtual DbSet<WEAPON> WEAPONs { get; set; }
        public virtual DbSet<WeaponAttackType> WeaponAttackTypes { get; set; }
        public virtual DbSet<WeaponDamage> WeaponDamages { get; set; }
        public virtual DbSet<advantage_prereq> advantage_prereq { get; set; }
        public virtual DbSet<amount> amounts { get; set; }
        public virtual DbSet<attribute_prereq> attribute_prereq { get; set; }
        public virtual DbSet<categories1> categories1 { get; set; }
        public virtual DbSet<category1> category1 { get; set; }
        public virtual DbSet<default1> default1 { get; set; }
        public virtual DbSet<level> levels { get; set; }
        public virtual DbSet<name1> name1 { get; set; }
        public virtual DbSet<note> notes { get; set; }
        public virtual DbSet<prereq_list1> prereq_list1 { get; set; }
        public virtual DbSet<skill1> skill1 { get; set; }
        public virtual DbSet<skill_container> skill_container { get; set; }
        public virtual DbSet<skill_list> skill_list { get; set; }
        public virtual DbSet<skill_prereq> skill_prereq { get; set; }
        public virtual DbSet<specialization1> specialization1 { get; set; }
        public virtual DbSet<technique> techniques { get; set; }
        public virtual DbSet<weapon_bonus> weapon_bonus { get; set; }
        public virtual DbSet<when_tl> when_tl { get; set; }
        public virtual DbSet<AdvantageMod> AdvantageMods { get; set; }
        public virtual DbSet<AttributeBonu> AttributeBonus { get; set; }
        public virtual DbSet<DefaultSkill> DefaultSkills { get; set; }
        public virtual DbSet<NeedSkill> NeedSkills { get; set; }
        public virtual DbSet<SkillBonu> SkillBonus { get; set; }
    
        public virtual int NEW_ITEM_att(string name, Nullable<int> g_att_class, Nullable<int> g_sub_att, string id_att_mount)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var g_att_classParameter = g_att_class.HasValue ?
                new ObjectParameter("G_att_class", g_att_class) :
                new ObjectParameter("G_att_class", typeof(int));
    
            var g_sub_attParameter = g_sub_att.HasValue ?
                new ObjectParameter("G_sub_att", g_sub_att) :
                new ObjectParameter("G_sub_att", typeof(int));
    
            var id_att_mountParameter = id_att_mount != null ?
                new ObjectParameter("id_att_mount", id_att_mount) :
                new ObjectParameter("id_att_mount", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("NEW_ITEM_att", nameParameter, g_att_classParameter, g_sub_attParameter, id_att_mountParameter);
        }
    
        public virtual int NEW_ITEM(string name, string class_ofItem, ObjectParameter returns)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var class_ofItemParameter = class_ofItem != null ?
                new ObjectParameter("class_ofItem", class_ofItem) :
                new ObjectParameter("class_ofItem", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("NEW_ITEM", nameParameter, class_ofItemParameter, returns);
        }
    
        public virtual int NEW_ITEMWeap(string name, string class_ofItem, Nullable<decimal> weight, Nullable<int> sT, string bulk, Nullable<decimal> cost, string lcin, string tLin, string desc, Nullable<bool> twoHanded, string weaponClass, string weaponType, Nullable<bool> full_auto, Nullable<int> aCCAddin, Nullable<int> rOF_for_Sh, Nullable<int> rOF, Nullable<int> recoill, Nullable<int> defACCc, Nullable<int> half_Rangee, Nullable<int> fullRangee, string damagee, Nullable<int> shotss, Nullable<bool> addinChamber, Nullable<int> timeForreload, Nullable<bool> singlereload, string damage, Nullable<decimal> armorDivision, string typeOfDamage1, string typeOfDamage2, string typeOfDam1, string typeOfDam2, ObjectParameter returns)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var class_ofItemParameter = class_ofItem != null ?
                new ObjectParameter("class_ofItem", class_ofItem) :
                new ObjectParameter("class_ofItem", typeof(string));
    
            var weightParameter = weight.HasValue ?
                new ObjectParameter("Weight", weight) :
                new ObjectParameter("Weight", typeof(decimal));
    
            var sTParameter = sT.HasValue ?
                new ObjectParameter("ST", sT) :
                new ObjectParameter("ST", typeof(int));
    
            var bulkParameter = bulk != null ?
                new ObjectParameter("Bulk", bulk) :
                new ObjectParameter("Bulk", typeof(string));
    
            var costParameter = cost.HasValue ?
                new ObjectParameter("Cost", cost) :
                new ObjectParameter("Cost", typeof(decimal));
    
            var lcinParameter = lcin != null ?
                new ObjectParameter("Lcin", lcin) :
                new ObjectParameter("Lcin", typeof(string));
    
            var tLinParameter = tLin != null ?
                new ObjectParameter("TLin", tLin) :
                new ObjectParameter("TLin", typeof(string));
    
            var descParameter = desc != null ?
                new ObjectParameter("Desc", desc) :
                new ObjectParameter("Desc", typeof(string));
    
            var twoHandedParameter = twoHanded.HasValue ?
                new ObjectParameter("TwoHanded", twoHanded) :
                new ObjectParameter("TwoHanded", typeof(bool));
    
            var weaponClassParameter = weaponClass != null ?
                new ObjectParameter("WeaponClass", weaponClass) :
                new ObjectParameter("WeaponClass", typeof(string));
    
            var weaponTypeParameter = weaponType != null ?
                new ObjectParameter("WeaponType", weaponType) :
                new ObjectParameter("WeaponType", typeof(string));
    
            var full_autoParameter = full_auto.HasValue ?
                new ObjectParameter("Full_auto", full_auto) :
                new ObjectParameter("Full_auto", typeof(bool));
    
            var aCCAddinParameter = aCCAddin.HasValue ?
                new ObjectParameter("ACCAddin", aCCAddin) :
                new ObjectParameter("ACCAddin", typeof(int));
    
            var rOF_for_ShParameter = rOF_for_Sh.HasValue ?
                new ObjectParameter("ROF_for_Sh", rOF_for_Sh) :
                new ObjectParameter("ROF_for_Sh", typeof(int));
    
            var rOFParameter = rOF.HasValue ?
                new ObjectParameter("ROF", rOF) :
                new ObjectParameter("ROF", typeof(int));
    
            var recoillParameter = recoill.HasValue ?
                new ObjectParameter("Recoill", recoill) :
                new ObjectParameter("Recoill", typeof(int));
    
            var defACCcParameter = defACCc.HasValue ?
                new ObjectParameter("DefACCc", defACCc) :
                new ObjectParameter("DefACCc", typeof(int));
    
            var half_RangeeParameter = half_Rangee.HasValue ?
                new ObjectParameter("Half_Rangee", half_Rangee) :
                new ObjectParameter("Half_Rangee", typeof(int));
    
            var fullRangeeParameter = fullRangee.HasValue ?
                new ObjectParameter("FullRangee", fullRangee) :
                new ObjectParameter("FullRangee", typeof(int));
    
            var damageeParameter = damagee != null ?
                new ObjectParameter("Damagee", damagee) :
                new ObjectParameter("Damagee", typeof(string));
    
            var shotssParameter = shotss.HasValue ?
                new ObjectParameter("Shotss", shotss) :
                new ObjectParameter("Shotss", typeof(int));
    
            var addinChamberParameter = addinChamber.HasValue ?
                new ObjectParameter("AddinChamber", addinChamber) :
                new ObjectParameter("AddinChamber", typeof(bool));
    
            var timeForreloadParameter = timeForreload.HasValue ?
                new ObjectParameter("TimeForreload", timeForreload) :
                new ObjectParameter("TimeForreload", typeof(int));
    
            var singlereloadParameter = singlereload.HasValue ?
                new ObjectParameter("singlereload", singlereload) :
                new ObjectParameter("singlereload", typeof(bool));
    
            var damageParameter = damage != null ?
                new ObjectParameter("Damage", damage) :
                new ObjectParameter("Damage", typeof(string));
    
            var armorDivisionParameter = armorDivision.HasValue ?
                new ObjectParameter("ArmorDivision", armorDivision) :
                new ObjectParameter("ArmorDivision", typeof(decimal));
    
            var typeOfDamage1Parameter = typeOfDamage1 != null ?
                new ObjectParameter("TypeOfDamage1", typeOfDamage1) :
                new ObjectParameter("TypeOfDamage1", typeof(string));
    
            var typeOfDamage2Parameter = typeOfDamage2 != null ?
                new ObjectParameter("TypeOfDamage2", typeOfDamage2) :
                new ObjectParameter("TypeOfDamage2", typeof(string));
    
            var typeOfDam1Parameter = typeOfDam1 != null ?
                new ObjectParameter("TypeOfDam1", typeOfDam1) :
                new ObjectParameter("TypeOfDam1", typeof(string));
    
            var typeOfDam2Parameter = typeOfDam2 != null ?
                new ObjectParameter("TypeOfDam2", typeOfDam2) :
                new ObjectParameter("TypeOfDam2", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("NEW_ITEMWeap", nameParameter, class_ofItemParameter, weightParameter, sTParameter, bulkParameter, costParameter, lcinParameter, tLinParameter, descParameter, twoHandedParameter, weaponClassParameter, weaponTypeParameter, full_autoParameter, aCCAddinParameter, rOF_for_ShParameter, rOFParameter, recoillParameter, defACCcParameter, half_RangeeParameter, fullRangeeParameter, damageeParameter, shotssParameter, addinChamberParameter, timeForreloadParameter, singlereloadParameter, damageParameter, armorDivisionParameter, typeOfDamage1Parameter, typeOfDamage2Parameter, typeOfDam1Parameter, typeOfDam2Parameter, returns);
        }
    
        public virtual int NEW_ITEM_Ammo(string name, Nullable<decimal> weigth, Nullable<decimal> price, string sClass)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var weigthParameter = weigth.HasValue ?
                new ObjectParameter("weigth", weigth) :
                new ObjectParameter("weigth", typeof(decimal));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(decimal));
    
            var sClassParameter = sClass != null ?
                new ObjectParameter("sClass", sClass) :
                new ObjectParameter("sClass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("NEW_ITEM_Ammo", nameParameter, weigthParameter, priceParameter, sClassParameter);
        }
    }
}
