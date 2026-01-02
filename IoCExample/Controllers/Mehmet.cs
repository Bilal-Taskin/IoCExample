using IoCExample.Interface;

namespace IoCExample.Controllers
{
    public class Mehmet : INameCaller
    {
        public string NameCaller()
        {
            return "Mehmet";
        }
    }
}
