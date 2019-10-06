using System;
using System.IO;

namespace TestExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory() + "/Test.xlsx";
            ExcelCRUD excel = new ExcelCRUD(path,1);
            excel.CreateExcel();
            //  excel.CreateNewSheet();
            excel.StartMerge();
            //string path = Directory.GetCurrentDirectory() + "/Test.xlsx";
            // excel.SaveAs($"{path}");
            excel.Save();
            excel.Close();
        }
    }
}
