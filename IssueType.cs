using System.ComponentModel;

namespace nitutz
{
    public enum IssueType
    {
        [Description("Maintenance")]
        Maintenance,
        [Description("IT")]
        IT,
        [Description("Cleaning")]
        Cleaning
    }
}