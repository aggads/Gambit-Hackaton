using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Gambit.Models
{
	public class Startup
	{
		[Key]
		public string Tva { get; set; }
		public string StartupName { get; set; }
		public string FounderName { get; set; }
		public int CategoryID { get; set; }
		public Category Category { get; set; }

		public string Description { get; set; }
		public int Risk { get; set; }

		[DataType(DataType.Date)]
		public DateTime DeadLine { get; set; }

		public string UrlImage { get; set; }
		public int CollectedFund { get; set; }
		public int TargetGoal { get; set; }
		public ICollection<MiStartup> MiStartups { get; set; }

		public Startup()
		{
			MiStartups = new Collection<MiStartup>();
		}
	}

	public class Mi
	{
		[Key]
		public string RegisterNumber { get; set; }

		public ICollection<MiStartup> MiStartups { get; set; }

		public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
		public string AccountNumber { get; set; }

		public Mi()
		{
			MiStartups = new Collection<MiStartup>();
		}
	}

	public class MiStartup
	{
		public Startup Startup { get; set; }
		public Mi Mi { get; set; }
		[Key]
		public string Tva { get; set; }
		[Key]
		public string RegisterNumber { get; set; }
		public decimal AmountInvest{ get; set; }
	}

	public class Category
	{
		[Key]
		public int CategoryID { get; set; }
		public string Name { get; set; }
		public ICollection<Startup> Startups { get; set; }

		public Category()
		{
			Startups = new Collection<Startup>();
		}
	}
}