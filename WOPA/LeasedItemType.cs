using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // winform 
using Microsoft.Data;
using Microsoft.Data.SqlClient;

namespace WOPA;

public class LeasedItemType
{
    
    private string type;
    private double price;
    private int creditAmount;
    private double deposit;

    public LeasedItemType(string type, double price, int creditAmount, double deposit, bool isNew)
    {
        this.type = type;
        this.price = price;
        this.creditAmount = creditAmount;
        this.deposit = deposit;
        if (isNew)
        {
            createLeasedItemType();
            Program.LeasedItemTypes.Add(this);
        }
    }

    public string getType()
    {
        return this.type;
    }

    public double getPrice()
    {
        return this.price;
    }

    public int getCreditAmount()
    {
        return this.creditAmount;
    }

    public double getDeposit()
    {
        return this.deposit;
    }


    public void updateType(string type)
    {
        this.type = type;
    }

    public void updatePrice(double price)
    {
        this.price = price;
    }

    public void updateCreditAmount(int creditAmount)
    {
        this.creditAmount = creditAmount;
    }

    public void updateDeposit(double deposit)
    {
        this.deposit = deposit;
    }


    public void createLeasedItemType()
    {
        SqlCommand c = new SqlCommand();
        c.CommandText = "EXECUTE dbo.Create_Leased_Item @type, @price, @creditAmount, @deposit";
        c.Parameters.AddWithValue("@type", type);
        c.Parameters.AddWithValue("@price", price);
        c.Parameters.AddWithValue("@creditAmount", creditAmount);
        c.Parameters.AddWithValue("@deposit", deposit);
        SQL_CON SC = new SQL_CON();
        SC.execute_non_query(c);
    }

    public void updateLeasedItemType()
    {
        SqlCommand c = new SqlCommand();
        c.CommandText = "EXECUTE dbo.Update_Leased_Item @type, @price, @creditAmount, @deposit";
        c.Parameters.AddWithValue("@type", type);
        c.Parameters.AddWithValue("@price", price);
        c.Parameters.AddWithValue("@creditAmount", creditAmount);
        c.Parameters.AddWithValue("@deposit", deposit);
        SQL_CON SC = new SQL_CON();
        SC.execute_non_query(c);
    }



}