using Tyuiu.ShabalinaYP.Sprint7.Task0.V5.Lib;
namespace Tyuiu.ShabalinaYP.Sprint7.Task0.V5.Test
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
                {new string[]{"товар", "код товара", "поставщик", "количество на складе"} },
                {new string[]{"диван", "12", "ООО икея", "34" } }
            };
            CollectionAssert.Equals(res, wait);
                
//

        }
    }
}
