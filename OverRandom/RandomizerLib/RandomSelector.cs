using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizerLib
{
	public class RandomSelector
	{
		Random random = new Random();

		List<HeroModel> allTanks = new List<HeroModel>();
		List<HeroModel> allSupport = new List<HeroModel>();

		public RandomSelector()
		{

		}

		public string RandomTank()
		{
			CheckHeroListPopulated();

			int randomHero = random.Next(allTanks.Count);
			string tankOne = allTanks[randomHero].HeroTags[1];
			return tankOne;
		}

		public string RandomSupport()
		{
			CheckHeroListPopulated();

			int randomHero = random.Next(allSupport.Count);
			//string supportOne = allSupport[randomHero].HeroTags[1];
			string supportOne = allSupport[randomHero].HeroName;
			return supportOne;
		}

		private void CheckHeroListPopulated()
		{
			if (allTanks.Any<HeroModel>() == false)
			{
				PopulateTanks();
			}

			if (allSupport.Any<HeroModel>() == false)
			{
				PopulateSupport();
			}
		}

		private void PopulateTanks()
		{
			const string heroClass = "Tank";

			HeroModel dva = new HeroModel("D.Va", heroClass, "Flanker");
			HeroModel orisa = new HeroModel("Orisa", heroClass, "Shields");
			HeroModel reinhardt = new HeroModel("Reinhardt", heroClass, "Shields");
			HeroModel roadhog = new HeroModel("Roadhog", heroClass, "Sustain");
			HeroModel winston = new HeroModel("Winston", heroClass, "Bubble");
			HeroModel wreckingBall = new HeroModel("Wrecking Ball", heroClass, "Ball");
			HeroModel zarya = new HeroModel("Zarya", heroClass, "ZOOP");

			allTanks.Add(dva);
			allTanks.Add(orisa);
			allTanks.Add(reinhardt);
			allTanks.Add(roadhog);
			allTanks.Add(winston);
			allTanks.Add(wreckingBall);
			allTanks.Add(zarya);
		}

		private void PopulateSupport()
		{
			const string heroClass = "Support";

			HeroModel ana = new HeroModel("Ana", heroClass, "Control");
			HeroModel baptiste = new HeroModel("Baptiste", heroClass, "Mobility");
			HeroModel brigitte = new HeroModel("Brigitte", heroClass, "Shields");
			HeroModel lucio = new HeroModel("Lucio", heroClass, "AOE");
			HeroModel mercy = new HeroModel("Mercy", heroClass, "Mobility");			
			HeroModel moira = new HeroModel("Moira", heroClass, "OP AF");
			HeroModel zenyatta = new HeroModel("Zenyatta", heroClass, "Focus");

			allSupport.Add(ana);			
			allSupport.Add(baptiste);
			allSupport.Add(brigitte);
			allSupport.Add(lucio);
			allSupport.Add(mercy);
			allSupport.Add(moira);
			allSupport.Add(zenyatta);
		}
	}
}
