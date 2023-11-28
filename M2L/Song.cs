using System.Collections.Generic;

namespace MidiToLua
{
    public class Song
    {
        public string name;
        public int totalSamples;

        public List<Section> sections;
        public List<NoteEvent> noteEvents;

        public Song(string name)
        {
            this.name = name;
            totalSamples = 0;
            sections = new List<Section>();
            noteEvents = new List<NoteEvent>();
        }

        public void AddSection(Section section)
        {
            sections.Add(section);
            totalSamples += section.sampleEnd - section.sampleBegin;
        }

        public void AddNoteEvent(NoteEvent noteEvent)
        {
            noteEvents.Add(noteEvent);
        }
    }
}