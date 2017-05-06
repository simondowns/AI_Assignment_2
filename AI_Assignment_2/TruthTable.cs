using System;
using System.Collections.Generic;

namespace AI_Assignment_2
{
	public class TruthTable
	{

		private List<string> Implies = new List<string>();
		private List<string> Vars = new List<string>();
		public string BuildTT()
		{
			string result = "";
			foreach (string s in Implies)
			{
				//do stufff
			}

			return result;
		}

		public TruthTable(List<string> imp, List<string> vari)
		{
			Implies = imp;
			Vars = vari;
		}
	}
}
