﻿
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SosninFM.Sprint5.Task3.V7.Lib
{
	public class DataService : ISprint5Task3V7
	{
		public string SaveToFileTextData(int x)
		{
			string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";
			double y = (1.6 * Math.Pow(x, 3) - 2.1 * Math.Pow(x, 2) + 7 * x);
			y = Math.Round(y, 3);
			using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
			{
				writer.Write(BitConverter.GetBytes(y));
			}
			return path;

		}
	}
}
