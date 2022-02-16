using ExcecoesPesonalisadas.Entities;
using ExcecoesPesonalisadas.Entities.Exceptions;

try
{
    Console.Write("Room Numer: ");
    int number = int.Parse(Console.ReadLine());

    Console.Write("Check-in Date (dd/MM/yyyy): ");
    DateTime checkIn = DateTime.Parse(Console.ReadLine());

    Console.Write("Check-out Date (dd/MM/yyyy): ");
    DateTime checkOut = DateTime.Parse(Console.ReadLine());


    Reservation reservation = new Reservation(number, checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);

    Console.WriteLine();
    Console.WriteLine("Enter data to update the reservation");
    Console.Write("Check-in Date (dd/MM/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine());

    Console.Write("Check-out Date (dd/MM/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine());

    reservation.UpdateDates(checkIn, checkOut);

    Console.WriteLine("Reservation: " + reservation);
}
catch (DomainException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine("Format Error: " + ex);
}
catch(Exception ex)
{
    Console.WriteLine("Unexpected Error: " + ex);
}

