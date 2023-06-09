using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
			IsAlive = true;
			LegCount = 4;
			LandSeaAir = "Land";
			Age = 0;
		}
		public bool IsColdBlooded { get; set; }
		public bool isScaly { get; set; }
		public string Habitat { get; set; }

		public bool CanGrowTail { get; set; }
	}
}

