using System;
namespace SWENG421_Lab08
{
	public sealed class UltraHD_TV : TV
	{
		public UltraHD_TV()
		{
			price = 400;
			type = "Ultra HD TV";
		}

		public UltraHD_TV(int p, String t)
		{
			this.price = p;
			this.type = t;
		}
	}
}

