class Room
{
    public int roomId = 1;
    public string roomBookedBy = "No User Has Booked This Room Yet";
    public DateTime startDateTime;
    public DateTime endDateTime;

    public Room()
    {

    }
    public Room(int roomId, string roomBookedBy = "Ram")
    {
        this.roomId = roomId;
        this.roomBookedBy = roomBookedBy;
        this.startDateTime = DateTime.Now;
        this.endDateTime = DateTime.Now.AddDays(2);
    }

    public string UpdateOwner(string roomBookedBy)
    {
        this.roomBookedBy = roomBookedBy;
        return roomBookedBy;
    }
    public string GetOwner()
    {
        return this.roomBookedBy;
    }

    public string UpdateBookingDateTime(DateTime fromDate, DateTime toDate)
    {
        this.startDateTime = fromDate;
        this.endDateTime = toDate;
        return $"Room {this.roomId} has been booked by {this.roomBookedBy}, and booking time has been updated from {fromDate} to {toDate}";
    }
    //Expression bodied member
    public string PrintMessage() => $"Room {this.roomId} has been booked by {this.roomBookedBy}, and booking time has been updated from {this.startDateTime} to {this.endDateTime}";

}