using Tyuiu.ShabalinaYP.Sprint7.Project.V5.Lib;
namespace Tyuiu.ShabalinaYP.Sprint7.Project.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidWholebase()
        {
            DataService dataService = new DataService();
            List<string[]> res = dataService.WholesaleBase(@"C:\Users\User\source\repos\sprint7.csv");
            List<string[]> wait = new List<string[]>
            {
                {new string[]{"1", "10021", "Клавиатура механическая", "ООО “Техномир”", "15", "23.02.2025"} }
            };
            CollectionAssert.Equals(res, wait);
        }
}
