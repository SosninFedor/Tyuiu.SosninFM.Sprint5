
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SosninFM.Sprint5.Task2.V27.Lib
{
	public class DataService : ISprint5Task2V27
	{
		public string SaveToFileTextData(int[,] matrix)
		{

			string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.csv" });

			FileInfo fileInfo = new FileInfo(path);
			bool FileExists = fileInfo.Exists;

			if (FileExists)
			{
				File.Delete(path);
			}

			int rows = matrix.GetUpperBound(0) + 1;		//строки
			int cols = matrix.Length / rows;			//столбцы

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (matrix[i, j] % 2 != 0)
					{
						matrix[i, j] = 0;
					}
				}
			}

			string str = "";
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0;j < cols; j++)
				{
					if (j != cols - 1)
					{
						str = str + matrix[i, j] + ";";
					}
					else
					{
						str = str + matrix[i, j];
					}
				}

				if (i != rows - 1)
				{
					File.AppendAllText(path, str + Environment.NewLine);
				}
				else
				{
					File.AppendAllText(path, str);
				}
				str = "";

			}

			return path;
		}
	}
}
