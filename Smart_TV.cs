using System;
namespace SWENG421_Lab08
{
	// "sealed" is equivalent to "final" in Java
	public sealed class Smart_TV : TV
	{
		private double powerUsage;

		public Smart_TV()
		{
			price = 300;
			type = "Smart TV";
		}

		public Smart_TV(int p, String t)
		{
			this.price = p;
			this.type = t;
		}

		public void setPowerUsage(double pow)
		{
			this.powerUsage = pow;
		}

		// returns power usage in watts per hour
		double getPowerUsage()
		{
			return 5.5;
		}
	}
}

