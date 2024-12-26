using System.Text;
namespace Tyuiu.ShabalinaYP.Sprint7.Project.V5.Lib
{
    public class DataService
    {
        public List<string[]> WholesaleBase(string path)
        {
            List<string[]> items = new List<string[]>();
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    items.Add(line.Split(';'));
                }
            }
            return items;
        }
        public string[,] GetData(string path)
        {
            string[] fileData = File.ReadAllText(path).Replace('\n', '\r').Split('\r', StringSplitOptions.RemoveEmptyEntries);

            int rows = fileData.Length;
            int columns = fileData[0].Split(';').Length;

            string[,] data = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line = fileData[i].Split(";");
                for (int j = 0; j < columns; j++)
                {
                    data[i, j] = line[j];
                }
            }
            return data;

        }
}
