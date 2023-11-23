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
        string outdoorTemp = "20";
        string indoorTemp  = "20";
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
            setOutdoorTemp.Text     = Convert.ToString(outdoorTempSlider.Value);
            setIndoorTemp.Text = Convert.ToString(indoorTempSlider.Value);

            ActualTempIndoor.Text = Convert.ToString(Functions.ShowActualSliderIndoorValue(Convert.ToInt32(indoorTemp), indoorTempSlider.Value));

            //ActualTempIndoor.Text = Convert.ToString(i);
            //ActualTempIndoor.Text   = Convert.ToString(indoorTempSlider.Value);
            //ActualTempOutdoor.Text  = Convert.ToString(outdoorTempSlider.Value);
        }


    }

}