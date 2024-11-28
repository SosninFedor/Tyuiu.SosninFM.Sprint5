using Tyuiu.SosninFM.Sprint5.Task5.V28.Lib;

namespace Tyuiu.SosninFM.Sprint5.Task5.V28
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataService ds = new DataService();

			Console.WriteLine("****************************************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
			Console.WriteLine("****************************************************************************************************");

			string path = @"C:\DataSprint5\InPutDataFileTask5V28.txt";
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
