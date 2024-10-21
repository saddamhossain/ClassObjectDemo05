ParkingSpot parkingSpot = new ParkingSpot(1);

if (parkingSpot.ParkVehicle("Car"))
{
    Console.WriteLine($"Vehicle 'Car' parked in spot {parkingSpot.SpotNumber}.");
}
else
{
    Console.WriteLine($"Spot {parkingSpot.SpotNumber} is already occupied.");
}


if (!parkingSpot.ParkVehicle("Motorcycle"))
{
    Console.WriteLine($"Cannot park Motorcycle. Spot {parkingSpot.SpotNumber} is already occupied by a {parkingSpot.VehicleType}.");
}


if (parkingSpot.RemoveVehicle())
{
    Console.WriteLine($"Vehicle removed from spot {parkingSpot.SpotNumber}.");
}


if (parkingSpot.IsAvailable())
{
    Console.WriteLine($"Spot {parkingSpot.SpotNumber} is available for parking.");
}


if (parkingSpot.ParkVehicle("Truck"))
{
    Console.WriteLine($"Vehicle 'Truck' parked in spot {parkingSpot.SpotNumber}.");
}