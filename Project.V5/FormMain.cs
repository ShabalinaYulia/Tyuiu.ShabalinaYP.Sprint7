using System.Data;
using Tyuiu.ShabalinaYP.Sprint7.Task0.V5.Lib;
namespace Project.V5
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public List<string[]> arrayValues;
        private DataTable selectedItemsTable = new DataTable();
        private List<string[]> selectedItems = new List<string[]>();
        private List<string[]> selectedRows = new List<string[]>();
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_SYP.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialog_SYP.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";
            dataGridViewOriginalFile_SYP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOriginalFile_SYP.MultiSelect = true;
            dataGridViewCard_SYP.MultiSelect = false;

            dataGridViewOriginalFile_SYP.SelectionChanged += dataGridViewOriginalFile_SYP_SelectionChanged;
            buttonAddtoCard_SYP.Click += buttonAddtoCard_SYP_Click; // Добавляем обработчик на нажатие кнопки "Добавить"
            dataGridViewCard_SYP.DataSource = selectedItemsTable;
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
                        buttonAddtoCard_SYP.Enabled = true;
                        if (listDataTable.Columns.Count > 0)
                        {
                            listDataTable.Columns[0].ColumnName = "№";
                            listDataTable.Columns[2].ColumnName = "Товар";
                            listDataTable.Columns[1].ColumnName = "Код товара";
                            listDataTable.Columns[3].ColumnName = "Поставщик";
                            listDataTable.Columns[4].ColumnName = "Количество на складе";
                            selectedItemsTable = listDataTable.Clone();
                            if (selectedItemsTable.Columns.Count > 0) 
                            {
                                selectedItemsTable.Columns[4].ColumnName = "Количество";
                            };
                            dataGridViewCard_SYP.DataSource = selectedItemsTable;

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
        private void buttonSaveFile_SBI_Click(object sender, EventArgs e)
        {
            saveFileDialog_SYP.FileName = "Корзина.csv";
            saveFileDialog_SYP.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_SYP.ShowDialog();

            string path = saveFileDialog_SYP.FileName;

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }
            int row = this.dataGridViewCard_SYP.RowCount;
            int column = this.dataGridViewCard_SYP.ColumnCount;
            string str = "";
            if (this.saveFileDialog_SYP.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        if (this.dataGridViewCard_SYP.Rows[i].Cells[j].Style.BackColor == Color.OrangeRed) break;

                        if (j == column - 1)
                        {
                            str += this.dataGridViewCard_SYP.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            str += this.dataGridViewCard_SYP.Rows[i].Cells[j].Value.ToString() + ";";
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }



        }
        private void dataGridViewOriginalFile_SYP_SelectionChanged(object sender, EventArgs e)
        {
            selectedRows.Clear();
            foreach (DataGridViewRow row in dataGridViewOriginalFile_SYP.SelectedRows)
            {
                if (row.IsNewRow) continue; // Пропускаем строку добавления
                string[] values = new string[row.Cells.Count];
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    values[i] = row.Cells[i].Value?.ToString();
                }
                selectedRows.Add(values);
            }
        }
        private void buttonAddtoCard_SYP_Click(object sender, EventArgs e)
        {
            if (selectedRows.Count > 0)
            {
                foreach (string[] row in selectedRows)
                {
                    selectedItemsTable.Rows.Add(row);
                }
            }
        }
    }
}
