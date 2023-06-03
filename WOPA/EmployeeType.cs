using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOPA;

public enum EmployeeType
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