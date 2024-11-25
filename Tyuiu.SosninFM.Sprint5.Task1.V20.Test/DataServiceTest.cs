
using Tyuiu.SosninFM.Sprint5.Task1.V20.Lib;

namespace Tyuiu.SosninFM.Sprint5.Task1.V20.Test
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
