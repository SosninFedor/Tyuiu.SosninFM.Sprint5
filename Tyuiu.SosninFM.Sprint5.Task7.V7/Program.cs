
using Tyuiu.SosninFM.Sprint5.Task7.V7.Lib;

namespace Tyuiu.SosninFM.Sprint5.Task7.V7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataService ds = new DataService();

			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
			Console.WriteLine("***************************************************************************");


			string path = @"C:\DataSprint5\InPutDataFileTask6V13.txt";
			string pathSaveFile = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V4.txt" });
			Console.WriteLine("Данные находятся в файле: " + path);

			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
			Console.WriteLine("***************************************************************************");

			pathSaveFile = ds.LoadDataAndSave(path);
			Console.WriteLine(pathSaveFile);
			Console.ReadKey();

		}
	}
}
