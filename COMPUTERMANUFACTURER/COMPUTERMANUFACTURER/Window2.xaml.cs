using System;
using System.Data;
using System.Windows;


namespace COMPUTERMANUFACTURER
{
    public partial class Window2 : Window
    {
        COMPUTEREntities7 _bd = new COMPUTEREntities7();
        public Window2()
        {
            InitializeComponent();
        }
        void method()
        {
            SPECIFICATIONS har = new SPECIFICATIONS()
            {
                MODEL = INSERT_MODEL.Text,
                CPU = INSERT_CPU.Text, 
                FREQUENCY = Convert.ToInt32(INSERT_FREQUENCY.Text), 
                RAM = Convert.ToInt32(INSERT_RAM.Text), 
                HardDiskSpace = Convert.ToInt32(INSERT_HardDiskSpace.Text), 
                RELEASEdATE = Convert.ToDateTime(PickrerDate.SelectedDate),
            };
            _bd.SPECIFICATIONS.Add(har);
            _bd.SaveChanges();
        }

        private void INSERT_COMPUTER_Click(object sender, RoutedEventArgs e)
        { 
            method();
        }

        private void VIEW_COMP_Click(object sender, RoutedEventArgs e)
        {
            Window8 j = new Window8();
            j.Show();
        }
    }
}
