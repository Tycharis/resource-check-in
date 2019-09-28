using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResourceCheckin
{
    public partial class UserInterface : Form
    {
        private int resourceIdCounter = 0;

        public UserInterface()
        {
            InitializeComponent();

            List<string> items = new List<string> { "Checked In", "Checked Out", "Deployed", "Out of Service" };

            DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();

            uxDataGrid.DataError += new DataGridViewDataErrorEventHandler(handleDataGridViewErrors);

            column.Name = "uxResourceStatusColumn";
            column.HeaderText = "Resource Status";
            column.DataSource = items;

            uxDataGrid.Columns.Add(column);
        }

        private void uxAddButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            DataGridViewComboBoxCell statusCell = new DataGridViewComboBoxCell();

            object[] content = {
                resourceIdCounter++,
                uxResourceDropdown.SelectedItem.ToString(),
                uxNameBox.Text,
                uxOwnerBox.Text,
                "",
                statusCell
            };

            row.CreateCells(uxDataGrid, content);

            uxDataGrid.Rows.Add(row);

            uxNameBox.Text = "";
            uxOwnerBox.Text = "";
        }

        private void handleDataGridViewErrors(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
