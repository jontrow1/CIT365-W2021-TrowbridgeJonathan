using System;

namespace MegaDesk
{
    public class DeskQuote
    {
        public string name;
        public string date;
        public string delivery;
        public double rushCost;
        public Desk desk;
        public double totalCost;
        public double sizeCost;
        public double drawerCost;
        public double materialCost;

        public DeskQuote()
        {
            name = string.Empty;
            date = string.Empty;
            delivery = string.Empty;
        }

        public double calculateSize()
        {
            sizeCost = 0;
            if (desk.calculateArea() > 1000)
            {
                sizeCost = desk.area - 1000;
            }
            return sizeCost;
        }

        public double calculateDrawer()
        {
            drawerCost = desk.drawerNumber * 50;
            return drawerCost;
        }

        public double calculateMaterial()
        {
            switch (desk.surfaceType)
            {
                case "Laminate":
                    materialCost = 100;
                    break;
                case "Oak":
                    materialCost = 200;
                    break;
                case "Rosewood":
                    materialCost = 300;
                    break;
                case "Veneer":
                    materialCost = 125;
                    break;
                case "Pine":
                    materialCost = 50;
                    break;
            }
            return materialCost;
        }

        public double calculateRush()
        {
            rushCost = 0;
            try
            {
                switch (delivery)
                {
                    case "3 Days":
                        if (desk.area < 1000)
                        {
                            rushCost = 60;
                        } else if (desk.area > 2000)
                        {
                            rushCost = 80;
                        } else
                        {
                            rushCost = 70;
                        }
                        break;
                    case "5 Days":
                        if (desk.area < 1000)
                        {
                            rushCost = 40;
                        }
                        else if (desk.area > 2000)
                        {
                            rushCost = 60;
                        }
                        else
                        {
                            rushCost = 50;
                        }
                        break;
                    case "7 Days":
                        if (desk.area < 1000)
                        {
                            rushCost = 30;
                        }
                        else if (desk.area > 2000)
                        {
                            rushCost = 40;
                        }
                        else
                        {
                            rushCost = 35;
                        }
                        break;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return rushCost;
        }

        public double calculatePrice()
        {
            totalCost = 200 + calculateSize() + calculateDrawer() + calculateRush() + calculateMaterial();

            return totalCost;
        }
    }
}
