using Microsoft.HandsFree.GazePointer;
using Microsoft.HandsFree.Settings;
using System.Windows;
using Microsoft.HandsFree.Keyboard.Settings;

namespace Microsoft.HandsFree.Keyboard
{
    /// <summary>
    /// Interaction logic for AssistanceWindow.xaml
    /// </summary>
    public partial class AssistanceWindow : Window
    {
        const int MAX_GAZE_CLICK_DELAY = 250;

        public AssistanceWindow()
        {
            InitializeComponent();

            Loaded += (s, e) =>
                {
                    GazePointer.GazePointer.Attach(this);
                };
        }
        int GetGazeDelay(FrameworkElement element)
        {
            return MAX_GAZE_CLICK_DELAY;
        }

        void CloseClicked(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
