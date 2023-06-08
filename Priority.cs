using System.ComponentModel;

namespace nitutz
{
    public enum Priority
    {
         [Description("Low")]
        Low , 
        [Description("Normal")]
        Normal , 
        [Description("Urgent")]
        Urgent
    }
}
