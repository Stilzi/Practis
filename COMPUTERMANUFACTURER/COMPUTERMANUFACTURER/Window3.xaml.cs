using System;
using System.Windows;


namespace COMPUTERMANUFACTURER
{
    public partial class Window3 : Window
    {
        COMPUTEREntities7 _Bd = new COMPUTEREntities7();
        public Window3()
        {
            InitializeComponent();
        }
        void method()
        {
            CONSIGNMENT cons = new CONSIGNMENT()
            {
                PRICE =  Convert.ToInt32(INSERT_CONS_PRICE.Text), 
                BATCHSIZE = Convert.ToInt32(INSERT_CONS_SIZE.Text)
            };
            _Bd.CONSIGNMENT.Add(cons);
            _Bd.SaveChanges();
        }

        private void INSERT_CONS_Click(object sender, RoutedEventArgs e)
        {
            method();
        }

        private void VIEW_CONS_Click(object sender, RoutedEventArgs e)
        {
            Window6 j = new Window6();
            j.Show();
        }
    }
}
