
using Tyuiu.SosninFM.Sprint5.Task0.V4.Lib;
using System.IO;

namespace Tyuiu.SosninFM.Sprint5.Task0.V4.Test
{
	[TestClass]
	public sealed class DataServiceTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			string path = @"D:\Programs\VisualStudio\Projects\repos\2024\Tyuiu.SosninFM.Sprint5\
							Tyuiu.SosninFM.Sprint5.Task5.V28\bin\Debug\InPutDataFileTask5V28.txt";

			FileInfo fileInfo = new FileInfo(path);
			bool fileExists = fileInfo.Exists;
			bool wait = false;

			Assert.AreEqual(wait, fileExists);

		}
	}
}
