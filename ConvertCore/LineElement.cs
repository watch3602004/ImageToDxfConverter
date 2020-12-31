namespace ConvertCore
{
    internal class LineElement
    {
        public double StartX { get; }
        public double StartY { get; }
        public double EndX { get; private set; }
        public double EndY { get; }

        public LineElement(double startX, double startY)
        {
            StartX = startX;
            StartY = startY;
            EndX = startX;
            EndY = startY;
        }

        public void SetEndX(double endX)
        {
            EndX = endX;
        }
    }
}