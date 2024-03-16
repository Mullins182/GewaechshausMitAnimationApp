using GewaechshausMitAnimation.Model;
using System.Windows;
using System.Windows.Media;

namespace GewaechshausMitAnimation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

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

            exit.BorderThickness        = new Thickness(2,3,3,2);
        }

        private void outdoorTempSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            setOutdoorTemp.Text = Convert.ToString(outdoorTempSlider.Value);
        }
        private void indoorTempSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            setIndoorTemp.Text  = Convert.ToString(indoorTempSlider.Value);
        }

        private async void set_outdoor_temp_Click(object sender, RoutedEventArgs e)
        {
            if((double)outdoorTemp == outdoorTempSlider.Value)
            {

            }
            else
            {
                outdoorTemp                 = Convert.ToInt32(outdoorTempSlider.Value);
                ActualTempOutdoor.Text      = $"{Convert.ToString(outdoorTemp)} °C";

                Tomate.setSystems(indoorTemp, outdoorTemp);

                LueftungStatus.Text         = Tomate.getLueftungStatus();
                KuehlungStatus.Text         = Tomate.getKuehlungStatus();
                HeizungStatus.Text          = Tomate.getHeizungStatus();
                VerdunklungStatus.Text      = Tomate.getVerdunklStatus();

                set_outdoor_temp.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0x3E, 0x11, 0x11));

                for (int i = 4; i > 0; i--)
                {
                    set_outdoor_temp.BorderThickness    = new Thickness(0,2.6,0,2.6);
                    set_outdoor_temp.BorderBrush        = Brushes.LimeGreen;

                    await Task.Delay(100);

                    set_outdoor_temp.BorderThickness    = new Thickness(0);

                    await Task.Delay(100);
                }
            }
        }

        private async void set_indoor_temp_Click(object sender, RoutedEventArgs e)
        {
            if((double)indoorTemp == indoorTempSlider.Value)
            {

            }
            else
            {
                indoorTemp                  = Convert.ToInt32(indoorTempSlider.Value);
                ActualTempIndoor.Text       = $"{Convert.ToString(indoorTemp)} °C";

                Tomate.setSystems(indoorTemp, outdoorTemp);

                LueftungStatus.Text         = Tomate.getLueftungStatus();
                KuehlungStatus.Text         = Tomate.getKuehlungStatus();
                HeizungStatus.Text          = Tomate.getHeizungStatus();
                VerdunklungStatus.Text      = Tomate.getVerdunklStatus();

                set_indoor_temp.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0x3E, 0x11, 0x11));

                for (int i = 4; i > 0; i--)
                {
                    set_indoor_temp.BorderThickness = new Thickness(0, 2.6, 0, 2.6);
                    set_indoor_temp.BorderBrush     = Brushes.LimeGreen;

                    await Task.Delay(133);

                    set_indoor_temp.BorderThickness = new Thickness(0);

                    await Task.Delay(133);
                }
            }
        }

        private void set_outdoor_temp_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            set_outdoor_temp.Background = new SolidColorBrush(Color.FromArgb(0xAA, 0x10, 0x5A, 0x11));
        }

        private void set_outdoor_temp_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            set_outdoor_temp.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0x3E, 0x11, 0x11));
        }

        private void set_indoor_temp_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            set_indoor_temp.Background = new SolidColorBrush(Color.FromArgb(0xAA, 0x10, 0x5A, 0x11));
        }

        private void set_indoor_temp_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            set_indoor_temp.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0x3E, 0x11, 0x11));
        }

        private async void exit_Click(object sender, RoutedEventArgs e)
        {
            while (exit.IsPressed)
            {
                exit.BorderThickness    = new Thickness(2.4,4,4,3.4);
                exit.BorderBrush        = Brushes.Lime;
                exit.Foreground         = Brushes.Lime;
                await Task.Delay(250);
            }

            this.Close();
        }
    }
}
