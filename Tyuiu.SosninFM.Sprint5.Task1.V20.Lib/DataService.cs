
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SosninFM.Sprint5.Task1.V20.Lib
{
	public class DataService : ISprint5Task1V20
	{
		public string SaveToFileTextData(int startValue, int stopValue)
		{
			string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });

			FileInfo fileInfo = new FileInfo(path);

			bool FileExists = fileInfo.Exists;

			if (FileExists)
			{
				File.Delete(path);
			}

			double y;
			string strY;


			for (int x = startValue; x <= stopValue; x++)
			{
				y = Math.Round(((5 * x + 2.5) / (Math.Sin(x) + 3) + 2 * x + Math.Cos(x)), 2);
				strY = Convert.ToString(y);

				if (x != stopValue)
				{
					File.AppendAllText(path, strY + Environment.NewLine);
				}
				else
				{
					File.AppendAllText(path, strY);
				}
			}
			return path;
		}
	}
}
