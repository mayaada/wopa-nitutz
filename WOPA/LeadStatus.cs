using System.ComponentModel;

namespace WOPA
{
    public enum LeadStatus
    {
        Lost, 
        Open,
        [Description("Move To Tenant")]
        MoveToTenant

    }
}
