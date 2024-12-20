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
        private void buttonOpenFile_SYP_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SYP.Filter = "��������, ���������� �������� (*.csv)|*.csv|��� ����� (*.*)|*.*";

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
                            MessageBox.Show("�� ������� ��������� ��� ���������� ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        buttonDone_SYP.Enabled = true;
                        if(listDataTable.Columns.Count > 0)
                        {
                            listDataTable.Columns[0].ColumnName = "�����";
                            listDataTable.Columns[1].ColumnName = "��� ������";
                            listDataTable.Columns[2].ColumnName = "���������";
                            listDataTable.Columns[3].ColumnName = "���������� �� ������";
                        }
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show($"���� �� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"������ �����-������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"��������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void buttonSaveFile_SBI_Click(object sender, EventArgs e)
        {
            saveFileDialog_SYP.FileName = "file.csv";
            saveFileDialog_SYP.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_SYP.ShowDialog();

            string path = saveFileDialog_SYP.FileName;

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

        }

    }
}
