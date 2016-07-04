using System;
using System.Collections.Generic;

namespace GSM
{
    internal class GSM
    {
        private const double CALLPRICE = 0.37; //no need for decimal because there are no more digits after the second one
        private string model;
        private string manufacturer;
        private decimal? Price;
        private string Owner { get; set; }
        private Battery Battery { get; set; }
        private Display Display { get; set; }
        public List<Call> callHistory { get; }

        public string Model
        {
            get { return model; }
            set
            {
                if (value.Length < 2)
                {
                    throw new Exception("The model name should be at least 2 characters long");
                }

                model = value;

            }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (value.Length < 2)
                {
                    throw new Exception("The manufacturer should be at least 2 characters long");
                }

                manufacturer = value;

            }
        }

        public GSM(string model, string manufacturer)
        {
            Model = model;
            Manufacturer = manufacturer;
            callHistory = new List<Call>();
        }
        public GSM(string model, string manufacturer, decimal price) : this(model, manufacturer)
        {
            Price = price;
        }
        public GSM(string model, string manufacturer, decimal price, string owner) : this(model, manufacturer, price)
        {
            Owner = owner;
        }
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery) : this(model, manufacturer, price, owner)
        {
            Battery = battery;
        }
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display) : this(model, manufacturer, price, owner, battery)
        {
            Display = display;
        }

        public override string ToString()
        {
            return $"{Manufacturer} {Model} \n ${Price} \n Owner: {Owner} \n {Battery.ToString()} \n {Display.ToString()} \n";
        }

        public static readonly GSM IPhone6S = new GSM("iPhone 6S", "Apple", 699.99m, "Spas", new Battery("Chinese", 148.5f, 7.8f, BatteryType.LiPol), new Display("1920x1080", "16M"));


        public void AddCall(Call call)
        {
            callHistory.Add(call);
        }
        public void RemoveCall(Call call)
        {
            callHistory.Remove(call);
        }
        public void ClearCalls()
        {
            callHistory.Clear();
        }

        public double CallsPrice()
        {
            int seconds = 0;

            foreach (var item in callHistory)
            {
                seconds += item.Duration;
            }
            return (seconds / 60) * CALLPRICE;
        }
        public void PrintCallHistory()
        {

            foreach (var call in callHistory)
            {
                Console.WriteLine(call.ToString());
            }
        }
    }
}
