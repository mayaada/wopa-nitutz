namespace WOPA
{

    public class Lead
    {
        private string companyName;
        private string contact;
        private string number;
        private string email;
        private DateTime dateOpened;
        private LeadStatus status;
        private int NumOfworkStation;
        private LeadSource source;
        private Employee Added_By;

        public Lead(string companyName, string contact, string number, string email, DateTime dateOpened, int workStation,
         LeadStatus status, LeadSource source, Employee Added_By, Boolean isNew)
        {
            this.companyName = companyName;
            this.contact = contact;
            this.number = number;
            this.email = email;
            this.dateOpened = dateOpened;
            this.status = status;
            this.NumOfworkStation = workStation;
            this.source = source;
            this.Added_By = Added_By;
            if (isNew)
            {
                createLead();
                Program.Lead.Add(this);
            }
        }

        public Lead(string? v1, string? v2, string? v3, string? v4, DateTime dateTime, Func<string?> toString, LeadStatus leadStatus, LeadSource leadSource, Employee employee, bool v5)
        {
        }

        public string GetCompanyName()
        {
            return companyName;
        }

        public void SetCompanyName(string value)
        {
            companyName = value;
        }

        public string GetContact()
        {
            return contact;
        }

        public void SetContact(string value)
        {
            contact = value;
        }

        public string GetNumber()
        {
            return number;
        }

        public void SetNumber(string value)
        {
            number = value;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string value)
        {
            email = value;
        }

        public DateTime GetDateOpened()
        {
            return dateOpened;
        }

        public void SetDateOpened(DateTime value)
        {
            dateOpened = value;
        }

        public LeadStatus GetStatus()
        {
            return status;
        }

        public void SetStatus(LeadStatus value)
        {
            status = value;
        }

        public int GetWorkStation()
        {
            return workStation;
        }

        public void SetWorkStation(int value)
        {
            workStation = value;
        }

        public LeadSource GetSource()
        {
            return source;
        }

        public void SetSource(LeadSource value)
        {
            source = value;
        }

        public Employee GetAddedBy()
        {
            return addedBy;
        }

        public void SetAddedBy(Employee value)
        {
            addedBy = seekEemploye(value);
        }


    }
}