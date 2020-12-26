using System.Windows;


namespace COMPUTERMANUFACTURER
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void choise1_Click(object sender, RoutedEventArgs e)
        {
            Window4 Proizv = new Window4();
            Proizv.Show();
        }
        private void choise2_Click(object sender, RoutedEventArgs e)
        {
            Window2 comp = new Window2();
            comp.Show();
        }

        private void choise3_Click(object sender, RoutedEventArgs e)
        {
            Window1 real = new Window1();
            real.Show();
        }

        private void choise4_Click(object sender, RoutedEventArgs e)
        {
            Window3 part = new Window3();
            part.Show();
        }
    }
}
