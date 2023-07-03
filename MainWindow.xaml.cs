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

namespace WpfApp1
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
        private void btnHeron_Click(object sender, RoutedEventArgs e)
        {
            double sideA, sideB, sideC, semiperimeter, area;
            try
            {
                sideA = Convert.ToDouble(txtSideA.Text);
                sideB = Convert.ToDouble(txtSideB.Text);
                sideC = Convert.ToDouble(txtSideC.Text);

                // Проверяем, что стороны образуют треугольник
                if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
                {
                    // Вычисляем полупериметр
                    semiperimeter = (sideA + sideB + sideC) / 2;

                    // Вычисляем площадь по формуле Герона
                    area = Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));

                    txtResult.Text = $"Площадь треугольника: {area:F2}";
                }
                else
                {
                    txtResult.Text = "Такой треугольник не существует!";
                }
            }
            catch (Exception ex)
            {
                txtResult.Text = $"Ошибка: {ex.Message}";
            }
        }
    }
}
