using System.Collections.Generic;

namespace Models
{
    public class Musician : User
    {
        public ISet<KeyValuePair<Skill, SkillLevel>> InstrumentSkills { get; set; }
        public ISet<Work> Works { get; set; }
        public ISet<Song> Songs { get; set; }
    }
}
