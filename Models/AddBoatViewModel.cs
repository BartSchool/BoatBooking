using Microsoft.Build.Framework;
using Microsoft.Data.SqlClient;

namespace BoatBooking.Models
{
    public class AddBoatViewModel
    {
        [Required] public string? name { get; set; }
        [Required] public string? type { get; set; }
        public int? minWeight { get; set; }
        public int? maxWeight { get; set; }
        public string? authorised { get; set; }
    }
}
