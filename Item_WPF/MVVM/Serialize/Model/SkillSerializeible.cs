﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Xml.Linq;
using System.IO;
using Item_WPF.ItemEntityModel;
using System.Windows;

namespace Item_WPF.MVVM.Serialize.Model
{
    public class SkillSerializeible
    {
        private item1Entities _context;
        public ObservableCollection<GurpsSkill> CollectionCategiry = new ObservableCollection<GurpsSkill>();
        public ObservableCollection<SkillXMLModel> OutstringCollection = new ObservableCollection<SkillXMLModel>();
        public ObservableCollection<GurpsSkillCategory> gurpsSkillCategories = new ObservableCollection<GurpsSkillCategory>();
        public ObservableCollection<string> retcompare;

        public SkillSerializeible(string xmlString, string writePath)
        {
            _context = new item1Entities();
            retcompare = new ObservableCollection<string>();

            int contextAdded = 1;
            XDocument xdoc = XDocument.Load(xmlString);

            #region Read XML
            foreach (XElement skillElement in xdoc.Element("skill_list").Elements("skill"))
            {
                contextAdded += 1;
                SkillXMLModel qwerty = new SkillXMLModel();
                qwerty.numPP = contextAdded;
                qwerty.NameSkill = skillElement.Element("name");
                qwerty.Specialization = skillElement.Element("specialization");
                qwerty.tech_level = skillElement.Element("tech_level");
                qwerty.difficulty = skillElement.Element("difficulty");
                qwerty.Points = skillElement.Element("points");
                qwerty.Reference = skillElement.Element("reference");
                qwerty.version = skillElement.Attribute("version");
                qwerty.encumbrance_penalty_multiplier = skillElement.Element("encumbrance_penalty_multiplier");

                qwerty.notes = skillElement.Element("notes");

                #region  Default Collection
                qwerty.Default = new ObservableCollection<DefaultXML>();
                foreach (var itemdefault in skillElement.Elements("default"))
                {
                    DefaultXML def = new DefaultXML(itemdefault);
                    qwerty.Default.Add(def);
                }
                #endregion
                #region categories Collection
                qwerty.categories = new ObservableCollection<CategoriesXML>();
                foreach (var itemCategory in skillElement.Elements("categories").Elements("category"))
                {
                    CategoriesXML cat = new CategoriesXML(itemCategory);
                    qwerty.categories.Add(cat);
                }
                #endregion
                #region prereq_list
                qwerty.prereq_list = new ObservableCollection<Prereq_listXML>();

                if (qwerty.Specialization!=null)
                {
                    if (qwerty.Specialization.Value.ToString()=="Conducting")
                    {
                        
                    }
                }

                foreach (XElement itemprereq_list in skillElement.Elements("prereq_list"))
                {
                    Prereq_listXML prl = new Prereq_listXML(itemprereq_list, skillElement);
                    qwerty.prereq_list.Add(prl);
                }
                #endregion
                OutstringCollection.Add(qwerty);

                //qwerty.attribute_bonus =    new ObservableCollection<Attribute_bonusXML>(skillElement.Elements("attribute_bonus"));
                //qwerty.weapon_bonus =       new ObservableCollection<Weapon_bonusXML>   (skillElement.Elements("weapon_bonus"));
                //OutstringCollection.Add(qwerty);
                //contextAdded += 1;
            }

            #endregion

           // Console.WriteLine("Read XML is Complite\n reading {0} entities", contextAdded.ToString());
            //Console.ReadKey();

            contextAdded = 0;
          //  ObservableCollection<SkillXMLModel> qt = new ObservableCollection<SkillXMLModel>(OutstringCollection.Where(p => p.NameSkill.Value.ToString() == "Group Performance"));
        //    SkillXMLModel qm = qt.FirstOrDefault(p => p.Specialization.Value.ToString() == "Conducting");
                       foreach (SkillXMLModel item in OutstringCollection.OrderBy(p => p.numPP))
           // foreach (SkillXMLModel item in qt)
            {
                //if (item.Specialization.Value.ToString() == "Conducting")
              //  {
                    GurpsSkill SkillAstronomy = new GurpsSkill(item, _context, CollectionCategiry);
                _context.GurpsSkills.Add(SkillAstronomy);
               // }
            }
            

            _context.SaveChanges();
            MessageBox.Show("_context SaveChanges");
        }
        public void ToSqlFromCollString(ObservableCollection<DefaultSkill> ResultOrder, ObservableCollection<string> outSting)
        {
            foreach (var item in ResultOrder)
            {
                outSting.Add("INSERT INTO CharDB.       "
                    + item
                    + "' )GO"
                    );
            }
        }
        public void WriteToFile(string writePathin, ObservableCollection<string> resultin)
        {
            using (StreamWriter sw = new StreamWriter(writePathin, false, System.Text.Encoding.Default))
            {
                foreach (var article in resultin)
                {
                    Console.WriteLine("{0}", article);
                    sw.WriteLine(article);
                }
            }
        }
    }    
}
