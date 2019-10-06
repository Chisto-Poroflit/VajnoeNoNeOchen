
namespace DbLibrary.Models.Entity
{
    public class Room
    {
        public string Number { get; set; }

        public int Capacity { get; set; }

        public bool IsLecture { get; set; }

        public bool IsPractice { get; set; }

        public bool IsLaboratory { get; set; }

        public bool IsSpecial { get; set; }

        public Couple Couple { get; set; }
    }
}
