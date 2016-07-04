namespace GSM
{
    class Battery
    {
        public string Model { get; set; }
        public float? HoursIdle { get; set; }
        public float? HoursTalk { get; set; }
        public BatteryType BatteryType { get; set; }

        public Battery(string model)
        {
            Model = model;
        }

        public Battery(string model, float hoursIddle, float hoursTalk) : this(model)
        {
            HoursIdle = hoursIddle;
            HoursTalk = hoursTalk;
        }
        public Battery(string model, float hoursIddle, float hoursTalk, BatteryType type) : this(model, hoursIddle, hoursTalk)
        {
            BatteryType = type;
        }
        public override string ToString()
        {
            return $"{Model} - {BatteryType}, Hours Talk: {HoursTalk}h, Hours Iddle {HoursIdle}h";
        }
    }
}
