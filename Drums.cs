using System.Media;

namespace netdrummer5
{

    public static class Drums
    {
        public static void Haus()
        {
            using (var player = new SoundPlayer(@"C:\Source\netdrummer5\samples\bd_haus.wav"))
            {
                player.Play();
            }
        }

        public static void Sone()
        {
            using (var player = new SoundPlayer(@"C:\Source\netdrummer5\samples\bd_sone.wav"))
            {
                player.Play();
            }
        }

        public static void Zome()
        {
            using (var player = new SoundPlayer(@"C:\Source\netdrummer5\samples\bd_zome.wav"))
            {
                player.Play();
            }
        }

        public static void Zum()
        {
            using (var player = new SoundPlayer(@"C:\Source\netdrummer5\samples\bd_zum.wav"))
            {
                player.Play();
            }
        }

        public static void Snare()
        {
            using (var player = new SoundPlayer(@"C:\Source\netdrummer5\samples\elec_hi_snare.wav"))
            {
                player.Play();
            }
        }

        public static void SnareLow()
        {
            using (var player = new SoundPlayer(@"C:\Source\netdrummer5\samples\elec_lo_snare.wav"))
            {
                player.Play();
            }
        }

        public static void Triangle()
        {
            using (var player = new SoundPlayer(@"C:\Source\netdrummer5\samples\elec_triangle.wav"))
            {
                player.Play();
            }
        }

        public static void Twang()
        {
            using (var player = new SoundPlayer(@"C:\Source\netdrummer5\samples\elec_twang.wav"))
            {
                player.Play();
            }
        }

        public static void HiHat()
        {
            using (var player = new SoundPlayer(@"C:\Source\netdrummer5\samples\drum_cymbal_pedal.wav"))
            {
                player.Play();
            }
        }

        public static void Cymbal()
        {
            using (var player = new SoundPlayer(@"C:\Source\netdrummer5\samples\drum_cymbal_soft.wav"))
            {
                player.Play();
            }
        }
    }
}