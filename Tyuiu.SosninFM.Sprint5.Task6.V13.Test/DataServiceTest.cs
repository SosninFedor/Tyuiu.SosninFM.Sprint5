
using Tyuiu.SosninFM.Sprint5.Task6.V13.Lib;

namespace Tyuiu.SosninFM.Sprint5.Task6.V13.Test
{
	[TestClass]
	public sealed class DataServiceTest
	{
		[TestMethod]
		public void ValidCalc()
		{
			DataService ds = new DataService();
			string path = @"C:\DataSprint5\InPutDataFileTask6V13.txt";
			
			var res = ds.LoadFromDataFile(path);
			int wait = 10;
			Assert.AreEqual(wait, res);

		}

		[TestMethod]
		public void CheckedExistsFile()
		{
			string path = @"C:\DataSprint5\InPutDataFileTask6V13.txt";
			FileInfo fileInfo = new FileInfo(path);
			bool fileExsist = fileInfo.Exists;
			bool wait = true;

			Assert.AreEqual(wait, fileExsist);
		}


	}
}
