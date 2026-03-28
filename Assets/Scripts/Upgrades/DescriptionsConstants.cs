using UnityEngine;

public static class DescriptionsConstants
{
    public static class RayGun
    {
        public const string FIRST = "Ray Gun";
        public const string FINAL = "Starlight Cannon";
        public static readonly string[] Descriptions = new string[]
            {
                /* 0 */ "N/A",
                /* 1 */ "Shoots faster, does more damage.",
                /* 2 */ "Double trouble! There are two beams now, with increased firerate for both of them.",
                /* 3 */ "The beams are wider now, with an even faster firerate. Increases damage output too.",
                /* 4 */ "Infinite output.",
            };
    }

    public static class Star
    {
        public const string FIRST = "Star";
        public const string FINAL = "Supernova";
        public static readonly string[] Descriptions = new string[]
            {
                /* 0 */ "A star floating above you shooting out powerful beams that pierce tons of enemies.",
                /* 1 */ "Beam grows wider, shoots more frequently, and is more deadly.",
                /* 2 */ "Beams set enemies ablaze, increases size and output further.",
                /* 3 */ "Beam gets even larger, significantly more damage.",
                /* 4 */ "Absolute incineration. Yeah they ain't surviving this one.",
            };
    }


    public static class Asteroid
    {
        public const string FIRST = "Asteroid";
        public const string FINAL = "Fury of Uranus";
        public static readonly string[] Descriptions = new string[]
            {
                /* 0 */ "Asteroid rains upon enemies, dealing huge damage.",
                /* 1 */ "More asteroids! Larger explosion.",
                /* 2 */ "Even more asteroids, more damage.",
                /* 3 */ "A ton more asteroids with larger explosions. They slow down enemies now.",
                /* 4 */ "OHHHHH MY PC!!!!",
            };
    }



    public static class Comet
    {
        public const string FIRST = "Comet";
        public const string FINAL = "Celestium";
        public static readonly string[] Descriptions = new string[]
            {
                /* 0 */ "A comet orbits you, damaging enemies in its way.",
                /* 1 */ "Gain another comet, deals more damage.",
                /* 2 */ "Faster orbit, gain another comet.",
                /* 3 */ "Burns enemies, comet size increases, more damage.",
                /* 4 */ "Annihilates everything in its way.",
            };
    }
}
