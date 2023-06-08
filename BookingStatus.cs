using System.ComponentModel;

namespace nitutz
{
    public enum BookingStatus
    {
        [Description("Pending")]
        Pending,
        [Description("Approved")]
        Approved,
        [Description("Declined")]
        Declined,   
        [Description("Deleted")]
        Deleted
    }
}