using System.Windows;


namespace COMPUTERMANUFACTURER
{
    public partial class Window1 : Window
    {
        COMPUTEREntities7 _BD = new COMPUTEREntities7();
        public Window1()
        {
            InitializeComponent();
        }
        void method()
        {
            DISTRIBUTOR VVOD = new DISTRIBUTOR()
            {
                NAME = INSERT_DISTR_NAME.Text, ADDRESS = INSERT_DISTR_ADDRESS.Text, PHONE = INSERT_DISTR_PHONE.Text
            };
            _BD.DISTRIBUTOR.Add(VVOD);
            _BD.SaveChanges();
        }

        private void INSERT_DISTR_Click(object sender, RoutedEventArgs e)
        {
            method();
        }

        private void VIEW_DISTR_Click(object sender, RoutedEventArgs e)
        {
            Window7 k = new Window7();
            k.Show();
        }
    }
}
