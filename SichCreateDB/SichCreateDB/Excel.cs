using System;
using System.Collections.Generic;
using System.Text;
using OfficeOpenXml;
using System.IO;
using OfficeOpenXml.Style;

namespace SichCreateDB
{
    public class Excel
    {
        ExcelPackage excel = new ExcelPackage();
        ExcelWorkbook wb;
        ExcelWorksheet ws;
        public Excel()
        {
            wb = excel.Workbook;
            for(int i = 1; i <= 6; i++)
            {
                if (i < 5)
                    wb.Worksheets.Add($"Курс {i}");
                else
                    wb.Worksheets.Add($"Маг Курс {i - 4}");
            }
            ws = wb.Worksheets[1];         
        }

        public void CreateStartExcel(string path)
        {
            string[] days = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };
            string[] time = new string[] { "8:00-9:35", "9:45-11:20", "11:30-13:05", "13:25-15:00", "15:10-16:45", "16:55-18:30", "18:40-20:00" };

            for (int w = 1; w <= 6; w++)
            {
                ws = wb.Worksheets[w];
                int q = 0;

                for (int i = 1; i < 6; i++)
                {
                    using (ExcelRange rng = ws.Cells[1, i * 2 + 1, 1, i * 2 + 2])
                    {
                        rng.Value = $"Группа {i}";
                        rng.Merge = true;

                        rng.Style.Font.Size = 12;
                        rng.Style.Font.Bold = true;

                        rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        rng.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                        rng.Style.Border.Top.Style = ExcelBorderStyle.Medium;
                        rng.Style.Border.Bottom.Style = ExcelBorderStyle.Medium;
                        rng.Style.Border.Right.Style = ExcelBorderStyle.Medium;
                        rng.Style.Border.Left.Style = ExcelBorderStyle.Medium;
                    }
                    for (int j = 1; j < 3; j++)
                    {
                        using (ExcelRange rng = ws.Cells[2, i * 2 + j])
                        {
                            rng.Value = $"{i}.{j}";

                            rng.Style.Font.Size = 12;
                            rng.Style.Font.Bold = true;

                            rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            rng.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                            rng.Style.Border.Top.Style = ExcelBorderStyle.Medium;
                            rng.Style.Border.Bottom.Style = ExcelBorderStyle.Medium;
                            rng.Style.Border.Right.Style = ExcelBorderStyle.Medium;
                            rng.Style.Border.Left.Style = ExcelBorderStyle.Medium;
                        }
                    }
                }

                for (int i = 1; i < 7; i++)
                {
                    using (ExcelRange rng = ws.Cells[(i - 1) * 13 + 3 + q, 1, i * 13 + 3 + q, 1])
                    {
                        rng.Value = $"{days[i - 1]}";
                        rng.Merge = true;

                        rng.Style.Font.Size = 12;
                        rng.Style.Font.Bold = true;

                        rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        rng.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                        rng.Style.Border.Top.Style = ExcelBorderStyle.Medium;
                        rng.Style.Border.Bottom.Style = ExcelBorderStyle.Medium;
                        rng.Style.Border.Right.Style = ExcelBorderStyle.Medium;
                        rng.Style.Border.Left.Style = ExcelBorderStyle.Medium;
                    }

                    for (int j = 1; j < 8; j++)
                    {
                        using (ExcelRange rng = ws.Cells[(i - 1) * 14 + 3 + (j - 1) * 2, 2, (i - 1) * 14 + 4 + (j - 1) * 2, 2])
                        {
                            rng.Value = $"{time[j - 1]}";
                            rng.Merge = true;

                            rng.AutoFitColumns();
                            rng.Style.Font.Size = 12;
                            rng.Style.Font.Bold = true;

                            rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            rng.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                            rng.Style.Border.Top.Style = ExcelBorderStyle.Medium;
                            rng.Style.Border.Bottom.Style = ExcelBorderStyle.Medium;
                            rng.Style.Border.Right.Style = ExcelBorderStyle.Medium;
                            rng.Style.Border.Left.Style = ExcelBorderStyle.Medium;
                        }
                    }

                    q++;
                }
            }
        }
    }
}
