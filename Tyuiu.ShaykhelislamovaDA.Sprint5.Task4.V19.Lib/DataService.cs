using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShaykhelislamovaDA.Sprint5.Task4.V19.Lib
{
    public class DataService : ISprint5Task4V19
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Replace('.', ',');
            double x = Convert.ToDouble(strX);
            double res = Math.Round(Math.Pow(x/Math.Cos(x), 2), 3);
            return res;
        }
    }
}
