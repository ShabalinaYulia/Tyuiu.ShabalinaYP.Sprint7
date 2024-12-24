using System.Data;
using Tyuiu.ShabalinaYP.Sprint7.Task0.V5.Lib;
namespace Project.V5
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public List<string[]> arrayValues;
        private DataTable selectedItemsTable = new DataTable();
        private List<string[]> selectedRows = new List<string[]>();
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_SYP.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialog_SYP.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";
            dataGridViewOriginalFile_SYP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOriginalFile_SYP.MultiSelect = true;
            dataGridViewCompletedOrders_SYP.MultiSelect = false;

            dataGridViewOriginalFile_SYP.SelectionChanged += dataGridViewSource_SelectionChanged;
            dataGridViewCompletedOrders_SYP.DataSource = selectedItemsTable;
        }

        private void buttonOpenFile_SYP_Click(object sender, EventArgs e)
        {
            if (openFileDialogTask_SYP.ShowDialog() == DialogResult.OK)
            {
                string openFilePath = openFileDialogTask_SYP.FileName;
                if (!string.IsNullOrEmpty(openFilePath))
                {
                    try
                    {
                        List<string[]> arrayValues = ds.WholesaleBase(openFilePath);
                        if (arrayValues == null || arrayValues.Count == 0)
                        {
                            MessageBox.Show("Не удалось прочитать или обработать файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        dataGridViewOriginalFile_SYP.AllowUserToAddRows = false;

                        DataTable listDataTable = new DataTable();
                        if (arrayValues.Count > 0)
                        {
                            int columnCount = arrayValues[0].Length;
                            for (int i = 0; i < columnCount; i++)
                            {
                                listDataTable.Columns.Add(new DataColumn($"Column {i + 1}", typeof(string)));
                            }
                        }
                        foreach (string[] row in arrayValues)
                        {
                            listDataTable.Rows.Add(row);
                        }

                        dataGridViewOriginalFile_SYP.DataSource = listDataTable;
                        buttonSaveFile_SYP.Enabled = true;
                        buttonAddCompletedOrders_SYP.Enabled = true;
                        dataGridViewCompletedOrders_SYP.AllowUserToAddRows = false;
                        if (listDataTable.Columns.Count > 0)
                        {
                            listDataTable.Columns[0].ColumnName = "№";
                            listDataTable.Columns[2].ColumnName = "Товар";
                            listDataTable.Columns[1].ColumnName = "Код товара";
                            listDataTable.Columns[3].ColumnName = "Поставщик";
                            listDataTable.Columns[4].ColumnName = "Количество";
                            listDataTable.Columns[5].ColumnName = "Дата заказа";
                            selectedItemsTable = listDataTable.Clone();
                            
                            dataGridViewCompletedOrders_SYP.DataSource = selectedItemsTable;
                            


                        }
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show($"Файл не найден: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"Ошибка ввода-вывода: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void buttonSaveFile_SYP_Click(object sender, EventArgs e)
        {
            saveFileDialog_SYP.FileName = "Выполненные заказы.csv";
            saveFileDialog_SYP.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_SYP.ShowDialog();

            string path = saveFileDialog_SYP.FileName;
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewCompletedOrders_SYP.RowCount;
            int columns = dataGridViewCompletedOrders_SYP.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewCompletedOrders_SYP.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewCompletedOrders_SYP.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonChangeFile_SYP_Click(object sender, EventArgs e)
        {
            saveFileDialog_SYP.FileName = "wholesale base.csv";
            saveFileDialog_SYP.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_SYP.ShowDialog();

            string path = saveFileDialog_SYP.FileName;
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOriginalFile_SYP.RowCount;
            int columns = dataGridViewOriginalFile_SYP.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOriginalFile_SYP.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOriginalFile_SYP.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void ToolStripMenuItemAbout_SYP_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void dataGridViewSource_SelectionChanged(object sender, EventArgs e)
        {
            selectedRows.Clear(); 
            foreach (DataGridViewRow row in dataGridViewOriginalFile_SYP.SelectedRows)
            {
                if (row.IsNewRow) continue;
                string[] values = new string[row.Cells.Count];
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    values[i] = row.Cells[i].Value?.ToString();
                    
                }
                selectedRows.Add(values); // Добавляем новый массив строк
            }

        }
        private void buttonAddCompletedOrders_SYP_Click(object sender, EventArgs e)
        {
            if (selectedRows == null || selectedRows.Count == 0)
            {
                MessageBox.Show("Нет выделенных строк для добавления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                foreach (string[] Rows in selectedRows)
                {
                    selectedItemsTable.Rows.Add(Rows);
                }

            };            
            buttonDeleteCompletedOrders_SYP.Enabled = true;
        }
        
        private void buttonDeleteCompletedOrders_SYP_Click(object sender, EventArgs e)
        {
            if (selectedRows == null || selectedRows.Count == 0)
            {
                MessageBox.Show("Нет выделенных строк для добавления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                foreach(DataGridViewRow Row in dataGridViewCompletedOrders_SYP.SelectedRows)
                {
                    dataGridViewCompletedOrders_SYP.Rows.Remove(Row);
                }                  
                    
            }
        }
        private void buttonStatics_SYP_Click(object obj, EventArgs e)
        {
            FormStatics formStatics = new FormStatics();
            formStatics.ShowDialog();
        }
        private void buttonSearch_SBI_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxSearch_SYP.Text, out int number))
            {
                DataGridView dataGrid = tabControlFile_SYP.SelectedIndex == 0 ? dataGridViewOriginalFile_SYP : dataGridViewCompletedOrders_SYP;
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) != number)
                    {
                        dataGrid.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    
    }
}
