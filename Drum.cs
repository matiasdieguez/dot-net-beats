namespace DotNetBeats
{

    public static class Drum
    {
        public static void Haus()
        {
            Beat.Play("bd_haus");
        }

        public static void Sone()
        {
            Beat.Play("bd_sone");
        }

        public static void Zome()
        {
            Beat.Play("bd_zome");
        }

        public static void Zum()
        {
            Beat.Play("bd_zum");
        }

        public static void Snare()
        {
            Beat.Play("elec_hi_snare");
        }

        public static void SnareLow()
        {
            Beat.Play("elec_lo_snare");
        }

        public static void Triangle()
        {
            Beat.Play("elec_triangle");
        }

        public static void Twang()
        {
            Beat.Play("elec_twang");
        }

        public static void HiHat()
        {
            Beat.Play("drum_cymbal_pedal");
        }

        public static void Cymbal()
        {
            Beat.Play("drum_cymbal_soft");
        }
    }
}
#pragma warning restore CA1416
