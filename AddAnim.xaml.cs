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

namespace Practicheskaya_7
{
    /// <summary>
    /// Логика взаимодействия для AddAnim.xaml
    /// </summary>
    public partial class AddAnim : Window
    {
        public AddAnim()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateAnim.Add(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), textBox4.Text);
            this.Close();
        }
    }
}
