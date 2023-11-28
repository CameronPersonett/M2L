using System.Collections.Generic;

namespace MidiToLua
{
    public class Instruments
    {
        private static List<string> bass = new List<string>() { "F#1",
            "G1", "G#1", "A1", "A#1", "B1", "C2", "C#2", "D2", "D#2", "E2", "F2"};

        private static List<string> guitar = new List<string>() { "F#2",
            "G2", "G#2", "A2", "A#2", "B2", "C3", "C#3", "D3", "D#3", "E3", "F3", "F#3",
            "G3", "G#3", "A3", "A#3", "B3", "C4", "C#4", "D4", "D#4", "E4", "F4", "F#4" };

        private static List<string> flute = new List<string>() {
            "G4", "G#4", "A4", "A#4", "B4", "C5", "C#5", "D5", "D#5", "E5", "F5", "F#5",
            "G5", "G#5", "A5", "A#5", "B5", "C6", "C#6", "D6", "D#6", "E6", "F6", "F#6" };

        private static List<string> bell = new List<string>() {
            "G6", "G#6", "A6", "A#6", "B6", "C7", "C#7", "D7", "D#7", "E7", "F7", "F#7" };

        private static List<string> bassDrums = new List<string>() { "B1", "C2" };

        private static List<string> snares = new List<string>() { "D2", "D#2", "E2" };

        private static List<string> cymbals = new List<string>() { "G1", "G#1", "A1", "A#1", "C#2",
            "F#2", "G#2", "A#2", "C#3", "D#3", "E3", "F3", "F#3", "G3", "G#3", "A3", "A#3", "B3",
            "A4", "A#4", "D#5", "E5", "F5", "G#5", "A5", "A#5", "B5", "C#6" };

        private static string lowFloorTom = "F2";
        private static string highFloorTom = "G2";
        private static string lowTom = "A2";
        private static string lowMidTom = "B2";
        private static string highMidTom = "C3";
        private static string highTom = "D3";

        public static string GetInstrument(int track, string note)
        {
            if(track != 9)
            {
                if(bass.Contains(note))
                {
                    return "bass";
                } else if(guitar.Contains(note))
                {
                    return "guitar";
                } else if(flute.Contains(note))
                {
                    return "flute";
                } else if(bell.Contains(note))
                {
                    return "bell";
                } else
                {
                    return "unknown";
                }
            } else
            {
                if(bassDrums.Contains(note))
                {
                    return "bassDrum";
                } else if(lowFloorTom.Equals(note))
                {
                    return "lowFloorTom";
                } else if(highFloorTom.Equals(note))
                {
                    return "highFloorTom";
                } else if(lowTom.Equals(note))
                {
                    return "lowTom";
                } else if(lowMidTom.Equals(note))
                {
                    return "lowMidTom";
                } else if(highMidTom.Equals(note))
                {
                    return "highMidTom";
                } else if(highTom.Equals(note))
                {
                    return "highTom";
                } else if(snares.Contains(note))
                {
                    return "snare";
                } else if(cymbals.Contains(note))
                {
                    return "hat";
                } else
                {
                    return "unknown";
                }
            }
        }
    }
}