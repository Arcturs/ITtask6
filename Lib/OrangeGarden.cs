namespace Lib
{
    internal class OrangeGarden : Garden
    {
        private int numOfPlants { get; set; }

        public override string harvest()
        {
            return "You're harvesting in orange colours";
        }

        public double costOfHarvest(double unitPrice, int quantity)
        {
            return unitPrice * quantity;
        }
    }
}
