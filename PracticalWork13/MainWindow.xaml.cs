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
using Пример_таблицы_WPF;

namespace PracticalWork13
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

        int[,] matr;
        int[] mas;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            matr = new int[5, 6];
            mas = new int[6];
            dataGridA.ItemsSource = VisualArray.ToDataTable(matr).DefaultView;
            dataGridB.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №13 вариант 14\n\nДунаева М.И. ИСП-31\n\n" +
                "По массиву A(5,6)получить массив В(6), присвоив его j-элементу значение true," +
                "если все элементы j-столбца массива А нулевые, и значение false иначе");
        }

        private void btn_Count_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Fill_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Count2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
