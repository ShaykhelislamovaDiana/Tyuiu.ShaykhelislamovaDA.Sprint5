using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text;
namespace Tyuiu.ShaykhelislamovaDA.Sprint5.Task3.V6.Lib
{
    public class DataService : ISprint5Task3V6
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();

            double res = Math.Round((double)x / Math.Pow((double)x * x + x, 0.5), 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(res));
            }
            return path;
        }
    }
}
