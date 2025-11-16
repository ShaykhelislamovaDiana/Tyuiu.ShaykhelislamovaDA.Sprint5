using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShaykhelislamovaDA.Sprint5.Task7.V14.Lib
{
    public class DataService : ISprint5Task7V14
    {
        public string LoadDataAndSave(string path)
        {
            string respath = Path.GetTempFileName();
            string res = "";
            using(StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    res += line.ToUpper();
                }
            }
            File.WriteAllText(respath, res);
            return respath;
        }
    }
}
