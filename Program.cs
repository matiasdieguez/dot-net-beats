namespace DotNetBeats
{
    class Program
    {
        static void Main(string[] args)
        {
            Beat.SamplesFolder = @"C:\Source\dot-net-beats\samples";

            while (true)
            {
                // for (int i = 0; i < 2; i++)
                // {
                //     Sample.Safari();
                //     Time.EighthNote();
                // }

                Sample.VinylBackspin();
                Time.QuarterNote();

                Sample.VinylRewind();
                Time.QuarterNote();

                for (int d = 0; d < 256; d++)
                {
                    Drum.Haus();
                    Time.Sleep(1000);
                    
                    Sample.Snap();
                    Time.Sleep(1000);
                }

            }
        }
    }
}