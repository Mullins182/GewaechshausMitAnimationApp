using GewaechshausMitAnimation.Model;
using System.Windows;

namespace GewaechshausMitAnimation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GewaechshausSystems Tomate = new GewaechshausSystems();

        int outdoorTemp = 20;
        int indoorTemp  = 20;
        public MainWindow()
        {
            InitializeComponent();

            Tomate.setSystems(indoorTemp, outdoorTemp);

            LueftungStatus.Text         = Tomate.getLueftungStatus();
            KuehlungStatus.Text         = Tomate.getKuehlungStatus();
            HeizungStatus.Text          = Tomate.getHeizungStatus();
            VerdunklungStatus.Text      = Tomate.getVerdunklStatus();
        }

        private void outdoorTempSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            setOutdoorTemp.Text = Convert.ToString(outdoorTempSlider.Value);
        }
        private void indoorTempSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            setIndoorTemp.Text  = Convert.ToString(indoorTempSlider.Value);
        }

        private void set_outdoor_temp_Click(object sender, RoutedEventArgs e)
        {
            outdoorTemp                 = Convert.ToInt32(outdoorTempSlider.Value);
            ActualTempOutdoor.Text      = Convert.ToString(outdoorTemp);

            Tomate.setSystems(indoorTemp, outdoorTemp);

            LueftungStatus.Text         = Tomate.getLueftungStatus();
            KuehlungStatus.Text         = Tomate.getKuehlungStatus();
            HeizungStatus.Text          = Tomate.getHeizungStatus();
            VerdunklungStatus.Text      = Tomate.getVerdunklStatus();
        }

        private void set_indoor_temp_Click(object sender, RoutedEventArgs e)
        {
            indoorTemp                  = Convert.ToInt32(indoorTempSlider.Value);
            ActualTempIndoor.Text       = Convert.ToString(indoorTemp);

            Tomate.setSystems(indoorTemp, outdoorTemp);

            LueftungStatus.Text         = Tomate.getLueftungStatus();
            KuehlungStatus.Text         = Tomate.getKuehlungStatus();
            HeizungStatus.Text          = Tomate.getHeizungStatus();
            VerdunklungStatus.Text      = Tomate.getVerdunklStatus();
        }

        //public static void SystemStatusOutput(GewaechshausSystems Tomate, int indoorTemp, int outdoorTemp)
        //{
        //    Tomate.setSystems(indoorTemp, outdoorTemp);

        //    MainWindow.LueftungStatus.Text = Convert.ToString(Tomate.getLueftungStatus());
        //    KuehlungStatus.Text = Convert.ToString(Tomate.getKuehlungStatus());
        //    HeizungStatus.Text = Convert.ToString(Tomate.getHeizungStatus());
        //    VerdunklungStatus.Text = Convert.ToString(Tomate.getVerdunklStatus());

        //}




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