using System.Threading.Tasks;

namespace DotNetBeats
{
    class Program
    {
        protected static void Main()
        {
            Beat.SamplesFolder = @"C:\Source\dot-net-beats\samples";
            
            Task.Run(()=> 
            {
                while(true)
                {
                    Time.Seconds(8);
                    Drum.Cymbal();
                }
            });

            while (true)
            {
                for (var i = 0; i < 8; i++)
                {
                    Drum.Haus();
                    Time.Seconds(1);

                    Sample.Snap();
                    Time.Seconds(1);
                }

                //HiHat()

                //Snare()

            }
        }
    }
}