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
using System.Windows.Shapes;

namespace учёт_персонала
{
    /// <summary>
    /// Логика взаимодействия для WindowMenu.xaml
    /// </summary>
    public partial class WindowMenu : Window
    {
        public WindowMenu()
        {
            InitializeComponent();
        }


        private void But_Rab_Click(object sender, RoutedEventArgs e)
        {
            WindowWorkers winWor = new WindowWorkers();
            this.Visibility = Visibility.Collapsed;
            winWor.ShowDialog();
        }

        private void But_Vak_Click(object sender, RoutedEventArgs e)
        {
            WindowVacansii winVac = new WindowVacansii();
            this.Visibility = Visibility.Collapsed;
            winVac.ShowDialog();
        }

        private void But_Rasp_Click(object sender, RoutedEventArgs e)
        {
            WindowRaspisanie winRasp = new WindowRaspisanie();
            this.Visibility = Visibility.Collapsed;
            winRasp.ShowDialog();
        }

        private void But_Close_Prog_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
