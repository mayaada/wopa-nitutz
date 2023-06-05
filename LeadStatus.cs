using System.ComponentModel;

namespace nitutz
{
    public enum LeadStatus
    {
        Lost,
        Open,
        [Description("Move To Tenant")]
        MoveToTenant

    }
}