using Tyuiu.SosninFM.Sprint5.Task4.V8.Lib;

namespace Tyuiu.SosninFM.Sprint5.Task4.V8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataService ds = new DataService();

			Console.WriteLine("****************************************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
			Console.WriteLine("****************************************************************************************************");

			string path = @"С:\DataSprint5\InPutDataFileTask4V8.txt";
			Console.WriteLine("Данные находятся в файле: " + path);

			Console.WriteLine("****************************************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
			Console.WriteLine("****************************************************************************************************");

			double res = ds.LoadFromDataFile(path);
			Console.WriteLine(res);
			Console.ReadKey();
		}
	}
}
