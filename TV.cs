using System;
namespace SWENG421_Lab08
{
    public class TV
    {
        protected int price;
        protected String type;

        public TV()
        {
            this.price = 200;
            this.type = "TV";
        }

        public TV(int p, String t)
        {
            this.price = p;
            this.type = t;
        }

        int getPrice()
        {
            return price;
        }

        void setPrice(int price)
        {
            this.price = price;
        }

        String getType()
        {
            return type;
        }

        public void setType(String brand)
        {
            this.type = brand;
        }

        public String getInfo()
        {
            return "Type: " + type + " Price: " + price;
        }
    }
}
