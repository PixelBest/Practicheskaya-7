using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practicheskaya_7
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateAnimals(object sender, RoutedEventArgs e)
        {
            CreateAnim.Create();
            dataGrid1.ItemsSource = CreateAnim.anim;
        }

        private void AddAnimals(object sender, RoutedEventArgs e)
        {
            AddAnim an = new AddAnim();
            an.Show();
        }

        private void SaveData(object sender, RoutedEventArgs e)
        {
            Data.SaveData();
        }
    }
}
