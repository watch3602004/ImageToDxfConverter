namespace ConvertCore
{
    public class LinePitch
    {
        private readonly double _pitch;

        public static LinePitch CreateFromUm(double pitch)
        {
            return new(pitch);
        }

        private LinePitch(double pitch)
        {
            _pitch = pitch;
        }

        public double PitchMm()
        {
            return _pitch / 1000d;
        }
    }
}