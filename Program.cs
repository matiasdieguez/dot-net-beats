#pragma warning disable CA1416

namespace netdrummer5
{
    class Program
    {
        static void Main(string[] args)
        {
            Times.SetWholeNote(2000);

            while (true)
            {
                for (var i = 0; i < 8; i++)
                {
                    Drums.Haus();
                    Times.QuarterNote();

                    Drums.HiHat();
                    Times.SixteenthNote();

                    Drums.Haus();
                    Times.QuarterNote();

                    Drums.Haus();
                    Times.SixteenthNote();

                    Samples.VinylScratch();
                    Times.SixteenthNote();
                }

                for (var i = 0; i < 4; i++)
                {
                    Drums.Haus();
                    Times.EighthNote();

                    Drums.Haus();
                    Times.EighthNote();

                    Drums.Haus();
                    Times.EighthNote();

                    Samples.VinylScratch();
                    Times.EighthNote();
                }

                for (var i = 0; i < 4; i++)
                {
                    Drums.Haus();
                    Times.SixteenthNote();

                    Drums.Haus();
                    Times.SixteenthNote();

                    Drums.Haus();
                    Times.SixteenthNote();

                    Drums.Zome();
                    Times.SixteenthNote();
                }

                for (var i = 0; i < 4; i++)
                {
                    Drums.Haus();
                    Times.ThirtySecondNote();
                    Drums.Haus();
                    Times.ThirtySecondNote();
                    Drums.Haus();
                    Times.ThirtySecondNote();
                    Drums.Zome();
                    Times.ThirtySecondNote();
                }

                for (var i = 0; i < 4; i++)
                {
                    Drums.Haus();
                    Drums.Cymbal();
                    Times.ThirtySecondNote();
                }
            }
        }
    }
}
#pragma warning restore CA1416
