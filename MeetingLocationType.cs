using System.ComponentModel;

namespace nitutz
{

    public enum MeetingLocationType
    {

        [Description("Meeting Room")]
        MeetingRoom,
        [Description("Auditorium")]
        Auditorium,
        [Description("Balcony")]
        Balcony,
        [Description("Patio")]
        Patio,
        [Description("Boardroom")]
        Boardroom,
        [Description("Tribune")]
        Tribune

    }
}