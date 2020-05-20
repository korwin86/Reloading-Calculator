namespace ReloadingCalc
{
    //Патрон          Комплектующие, навеска пороха и дроби. МЕТОД Цена патрона\сколько патронов из пороха-дроби
    class Shotshells
    {

        public double ShotCharge { get; set; } //Навеска дроби
        public double PriceHull { get; set; }
        public double PricePowder { get; set; }
        public double PricePrimer { get; set; }
        public double PriceShot { get; set; }
        public double PriceWad { get; set; }
        public double Price(double priceHull, double pricePowder, double pricePrimer, double priceShot, double priceWad)
        {

            PriceHull = priceHull;
            PricePowder = pricePowder;
            PricePrimer = pricePrimer;
            PriceShot = priceShot;
            PriceWad = priceWad;

            double result = PriceHull + PricePowder + PricePrimer + PriceShot + PriceWad;

            return result;
        }

        //  Сколько патронов из пороха. Масса пороха в банке/навеска пороха*количество банок пороха
        public int ShotshellsOnPowder(int powderVolume, double powderCharge, int powderQuantity)
        {

            int result = (int)(powderVolume / powderCharge * powderQuantity);
            return result;
        }

        // Сколько патронов получится из дроби. Масса дроби в кг переводим в граммы и делим на навеску
        public int ShotshellsOnShot(int weight, double shotCharge)
        {
            ShotCharge = shotCharge;
            int result = (int)(weight * 1000 / ShotCharge);
            return result;
        }

    }
}
