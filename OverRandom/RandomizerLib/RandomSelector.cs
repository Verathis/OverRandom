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

		List<HeroModel> allHeroes = new List<HeroModel>();

		public RandomSelector()
		{

		}

		public HeroModel RandomAny()
		{
			CheckHeroListPopulated();
			
			int randomIndex = random.Next(allHeroes.Count);
			HeroModel randomHero = allHeroes[randomIndex];

			return randomHero;
		}

		public HeroModel RandomTank()
		{
			CheckHeroListPopulated();

			List<HeroModel> randomTankList = TagFinder("Tank");
			int randomIndex = random.Next(randomTankList.Count);
			HeroModel randomTank = randomTankList[randomIndex];

			return randomTank;
		}

		public HeroModel RandomSupport()
		{
			CheckHeroListPopulated();

			List<HeroModel> randomSupportList = TagFinder("Support");
			int randomIndex = random.Next(randomSupportList.Count);
			HeroModel randomSupport = randomSupportList[randomIndex];
			
			return randomSupport;
		}

		public HeroModel RandomDamage()
		{
			CheckHeroListPopulated();

			List<HeroModel> randomDamageList = TagFinder("Damage");
			int randomIndex = random.Next(randomDamageList.Count);
			HeroModel randomDamage = randomDamageList[randomIndex];

			return randomDamage;
		}

		public List<HeroModel> RandomTwoOfEach()
		{
			CheckHeroListPopulated();

			List<HeroModel> twoOfEach = new List<HeroModel>();
			List<HeroModel> randomTankList = TagFinder("Tank");
			List<HeroModel> randomSupportList = TagFinder("Support");
			List<HeroModel> randomDamageList = TagFinder("Damage");
			//List<HeroModel> twoTanks = TwoUniqueRandoms(randomTankList);
			//List<HeroModel> twoSupport = TwoUniqueRandoms(randomSupportList);
			//List<HeroModel> twoDamage = TwoUniqueRandoms(randomDamageList);
			//twoOfEach.AddRange(twoTanks);
			//twoOfEach.AddRange(twoSupport);
			//twoOfEach.AddRange(twoDamage);
			twoOfEach.AddRange(TwoUniqueRandoms(randomTankList));
			twoOfEach.AddRange(TwoUniqueRandoms(randomSupportList));
			twoOfEach.AddRange(TwoUniqueRandoms(randomDamageList));
			return twoOfEach;
		}

		private List<HeroModel> TwoUniqueRandoms(List<HeroModel> models)
		{
			List<HeroModel> twoUniqueRandomHeroes = new List<HeroModel>();
			List<int> randomNumbers = new List<int>();
			
			for (int i = 0; i < 2;)
			{
				int randomIndex = random.Next(models.Count);
				if(!randomNumbers.Contains(randomIndex))
				{
					HeroModel randomHero = models[randomIndex];
					twoUniqueRandomHeroes.Add(randomHero);
					randomNumbers.Add(randomIndex);
					i++;
				}
			}
			return twoUniqueRandomHeroes;
		}

		private List<HeroModel> TagFinder(string tag)
		{
			List<HeroModel> relevantModels = new List<HeroModel>();
			
			foreach (HeroModel model in allHeroes)
			{
				if(model.HeroTags.Contains(tag))
				{
					relevantModels.Add(model);
				}
			}
			return relevantModels;
		}

		private void CheckHeroListPopulated()
		{
			if (allHeroes.Any<HeroModel>() == false)
			{
				PopulateTanks();
				PopulateSupport();
				PopulateDamage();
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

			allHeroes.Add(dva);
			allHeroes.Add(orisa);
			allHeroes.Add(reinhardt);
			allHeroes.Add(roadhog);
			allHeroes.Add(winston);
			allHeroes.Add(wreckingBall);
			allHeroes.Add(zarya);
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

			allHeroes.Add(ana);			
			allHeroes.Add(baptiste);
			allHeroes.Add(brigitte);
			allHeroes.Add(lucio);
			allHeroes.Add(mercy);
			allHeroes.Add(moira);
			allHeroes.Add(zenyatta);
		}

		private void PopulateDamage()
		{
			const string heroClass = "Damage";

			HeroModel ashe = new HeroModel("Ashe", heroClass, "idk");
			HeroModel bastion = new HeroModel("Bastion", heroClass, "idk");
			HeroModel doomfist = new HeroModel("Doomfist", heroClass, "idk");
			HeroModel genji = new HeroModel("Genji", heroClass, "idk");
			HeroModel hanzo = new HeroModel("Hanzo", heroClass, "idk");
			HeroModel junkrat = new HeroModel("Junkrat", heroClass, "idk");
			HeroModel mcCree = new HeroModel("McCree", heroClass, "idk");
			HeroModel mei = new HeroModel("Mei", heroClass, "idk");
			HeroModel pharah = new HeroModel("Pharah", heroClass, "idk");
			HeroModel reaper = new HeroModel("Reaper", heroClass, "idk");
			HeroModel soldier = new HeroModel("Soldier: 76", heroClass, "idk");
			HeroModel sombra = new HeroModel("Sombra", heroClass, "idk");
			HeroModel symmetra = new HeroModel("Symmetra", heroClass, "idk");
			HeroModel torbjorn = new HeroModel("Torbjörn", heroClass, "idk");
			HeroModel tracer = new HeroModel("Tracer", heroClass, "idk");
			HeroModel widowmaker = new HeroModel("Widowmaker", heroClass, "idk");

			allHeroes.Add(ashe);
			allHeroes.Add(bastion);
			allHeroes.Add(doomfist);
			allHeroes.Add(genji);
			allHeroes.Add(hanzo);
			allHeroes.Add(junkrat);
			allHeroes.Add(mcCree);
			allHeroes.Add(mei);
			allHeroes.Add(pharah);
			allHeroes.Add(reaper);
			allHeroes.Add(soldier);
			allHeroes.Add(sombra);
			allHeroes.Add(symmetra);
			allHeroes.Add(torbjorn);
			allHeroes.Add(tracer);
			allHeroes.Add(widowmaker);
		}
	}
}
