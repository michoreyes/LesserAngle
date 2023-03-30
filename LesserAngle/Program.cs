namespace LesserAngle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hours (0-23): ");
            int hour = int.Parse(Console.ReadLine());   //getting the value of hour
            Console.Write("Enter minutes (0-59): ");
            int min = int.Parse(Console.ReadLine());   //getting the value of minutes
            Console.WriteLine(angleclock(hour, min));

        }
        public static double angleclock(int hour, int min)
        {
            double hourarm = (hour % 12) * 30 + (double)min / 2;    // to calculate where the hour arm is pointing
            double minarm = min * 6;    // to calculate where the min arm is pointing
            double angle = Math.Abs(hourarm - minarm);   //to calculate the absolute difference of the two arm
            double less = Math.Min(angle, 360 - angle);     //to find the lesser angle
            
            return less; 

        }
    }
}