namespace SWENG421_Lab08;

public class Program
{
    public static void Main(String[] args)
    {
        Retailer retailer = new Retailer();
        Vizio vizio = new Vizio();
        Sony sony = new Sony();

        // create each Vizio TV object
        TV Vizio_TV = new TV(250, "Vizio TV");
        Smart_TV Vizio_Smart_TV = new Smart_TV(350, "Vizio Smart TV");
        UltraHD_TV Vizio_UltraHD_TV = new UltraHD_TV(450, "Vizio Ultra HD TV");

        // create each Sony TV object
        TV Sony_TV = new TV(280, "Sony TV");
        Smart_TV Sony_Smart_TV = new Smart_TV(380, "Sony Smart TV");
        UltraHD_TV Sony_UltraHD_TV = new UltraHD_TV(480, "Sony Ultra HD TV");

        // set power consumption for the smart TV's
        Vizio_Smart_TV.setPowerUsage(6.35);
        Sony_Smart_TV.setPowerUsage(5.15);

        TV tv = retailer.replenishTV(320);

        Console.WriteLine(tv.getInfo());
    }
}
