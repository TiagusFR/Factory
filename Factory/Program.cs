namespace Factory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cartesianPoint = PointFactory.NewCartesianPoint(3, 4);
            var polarPoint = PointFactory.NewPolarPoint(5, Math.PI / 4);

        }
    }
}