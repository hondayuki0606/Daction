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
            // ResourceManagerを取得する
            System.Resources.ResourceManager resource = Properties.Resources.ResourceManager;
            // "Sample"に値を取得してコンソールに出力する
            string message = resource.GetString("map.html");
            System.Console.WriteLine(message);
            string html = Properties.Resources.map;

            string outhtml = @html;
            this.WebView.NavigateToString(outhtml);

        }
    }
}

