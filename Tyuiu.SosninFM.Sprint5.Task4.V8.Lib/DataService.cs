
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SosninFM.Sprint5.Task4.V8.Lib
{
	public class DataService : ISprint5Task4V8
	{
		public double LoadFromDataFile(string path)
		{
			string content;
			using (StreamReader sr = new StreamReader(path))
			{
				content = sr.ReadToEnd().Trim();
			}

			double x;
			if (!double.TryParse(content, NumberStyles.Any, CultureInfo.InvariantCulture, out x))
			{
				content = content.Replace(',', '.');
			}

			double y = (Math.Pow(x, 2) / (Math.Sin(x)) + 3);

			return Math.Round(y, 3);



		}
	}
}
