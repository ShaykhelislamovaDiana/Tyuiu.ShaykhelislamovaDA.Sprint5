using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShaykhelislamovaDA.Sprint5.Task5.V18.Lib
{
    public class DataService : ISprint5Task5V18
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace('.', ',');
                    string[] dig = line.Split(' ');
                    for (int i = 0; i < dig.Length; i++)
                    {
                        if ((Convert.ToDouble(dig[i]) > -100 & Convert.ToDouble(dig[i]) <= -10) | (Convert.ToDouble(dig[i]) < 100 & Convert.ToDouble(dig[i]) >= 10))
                        {
                            res *= Convert.ToDouble(dig[i]);
                        }
                    }
                }
            }
            return Math.Round(res, 3);
        }
    }
}
