using System;
using System.IO;
using System.Collections.Generic;
namespace AI_Assignment_2
{
	public class BuildKB
	{
		private List<string>  _kbbits = new List<string>();
		private string _file;
		private string _kb;
		private string _ask;

		
		public bool ParseKB()
		{
			try
			{
				// Create an instance of StreamReader to read from a file.
				// The using statement also closes the StreamReader.
				using (StreamReader sr = new StreamReader(_file))
				{
					string read;
					// Read and display lines from the file until the end of 
					// the file is reached.
					while (((read = sr.ReadLine()) != null))
					{
						_kbbits.Add(read);
					}

				}
			}
			catch (Exception e)
			{
				// Let the user know what went wrong.
				Console.WriteLine("The file could not be read:");
				Console.WriteLine(e.Message);
				return false;
			}
			return true;
		}

		public BuildKB(string filename)
		{
			_file = filename;
		}
	}
}
