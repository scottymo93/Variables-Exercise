namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "Scott";
            int myAge = 32;
            double ave = 98.6;
            decimal bankAccount = 10000.00m;
            char initial = 's';
            bool isMarried = true;
            
            Console.WriteLine($"Name: {myName}\nAge: {myAge}\nAverage: {ave}\nMoney: {bankAccount}\nInitial: {initial}\nMarried: {isMarried}");
        }
    }
}
