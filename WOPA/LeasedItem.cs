namespace WOPA;

public class Leased_Item
{

    private int number;
    private int floor;
    private LeasedItemType type;
    private bool electricCharging;
    private bool isAvailable;
    
    public Leased_Item(int number, int floor, LeasedItemType type, bool electricCharging, bool isAvailable, bool isNew)
    {
        this.number = number;
        this.floor = floor;
        this.type = type;
        this.electricCharging = electricCharging;
        this.isAvailable = isAvailable;
        if (isNew)
        {
            createLeasedItem();
            Program.LeasedItems.Add(this);
        }
    }
    
    public int getNumber()
    {
        return this.number;
    }
    
    public int getFloor()
    {
        return this.floor;
    }
    
    public LeasedItemType getType()
    {
        return this.type;
    }
    
    public bool getElectricCharging()
    {
        return this.electricCharging;
    }
    
    public bool getIsAvailable()
    {
        return this.isAvailable;
    }

    public void updateType(LeasedItemType type)
    {
        this.type = type;
    }
    
    public void updateElectricCharging(bool electricCharging)
    {
        this.electricCharging = electricCharging;
    }
    
    public void updateIsAvailable(bool isAvailable)
    {
        this.isAvailable = isAvailable;
    }
    
    public void createLeasedItem()
    {
        SqlCommand c = new SqlCommand();
        c.CommandText = "EXECUTE dbo.Create_Leased_Item @number, @floor, @type, @electricCharging, @isAvailable";
        c.Parameters.AddWithValue("@number", number);
        c.Parameters.AddWithValue("@floor", floor);
        c.Parameters.AddWithValue("@type", type);
        c.Parameters.AddWithValue("@electricCharging", electricCharging);
        c.Parameters.AddWithValue("@isAvailable", isAvailable);
        SQL_CON SC = new SQL_CON();
        SC.execute_non_query(c);
    }
}