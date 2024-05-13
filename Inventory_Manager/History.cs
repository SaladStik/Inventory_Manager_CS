using System.Data;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class History : Form
    {
        public History(DataTable historyData)
        {
            InitializeComponent();
            historyDataGridView.DataSource = historyData;
        }
    }
}
