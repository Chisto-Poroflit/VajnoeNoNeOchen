using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestExcel
{
    public class ExcelCRUD
    {
        private string _path = "";
        _Application objExcel = new Excel.Application();
        Workbook workbook;
        Worksheet worksheet;

        public ExcelCRUD()
        {

        }
        public ExcelCRUD(string path, int Sheet)
        {
            this._path = path;
            workbook = objExcel.Workbooks.Open(_path);
            worksheet = (Worksheet)workbook.Worksheets[Sheet];
        }
        public void CreateExcel()
        {
            this.workbook = objExcel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            this.worksheet = (Worksheet)workbook.Worksheets[1];
           // this.worksheet = (Worksheet)workbook.ActiveSheet;
        }

        public void SaveAs(string path)
        {
            workbook.SaveAs(path);
        }

        public void Close()
        {
            workbook.Close();
        }

        public void CreateNewSheet()
        {
            Worksheet ws = (Worksheet)workbook.Worksheets.Add(After: worksheet);
        }

        public void SelectWorksheet(int Sheet)
        {
            this.worksheet = (Worksheet)workbook.Worksheets[Sheet];
        }

        public void StartMerge()
        {
            Range _range = (Range)worksheet.get_Range("H1", "K1").Cells;
            _range.Merge(Type.Missing);
            worksheet.Cells[1, 8] = "Obwie";
        }

        public void Save()
        {
            workbook.Save();
        }

        public void AddStart()
        {

        }
    }
}
