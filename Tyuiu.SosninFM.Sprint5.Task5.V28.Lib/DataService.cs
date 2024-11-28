
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
			double ans = double.MinValue;

			using (StreamReader reader = new StreamReader(path))
			{
				string line;

				while ((line = reader.ReadLine()) != null)
				{

					double res = 1;
					string[] arr = line.Split(' ');
					foreach (string value2 in arr)
					{
						bool check = false;
						foreach (char tempchar in value2)
						{
							if (tempchar == '.' || tempchar == ',')
							{
								check = true;
							}
						}
						if (check)
						{
							continue;
						}
						
						double min = int.MaxValue;

						double number = double.Parse(line);
						if (number > 0 && number % 5 == 0 && number < min)
							{
								min = number;
							}


							for (int i = 2; i <= number; i++)
							{
								res *= i;
							}
						
					}
					return res;
				}

			}
		}
	}
}