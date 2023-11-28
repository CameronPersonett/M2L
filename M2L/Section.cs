namespace MidiToLua
{
    public class Section
    {
        public int samples, sampleBegin, sampleEnd, midiBegin, midiEnd;

        public Section(int sampleBegin, int sampleEnd, int midiBegin, int midiEnd)
        {
            samples = sampleEnd - sampleBegin;
            this.sampleBegin = sampleBegin;
            this.sampleEnd = sampleEnd;
            this.midiBegin = midiBegin;
            this.midiEnd = midiEnd;
        }
    }
}