namespace Lib
{
    public abstract class Garden : Site
    {
        public double area { get; set; }
        public double length { get; set; }
        public double width { get; set; }


        public string digUp() 
        { 
            return "You're digging a garden";
        }


        public string sow()
        {
            return "You plant seeds";
        }


        public abstract string harvest();
    }
}
