
using Tyuiu.SosninFM.Sprint5.Task5.V28;
using System.IO;

namespace Tyuiu.SosninFM.Sprint5.Task5.V28.Test
{
	[TestClass]
	public sealed class DataServivceTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			string path = @"C:\DataSprint5\InPutDataFileTask5V28.txt";
			FileInfo fileInfo = new FileInfo(path);
			bool fileExsist = fileInfo.Exists;
			bool wait = true;

			Assert.AreEqual(wait, fileExsist);

		}
	}
}
