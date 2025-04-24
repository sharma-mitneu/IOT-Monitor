namespace IoTMonitor.API.DTOs
{
    public class SensorDataDto
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public DateTime Timestamp { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double Vibration { get; set; }
    }
}
