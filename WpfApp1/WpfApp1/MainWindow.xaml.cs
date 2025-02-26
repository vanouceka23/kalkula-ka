using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double pamet = 0;
        private double pamet2 = 0;
        private double ukazka = 0;
        private int akce = 0;
        private int a = 0;
        private int b = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        static double pridat_cislo(int cislo,double ukazka,int a, int b)
        {
            if (b == 1)
            {
                return(cislo);
            }
            if (ukazka * 10 % 10 == 0)
            {
                if (ukazka < 0)
                {
                    ukazka = ukazka * 10 - cislo;
                }
                else
                {
                    ukazka = ukazka * 10 + cislo;
                }
                if (a != 0)
                {
                    ukazka=ukazka / 10;
                }

            }
            else
            {
                while (ukazka % 10 != 0)
                {
                    a++;
                    ukazka = ukazka * 10;
                }
                a--;
                if (ukazka < 0)
                {
                    ukazka -= cislo;
                }
                else
                {
                    ukazka += cislo;
                }
                while (a != 0)
                {
                    ukazka = ukazka / 10;
                    a--;
                }
            }
            a=0;
            return(ukazka);
        }
        


        private void procenta(object sender, RoutedEventArgs e)
        {
            ukazka = pamet / 100 * ukazka;
            cislo.Content = ukazka.ToString();
        }
        private void CE(object sender, RoutedEventArgs e)
        {
            a = 0;
            b = 0;
            pamet = 0;
            ukazka = 0;
            cislo.Content = ukazka.ToString();
        }

        private void C(object sender, RoutedEventArgs e)
        {
            ukazka = 0;
            a = 0;
            b = 0;
            cislo.Content = ukazka.ToString();
        }

        private void V_Click(object sender, RoutedEventArgs e)
        {
            ukazka = (ukazka - ukazka % 10)/10;
            b = 0;
            cislo.Content = ukazka.ToString();
        }

        private void jednaxtina_Click(object sender, RoutedEventArgs e)
        {
            ukazka = 1 / ukazka;
            b = 0;
            cislo.Content = ukazka.ToString();
        }

        private void nadruhou_Click(object sender, RoutedEventArgs e)
        {
            ukazka = ukazka * ukazka;
            b = 0;
            cislo.Content = ukazka.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ukazka = (double)Math.Sqrt(ukazka);
            b = 0;
            cislo.Content = ukazka.ToString();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (b == 0)
            {
                Button_Click_17(sender, e);
            }
            b = 0;
            pamet = ukazka;
            ukazka = 0;
            akce = 4;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ukazka = pridat_cislo(7, ukazka, a, b);
            if (b == 1)
            {
                pamet = 0;
                akce = 0;
            }
            b = 0;
            cislo.Content=ukazka.ToString();
        }


        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ukazka = pridat_cislo(8, ukazka, a, b);
            if (b == 1)
            {
                pamet = 0;
                akce = 0;
            }
            cislo.Content = ukazka.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ukazka = pridat_cislo(9, ukazka, a, b);
            if (b == 1)
            {
                pamet = 0;
            }
            b = 0;
            cislo.Content = ukazka.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (b == 0)
            {
                Button_Click_17(sender, e);
            }
            b = 0;
            pamet =ukazka;
            ukazka = 0;
            akce = 3;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ukazka = pridat_cislo(4, ukazka, a, b);
            if (b == 1)
            {
                pamet = 0;
                akce = 0;
            }
            b = 0;
            cislo.Content = ukazka.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {   
            ukazka = pridat_cislo(5, ukazka, a, b);
            if (b == 1)
            {
                pamet = 0;
                akce = 0;
            }
            b = 0;
            cislo.Content = ukazka.ToString();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            ukazka = pridat_cislo(6, ukazka, a, b);
            b = 0;
            cislo.Content = ukazka.ToString();

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (b == 0)
            {
                Button_Click_17(sender, e);
            }
            b = 0;
            pamet = ukazka;
            ukazka = 0;
            akce = 2; 


        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            ukazka = pridat_cislo(1, ukazka, a, b);
            if (b == 1)
            {
                pamet = 0;
                akce = 0;
            }
            b = 0;
            cislo.Content = ukazka.ToString();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            ukazka = pridat_cislo(2, ukazka, a, b);
            if (b == 1)
            {
                pamet = 0;
                akce = 0;
            }
            b = 0;
            cislo.Content = ukazka.ToString();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            ukazka = pridat_cislo(3, ukazka, a  , b);
            if (b == 1)
            {
                pamet = 0;
                akce = 0;
            }
            b = 0;
            cislo.Content = ukazka.ToString();

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (b == 0)
            {
                Button_Click_17(sender, e);
            }
            b = 0;
            pamet = ukazka;
            ukazka = 0;
            akce = 1;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            ukazka = ukazka * -1;
            b = 0;
            cislo.Content=ukazka.ToString();
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            ukazka = pridat_cislo(0, ukazka, a, b);
            if (b == 1)
            {
                pamet = 0;
                akce = 0;
            }
            b = 0;
            cislo.Content = ukazka.ToString();
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            a = 1;
            b = 0;
            cislo.Content = ukazka.ToString()+",";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            if (b == 0) 
            {
                pamet2=ukazka;
                if (akce == 1)
                {
                    ukazka = pamet + ukazka;
                }
                if (akce == 2)
                {
                    ukazka = pamet - ukazka;
                }
                if (akce == 3)
                {
                    ukazka = pamet * ukazka;
                }
                if (akce == 4)
                {
                    ukazka = pamet / ukazka;
                }
                pamet=ukazka;
            }
            else
            {
                if (akce == 1)
                {
                    ukazka = pamet + pamet2;
                }
                if (akce == 2)
                {
                    ukazka = pamet - pamet2;
                }
                if (akce == 3)
                {
                    ukazka = pamet * pamet2;
                }
                if (akce == 4)
                {
                    ukazka = pamet / pamet2;
                }
                pamet = ukazka;
            }
            b = 1;
            cislo.Content = ukazka.ToString();
        }
    }

}