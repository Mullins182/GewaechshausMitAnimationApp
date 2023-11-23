using GewaechshausMitAnimation.Controller;
using System;
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

namespace GewaechshausMitAnimation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string outdoorTemp = "";
        string indoorTemp  = "";
        public MainWindow()
        {
            InitializeComponent();

            

        }

        private void set_outdoor_temp_Click(object sender, RoutedEventArgs e)
        {
            outdoorTemp = setOutdoorTemp.Text;
            ActualTempOutdoor.Text = outdoorTemp;
        }

        private void set_indoor_temp_Click(object sender, RoutedEventArgs e)
        {
            indoorTemp = setIndoorTemp.Text;
            ActualTempIndoor.Text = indoorTemp;
        }

        private void outdoorTempSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ActualTempOutdoor.Text = Convert.ToString(outdoorTempSlider.Value);
        }
    }
}