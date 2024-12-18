using System.Data;
using Tyuiu.ShabalinaYP.Sprint7.Task0.V5.Lib;
namespace Project.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        public List<string[]> arrayValues;
        private void buttonOpenFile(object sender, EventArgs e)
        {
            openFileDialogTask_SYP.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";

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

                        //Преобразуем массив строк в DataTable
                        DataTable listDataTable = new DataTable();

                        // Получаем количество столбцов (по первому ряду)
                        if (arrayValues.Count > 0)
                        {
                            int columnCount = arrayValues[0].Length;
                            for (int i = 0; i < columnCount; i++)
                            {
                                listDataTable.Columns.Add(new DataColumn($"Column {i + 1}", typeof(string)));
                            }
                        }

                        // Заполняем DataTable данными
                        foreach (string[] row in arrayValues)
                        {
                            listDataTable.Rows.Add(row);
                        }

                        dataGridViewOriginalFile_SYP.DataSource = listDataTable;
                        buttonDone_SYP.Enabled = true;
                        if(listDataTable.Columns.Count > 0)
                        {
                            listDataTable.Columns[0].ColumnName = "Товар";
                            listDataTable.Columns[1].ColumnName = "Код товара";
                            listDataTable.Columns[2].ColumnName = "Поставщик";
                            listDataTable.Columns[3].ColumnName = "Количество на складе";
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
        private void buttonOpenFile_SBI_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SYP.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";
            openFileDialogTask_SYP.ShowDialog();
            if (File.Exists(openFileDialogTask_SYP.FileName))
            {
                openFilePath = openFileDialogTask_SYP.FileName;
                arrayValues = ds.WholesaleBase(openFilePath);

                for (int i = 0; i < arrayValues.Count; i++)
                {
                    if (arrayValues[i].Length < 4 || !int.TryParse(arrayValues[i][0], out _))
                    {
                        MessageBox.Show("Возникла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

    }
}
