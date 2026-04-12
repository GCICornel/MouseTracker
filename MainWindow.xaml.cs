using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MouseTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isTracking = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            //on click it needs to first check if mouse tracking is active and then start tracking the mouse position and store its data into a list of mouse positions and timestamps. then update ui to show its tracking status. also needs to trigger when pressed f9 key
            if (!isTracking)
            {
                isTracking = true;
                StatusTextBlock.Text = "Tracking Started";
                //start tracking mouse position and store data
                //update ui to show tracking status
            }

        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            //on click it needs to stop tracking the mouse position then update ui to show its tracking status. also needs to trigger when pressed the f10 key
            if (isTracking)
            {
                isTracking = false;
                StatusTextBlock.Text = "Tracking Stopped";
                //stop tracking mouse position
                //update ui to show tracking status
            }
        }

        private void SelectStoragePath_Click(object sender, RoutedEventArgs e)
        {
            //here it needs to open a file dialog to select the storage path for the mouse tracking data and then update the ui to show the selected path
        }

        private void VisualizeData_Click(object sender, RoutedEventArgs e)
        {
            //here on click it will send to new windows where the user will be able to selecte the visualization types (like a heatmap or a line chart or a simple grid etc.)
        }

        private void AutodefineScreenSize_Click(object sender, RoutedEventArgs e)
        {
            // will take the calcualated scren size and aspect ratio and show them to the user and then also ask user for next input
            var win = new AutoDefineWindow();
            win.Owner = this;   // Makes it stay on top of the parent window
            win.ShowDialog();   // Blocks interaction with the parent until closed
        }
    }
}