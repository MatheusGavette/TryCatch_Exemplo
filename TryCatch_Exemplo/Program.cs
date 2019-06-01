using System;
using TryCatch_Exemplo.Entities;

namespace TryCatch_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Room Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/YY/yyyy)");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error inreservation: Checl-out date must be after check-in date");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/YY/yyyy)");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy");
                checkOut = DateTime.Parse(Console.ReadLine());

                String error = reservation.UpdateDates(checkIn, checkOut);

                if (error != null)
                {
                    Console.WriteLine("Erroe in reservation :" + error);
                }
                else
                {
                    Console.WriteLine("Reservation: " + reservation);
                }
            }

        }
    }
}
