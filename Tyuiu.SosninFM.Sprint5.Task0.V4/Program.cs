
using Tyuiu.SosninFM.Sprint5.Task0.V4.Lib;

namespace Tyuiu.SosninFM.Sprint5.Task0.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {

			DataService ds = new DataService();

			int x = 2;
			Console.WriteLine("x = " + x);

			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
			Console.WriteLine("***************************************************************************");

			double y = 2 * Math.Pow(x, 3) + 0.5 * Math.Pow(x, 2) - 3.5 * x + 2;
			y = Math.Round(y, 3);
			Console.WriteLine("Ответ: " + y);

			Console.WriteLine("***************************************************************************");

			string res = ds.SaveToFileTextData(x);
			Console.WriteLine("Фaйл: " + res);
			Console.WriteLine("Coздан!");
			Console.ReadKey();
		}
    }
}
