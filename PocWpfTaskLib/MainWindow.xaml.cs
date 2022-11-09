using System.Windows;

namespace PocWpfTaskLib
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainWindowVM _vm;

        public MainWindow()
        {
            InitializeComponent();
            _vm = new MainWindowVM();
        }

        private void Button_Click_Delay0(object sender, RoutedEventArgs e)
        {
            _vm.PoC01_TaskResultAndAwaitTaskDelay0();
        }

        private void Button_Click_Delay0_QueueDispatcher(object sender, RoutedEventArgs e)
        {
            _vm.PoC01_TaskResultAndAwaitTaskDelay0_QueueDispatcher();
        }

        private void Button_Click_Delay1(object sender, RoutedEventArgs e)
        {
            _vm.PoC02_TaskResultAndAwaitTaskDelay1();
        }
    }
}
