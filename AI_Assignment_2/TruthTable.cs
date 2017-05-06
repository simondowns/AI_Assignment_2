using System;
using System.Collections.Generic;

namespace AI_Assignment_2
{
	public class TruthTable
	{

		private List<string> Implies = new List<string>();
		private List<string> Vars = new List<string>();
		private string ask;
		/// <summary>
		/// Builds the Truth Table.
		/// </summary>
		/// <returns>string telling if the statement is true.</returns>
		public string BuildTT()
		{
			string result = "";
			string[] temp;
			int levels = 0;
			foreach (string s in Implies)
			{
				//look for the ask first.
				if (s.Contains(ask))
				{
					temp = s.Split('=');
					temp[1] = temp[1].TrimStart('>');
					temp[1] = temp[1].TrimStart(' ');
					if (temp[1] == ask)
						levels++;
					result += "yes";
					//TODO: use temp one as the next one to look for and add to levels
				}
			}

			return result;
		}

		public TruthTable(List<string> imp, List<string> vari, string asking)
		{
			Implies = imp;
			Vars = vari;
			ask = asking;
			//BuildTT();
		}
	}
}
