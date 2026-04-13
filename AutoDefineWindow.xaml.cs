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

namespace MouseTracker
{
    /// <summary>
    /// Interaction logic for AutoDefineWindow.xaml
    /// </summary>
    public partial class AutoDefineWindow : Window
    {
        public AutoDefineWindow()
        {
            InitializeComponent();
            var gridMaker = new GridMaker();
            ScreenSizeText.Text = gridMaker.UIGridInfo();
            AspectRatioText.Text = gridMaker.screenAspectRatio.ToString("F2");
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;   // closes the modal dialog
        }
    }
}
