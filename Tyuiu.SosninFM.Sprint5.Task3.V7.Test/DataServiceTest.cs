
using Tyuiu.SosninFM.Sprint5.Task3.V7.Lib;

namespace Tyuiu.SosninFM.Sprint5.Task3.V7.Test
{
	[TestClass]
	public sealed class DataServiceTest
	{
		[TestMethod]
		public void CheckExistsFile()
		{
			string path = @"C:\Users\sosni\AppData\Local\Temp\OutPutFileTask2.bin";

			FileInfo fileInfo = new FileInfo(path);

			bool fileExists = fileInfo.Exists;
			bool wait = false;

			Assert.AreEqual(wait, fileExists);
		}
	}
}
