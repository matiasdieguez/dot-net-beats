using System.Threading;

namespace DotNetBeats
{
    public static class Time
    {
        private static int WholeNoteValue = 4000;

        public static void SetWholeNote(int wholeNoteDuration)
        {
            WholeNoteValue = wholeNoteDuration;
        }

        public static void Sleep(int ms)
        {
            Thread.Sleep(ms);
        }

        public static void Seconds(int s)
        {
            Thread.Sleep(s * 1000);
        }

        public static void WholeNote()
        {
            Thread.Sleep(WholeNoteValue);
        }

        public static void HalfNote()
        {
            Thread.Sleep(WholeNoteValue / 2);
        }

        public static void QuarterNote()
        {
            Thread.Sleep(WholeNoteValue / 4);
        }

        public static void EighthNote()
        {
            Thread.Sleep(WholeNoteValue / 8);
        }

        public static void SixteenthNote()
        {
            Thread.Sleep(WholeNoteValue / 16);
        }

        public static void ThirtySecondNote()
        {
            Thread.Sleep(WholeNoteValue / 32);
        }

        public static void SixtyFourNote()
        {
            Thread.Sleep(WholeNoteValue / 64);
        }
    }
}