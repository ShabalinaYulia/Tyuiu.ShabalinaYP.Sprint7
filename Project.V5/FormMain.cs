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

                dataGridViewOriginalFile_SYP.DataSource = arrayValues;
                
            }
            buttonDone_SYP.Enabled = true;
        }
        private void buttonOpenFile_SBI_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SYP.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";
            openFileDialogTask_SYP.ShowDialog();
            if (File.Exists(openFileDialogTask_SYP.FileName))
            {
                openFilePath = openFileDialogTask_SYP.FileName;
                arrayValues = ds.WholesaleBase(openFilePath);

                for (int i = 0; i<arrayValues.Count; i++)
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
        }
    }
}
