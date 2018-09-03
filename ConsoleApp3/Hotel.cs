using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Hotel
    {
        static void Main(string[] args)
        {
            Room room = new Room(); 

            Console.WriteLine("Which room do you want to check the payment status for?");
            //store room number input in a variable to use as display and check list for status.
            int inputRoomNumber = int.Parse(Console.ReadLine());

            //Display different results for the boolean value payment TRUE or FALSE -> PAID and OPEN.
            if (room.listPayments[inputRoomNumber] == true)
            {
                Console.WriteLine("The payment status for room number " + inputRoomNumber + " is PAID.");
            }
            else
            {
                Console.WriteLine("The payment status for room number " + inputRoomNumber + " is OPEN.");
            }


            /*
            room.Paid = bool.Parse(Console.ReadLine());

            if (room.Paid)
            {
                Console.WriteLine("Room has been paid for.");
            }
            else
            {
                Console.WriteLine("Room has open payments");
               
            }

           //Check list and print to see the values and the number index.  
              for (int i=0; i< room.listPayments.Count; i++)
              {
                  Console.WriteLine($"{i} = {room.listPayments[i]}");
              }

              bool CheckingPaidRooms(bool value)
              {
                  if (value == true)
                      return true;
                  else
                      return false;
              }
              
            //Predicate for FindAll
            bool CheckingPaidRooms(bool value)
            {
                if (value == true)
                    return true;
                else
                    return false;
            }

            //FindAll but figurin out how to get the index of the results. 
            List<bool> paidPayments = room.listPayments.FindAll(CheckingPaidRooms);
            foreach (var i in paidPayments)
            {
                Console.WriteLine($"{i}= {paidPayments}");
            }
            */
            Console.ReadLine();


        }

    }
}
