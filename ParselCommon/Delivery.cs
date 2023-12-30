using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_GIT_TEAM.ParselCommon
{
    public class Delivery : IDelivery
    {
        public List<BoxOfParsels>? BoxParsels { get; set; }

        public void Delive()
        {
            //Якась логіка доставки посилок
            Console.WriteLine("The parcels have been delivered!");
        }

        public void ShowParsels()
        {
            if (BoxParsels != null) 
            { 
                Console.WriteLine("There are no parcels");
                return;
            }

            uint i = 0;
            foreach (BoxOfParsels Box in BoxParsels)
            {
                i++;
                Console.WriteLine($"Box {i}");
                foreach (Parsel parsel in Box.parsels)
                {
                    Console.WriteLine(parsel);
                }

                Console.WriteLine(string.Empty);
            }
        }
    }
}
