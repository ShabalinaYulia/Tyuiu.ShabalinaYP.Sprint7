using System.Text;
namespace Tyuiu.ShabalinaYP.Sprint7.Task0.V5.Lib
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
    }
}
