using Daction.Views.Dialog;
using System.Windows;

namespace Daction.Views
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Associate event handler to the button. You can remove the event
            // handler using "-=" syntax rather than "+=".
            this.GoogleMapButton.Click += new RoutedEventHandler(GoogleMapButton_Click);
            this.YoutubeButton.Click  += new RoutedEventHandler(YoutubeButton_Click);
            this.FileUploadButton.Click += new RoutedEventHandler(FileUploadButton_Click);

        }

        void GoogleMapButton_Click(object sender, RoutedEventArgs e)
        {
            GoogleMap sw = new GoogleMap();
            sw.Show();

        }

        void YoutubeButton_Click(object sender, RoutedEventArgs e)
        {
            Youtube sw = new Youtube();
            sw.Show();

        }

        void TwitterButton_Click(object sender, RoutedEventArgs e)
        {
            Twitter sw = new Twitter();
            sw.Show();

        }

        void FileUploadButton_Click(object sender, RoutedEventArgs e)
        {
            FileUpload sw = new FileUpload();
            sw.Show();

        }
    }
}