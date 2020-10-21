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
using RadioApp; 

namespace radioGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Radio radio = new Radio(); 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioON_Click(object sender, RoutedEventArgs e)
        {
            if (btnRadioON.IsEnabled)
            {
                radio.TurnOn();
                
                txtRadioDisplay.Text = radio.Play();
                btnChnl1.IsEnabled = true;
                btnChnl2.IsEnabled = true;
                btnChnl3.IsEnabled = true;
                btnChnl4.IsEnabled = true;
                sldChnlControl.IsEnabled = true; 
            }
           
        }
        private void RadioOFF_Click(object sender, RoutedEventArgs e)
        {
            if (btnRadioOFF.IsEnabled)
            {
                radio.TurnOff();
                txtRadioDisplay.Text = radio.Play();
                btnChnl1.IsEnabled = false;
                btnChnl2.IsEnabled = false;
                btnChnl3.IsEnabled = false;
                btnChnl4.IsEnabled = false;
                sldChnlControl.IsEnabled = false; 
            }
        }

        private void btnChnl1_Click(object sender, RoutedEventArgs e)
        {
            radio.Channel = 1;
            txtRadioDisplay.Text = radio.Play();
           

        }
        private void btnChnl2_Click(object sender, RoutedEventArgs e)
        {
            radio.Channel = 2;
            txtRadioDisplay.Text = radio.Play();
        }

        private void btnChnl3_Click(object sender, RoutedEventArgs e)
        {
            radio.Channel = 3;
            txtRadioDisplay.Text = radio.Play();
        }

        private void btnChnl4_Click(object sender, RoutedEventArgs e)
        {
            radio.Channel = 4;
            txtRadioDisplay.Text = radio.Play();
        }

        private void sldChnlControl_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = Math.Round(sldChnlControl.Value, 0.0); 
            
            if(value == 1)
            {
                radio.Channel = 1; 
                txtRadioDisplay.Text = radio.Play();
            }
            else if(value == 2)
            {
                radio.Channel = 2;
                txtRadioDisplay.Text = radio.Play();
            }
            else if (value == 3)
            {
                radio.Channel = 3;
                txtRadioDisplay.Text = radio.Play();
            }
            else if (value == 4)
            {
                radio.Channel = 4;
                txtRadioDisplay.Text = radio.Play();
            }
        }
    }
}
