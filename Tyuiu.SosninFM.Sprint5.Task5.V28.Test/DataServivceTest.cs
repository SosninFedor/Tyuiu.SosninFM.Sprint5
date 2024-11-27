
using Tyuiu.SosninFM.Sprint5.Task5.V28;

namespace Tyuiu.SosninFM.Sprint5.Task5.V28.Test
{
	[TestClass]
	public sealed class DataServivceTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			string path = @"C:\Users\sosni\AppData\Local\Temp\OutPutFileTask5V28.txt";

			FileInfo fileInfo = new FileInfo(path);
			bool fileExists = fileInfo.Exists;
			bool wait = false;

			Assert.AreEqual(wait, fileExists);


		}
	}
}
