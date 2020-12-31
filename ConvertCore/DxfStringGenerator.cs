using System.Collections.Generic;

namespace ConvertCore
{
    internal static class DxfStringGenerator
    {
        public static IEnumerable<string> Header()
        {
            return new List<string>
            {
                "0",
                "SECTION",
                "2",
                "ENTITIES",
            };
        }

        public static IEnumerable<string> Footer()
        {
            return new List<string>
            {
                "0",
                "ENDSEC",
                "0",
                "EOF"
            };
        }

        public static IEnumerable<string> GenerateLine(LineElement line)
        {
            var lineElement = new List<string>
            {
                "0",
                "LINE",
                "8",
                "0",
                "10",
                line.StartX.ToString("F3"),
                "20",
                line.StartY.ToString("F3"),
                "11",
                line.EndX.ToString("F3"),
                "21",
                line.EndY.ToString("F3"),
            };

            return lineElement;
        }
    }
}