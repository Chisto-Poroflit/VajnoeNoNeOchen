﻿
namespace DbLibrary.Models.Entity
{
    public class Teacher
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Position { get; set; }

        public Couple Couple { get; set; }
    }
}
