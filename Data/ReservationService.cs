using System;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace WebApplication1.Data
{
    public class ReservationService
    {

        public bool GetReservationAsync(DateTime startDate,string message)
        {
            string path = String.Format(@"{0}/type1.txt", Directory.GetCurrentDirectory());

            File.WriteAllText(path, message);
            
            Console.WriteLine("text written");
            return true;
        }
    }
}
