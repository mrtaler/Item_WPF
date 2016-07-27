﻿using Item_WPF.addin;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_WPF.MVVM.GurpsSkill
{
    public class AllGurpsSkillViewModel : ViewModelBase
    {
        private item1Entities _context;
        public ObservableCollection<Item_WPF.GurpsSkill> AllGurpsSkillforTree
        {
            get { return new ObservableCollection<Item_WPF.GurpsSkill>(_context.GurpsSkills.Where(p => p.idSpecialization == null)); }
        }
        public ViewModelCommand SelectedItemChangedCommand { get; set; }
        public Item_WPF.GurpsSkill SelectedGurps { get; set; }
        public GurpsSkillModel SelectedGurpsForWork { get; private set; }


        public AllGurpsSkillViewModel()
        {
            _context = new item1Entities();
            SelectedItemChangedCommand = new ViewModelCommand(SelectedItemChanged, true);
            SelectedGurpsForWork = new GurpsSkillModel();
            SelectedGurps = new Item_WPF.GurpsSkill();
        }
        private void SelectedItemChanged(object parameter)
        {
            Item_WPF.GurpsSkill SelectGurpsSkill = (parameter as Item_WPF.GurpsSkill);
            int vx = SelectGurpsSkill.id;
            //int vx = System.Convert.ToInt32(parameter);

            //SelectedGurpsForWork =_context.GurpsSkills.Find(vx);
            // SelectedGurpsForWork = (parameter as Item_WPF.GurpsSkill);

            if (_context.GurpsSkills.Find(vx).idSpecialization == null)
            {
                SelectedGurpsForWork.NameSkill = SelectGurpsSkill.NameSkill;
            }
            else
            if (_context.GurpsSkills.Find(vx).idSpecialization != null)
            {
                SelectedGurpsForWork.NameSkill = "name: " +
                    _context.GurpsSkills.Find(_context.GurpsSkills.Find(vx).idSpecialization).NameSkill
                    + "/"
                    + _context.GurpsSkills.Find(vx).NameSkill;
                SelectedGurpsForWork.SkillDifficulty =
                    _context.GurpsSkills.Find(_context.GurpsSkills.Find(vx).idSpecialization).SkillDifficulty.Attribute.Name
                    + "/" +
                    _context.GurpsSkills.Find(_context.GurpsSkills.Find(vx).idSpecialization).SkillDifficulty.Difficulty.Name;
            }
            NotifyPropertyChanged("SelectedGurpsForWork");

        }

    }
}
