using Daction.Views.Dialog;
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
using System.Windows.Shapes;

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

        void FileUploadButton_Click(object sender, RoutedEventArgs e)
        {
            FileUpload sw = new FileUpload();
            sw.Show();

        }
    }
}