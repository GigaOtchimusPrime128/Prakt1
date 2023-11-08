using Microsoft.Windows.Themes;
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
using Lib_1;

namespace Prakt_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {//Скобка
        public MainWindow()
        {//Скобка
            InitializeComponent();
        }//Скобка
        public void Close(object sender, RoutedEventArgs e)//Закрывает программу
        {//Скобка
            this.Close();//Закрытие окна
        }//Скобка
        public void Su(object sender,RoutedEventArgs e)//Функция вывода данных на основе числа n
        {//Скобка
            if (Int32.TryParse(nashN.Text, out int n) == true) //Если ввод данных удачный
            {//Скобка
                int[] x = new int[n];//Массив
                Random random = new Random();//Способ ввести случайное число
                for (int i = 0; i < n; i++)//Цикл ввода массива
                {//Скобка
                    x[i] = random.Next(1, n);//Ввод случайных чисел
                }//Скобка
                Otv1.Text = Lib_1.Summa.Massi(x);//Вывод массива
                Otv2.Text = Convert.ToString(Lib_1.Summa.MassSum(x));//Вывод суммы данных массива
            }//Скобка
            else//Если ввод данных неудачный
            {//Скобка
                Otv1.Text = "";//Очищение поля
                Otv2.Text = "";//Очищение поля
                nashN.Text = ">:(";//Лицо недовольное вашим умением вводить что угодно кроме цифр
            }//Скобка
        }//Скобка
    }//Скобка
}//Скобка
