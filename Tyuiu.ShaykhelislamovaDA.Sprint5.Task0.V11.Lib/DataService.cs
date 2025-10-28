using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShaykhelislamovaDA.Sprint5.Task0.V11.Lib
{
    public class DataService : ISprint5Task0V11
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double y = Math.Round((4.0 - Math.Pow((double)x, 3)) / Math.Pow((double)x, 2), 3);
            File.WriteAllText(path, y.ToString());
            return path;
        }
    }
}
