using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Xml.Serialization;
using System.Collections.ObjectModel;

namespace Practicheskaya_7
{
    internal class Data
    {
        public static void SaveData()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Animals";
            sfd.Filter = "Text file(*.txt)|*.txt| Xml file(*.xml)|*.xml";
            if(sfd.ShowDialog() == true)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    foreach (Animals animals in CreateAnim.anim)
                        sw.WriteLine($"{animals.KindOfAnimals}-{animals.Name}-{animals.Age}-{animals.Gender}");
                MessageBox.Show("Сохранение прошло успешно");
            }
        }
    }
}
