using System.ComponentModel;

namespace nitutz
{
    public enum LeadStatus
    {

        [Description("Lost")]
        Lost,
        [Description("Open")]
        Open,
        [Description("Move to Tenant")]
        MovetoTenant

    }
}