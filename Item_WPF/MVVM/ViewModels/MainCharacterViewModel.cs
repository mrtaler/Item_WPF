﻿using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Xml.Serialization;
using Item_WPF.addin;
using Item_WPF.MVVM.Models;
using Item_WPF.Properties;
using Item_WPF.MVVM.View;
using Microsoft.Win32;

namespace Item_WPF.MVVM.ViewModels
{
    class MainCharacterViewModel : ViewModelBase
    {
        protected Window Owner;
        private item1Entities _context;
        public CharacterDB Character { get; set; }

        public DelegateCommand AboutCommand { get; private set; }
        public DelegateCommand EditPrimaryStatsCommand { get; private set; }
        public DelegateCommand EditSecondaryStatsCommand { get; private set; }
        public DelegateCommand AddItemCommand { get; private set; }
        public DelegateCommand AddAdvantageCommand { get; private set; }
        public DelegateCommand AddSkillCommand { get; private set; }
        public DelegateCommand NewCommand { get; private set; }
        public DelegateCommand OpenCommand { get; private set; }

        public DelegateCommand OpenDBCommand { get; private set; }
        public DelegateCommand SaveAsCommand { get; private set; }
        public DelegateCommand OwnerCloseCommand { get; private set; }
        public MainCharacterViewModel(Window owner)
            : this(owner, new CharacterDB())
        {
        }

        public MainCharacterViewModel(Window owner, CharacterDB character)
        {
            Owner = owner;
            Character = character;

            // Create commands
            AboutCommand = new DelegateCommand(ShowAboutWindow);
            EditPrimaryStatsCommand = new DelegateCommand(EditPrimaryStats);
            EditSecondaryStatsCommand = new DelegateCommand(EditSecondaryStats);
            AddItemCommand = new DelegateCommand(AddItem);
            AddAdvantageCommand = new DelegateCommand(AddAdvantage);
            AddSkillCommand = new DelegateCommand(AddSkill);
            NewCommand = new DelegateCommand(New);
            OpenCommand = new DelegateCommand(Open);
            OpenDBCommand=new DelegateCommand(OpenDB);
            SaveAsCommand = new DelegateCommand(SaveAs);
            OwnerCloseCommand = new DelegateCommand(OwnerClose);

            // Setup property dependencies
            PropertyDependencyMap.Add("Strength", new[] { "MaxHP", "BasicLift", "ThrustDamage", "SwingDamage" });
            PropertyDependencyMap.Add("StrengthPoints", new[] { "Strength", "CharacterPoints" });
            PropertyDependencyMap.Add("Dexterity", new[] { "BasicSpeed" });
            PropertyDependencyMap.Add("DexterityPoints", new[] { "Dexterity", "CharacterPoints" });
            PropertyDependencyMap.Add("Intelligence", new[] { "Willpower", "Perception" });
            PropertyDependencyMap.Add("IntelligencePoints", new[] { "Intelligence", "CharacterPoints" });
            PropertyDependencyMap.Add("Health", new[] { "MaxFP", "BasicSpeed" });
            PropertyDependencyMap.Add("HealthPoints", new[] { "Health", "CharacterPoints" });
            PropertyDependencyMap.Add("MaxHPPoints", new[] { "MaxHP", "CharacterPoints" });
            PropertyDependencyMap.Add("MaxFPPoints", new[] { "MaxFP", "CharacterPoints" });
            PropertyDependencyMap.Add("WillpowerPoints", new[] { "Willpower", "CharacterPoints" });
            PropertyDependencyMap.Add("PerceptionPoints", new[] { "Perception", "CharacterPoints" });
            PropertyDependencyMap.Add("BasicSpeed", new[] { "BasicMove" });
            PropertyDependencyMap.Add("BasicSpeedPoints", new[] { "BasicSpeed", "CharacterPoints" });
            PropertyDependencyMap.Add("BasicMovePoints", new[] { "BasicMove", "CharacterPoints" });
            PropertyDependencyMap.Add("BasicLift", new[] { "Encumbrance" });
            PropertyDependencyMap.Add("Inventory", new[] { "Encumbrance" });
            PropertyDependencyMap.Add("Advantages", new[] { "CharacterPoints" });
            PropertyDependencyMap.Add("Skills", new[] { "CharacterPoints" });
            PropertyDependencyMap.Add("Encumbrance", new[] { "EncumbranceAsInt", "EncumbranceAsString", "Move", "Dodge" });
        }

        public string Name
        {
            get
            {
                string name = Character.Name;
                if (string.IsNullOrEmpty(name))
                    name = Properties.Resources.UnnamedCharacter;
                return name;
            }
        }
        public int Strength
        {
            get
            {
                return Character.Strength;
            }
        }
        public int Dexterity
        {
            get
            {
                return Character.Dexterity;
            }
        }
        public int Intelligence
        {
            get
            {
                return Character.Intelligence;
            }
        }
        public int Health
        {
            get
            {
                return Character.Health;
            }
        }
        public int MaxHP
        {
            get
            {
                return Character.MaxHP;
            }
        }
        public int MaxFP
        {
            get
            {
                return Character.MaxFP;
            }
        }
        public int Willpower
        {
            get
            {
                return Character.Willpower;
            }
        }
        public int Perception
        {
            get
            {
                return Character.Perception;
            }
        }
        public float BasicLift
        {
            get
            {
                return Character.BasicLift;
            }
        }
        public float BasicSpeed
        {
            get
            {
                return Character.BasicSpeed;
            }
        }
        public int BasicMove
        {
            get
            {
                return Character.BasicMove;
            }
        }
        public int Move
        {
            get
            {
                return Character.Move;
            }
        }
        public int Dodge
        {
            get
            {
                return Character.Dodge;
            }
        }
        public DiceString ThrustDamage
        {
            get
            {
                return Character.ThrustDamage;
            }
        }
        public DiceString SwingDamage
        {
            get
            {
                return Character.SwingDamage;
            }
        }

        public ObservableCollection<ITEM> Inventory
        {
            get
            {
                return Character.Inventory;
            }
        }
        public int TotalWeight
        {
            get
            {
                return Character.TotalWeight;
            }
        }

        public ObservableCollection<Advantage> Advantages
        {
            get
            {
                return Character.Advantages;
            }
        }

        public ObservableCollection<Skill> Skills
        {
            get
            {
                return Character.Skills;
            }
        }

        // Returns the window title
        public string Title
        {
            get
            {
                return "GURPS Character Editor - " + Name;
            }
        }

        public int CharacterPoints
        {
            get
            {
                return Character.CharacterPoints;
            }
        }
        public int? EncumbranceAsInt
        {
            get
            {
                return Character.Encumbrance;
            }
        }
        public string EncumbranceAsString
        {
            get
            {
                if (Character.Encumbrance.HasValue)
                {
                    switch ((int)Character.Encumbrance)
                    {
                        case 0:
                            return Resources.EncumbranceNo;
                        case 1:
                            return Resources.EncumbranceLight;
                        case 2:
                            return Resources.EncumbranceMedium;
                        case 3:
                            return Resources.EncumbranceHeavy;
                        case 4:
                            return Resources.EncumbranceExtraHeavy;
                        default:
                            return "N/A";
                    }
                }
                else
                {
                    return "N/A";
                }
            }
        }

        public void ShowAboutWindow(object parameter)
        {
            AboutWindowView window = new AboutWindowView();
            window.Owner = Owner;
            window.ShowDialog();
        }

        public void AddItem(object parameter)
        {
            all_ItemsView window = new all_ItemsView("all");
            window.Owner = Owner;
            //window.DataContext = new ITEM();

            bool? result = window.ShowDialog();
            if (result.HasValue && (result == true))
            {
                Character.Inventory.Add((ITEM)window._allItemsViewModel.SelectedItemForWork);

                NotifyPropertyChanged("Inventory");
            }
        }

        public void AddAdvantage(object parameter)
        {
            EditAdvantageWindowView window = new EditAdvantageWindowView();
            window.Owner = Owner;
            window.DataContext = new Advantage();

            bool? result = window.ShowDialog();
            if (result.HasValue && (result == true))
            {
                Character.Advantages.Add((Advantage)window.DataContext);

                NotifyPropertyChanged("Advantages");
            }
        }

        public void AddSkill(object parameter)
        {
            EditSkillWindowView window = new EditSkillWindowView();
            window.Owner = Owner;
            window.DataContext = new Skill();

            bool? result = window.ShowDialog();
            if (result.HasValue && (result == true))
            {
                Character.Skills.Add((Skill)window.DataContext);

                NotifyPropertyChanged("Skills");
            }
        }

        public void EditPrimaryStats(object parameter)
        {
            EditPrimaryStatsWindowView window = new EditPrimaryStatsWindowView();
            window.Owner = Owner;
            window.DataContext = new EditPrimaryStatsViewModel(Character);

            CharacterDB copy = (CharacterDB)Character.Copy();
            bool? result = window.ShowDialog();
            if (result.HasValue && (result == true))
            {
                NotifyPropertyChanged("StrengthPoints");
                NotifyPropertyChanged("DexterityPoints");
                NotifyPropertyChanged("IntelligencePoints");
                NotifyPropertyChanged("HealthPoints");
            }
            else
            {
                Character = copy;
            }
        }

        public void EditSecondaryStats(object parameter)
        {
            EditSecondaryStatsWindowView window = new EditSecondaryStatsWindowView();
            window.Owner = Owner;
            window.DataContext = new EditSecondaryStatsViewModel(Character);

            CharacterDB copy = (CharacterDB)Character.Copy();
            bool? result = window.ShowDialog();
            if (result.HasValue && (result == true))
            {
                NotifyPropertyChanged("MaxHPPoints");
                NotifyPropertyChanged("MaxFPPoints");
                NotifyPropertyChanged("WillpowerPoints");
                NotifyPropertyChanged("PerceptionPoints");
                NotifyPropertyChanged("BasicSpeedPoints");
                NotifyPropertyChanged("BasicMovePoints");
            }
            else
            {
                Character = copy;
            }
        }

        public void New(object parameter)
        {
            Character = new CharacterDB();

            // Notify all properties changed
            NotifyPropertyChanged(string.Empty);
        }
        public void OpenDB(object parameter)
        {
            AllCharfromDBView dialog = new AllCharfromDBView();
            dialog.DataContext = _context.CharacterDBs;

        }
        public void Open(object parameter)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt = ".gurps";
            dialog.CheckFileExists = true;
            dialog.Filter = "GURPS files|*.gurps";
            bool? result = dialog.ShowDialog();
            if (result.HasValue && (result == true))
            {
                // Deserialize the file
                FileStream stream = File.OpenRead(dialog.FileName);
                XmlSerializer serializer = new XmlSerializer(Character.GetType());
                try
                {
                    Character = (CharacterDB)serializer.Deserialize(stream);
                }
                catch (InvalidOperationException)
                {
                    System.Windows.MessageBox.Show(Resources.DialogLoadFailed);
                }
                stream.Close();

                // Notify all properties changed
                NotifyPropertyChanged(string.Empty);
            }
        }

        public void SaveAs(object parameter)
        {
            SaveFileDialog dialog = new SaveFileDialog(); ;
            dialog.DefaultExt = ".gurps";
            dialog.OverwritePrompt = true;
            dialog.CheckPathExists = true;
            dialog.Filter = "GURPS files|*.gurps";
            bool? result = dialog.ShowDialog();
            if (result.HasValue && (result == true))
            {
                // Serialize the models
                FileStream stream = File.OpenWrite(dialog.FileName);
                XmlSerializer serializer = new XmlSerializer(Character.GetType());
                serializer.Serialize(stream, Character);
                stream.Close();
            }
        }
        public void OwnerClose(object parameter)
        {
            Owner.Close();
        }
    }
}
