namespace WOPA
{

public enum LeadSource
    {
        [Description("Space Cenoter")]
        CommunityManager,
        [Description("Spacing")]
        MarketingManager,
        [Description("Recomendation")]
        MarketingManager,
        [Description("Website")]
        MarketingManager,
        [Description("Other")]
        FinanceManager
    }

    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute));

            return attribute?.Description ?? value.ToString();
        }





    }



}