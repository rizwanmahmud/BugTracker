using System;

namespace BugTracker.Models
{
    public class Bug
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime Opened { get; set; } = DateTime.Now;

        public string AssignedTo { get; set; } = string.Empty;
    }
}