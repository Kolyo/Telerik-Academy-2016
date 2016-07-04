namespace GSM
{
    class Display
    {
        public string Size { get; set; }
        public string Colors { get; set; }

        public Display()
        {
            Size = null;
            Colors = null;
        }
        public Display(string size) : this()
        {
            Size = size;
        }
        public Display(string size, string colors) : this(size)
        {
            Size = size;
            Colors = colors;
        }
        public override string ToString()
        {
            return $"Size: {Size}, Colors {Colors}";
        }

    }

}
