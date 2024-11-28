
using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SosninFM.Sprint5.Task7.V7.Lib
{
	public class DataService : ISprint5Task7V7
	{
		public string LoadDataAndSave(string path)
		{

			string path2 = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V4.txt" });

			FileInfo f = new FileInfo(path2);
			if (f.Exists)
			{
				File.Delete(path2);
			}

			string result = "";
			using (StreamReader reader = new StreamReader(path))
			{
				string inputText = reader.ReadToEnd();

				// Заменяем все русские буквы на пробел
				string outputText = Regex.Replace(inputText, @"[А-Я]", "");
				return outputText;



			}
		}
	}
}