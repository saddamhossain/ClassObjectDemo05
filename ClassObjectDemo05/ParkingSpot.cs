namespace ClassObjectDemo05;

public class ParkingSpot
{
    public int SpotNumber { get; private set; }
    public string VehicleType { get; private set; }
    public bool IsOccupied { get; private set; }

    public ParkingSpot(int spotNumber)
    {
        SpotNumber = spotNumber;
        VehicleType = string.Empty;
        IsOccupied = false;
    }

    public bool ParkVehicle(string vehicleType)
    {
        if (!IsOccupied)
        {
            VehicleType = vehicleType;
            IsOccupied = true;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool RemoveVehicle()
    {
        if (IsOccupied)
        {
            VehicleType = string.Empty;
            IsOccupied = false;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IsAvailable()
    {
        return !IsOccupied;
    }
}