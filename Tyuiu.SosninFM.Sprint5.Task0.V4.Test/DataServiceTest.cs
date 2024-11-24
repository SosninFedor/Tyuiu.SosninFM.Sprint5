using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SosninFM.Sprint5.Task0.V4.Lib;


namespace Tyuiu.SosninFM.Sprint5.Task0.V4.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void CheckExistsFile()
		{
			string path = @"D:\Programs\VisualStudio\Projects\repos\2024\Tyuiu.SosninFM.Sprint5\Tyuiu.SosninFM.Sprint5.Task0.V4\bin\Debug\OutPutFileTask0.txt";

			FileInfo fileInfo = new FileInfo(path);
			bool fileExists = fileInfo.Exists;
			bool wait = true;

			Assert.AreEqual(wait, fileExists);

		}
	}
}
