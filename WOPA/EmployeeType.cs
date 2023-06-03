using System.ComponentModel;

namespace WOPA
{


    public enum EmployeeType
    {
        [Description("Community Manager")]
        CommunityManager,
        [Description("Marketing Manager")]
        MarketingManager,
        [Description("Maintenance")]
        Maintenance,
        [Description("Finance Manager")]
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