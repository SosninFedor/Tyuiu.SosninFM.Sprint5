
using Tyuiu.SosninFM.Sprint5.Task3.V7.Lib;

namespace Tyuiu.SosninFM.Sprint5.Task3.V7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int x = 2;
			DataService ds = new DataService();

			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("x = " + x);
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
			Console.WriteLine("***************************************************************************");
			string res = ds.SaveToFileTextData(x);
			Console.WriteLine("Файл " + res);
			Console.WriteLine("Создан!");
			Console.ReadKey();

		}
	}
}
