namespace ReloadingCalc.Components
{
    //Порох           Цена банки\Количество банок\Количество в банке\Общая цена
    public class Powders : IComponents
    {
        public double Price { get; set; } //Цена банки пороха
        public int Quantity { get; set; } //Количество банок
        public int Volume { get; set; } // Масса пороха в банке
        public double PowderCharge { get; set; } //Навеска пороха

        public double AllPrice(double price, int quantity)
        {
            Price = price;
            Quantity = quantity;
            double result = Price * Quantity;
            return result;
        }
    }
}
