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

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TbTask_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbTask.Text.Length == 0)
            {
                btnAddTask.IsEnabled = false;
            }
            else
            {
                btnAddTask.IsEnabled = true;
                if (e.Key == Key.Enter)
                {
                    addToTasksBox(tbTask.Text);

                }
            }
            
        }

        private void addToTasksBox(string text)
        {
            lbTasks.Items.Add(text);
            tbTask.Text = "";
            btnAddTask.IsEnabled = false;
            
        }

        private void BtnAddTask_Click(object sender, RoutedEventArgs e)
        {
            addToTasksBox(tbTask.Text);
        }

        private void BtnDelTask_Click(object sender, RoutedEventArgs e)
        {
            lbTasks.Items.Remove(lbTasks.SelectedItem);
            btnDelTask.IsEnabled = false;
        }

        private void LbTasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnDelTask.IsEnabled = true;
        }
    }
}
