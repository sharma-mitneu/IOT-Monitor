// Models/Device.cs
public class Device
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public List<SensorData> SensorReadings { get; set; }
}
