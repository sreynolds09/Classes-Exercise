namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car();
            carOne.Make = "Honda";
            carOne.Model = "Accord";
            carOne.Year = 2005;
            
            Console.WriteLine($"This is a {carOne.Make} {carOne.Model}, and it was made in the year {carOne.Year}.");
        }
    }
}
