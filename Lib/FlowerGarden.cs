namespace Lib
{
    internal class FlowerGarden : Garden
    {
        private int numOfPlants { get; set; }

        public override string harvest()
        {
            return "You're harvesting beutifuly";
        }

        public double costOfHarvest(double unitPrice, int quantity)
        {
            return unitPrice * quantity;
        }
    }
}
