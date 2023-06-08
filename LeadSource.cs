using System.ComponentModel;

namespace nitutz
{

    public enum LeadSource
    {

        [Description("Space Center")]
        SpaceCenter,
        [Description("Spacing")]
        Spacing,
        [Description("Recomendation")]
        Recomendation,
        
        [Description("Website")]
        Website,
        [Description("Other")]
        Other

    }
}