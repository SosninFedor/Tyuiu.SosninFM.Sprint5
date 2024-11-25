
using Tyuiu.SosninFM.Sprint5.Task1.V20.Lib;

namespace Tyuiu.SosninFM.Sprint5.Task1.V20
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int startValue = -5;
			int endValue = 5;

			DataService ds = new DataService();

			string res = ds.SaveToFileTextData(startValue, endValue);
			Console.WriteLine("Файл: " + res);
			Console.WriteLine("Создан!");
			Console.ReadKey();



		}
	}
}
