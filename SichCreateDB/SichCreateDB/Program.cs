using DbLibrary;
using System.IO;
using System.Linq;
using System;
using System.Collections.Generic;

namespace SichCreateDB
{
    class Program
    {
        static void Main(string[] args)
        {
   
            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    List<int> groupsInCourses = new List<int>();
            //    var couples = db.Groups.ToList();
            //    int count = db.Groups.Max(p => p.SemesterNumber);
            //    if (count % 2 == 1)
            //        count = (count + 1) / 2;
            //    else
            //        count /= 2;
            //    for(int i = 1; i <= count; i++)
            //    {
            //        int groupsCount = db.Groups.Count(p => p.SemesterNumber == i * 2);
            //        int groupsCountChet = db.Groups.Count(p => p.SemesterNumber == i * 2 - 1);
            //    }
            //}
            Excel excel = new Excel();
            List<int> g = DBToExcel.GroupCounter();
            excel.CreateStartExcel(g);
        }
    }
}
