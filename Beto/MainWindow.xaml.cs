using System;
using System.Windows;
using System.Windows.Controls;
namespace WpfApp
{
    public partial class MainWindow : Window
    {
        private int _currentNumber = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            _currentNumber++;
            NumberListView.Items.Add(_currentNumber);
        }
        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            if (NumberListView.SelectedItem != null)
            {
                NumberListView.Items.Remove(NumberListView.SelectedItem);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите элемент для удаления.");
            }
        }
    }
}