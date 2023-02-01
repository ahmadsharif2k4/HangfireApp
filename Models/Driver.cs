using Microsoft.AspNetCore.Identity;

namespace HangfireApp.Models
{
    public class Driver
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string DriverNumber { get; set; } = default!;
        public int Status { get; set; }
    }
}
