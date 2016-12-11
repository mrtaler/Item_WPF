﻿namespace Item_WPF.ItemEntityModel
{
    public partial class SkillBonusDb
    {
        public SkillBonusDb() { }
        public SkillBonusDb(skill_bonusXML item)
        {
            name = item.name.Value.ToString();
            namecompare = item.name.Attribute("compare") != null
                        ? item.name.Attribute("compare").Value.ToString() : null;
            specialization = item.specialization.ToString();
            specializationcompare = item.specialization.Attribute("compare") != null
                                    ? item.specialization.Attribute("compare").Value.ToString() : null;
            AmountValue = item.amount.Value.ToString();
            AmountPer_level = item.amount.Attribute("Per_level") != null
                            ? item.amount.Attribute("per_level").Value.ToString() : null;
        }
    }
}