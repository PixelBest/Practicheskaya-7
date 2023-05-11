using Practicheskaya_7.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Practicheskaya_7.View
{
    /// <summary>
    /// Логика взаимодействия для AnimalTable.xaml
    /// </summary>
    public partial class AnimalTable : Window
    {
        public AnimalTable()
        {
            InitializeComponent();
            DataContext = new AnimalsViewModel();
        }

        private void SaveData(object sender, RoutedEventArgs e)
        {
            Data.SaveData();
        }
    }
}
