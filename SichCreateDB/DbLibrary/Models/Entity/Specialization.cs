using System.Collections.Generic;

namespace DbLibrary.Models.Entity
{
    public class Specialization
    {
        public int Id { get; set; }

        public string Name { get; set; }

      //  public int ParentSpecId { get; set; }

        public List<Specialization> ChildSpecializations { get; set; } 

        public Specialization ParentSpec { get; set; }

        public Group Group { get; set; }

        public CurriculumUnit CurriculumUnit { get; set; }
    }
}
