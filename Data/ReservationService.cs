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

            // This text is added only once to the file.
            if (!File.Exists(path)) 
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path)) 
                {
                    sw.WriteLine(message);
                }	
            }
            else{
                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path)) 
                {
                    sw.WriteLine(message);
                }	
            }
            
            Console.WriteLine("text written");
            return true;
        }
    }
}
