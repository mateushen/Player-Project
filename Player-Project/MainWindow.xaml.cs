using Microsoft.Win32;
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

namespace Player_Project
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            sliVol.Minimum = 0;
            sliVol.Maximum = 1;
            sliVol.Value = 0.2; 

        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AddExtension = true;
            ofd.DefaultExt = "*.*";
            ofd.Filter = "media (*.*)|*.*";
            ofd.ShowDialog();
            mE1.Source = new Uri(ofd.FileName);
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            mE1.Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mE1.Pause();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            mE1.Stop();
        }

        private void sliVol_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (mE1 != null)
            {
                mE1.Volume = sliVol.Value;
            }
        }
    }
}
