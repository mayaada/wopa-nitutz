/* 
CREATE TABLE LEASES(
Lease_ID		INT		            PRIMARY KEY 	NOT NULL,
Signer_Name     varchar (60)        NOT NULL, 
Start_Date      DATE                NOT NULL, 
End_Date        DATE                NULL, 
Termination_Notice INT              NOT NULL, 
Terms_And_Conditions varchar (60)   NOT NULL, 
Signed_By_Employee  VARCHAR (60)    NOT NULL,
Signed_By_Tenant	VARCHAR (60)    NOT NULL,
)
*/

namespace WOPA
{

    public class Lease
    {
        private int leaseID;
        private string signerName;
        private DateTime startDate;
        private DateTime endDate;
        private int terminationNotice;
        private string termsAndConditions;
        private Employee signedByEmployee;
        private Tenant signedByTenant;
        
        // constructor for new lease
        public Lease(int leaseID, string signerName, DateTime startDate, DateTime endDate, int terminationNotice,
            string termsAndConditions, Employee signedByEmployee, Tenant signedByTenant, bool isNew)
        {
            this.leaseID = leaseID;
            this.signerName = signerName;
            this.startDate = startDate;
            this.endDate = endDate;
            this.terminationNotice = terminationNotice;
            this.termsAndConditions = termsAndConditions;
            this.signedByEmployee = signedByEmployee;
            this.signedByTenant = signedByTenant;
            if (isNew)
            {
                createLease();
                Program.Leases.Add(this);
            }
        }

        private int addWorkStation(int numberOfWorkStations)
        {
            this.w
        }
    }
}