using System.Diagnostics.Metrics;

namespace MidiToLua
{
    public class NoteEvent
    {
        public string note;
        public int position;
        public string instrument;

        public NoteEvent(int track, string note, int position)
        {
            this.note = note;
            this.position = position;
            instrument = Instruments.GetInstrument(track, note);
        }

        public override string ToString()
        {
            return note + ", " + position + ", " + instrument;
        }

        public string GetNoteVar()
        {
            if(note.Equals("F#1"))
            {
                return "aa";
            } else if(note.Equals("G1"))
            {
                return "ab";
            } else if(note.Equals("G#1"))
            {
                return "ac";
            } else if(note.Equals("A1"))
            {
                return "ad";
            } else if(note.Equals("A#1"))
            {
                return "ae";
            } else if(note.Equals("B1"))
            {
                return "af";
            } else if(note.Equals("C2"))
            {
                return "ag";
            } else if(note.Equals("C#2"))
            {
                return "ah";
            } else if(note.Equals("D2"))
            {
                return "ai";
            } else if(note.Equals("D#2"))
            {
                return "aj";
            } else if(note.Equals("E2"))
            {
                return "ak";
            } else if(note.Equals("F2"))
            {
                return "al";
            } else if(note.Equals("F#2"))
            {
                return "am";
            } else if(note.Equals("G2"))
            {
                return "an";
            } else if(note.Equals("G#2"))
            {
                return "ao";
            } else if(note.Equals("A2"))
            {
                return "ap";
            } else if(note.Equals("A#2"))
            {
                return "aq";
            } else if(note.Equals("B2"))
            {
                return "ar";
            } else if(note.Equals("C3"))
            {
                return "as";
            } else if(note.Equals("C#3"))
            {
                return "at";
            } else if(note.Equals("D3"))
            {
                return "au";
            } else if(note.Equals("D#3"))
            {
                return "av";
            } else if(note.Equals("E3"))
            {
                return "aw";
            } else if(note.Equals("F3"))
            {
                return "ax";
            } else if(note.Equals("F#3"))
            {
                return "ay";
            } else if(note.Equals("G3"))
            {
                return "az";
            } else if(note.Equals("G#3"))
            {
                return "ba";
            } else if(note.Equals("A3"))
            {
                return "bb";
            } else if(note.Equals("A#3"))
            {
                return "bc";
            } else if(note.Equals("B3"))
            {
                return "bd";
            } else if(note.Equals("C4"))
            {
                return "be";
            } else if(note.Equals("C#4"))
            {
                return "bf";
            } else if(note.Equals("D4"))
            {
                return "bg";
            } else if(note.Equals("D#4"))
            {
                return "bh";
            } else if(note.Equals("E4"))
            {
                return "bi";
            } else if(note.Equals("F4"))
            {
                return "bj";
            } else if(note.Equals("F#1"))
            {
                return "bk";
            } else if(note.Equals("G4"))
            {
                return "bl";
            } else if(note.Equals("G#4"))
            {
                return "bm";
            } else if(note.Equals("A4"))
            {
                return "bn";
            } else if(note.Equals("A#4"))
            {
                return "bo";
            } else if(note.Equals("B4"))
            {
                return "bp";
            } else if(note.Equals("C5"))
            {
                return "bq";
            } else if(note.Equals("C#5"))
            {
                return "br";
            } else if(note.Equals("D5"))
            {
                return "bs";
            } else if(note.Equals("D#5"))
            {
                return "bt";
            } else if(note.Equals("E5"))
            {
                return "bu";
            } else if(note.Equals("F5"))
            {
                return "bv";
            } else if(note.Equals("F#5"))
            {
                return "bw";
            } else if(note.Equals("G5"))
            {
                return "bx";
            } else if(note.Equals("G#5"))
            {
                return "by";
            } else if(note.Equals("A5"))
            {
                return "bz";
            } else if(note.Equals("A#5"))
            {
                return "ca";
            } else if(note.Equals("B5"))
            {
                return "cb";
            } else if(note.Equals("C6"))
            {
                return "cc";
            } else if(note.Equals("C#6"))
            {
                return "cd";
            } else if(note.Equals("D6"))
            {
                return "ce";
            } else if(note.Equals("D#6"))
            {
                return "cf";
            } else if(note.Equals("E6"))
            {
                return "cg";
            } else if(note.Equals("F6"))
            {
                return "ch";
            } else if(note.Equals("F#6"))
            {
                return "ci";
            } else if(note.Equals("G6"))
            {
                return "cj";
            } else if(note.Equals("G#6"))
            {
                return "ck";
            } else if(note.Equals("A6"))
            {
                return "cl";
            } else if(note.Equals("A#6"))
            {
                return "cm";
            } else if(note.Equals("B6"))
            {
                return "cn";
            } else if(note.Equals("C7"))
            {
                return "co";
            } else if(note.Equals("C#7"))
            {
                return "cp";
            } else if(note.Equals("D7"))
            {
                return "cq";
            } else if(note.Equals("D#7"))
            {
                return "cr";
            } else if(note.Equals("E7"))
            {
                return "cs";
            } else if(note.Equals("F7"))
            {
                return "ct";
            } else if(note.Equals("F#7"))
            {
                return "cu";
            }
            return "u";
        }

        public string GetInstrumentVar()
        {
            if(instrument.Equals("bass"))
            {
                return "b";
            } else if(instrument.Equals("guitar"))
            {
                return "g";
            } else if(instrument.Equals("flute"))
            {
                return "f";
            } else if(instrument.Equals("bell"))
            {
                return "e";
            } else if(instrument.Equals("bassDrum"))
            {
                return "a";
            } else if(instrument.Equals("lowFloorTom"))
            {
                return "l";
            } else if(instrument.Equals("highFloorTom"))
            {
                return "h";
            } else if(instrument.Equals("lowTom"))
            {
                return "o";
            } else if(instrument.Equals("lowMidTom"))
            {
                return "m";
            } else if(instrument.Equals("highMidTom"))
            {
                return "d";
            } else if(instrument.Equals("highTom"))
            {
                return "i";
            } else if(instrument.Equals("snare"))
            {
                return "s";
            } else if(instrument.Equals("hat"))
            {
                return "t";
            }
            return "u";
        }
    }
}
