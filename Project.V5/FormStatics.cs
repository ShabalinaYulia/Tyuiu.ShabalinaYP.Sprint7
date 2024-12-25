using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V5
{
    public partial class FormStatics : Form
    {
        private static DataGridView mainFormDataGrid;
        private int BiggestOrders = 0;
        public FormStatics(DataGridView dataGrid)
        {
            mainFormDataGrid = dataGrid;
            InitializeComponent();
        }
        public void GetBiggestOrder()
        {
            string ans = null;
            for (int i = 0; i < mainFormDataGrid.Rows.Count; i++)
            {
                if (mainFormDataGrid.Rows[i].Cells[4].Value != null &&
          int.TryParse(mainFormDataGrid.Rows[i].Cells[4].Value.ToString(), out int cellValue))
                {
                    if (cellValue > BiggestOrders)
                    {
                        BiggestOrders = cellValue;
                        ans = mainFormDataGrid.Rows[i].Cells[4].Value.ToString();
                    }
                }
            }
            label1.Text = $"Самый большой заказ: {ans}";
        }
        private void GetMostRepeatedString()
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (DataGridViewRow row in mainFormDataGrid.Rows)
            {
                if (row.IsNewRow) continue;
                string value = row.Cells[3].Value?.ToString();
                if (value != null)
                {
                    if (counts.ContainsKey(value))
                    {
                        counts[value]++;
                    }
                    else
                    {
                        counts[value] = 1;
                    }
                }
            }          

            string mostFrequent = null;
            int maxCount = 0;
            foreach (var pair in counts)
            {
                if (pair.Value > maxCount)
                {
                    maxCount = pair.Value;
                    mostFrequent = pair.Key;
                }
            }
            label2.Text = $"Наиболее частый Поставщик: {mostFrequent}";
        }
        private void GetFirstOrders()
        {
            DateTime?
        }
        private void buttonCalculateStatics_Click(object sender, EventArgs e)
        {
            GetBiggestOrder();
            GetMostRepeatedString();

        }
        
    }
}
