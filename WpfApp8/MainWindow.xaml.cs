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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            Parsing parsing = new Parsing();
            if (e.Key == Key.Enter)
            {
                ListName.Items.Clear();
                parsing.getSite(NameSound.Text);
                List<string> result = parsing.generationList();
                foreach (string x in result)
                {
                    ListName.Items.Add(x);
                }
            }
            
                //MessageBox.Show(parsing.getSite(NameSound.Text));
        }
    }
}
