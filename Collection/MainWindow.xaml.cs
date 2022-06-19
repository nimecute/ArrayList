using System;
using System.Collections;
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

namespace Collection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList Text;
        public MainWindow()
        {
            InitializeComponent();
            Text = new ArrayList();
        }

        private void ShowAll(object sender, RoutedEventArgs e)
        {if (Text.Count <= 0)
            {
                MessageBox.Show("no information found");
            }
            else
            {
                foreach (String Date in Text)
                {
                    MessageBox.Show(Date);
                }
            }
        }

        private void Add(object sender, RoutedEventArgs e)
        { if (TEXTBOX.Text.Equals(""))
            {
                MessageBox.Show("Please enter information");
            }
        else
            {
                Text.Add ((TEXTBOX.Text));
                MessageBox.Show("Add Succeed");
                TEXTBOX.Clear();
            }
        }

        private void Remove (object sender, RoutedEventArgs e)
        {
            Text.Remove(TEXTBOX.Text);
            MessageBox.Show("Remove Success");
            Text.Clear();
        }
    }
}
