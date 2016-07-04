namespace Point
{
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> pointList;

        //Constructors
        public Path()
        {
            this.PointList = new List<Point3D>();
        }

        // Properties
        public List<Point3D> PointList
        {
            get { return this.pointList; }
            set { this.pointList = value; }
        }

        // Methods

        public void AddPoint(Point3D point)
        {
            this.pointList.Add(point);
        }
        public void RemovePoint(Point3D point)
        {
            this.pointList.Remove(point);
        }
    }
}
