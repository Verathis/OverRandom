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
		public List<string> HeroTags;

		public HeroModel()
		{
			HeroTags = new List<string>();
		}

		public HeroModel(string heroName, params string[] tags) : this()
		{
			HeroName = heroName;
			foreach (string tag in tags)
			{
				HeroTags.Add(tag);
			}			
		}
	}
}
