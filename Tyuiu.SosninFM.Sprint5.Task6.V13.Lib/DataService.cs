
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SosninFM.Sprint5.Task6.V13.Lib
{
	public class DataService : ISprint5Task6V13
	{
		public int LoadFromDataFile(string path)
		{
			int count = 0;

			using (StreamReader reader = new StreamReader(path))
			{
				int cnt = 0;
				string str = File.ReadAllText(path);
				str = str.ToUpper().Replace("СС", "*");
				for (int i = 0; i < str.Length; i++)
				{
					if (str[i] == '*')
					{
						cnt += 1;
					}
				}
				return cnt;
			}
	}
}
