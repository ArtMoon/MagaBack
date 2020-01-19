using System;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System.IO;
using System.Text;
using DIMON_APP.Models;

namespace DIMON_APP
{
    public class ExcelParser
    {
        public string Parse(string path,MyWebApiDbContext context)
        {
            FileInfo fi = new FileInfo(path);

            using(var package = new ExcelPackage(fi))
            {
                return readExcelPackageToString(package,package.Workbook.Worksheets["Sheet1"],context);
            }
        }

        private string readExcelPackageToString(ExcelPackage package, ExcelWorksheet worksheet,MyWebApiDbContext context)
        {
            var rowCount = worksheet.Dimension?.Rows;
            var colCount = worksheet.Dimension?.Columns;

            if (!rowCount.HasValue || !colCount.HasValue)
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();
            DateTime dt = new DateTime();
            
            Sensor_vals vals = new Sensor_vals();
            //avt_FIC1
           
            for (int row = 3; row <= rowCount; row++)
            {
                
                    vals.Value_id = 50544 + row;
                    vals.Sensor_value = float.Parse(worksheet.Cells[row, 11].Value.ToString());
                    DateTime.TryParse(worksheet.Cells[row, 1].Value.ToString(),out dt);
                    vals.Date_time = dt;
                    vals.Id_sensor = 10;
                    context.Sensor_Val.Add(vals);
                    context.SaveChanges();
                    sb.Append(dt);
            }
            
            return sb.ToString();
        }


        
    }
}