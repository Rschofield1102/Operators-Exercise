namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create two integar variables


            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remander = a % b;
            var sum = a + b;
            var sum1 = a - b;


            Console.WriteLine($"{a} + {b} is {sum}");
            Console.WriteLine($"{a} - {b} is {sum1}");
            Console.WriteLine($"{a} is / {b} is {quotient} remander {remander}");
            Console.WriteLine($"{a} % {b} is {remander}");
            Console.WriteLine($"{a} / {b} is {quotient}");

            Console.WriteLine("enter radius");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);
            


            Console.WriteLine(AreaOfCircle(radius));

        }

        //method to calculate radius of circle


        public static Double AreaOfCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;

            






        }

            
            

    }
}
