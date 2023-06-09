namespace Lib
{
    internal class AppleGarden : Garden
    {
        private int numOfPlants { get; set; }

        public override string harvest()
        {
            return "You're harvesting";
        }

        public double costOfHarvest(double unitPrice, int quantity)
        {
            return unitPrice * quantity;
        }
    }
}
