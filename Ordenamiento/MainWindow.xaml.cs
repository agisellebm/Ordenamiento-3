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
using System.Collections.ObjectModel;

namespace Ordenamiento
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<int> milista =
            new ObservableCollection<int>();
        public MainWindow()
        {
            InitializeComponent();
            milista.Add(58);
            milista.Add(35);
            milista.Add(20);
            milista.Add(16);
            milista.Add(15);
            milista.Add(78);
            milista.Add(9);
            milista.Add(66);
            milista.Add(13);

            lstNumeros.ItemsSource = milista;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           /* var temp = milista[0];
            milista[0] = milista[3];
            milista[3] = temp;*/

            int gap, temp, i, j;
            gap = milista.Count / 2;

            while(gap >0)
            {
                for(i=0; i<milista.Count; i++)
                {
                    if (gap + i < milista.Count && milista[i] > milista[gap + i]) 
                    {
                        temp = milista[i];
                        milista[i] = milista[gap + i];
                        milista[gap + i] = temp;
                    }
                }
                gap--;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;
            do
            {
                for (int i = 0; i < milista.Count - 1; i++) 
                {
                    if (milista[i] > milista[i + 1]) 
                    {
                        int temp = milista[i];
                        milista[i + 1] = temp;
                        intercambio = true;
                    }
                }

            } while (intercambio);

        }
    }
}
