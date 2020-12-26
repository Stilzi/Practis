using System.Linq;
using System.Windows;


namespace COMPUTERMANUFACTURER
{
    public partial class Window7 : Window
    {
        COMPUTEREntities7 l = new COMPUTEREntities7();
        public Window7()
        {
            InitializeComponent();

            DIS_DATAGRID.ItemsSource = l.DISTRIBUTOR.ToList();
        }
    }
}
