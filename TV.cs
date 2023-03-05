using System;
namespace SWENG421_Lab08
{
    public class TV : TV_IF
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

        public int getPrice()
        {
            return price;
        }

        public void setPrice(int price)
        {
            this.price = price;
        }

        public String getType()
        {
            return type;
        }

        public void setType(String type)
        {
            this.type = type;
        }

        public String getInfo()
        {
            return "Type: " + type + " Price: " + price;
        }
    }
}
