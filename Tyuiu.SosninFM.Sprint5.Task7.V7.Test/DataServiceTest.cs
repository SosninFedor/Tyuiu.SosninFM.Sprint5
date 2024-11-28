
using Tyuiu.SosninFM.Sprint5.Task7.V7.Lib;
using System.IO;

namespace Tyuiu.SosninFM.Sprint5.Task7.V7.Test
{
	[TestClass]
	public sealed class DataService
	{
		[TestMethod]
		public void TestMethod1()
		{
			string path = @"C:\DataSprint5\InPutDataFileTask6V13.txt";
			FileInfo fileInfo = new FileInfo(path);
			bool fileExists = fileInfo.Exists;
			bool wait = true;
			Assert.AreEqual(wait, fileExists);

		}
	}
}
