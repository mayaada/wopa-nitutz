namespace WOPA
{
    public enum LeadStatus
    {
        [Description("Low")]
        CommunityManager,
        [Description("Open")]
        MarketingManager,
        [Description("Move To Tenant")]
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