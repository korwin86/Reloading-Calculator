namespace ReloadingCalc.Components
{
    class Shots
    {
        //Дробь Цена кг\Количество кг\Общая цена
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int Weight { get; set; }

        public double AllPrice(double price, int quantity, int weight)
        {
            Price = price;
            Quantity = quantity;
            Weight = weight;
            double result = Price * Quantity;
            return result;

        }
    }
}
