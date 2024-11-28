
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.SosninFM.Sprint5.Task5.V28.Lib
{
	public class DataService : ISprint5Task5V28
	{
		public double LoadFromDataFile(string path)
		{
			int min = 1000;
			double res = 0;
			int fact = 1;
			using (StreamReader reader = new StreamReader(path))
			{
				string? line;
				while ((line = reader.ReadLine()) != null)
				{
					string lineReplace = line.Replace('.', ',');
					string[] lineArray = lineReplace.Split(' ');

					foreach (string number in lineArray)
					{
						double lineParse = double.Parse(number);

						if ((lineParse > 0) && (lineParse % 5 == 0))
						{
							res = lineParse;
							while (res < min)
							{
								min = (int)res;
							}
							for (int i = 1; i <= min; i++)
							{
								fact *= i;
							}
						}
					}
				}
			}
			return fact;
		}
	}
}