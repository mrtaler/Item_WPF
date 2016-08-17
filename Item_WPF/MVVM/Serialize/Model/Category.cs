﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Collections.ObjectModel;
using System.IO;

namespace Item_WPF.MVVM.Serialize

{
    public class Category
    {
       public ObservableCollection<string> CollectionCategiry = new ObservableCollection<string>();
       public ObservableCollection<string> ResultOrder;
       /// <summary>
        /// Получение в файл категорий
        /// </summary>
        /// <param name="xdoc">извлёчённый документ</param>
        /// <param name="writePath">файл для записи результата</param>
        public Category(string xmlString, string writePath)
        {
            XDocument xdoc = XDocument.Load(xmlString);
            foreach (XElement skillElement in xdoc.Element("skill_list").Elements("skill").Elements("categories").Elements("category"))
            {
                string cat = skillElement != null ? skillElement.Value.ToString() : "0";
                CollectionCategiry.Add(cat);
            }
            ResultOrder = new ObservableCollection<string>(CollectionCategiry.Distinct().OrderBy(i => i));
        }
        public void ToSqlFromCollString(ObservableCollection<string> outSting)
        {
            foreach (var item in ResultOrder)
            {
                outSting.Add("INSERT INTO CharDB.GurpsSkillCategory(  NamelCategory) VALUES(N'"
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
