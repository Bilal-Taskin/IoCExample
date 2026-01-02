using IoCExample.Interface;

namespace IoCExample.Controllers
{
    public class Ahmet : INameCaller
    {
        Random rnd = new Random();

        int number;
        public Ahmet()
        {
            number = rnd.Next(1, 100);
            //Console.WriteLine($"Ahmet created with number: {number}");
        }
        public string NameCaller()
        {
            return $"Ahmet {number} ";
        }
    }
}
