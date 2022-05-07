#pragma warning disable CA1416
using System;
using System.Media;
using NetCoreAudio;

namespace DotNetBeats
{
    public static class Beat
    {
        public static string SamplesFolder;
        public static void Play(string sampleName)
        {
            if(string.IsNullOrEmpty(SamplesFolder))
                throw new Exception("Must set Beat.SamplesFolder");

            // using (var player = new SoundPlayer($"{SamplesFolder}\\{sampleName}.wav"))
            // {
            //     player.Play();
                
            // }

            var player = new Player();
            var sample = $"{SamplesFolder}\\{sampleName}.wav";
            player.Play(sample).Wait();
            Console.WriteLine($"Playing: {sample}");
        }

    }
}
#pragma warning restore CA1416