public class SensorLog
{
    public string Location { get; set; }
    public double Temperature { get; set; }
}

// Objects for Table Storage must inherit from Table Entity
public class SensorLogEntity : TableEntity
{
    public SensorLogEntity()
    {
    }

    public SensorLogEntity(string location, string id)
    {
        PartitionKey = location;
        RowKey = id;
    }
    public string Temperature { get; set; }
}