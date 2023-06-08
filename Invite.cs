using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // winform
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using nitutz;
namespace nitutz
{
    public class Invite
    {
        private Tenant tenant;
        private Event eventName;


        public Invite(Tenant tenant, Event eventName)
        {
            this.tenant = tenant;
            this.eventName = eventName;
        }

        public Tenant getTenant()
        {
            return this.tenant;

        }

        public void setTenant(Tenant tenant)
        {
            this.tenant = tenant;
        }

        public Event getEventName()
        {
            return this.eventName;
        }

        public void setEventName(Event eventName)
        {
            this.eventName = eventName;



        }

        public void addInvite()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Add_Invite @Tenant_Name, @Event_Name";
            c.Parameters.AddWithValue("@Tenant_Name", tenant);
            c.Parameters.AddWithValue("@Event_Name", eventName);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void deleteInvite()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Delete_Invite @Tenant_Name, @Event_Name";
            c.Parameters.AddWithValue("@Tenant_Name", tenant);
            c.Parameters.AddWithValue("@Event_Name", eventName);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void updateInvite()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Update_Invite @Tenant_Name, @Event_Name";
            c.Parameters.AddWithValue("@Tenant_Name", tenant);
            c.Parameters.AddWithValue("@Event_Name", eventName);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}
