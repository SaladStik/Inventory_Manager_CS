using System.Data;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class History : Form
    {
        public History(DataTable dataTable)
        {
            InitializeComponent();
            historyDataGridView.DataSource = dataTable;
        }
    }

}
