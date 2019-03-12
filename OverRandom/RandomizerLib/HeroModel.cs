using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizerLib
{
	public class HeroModel
	{
		public string HeroName { get; set; }
		public string HeroClass { get; set; }

		public HeroModel()
		{
		}

		public HeroModel(string heroName, string heroClass) : this()
		{
			this.HeroName = heroName;
			this.HeroClass = heroClass;
		}
	}
}
