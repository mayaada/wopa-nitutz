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
        private int workStation;
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
            this.workStation = workStation;
            this.source = source;
            this.Added_By = Added_By;
            if (isNew)
            {
                createLead();
                Program.Lead.Add(this);
            }
        }


     public string get_name()
        {
            return this.WorkerName;
        }
        public string getID()
        {
            return this.WorkerId;
        }

        public Title get_title()
        {
            return this.workerTitle;
        }

        public void set_name(string name)
        {
            this.WorkerName = name; ;
        }

        public void set_title(Title t)
        {
             this.workerTitle=t;
        }



    }
}