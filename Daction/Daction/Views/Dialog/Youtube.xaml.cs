using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Daction.StartYoutube;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;

namespace Daction.Views.Dialog
{
    /// <summary>
    /// Youtube.xaml の相互作用ロジック
    /// </summary>
    public partial class Youtube : Window
    {
        public Youtube()
        {
            InitializeComponent();
            // ResourceManagerを取得する
            System.Resources.ResourceManager resource = Properties.Resources.ResourceManager;
            // "Sample"に値を取得してコンソールに出力する

            string html = Properties.Resources.youtube;

            string outhtml = @html;
            this.WebView.NavigateToString(outhtml);
        }
    }
}
