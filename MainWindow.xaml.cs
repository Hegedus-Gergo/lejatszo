using System;
using System.Windows;
using NAudio.Wave;

namespace AudioPlayer
{
    public partial class MainWindow : Window
    {
        private WaveStream hang;
        private WaveOutEvent waveout;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void mediaElement_Betolt(object sender, RoutedEventArgs e)
        {
            hang = new AudioFileReader("file.mp3");
            waveout = new WaveOutEvent();
            waveout.Init(hang);
            waveout.Play();
            kivalasztott.Play();
            lejatszasbtn.IsEnabled = false;
            megallitbtn.IsEnabled = true;
            leallitbtn.IsEnabled = true;
        }

        private void lejatszasbtn_Click(object sender, RoutedEventArgs e)
        {
            waveout.Play();
            kivalasztott.Play();
            lejatszasbtn.IsEnabled = false;
            megallitbtn.IsEnabled = true;
            leallitbtn.IsEnabled = true;
        }

        private void megallitbtn_Click(object sender, RoutedEventArgs e)
        {
            waveout.Pause();
            kivalasztott.Pause();
            lejatszasbtn.IsEnabled = true;
            megallitbtn.IsEnabled = false;
            leallitbtn.IsEnabled = true;
        }

        private void leallitbtn_Click(object sender, RoutedEventArgs e)
        {
            waveout.Stop();
            kivalasztott.Stop();
            lejatszasbtn.IsEnabled = true;
            megallitbtn.IsEnabled = false;
            leallitbtn.IsEnabled = false;
        }

        private void mediaElement_Vege(object sender, RoutedEventArgs e)
        {
            lejatszasbtn.IsEnabled = true;
            megallitbtn.IsEnabled = false;
            leallitbtn.IsEnabled = false;
        }
    }
}
