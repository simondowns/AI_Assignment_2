using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace AI_Assignment_2
{
	public class BuildKB
	{
		private List<string>  _kbbits = new List<string>();
		private string _file;
		private string _kb;
		private string _ask;
		public List<string> Implies = new List<string>();
		public List<string> Vars = new List<string>();

		/// <summary>
		/// Parses the Knowledge Base from the text file.
		/// </summary>
		/// <returns><c>true</c>, if kb was parsed, <c>false</c> otherwise.</returns>
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
			//kinda don't need these variables
			_kb = _kbbits[1];
			_ask = _kbbits[3];
			return true;
		}
		/// <summary>
		/// Build the Knowledge base
		/// </summary>
		private void build()
		{
			//					   and imply negate neg  EI     neg  union
			string[] specChars = { "&", "=>", "¬", "^", "<=>", "!", "||" };
			//first split them up into statements and variables
			List<string> allTheBits = new List<string>();
			allTheBits = _kb.Split(';').ToList();
			foreach (string s in allTheBits)
			{
				Console.WriteLine(s);
				//get rid of any spaces

				//is it an implication?
				if (s.Contains("=>"))
				{
					Implies.Add(s);
				}

				//what are the variables? ¬
				//this bit is going to get messy
				//some variable names are 2 chars long so don't break them


			}

		}

		public BuildKB(string filename)
		{
			_file = filename;
			if (ParseKB())
			{
				build();
			}
		}
	}
}
