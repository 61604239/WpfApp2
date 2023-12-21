using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public static class GameSettings
    {
        public static int ShakeDuration { get; set; } = 200;

        public static bool EnableBGMusic { get; set; } = true;
        public static double WallDensity { get; set; } = .02;
        public static bool WallFatality { get; set; } = true;
    }
}
