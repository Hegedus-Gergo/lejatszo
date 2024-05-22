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

        private void mediaElement_Loaded(object sender, RoutedEventArgs e)
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

        private void playButton_Click(object sender, RoutedEventArgs e)
        {
            waveout.Play();
            kivalasztott.Play();
            lejatszasbtn.IsEnabled = false;
            megallitbtn.IsEnabled = true;
            leallitbtn.IsEnabled = true;
        }

        private void pauseButton_Click(object sender, RoutedEventArgs e)
        {
            waveout.Pause();
            kivalasztott.Pause();
            lejatszasbtn.IsEnabled = true;
            megallitbtn.IsEnabled = false;
            leallitbtn.IsEnabled = true;
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            waveout.Stop();
            kivalasztott.Stop();
            lejatszasbtn.IsEnabled = true;
            megallitbtn.IsEnabled = false;
            leallitbtn.IsEnabled = false;
        }

        private void mediaElement_Vegetert(object sender, RoutedEventArgs e)
        {
            lejatszasbtn.IsEnabled = true;
            megallitbtn.IsEnabled = false;
            leallitbtn.IsEnabled = false;
        }
    }
}