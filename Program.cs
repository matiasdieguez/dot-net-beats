using System;
using System.Threading.Tasks;

namespace DotNetBeats
{
    class Program
    {
        protected static void Main()
        {
            Beat.SamplesFolder = @"C:\Source\dot-net-beats\samples";

            Task.Run(() =>
            {
                while (true)
                {
                    Drum.HiHat();
                    Time.Sleep(470);
                }
            });

            Task.Run(() =>
            {
                while (true)
                {
                    //Beat.Play("bass_c1");
                    Time.Sleep(3250);
                }
            });

            while (true)
            {
                for (int d = 0; d < 4; d++)
                {
                    Drum.Haus();
                    Time.Seconds(1);

                    Sample.Snap();
                    Time.Seconds(1);
                }
            }
        }
    }
}