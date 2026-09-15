namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "Noah";
            int myAge = 28;
            char inital = 'N';
            bool isMarried = true; 
          double avg = 98.7;
          decimal bankAccount = 10000.00m;

            Console.WriteLine($"Name: {myName}\nAge: {myAge}\nAverage: {avg}\nMoney: {bankAccount}\nInitial: {inital}\nMarried: {isMarried}");

        }
    }
}
