﻿using System.ComponentModel;

namespace nitutz
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
}

