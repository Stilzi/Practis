using System;
using System.Windows;


namespace COMPUTERMANUFACTURER
{
    public partial class Window4 : Window
    {
        COMPUTEREntities7 _bD = new COMPUTEREntities7();
        
        public Window4()
        {
            InitializeComponent();
        }

        void method()
        {
            MANUFACTURER man = new MANUFACTURER()
            {
                NAME = INSERT_MANUF_NAME.Text, 
                ADDRESS = INSERT_MANUF_ADDRESS.Text,
                SPECIFICATIONSID = Convert.ToInt32(INSERT_MANUF_MODEL.Text),
                CONSIGMENTID = Convert.ToInt32(INSERT_MANUF_CONS.Text)
            };
            _bD.MANUFACTURER.Add(man);
            _bD.SaveChanges();
        }

        private void VIEW_MANUF_Click(object sender, RoutedEventArgs e)
        {
            Window5 WIN = new Window5();
            WIN.Show();
        }

        private void INSERT_MANUF_Click(object sender, RoutedEventArgs e)
        {
            method();
        }
    }
}
