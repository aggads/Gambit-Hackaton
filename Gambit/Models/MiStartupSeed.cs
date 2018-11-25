using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Gambit.Models
{
	public static class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new MiStartupContext(
				serviceProvider.GetRequiredService<DbContextOptions<MiStartupContext>>()))
			{
				// Look for any microinvestors.
				if (context.MiStartup.Any())
				{
					return;   // DB has been seeded
				}

				context.Category.AddRange(
						new Category
						{
							Name = "Finance"
						},
						new Category
						{
							Name = "IoT"
						},
						new Category
						{
							Name = "Robotic"
						}
					);

				context.SaveChanges();
				// On suppose que les numéros de comptes sont uniques
				context.Mi.AddRange(
					new Mi
					{
						RegisterNumber = "10145678901",
						Name = "Nathan Ford",
						BirthDate = DateTime.Parse("2020-1-11"),
						AccountNumber = "BE99 38756482",
					},

					 new Mi
					 {
						 RegisterNumber = "23578946825",
						 Name = "Josephine Jacksons",
						 BirthDate = DateTime.Parse("2020-1-11"),
						 AccountNumber = "BE99 38756482",
					 },

					 new Mi
					 {
						 RegisterNumber = "34285462573",
						 Name = "Laura Lovelace",
						 BirthDate = DateTime.Parse("2020-1-11"),
						 AccountNumber = "BE99 38756482",
					 },

				   new Mi
				   {
					   RegisterNumber = "40956147274",
					   Name = "Dereck Swartz",
					   BirthDate = DateTime.Parse("2020-1-11"),
					   AccountNumber = "BE99 38756482",
				   },

					new Mi
					{
						RegisterNumber = "59969873252",
						Name = "Laila Gonzalez",
						BirthDate = DateTime.Parse("2020-1-11"),
						AccountNumber = "BE99 38756482",
					},

					new Mi
					{
						RegisterNumber = "69935687431",
						Name = "Letitia Price",
						BirthDate = DateTime.Parse("2020-1-11"),
						AccountNumber = "BE99 38756482",
					},

					new Mi
					{
						RegisterNumber = "74545681302",
						Name = "Ian Lockheed",
						BirthDate = DateTime.Parse("2020-1-11"),
						AccountNumber = "BE99 38756482",
					},

					new Mi
					{
						RegisterNumber = "82535782451",
						Name = "Zora Crawford",
						BirthDate = DateTime.Parse("2020-1-11"),
						AccountNumber = "BE99 38756482",
					},

					new Mi
					{
						RegisterNumber = "92948652791",
						Name = "Randy Coleman",
						BirthDate = DateTime.Parse("2020-1-11"),
						AccountNumber = "BE99 38756482",
					},

					new Mi
					{
						RegisterNumber = "10998534795",
						Name = "Elise Hamilton",
						BirthDate = DateTime.Parse("2020-1-11"),
						AccountNumber = "BE99 38756482",
					}
				);
				// On suppose que le fond collecté est calculé et ajouté à la DB
				context.Startup.AddRange(
					 new Startup
					 {
						 Tva = "BE12 34567899",
						 StartupName = "Locky's Palace",
						 FounderName = "Bob Dallas",
						 CategoryID = 1,
						 UrlImage = "~/images/Finance/Financial-Management.jpg",
						 Description = "A web startup \n Made for adult people to date and find the one they need" +
						 "or for casual meetups. A wonderful new implementation that you've never imagined before",
						 Risk = 3,
						 DeadLine = DateTime.Parse("2020-1-11"),
						 CollectedFund = 40322,
						 TargetGoal = 50000
					 },

					 new Startup
					 {
						 Tva = "BE21 34582899",
						 StartupName = "Dutch for Dummies",
						 FounderName = "Johnny Dutch",
						 CategoryID = 2,
						 UrlImage = "~/images/IoT/IoT-sphere.jpg",
						 Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec sit amet justo in nibh condimentum rutrum vitae vel magna. Maecenas vitae accumsan augue. Aliquam erat volutpat. Vivamus fermentum, risus at auctor iaculis, orci ante venenatis libero, non maximus nulla velit non nunc. Donec sollicitudin auctor felis in luctus. Fusce ultricies pellentesque interdum. Fusce porta, ante non eleifend condimentum, augue quam bibendum neque, porta pretium massa purus eu dui. In vulputate erat id ligula volutpat, at ultricies libero placerat. Donec ornare dolor eu mauris elementum malesuada in eu metus. Nunc in nisi eu neque elementum tempus. Etiam laoreet rhoncus aliquet.",
						 Risk = 0,
						 DeadLine = DateTime.Parse("2020-1-11"),
						 CollectedFund = 245,
						 TargetGoal = 50000
					 },

					 new Startup
					 {
						 Tva = "BE30 37282893",
						 StartupName = "Vegan-Deliveries",
						 FounderName = "Romain Vandeputte",
						 CategoryID = 3,
						 UrlImage = "~/images/Robotic/automation-robot.jpg",
						 Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec sit amet justo in nibh condimentum rutrum vitae vel magna. Maecenas vitae accumsan augue. Aliquam erat volutpat. Vivamus fermentum, risus at auctor iaculis, orci ante venenatis libero, non maximus nulla velit non nunc. Donec sollicitudin auctor felis in luctus. Fusce ultricies pellentesque interdum. Fusce porta, ante non eleifend condimentum, augue quam bibendum neque, porta pretium massa purus eu dui. In vulputate erat id ligula volutpat, at ultricies libero placerat. Donec ornare dolor eu mauris elementum malesuada in eu metus. Nunc in nisi eu neque elementum tempus. Etiam laoreet rhoncus aliquet.",
						 Risk = 0,
						 DeadLine = DateTime.Parse("2020-1-11"),
						 CollectedFund = 01,
						 TargetGoal = 50000
					 },

					 new Startup
					 {
						 Tva = "BE30 37952893",
						 StartupName = "Beard'O",
						 FounderName = "Marius Luigi",
						 CategoryID = 1,
						 UrlImage = "~/images/Finance/int-web.jpg",
						 Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec sit amet justo in nibh condimentum rutrum vitae vel magna. Maecenas vitae accumsan augue. Aliquam erat volutpat. Vivamus fermentum, risus at auctor iaculis, orci ante venenatis libero, non maximus nulla velit non nunc. Donec sollicitudin auctor felis in luctus. Fusce ultricies pellentesque interdum. Fusce porta, ante non eleifend condimentum, augue quam bibendum neque, porta pretium massa purus eu dui. In vulputate erat id ligula volutpat, at ultricies libero placerat. Donec ornare dolor eu mauris elementum malesuada in eu metus. Nunc in nisi eu neque elementum tempus. Etiam laoreet rhoncus aliquet.",
						 Risk = 8,
						 DeadLine = DateTime.Parse("2020-1-11"),
						 CollectedFund = 1874,
						 TargetGoal = 50000
					 },

				   new Startup
				   {
					   Tva = "BE51 33433793",
					   StartupName = "square.com",
					   FounderName = "Sara Cooper",
					   CategoryID = 2,
					   UrlImage = "~/images/IoT/metamorworks.jpg",
					   Description = "Online startup where you can buy/sell items \n" +
					   "obviously not the only one, but the layout and interactive way make it a one-of-a-kind experience which is promising",
					   Risk = 3,
					   DeadLine = DateTime.Parse("2020-1-11"),
					   CollectedFund = 999,
					   TargetGoal = 50000
				   },

				   new Startup
				   {
					   Tva = "BE61 33433793",
					   StartupName = "Metal Owl",
					   FounderName = "Douglas Wilson",
					   CategoryID = 1,
					   UrlImage = "~/images/Finance/G10274-EC.jpg",
					   Description = "High-end headphones \n The best of it's kind both for relaxing and the most intense hardcore experience " +
					   "you would want to get for music. Truly unmatched",
					   Risk = 3,
					   DeadLine = DateTime.Parse("2020-1-11"),
					   CollectedFund = 854,
					   TargetGoal = 50000
				   },

				   new Startup
				   {
					   Tva = "BE71 33433793",
					   StartupName = "coffee.com",
					   FounderName = "Diana Myers",
					   CategoryID = 3,
					   UrlImage = "~/images/Robotic/fso-insights.jpg",
					   Description = "A company build solely to honour coffee \n " +
					   "How is this not a thing? Long live coffee, may we never sleep again. Planning to install the best kind of coffee-machines" +
					   "on every street corner in the world, it's simply amazing",
					   Risk = 3,
					   DeadLine = DateTime.Parse("2020-1-11"),
					   CollectedFund = 7568,
					   TargetGoal = 50000
				   },

				   new Startup
				   {
					   Tva = "BE81 33433793",
					   StartupName = "Matrix",
					   FounderName = "Neo Anderson",
					   CategoryID = 2,
					   UrlImage = "~/images/IoT/practices-IoT.jpg",
					   Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec sit amet justo in nibh condimentum rutrum vitae vel magna. Maecenas vitae accumsan augue. Aliquam erat volutpat. Vivamus fermentum, risus at auctor iaculis, orci ante venenatis libero, non maximus nulla velit non nunc. Donec sollicitudin auctor felis in luctus. Fusce ultricies pellentesque interdum. Fusce porta, ante non eleifend condimentum, augue quam bibendum neque, porta pretium massa purus eu dui. In vulputate erat id ligula volutpat, at ultricies libero placerat. Donec ornare dolor eu mauris elementum malesuada in eu metus. Nunc in nisi eu neque elementum tempus. Etiam laoreet rhoncus aliquet.",
					   Risk = 3,
					   DeadLine = DateTime.Parse("2020-1-11"),
					   CollectedFund = 42,
					   TargetGoal = 50000
				   },

				   new Startup
				   {
					   Tva = "BE81 33448793",
					   StartupName = "Pulp Mixion",
					   FounderName = "Samael L Jackson",
					   CategoryID = 2,
					   UrlImage = "~/images/IoT/Untitled-design.jpg",
					   Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec sit amet justo in nibh condimentum rutrum vitae vel magna. Maecenas vitae accumsan augue. Aliquam erat volutpat. Vivamus fermentum, risus at auctor iaculis, orci ante venenatis libero, non maximus nulla velit non nunc. Donec sollicitudin auctor felis in luctus. Fusce ultricies pellentesque interdum. Fusce porta, ante non eleifend condimentum, augue quam bibendum neque, porta pretium massa purus eu dui. In vulputate erat id ligula volutpat, at ultricies libero placerat. Donec ornare dolor eu mauris elementum malesuada in eu metus. Nunc in nisi eu neque elementum tempus. Etiam laoreet rhoncus aliquet.",
					   Risk = 4,
					   DeadLine = DateTime.Parse("2020-1-11"),
					   CollectedFund = 42,
					   TargetGoal = 50000
				   },

				   new Startup
				   {
					   Tva = "BE91 33433793",
					   StartupName = "Juniper Cars",
					   FounderName = "Cynthya Fox",
					   CategoryID = 1,
					   UrlImage = "~/images/Finance/about-center.jpg",
					   Description = "Selling Brand Cars, as fast and as sexy as a Fox \n ",
					   Risk = 3,
					   DeadLine = DateTime.Parse("2020-1-11"),
					   CollectedFund = 1,
					   TargetGoal = 50000
				   },

				   new Startup
				   {
					   Tva = "BE10 33433793",
					   StartupName = "zombo.com",
					   FounderName = "Derik Wolfson",
					   CategoryID = 1,
					   UrlImage = "~/images/Finance/Finance-1.jpg",
					   Description = "A startup that inspires people to reach further and be all right \n ",
					   Risk = 3,
					   DeadLine = DateTime.Parse("2020-1-11"),
					   CollectedFund = 12,
					   TargetGoal = 50000
				   },

				   new Startup
				   {
					   Tva = "BE11 33433793",
					   StartupName = "square.com",
					   FounderName = "Eric Deere",
					   CategoryID = 2,
					   UrlImage = "~/images/IoT/iot-implementation.jpg",
					   Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec sit amet justo in nibh condimentum rutrum vitae vel magna. Maecenas vitae accumsan augue. Aliquam erat volutpat. Vivamus fermentum, risus at auctor iaculis, orci ante venenatis libero, non maximus nulla velit non nunc. Donec sollicitudin auctor felis in luctus. Fusce ultricies pellentesque interdum. Fusce porta, ante non eleifend condimentum, augue quam bibendum neque, porta pretium massa purus eu dui. In vulputate erat id ligula volutpat, at ultricies libero placerat. Donec ornare dolor eu mauris elementum malesuada in eu metus. Nunc in nisi eu neque elementum tempus. Etiam laoreet rhoncus aliquet.",
					   Risk = 3,
					   DeadLine = DateTime.Parse("2020-1-11"),
					   CollectedFund = 342,
					   TargetGoal = 50000
				   },

					new Startup
					{
						Tva = "BE12 33433793",
						StartupName = "FreshFruits",
						FounderName = "Anna Duchaussée",
						CategoryID = 3,
						UrlImage = "~/images/Robotic/robotic-automation.jpg",
						Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec sit amet justo in nibh condimentum rutrum vitae vel magna. Maecenas vitae accumsan augue. Aliquam erat volutpat. Vivamus fermentum, risus at auctor iaculis, orci ante venenatis libero, non maximus nulla velit non nunc. Donec sollicitudin auctor felis in luctus. Fusce ultricies pellentesque interdum. Fusce porta, ante non eleifend condimentum, augue quam bibendum neque, porta pretium massa purus eu dui. In vulputate erat id ligula volutpat, at ultricies libero placerat. Donec ornare dolor eu mauris elementum malesuada in eu metus. Nunc in nisi eu neque elementum tempus. Etiam laoreet rhoncus aliquet.",
						Risk = 2,
						DeadLine = DateTime.Parse("2020-1-11"),
						CollectedFund = 3251,
						TargetGoal = 50000
					},

					new Startup
					{
						Tva = "BE13 33433793",
						StartupName = "All-in",
						FounderName = "Jenkins Leeroy",
						CategoryID = 3,
						UrlImage = "~/images/Robotic/robotic-hand.jpg",
						Description = "Leeeeeeeeeeroooooooooooy...",
						Risk = 4,
						DeadLine = DateTime.Parse("2020-1-11"),
						CollectedFund = 9001,
						TargetGoal = 50000
					},
				   new Startup
				   {
					   Tva = "BE41 33433793",
					   StartupName = "Orteil Inc.",
					   FounderName = "Orteil Debrouwere",
					   CategoryID = 3,
					   UrlImage = "~/images/Robotic/robotic-process.jpg",
					   Description = "Making Cookies! \n clicking cookies, hiring grandma's for cookies, farming cookies, mining, factories, etc..." +
					   "practically nothing could go wrong, cookies ftw. Once in a while we produce a limited amount of golden cookies, be sure to check us out!",
					   Risk = 0,
					   DeadLine = DateTime.Parse("2020-1-11"),
					   CollectedFund = 999999999,
					   TargetGoal = 50000
				   }
					);

				context.SaveChanges();

				context.MiStartup.AddRange(
						new MiStartup
						{
							Tva = "BE13 33433793",
							RegisterNumber = "92948652791",
							AmountInvest = 10
						},

					new MiStartup
					{
						Tva = "BE13 33433793",
						RegisterNumber = "69935687431",
						AmountInvest = 20
					},

					new MiStartup
					{
						Tva = "BE13 33433793",
						RegisterNumber = "34285462573",
						AmountInvest = 25
					},

					new MiStartup
					{
						Tva = "BE12 33433793",
						RegisterNumber = "34285462573",
						AmountInvest = 70
					},

					new MiStartup
					{
						Tva = "BE12 33433793",
						RegisterNumber = "69935687431",
						AmountInvest = 40
					},

					new MiStartup
					{
						Tva = "BE12 33433793",
						RegisterNumber = "92948652791",
						AmountInvest = 50
					},

					new MiStartup
					{
						Tva = "BE12 33433793",
						RegisterNumber = "40956147274",
						AmountInvest = 100
					},

					new MiStartup
					{
						Tva = "BE71 33433793",
						RegisterNumber = "92948652791",
						AmountInvest = 80
					},

					new MiStartup
					{
						Tva = "BE91 33433793",
						RegisterNumber = "69935687431",
						AmountInvest = 10
					},

					new MiStartup
					{
						Tva = "BE91 33433793",
						RegisterNumber = "40956147274",
						AmountInvest = 5
					},

					new MiStartup
					{
						Tva = "BE91 33433793",
						RegisterNumber = "34285462573",
						AmountInvest = 9
					},

					new MiStartup
					{
						Tva = "BE91 33433793",
						RegisterNumber = "10998534795",
						AmountInvest = 45
					}
					);

				context.SaveChanges();
			}
		}
	}
}