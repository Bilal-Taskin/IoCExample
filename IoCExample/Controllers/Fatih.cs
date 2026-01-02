using IoCExample.Interface;

namespace IoCExample.Controllers
{
    public class Fatih : INameCaller
    {
        public string NameCaller()
        {
            return "Fatih";
        }
    }
}
