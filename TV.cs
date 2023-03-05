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

        public int getPrice()
        {
            return price;
        }

        void setPrice(int price)
        {
            this.price = price;
        }

        public String getBrand()
        {
            return type;
        }

        public void setBrand(String brand)
        {
            this.type = brand;
        }

        public String getInfo()
        {
            return "Brand: " + type + " Price: " + price;
        }
    }
}
