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
        int outdoorTemp = 20;
        int indoorTemp  = 20;
        public MainWindow()
        {
            InitializeComponent();

            

        }

        private void outdoorTempSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            setOutdoorTemp.Text = Convert.ToString(outdoorTempSlider.Value);
            outdoorTemp         = Convert.ToInt32(outdoorTempSlider.Value);
        }
        private void indoorTempSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            setIndoorTemp.Text  = Convert.ToString(indoorTempSlider.Value);
            indoorTemp          = Convert.ToInt32(indoorTempSlider.Value);
        }

        private void set_outdoor_temp_Click(object sender, RoutedEventArgs e)
        {
            ActualTempOutdoor.Text  = Convert.ToString(outdoorTemp);
        }

        private void set_indoor_temp_Click(object sender, RoutedEventArgs e)
        {
            ActualTempIndoor.Text   = Convert.ToString(indoorTemp);
        }




        //private void OutdoorTempSetButton_Click(object sender, RoutedEventArgs e)
        //{
        //    ActualTempOutdoor.Text = Convert.ToString(outdoorTemp);
        //}

        //private void IndoorTempSetButton_Click(object sender, RoutedEventArgs e)
        //{
        //    ActualTempIndoor.Text = Convert.ToString(indoorTemp);
        //}
    }

}