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
        private void buttonOpenFile(object sender, EventArgs e)
        {
            openFileDialogTask_SYP.ShowDialog();
            string openFilePath = openFileDialogTask_SYP.FileName;
            if (openFilePath != null)
            {
                List<string[]> arrayValues = ds.WholesaleBase(openFilePath);

                int rows = arrayValues.GetLength(0);
                int columns = arrayValues.GetLength(1);

                dataGridViewOriginalFile_SYP.ColumnCount = columns;
                dataGridViewOriginalFile_SYP.RowCount = rows;
                dataGridViewOriginalFile_SYP.ColumnCount = columns;
                dataGridViewOriginalFile_SYP.RowCount = rows;
                for (int i = 0; i < columns; i++)
                {
                    dataGridViewOriginalFile_SYP.Columns[i].Width = 25;
                    //dataGridViewOutPut_SYP.Columns[i].Width = 25;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewOriginalFile_SYP.Rows[i].Cells[j].Value = arrayValues[i, j];
                    }
                }
            }
            buttonDone_SYP.Enabled = true;
        }
    }
}
