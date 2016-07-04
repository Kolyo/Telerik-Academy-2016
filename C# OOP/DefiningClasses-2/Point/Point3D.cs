namespace Point
{
    public struct Point3D
    {
        public double X, Y, Z;
        private static readonly Point3D PointO = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"{{{X} : {Y} : {Z}}}";
        }

        public static Point3D O
        {
            get { return PointO; }
        }
        
    }
}
