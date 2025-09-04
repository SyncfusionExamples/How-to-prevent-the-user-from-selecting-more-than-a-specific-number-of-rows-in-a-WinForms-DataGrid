using SfDataGrid_Demo;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Enums;

namespace SfDataGrid_Demo
{
    public partial class Form1 : Form
    {
        OrderInfoCollection orderInfo;

        public Form1()
        {
            InitializeComponent();
            orderInfo = new OrderInfoCollection();
            sfDataGrid1.AutoGenerateColumns = false;
            sfDataGrid1.SelectionMode = GridSelectionMode.Multiple;
            sfDataGrid1.DataSource = orderInfo.Orders;
            sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "OrderID", HeaderText = "Order ID", AllowEditing = false });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "CustomerID", HeaderText = "Customer ID" , AllowEditing = true});
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "CustomerName", HeaderText = "Name", AllowEditing = false });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "Country", HeaderText = "Country" , AllowEditing = true });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ShipCity", HeaderText = "Ship City" , AllowEditing = false });
            sfDataGrid1.SelectionChanging += OnSelectionChanging;
        }

        private void OnSelectionChanging(object sender, SelectionChangingEventArgs e)
        {
            var dataGrid = (sender as SfDataGrid);
            if (dataGrid != null && (dataGrid.SelectedItems.Count + e.AddedItems.Count - e.RemovedItems.Count > 2))
            {
                // Cancel the selection above 2 rows
                e.Cancel = true;
            }
        }
    }
}
