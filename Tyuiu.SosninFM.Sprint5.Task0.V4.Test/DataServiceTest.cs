
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
			string path = @"C:\Users\sosni\AppData\Local\Temp\OutPutFileTask0.txt";

			FileInfo fileInfo = new FileInfo(path);
			bool fileExists = fileInfo.Exists;
			bool wait = true;

			Assert.AreEqual(wait, fileExists);

		}
	}
}
