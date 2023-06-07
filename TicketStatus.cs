using System.ComponentModel;

namespace nitutz
{
    public enum TicketStatus
    {
        [Description("Pending")]
        Pending,
        [Description("Open")]
        Open,
        [Description("Resolved")]
        Resolved

    }
}
