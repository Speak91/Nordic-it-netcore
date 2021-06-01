using System;
using System.IO;
using System.Text;

namespace L10_CXX_Files
{
	class Program
	{
		static void Main(string[] args)
		{
			const string fileName = @"d:\test.txt";
			const string testMessage = @"Hello world";

			byte[] messageBytes = Encoding.UTF8.GetBytes(testMessage);

			FileStream testFileStream = File.Open(
				fileName,
				FileMode.Create,
				FileAccess.Write,
				FileShare.Read);

			testFileStream.Write(messageBytes);
			testFileStream.Flush();

			testFileStream.Write(messageBytes);
			testFileStream.Write(messageBytes);
			testFileStream.Write(messageBytes);
			testFileStream.Write(messageBytes);
			testFileStream.Close();
		}
	}
}
