using System.Linq;
using System.Data;
using System.Windows;


namespace COMPUTERMANUFACTURER
{
    public partial class Window8 : Window
    {
        COMPUTEREntities7 o = new COMPUTEREntities7();
        public Window8()
        {
            InitializeComponent();

            SPECIF_DATAGRID.ItemsSource = o.SPECIFICATIONS.ToList();
        }
      }
   }
