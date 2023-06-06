using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // winform
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using nitutz;
namespace nitutz
{
    internal class Invite
    {
        private Tenant Tenant;
        private Event EventName;


        public Invite(Tenant tenant, Event eventName)
        {
            this.Tenant = tenant;
            this.EventName = eventName;
        }

        public Tenant getTenant()
        {
            return Tenant;

        }

        public void setTenant(Tenant tenant)
        {
            Tenant = tenant;
        }

        public Event getEventName()
        {
            return EventName;
        }

        public void setEventName(Event eventName)
        {
            EventName = eventName;



        }

        public void addInvite()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Add_Invite @Tenant_Name, @Event_Name";
            c.Parameters.AddWithValue("@Tenant_Name", Tenant);
            c.Parameters.AddWithValue("@Event_Name", EventName);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void deleteInvite()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Delete_Invite @Tenant_Name, @Event_Name";
            c.Parameters.AddWithValue("@Tenant_Name", Tenant);
            c.Parameters.AddWithValue("@Event_Name", EventName);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void updateInvite()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Update_Invite @Tenant_Name, @Event_Name";
            c.Parameters.AddWithValue("@Tenant_Name", Tenant);
            c.Parameters.AddWithValue("@Event_Name", EventName);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}
