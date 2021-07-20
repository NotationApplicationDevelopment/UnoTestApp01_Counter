using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UnoApp01
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int times = 0;
        SolidColorBrush red = new SolidColorBrush(Windows.UI.Colors.Red);
        SolidColorBrush blue = new SolidColorBrush(Windows.UI.Colors.Blue);

        public MainPage()
        {
            InitializeComponent();

            circle.Tapped += Circle_Tapped;
            resetButton.Click += ResetButton_Click;

            SetTimes(0);
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            SetTimes(0);
        }

        private void Circle_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            SetTimes(times + 1);
        }

        private void SetTimes(int t)
        {
            times = t;
            circle.Fill = times % 2 == 0 ? blue : red;
            counter.Text = "Count = " + times;
        }
    }
}
