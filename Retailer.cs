using System;
namespace SWENG421_Lab08
{
	public class Retailer
	{
        public int budget;

        public Retailer()
		{
			
		}

		public TV replenishTV(int budget)
		{
			if (budget > 0 && budget <= 200)
			{
				return new TV();
			}
			else if (budget > 200 && budget <= 300)
			{
				return new Smart_TV();
			}
			else if (budget > 300)
			{
				return new UltraHD_TV();
			}
			else
			{
				return null;
			}
		}
	}
}

