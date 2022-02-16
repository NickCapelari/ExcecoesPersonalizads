using ExcecoesPesonalisadas.Entities;

Console.Write("Room Numer: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Check-in Date (dd/MM/yyyy): ");
DateTime checkIn = DateTime.Parse(Console.ReadLine());

Console.Write("Check-out Date (dd/MM/yyyy): ");
DateTime checkOut = DateTime.Parse(Console.ReadLine());

if (checkOut <= checkIn) {
    Console.WriteLine("Erro na reserva Check Out maior que Check In");
}
else { 
Reservation reservation = new Reservation(number, checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);

    Console.WriteLine();
    Console.WriteLine("Enter data to update the reservation");
    Console.Write("Check-in Date (dd/MM/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine());

    Console.Write("Check-out Date (dd/MM/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine());

    string error = reservation.UpdateDates(checkIn, checkOut);
    if (error != null) {
        Console.WriteLine(error);
    }
    else
    {
        reservation.UpdateDates(checkIn, checkOut);
        Console.WriteLine("Reservation: " + reservation);
    }

}