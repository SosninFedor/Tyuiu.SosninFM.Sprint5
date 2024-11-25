
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SosninFM.Sprint5.Task3.V7.Lib
{
	public class DataService : ISprint5Task3V7
	{
		public string SaveToFileTextData(int x)
		{
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Append)))
            {
                writer.Write(1.6 * (Math.Pow(x, 3)) - 2.1 * (Math.Pow(x, 2)) + 7 * x);

            }

            return path;

		}
	}
}
