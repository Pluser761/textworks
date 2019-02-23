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

namespace TextWorks
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

        private void button_exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void button_clear_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            listBox_1.Items.Clear();
            listBox_2.Items.Clear();
        }

        private void button_read_Click(object sender, RoutedEventArgs e)
        {
            int n = comboBox.SelectedIndex;
            switch (n)
            {
                case 0:
                    int l = listBox_1.Items.Count;
                    listBox_1.Items.Add(listBox_1.Items + "");
                    for (int i = l - 1; i >= 0; i--)
                    {
                        listBox_1.Items[i + 1] = listBox_1.Items[i];
                    }
                    listBox_1.Items[0] = textBox.Text;
                    break;
                case 1:
                    listBox_2.Items.Add(textBox.Text);
                    break;
            }
            textBox.Clear();
        }

        private void button_right_Click(object sender, RoutedEventArgs e)
        {
            listBox_2.Items.Add(listBox_1.SelectedItem);
            listBox_1.Items.Remove(listBox_1.SelectedItem);
        }

        private void button_left_Click(object sender, RoutedEventArgs e)
        {
            listBox_1.Items.Add(listBox_2.SelectedItem);
            listBox_2.Items.Remove(listBox_2.SelectedItem);
        }

        private void button_rightall_Click(object sender, RoutedEventArgs e)
        {
            foreach (var it in listBox_1.Items)
                listBox_2.Items.Add(it);
            listBox_1.Items.Clear();
        }

        private void button_leftall_Click(object sender, RoutedEventArgs e)
        {
            foreach (var it in listBox_2.Items)
                listBox_1.Items.Add(it);
            listBox_2.Items.Clear();
        }
    }
}
