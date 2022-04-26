using System.Media;

namespace netdrummer5
{
    public static class Samples
    {
        public static void VinylScratch()
        {
            using (var player = new SoundPlayer(@"C:\Source\netdrummer5\samples\vinyl_scratch.wav"))
            {
                player.Play();
            }
        }

        public static void VinylBackspin()
        {
            using (var player = new SoundPlayer(@"C:\Source\netdrummer5\samples\vinyl_backspin.wav"))
            {
                player.Play();
            }
        }

        public static void VinylHiss()
        {
            using (var player = new SoundPlayer(@"C:\Source\netdrummer5\samples\vinyl_hiss.wav"))
            {
                player.Play();
            }
        }

        public static void VinylRewind()
        {
            using (var player = new SoundPlayer(@"C:\Source\netdrummer5\samples\vinyl_rewind.wav"))
            {
                player.Play();
            }
        }

        public static void PercWood()
        {
            using (var player = new SoundPlayer(@"C:\Source\netdrummer5\samples\loop_perc1.wav"))
            {
                player.Play();
            }
        }

        public static void PercThrow()
        {
            using (var player = new SoundPlayer(@"C:\Source\netdrummer5\samples\loop_perc2.wav"))
            {
                player.Play();
            }
        }

        public static void Safari()
        {
            using (var player = new SoundPlayer(@"C:\Source\netdrummer5\samples\loop_safari.wav"))
            {
                player.Play();
            }
        }

        public static void Mika()
        {
            using (var player = new SoundPlayer(@"C:\Source\netdrummer5\samples\loop_mika.wav"))
            {
                player.Play();
            }
        }
    }
}