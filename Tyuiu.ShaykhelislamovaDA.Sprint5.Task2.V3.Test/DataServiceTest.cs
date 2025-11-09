using Tyuiu.ShaykhelislamovaDA.Sprint5.Task2.V3.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint5.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\diana\source\repos\Tyuiu.ShaykhelislamovaDA.Sprint5\Tyuiu.ShaykhelislamovaDA.Sprint5.Task0.V11\bin\Debug\net8.0\OutPutFileTask0.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
