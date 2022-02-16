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

    DateTime now = DateTime.Now;
    if (now < checkIn || checkOut < now) {
        Console.WriteLine("Error in reservation: Reservation Dates for update must be future datas");
    }
    else if (checkOut <= checkIn)
    {
        Console.WriteLine("Erro na reserva Check Out maior que Check In");
    }
    else
    {
        reservation.UpdateDates(checkIn, checkOut);
        Console.WriteLine("Reservation: " + reservation);
    }

}