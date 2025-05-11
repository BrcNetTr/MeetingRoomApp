using Entities.Models.Common;

namespace Entities.Models;
public class Room:BaseEntity<Guid>
{
    public string RoomName { get; set; }
    public int NumberOSeats { get; set; }
   
}