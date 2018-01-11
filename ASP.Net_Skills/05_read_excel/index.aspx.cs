using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aspose.Cells;

namespace ASP.Net_Skills._05_read_excel
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Workbook workbook = new Workbook();
            workbook.Open(@"C:\Users\Keno\Desktop\0109链接.xlsx");
            
            //for (int i = 0; i < cells.MaxDataRow + 1; i++)
            //{
            //    for (int j = 0; j < cells.MaxDataColumn + 1; j++)
            //    {
            //        string s = cells[i, j].StringValue.Trim();
            //        //Row row read data,Insert the database code can also be written here
            //    }
            //}

            Cells cells = workbook.Worksheets[1].Cells;

            System.Data.DataTable dataTable1 = cells.ExportDataTable(1, 0, cells.MaxDataRow, cells.MaxColumn);//noneTitle

            System.Data.DataTable dataTable2 = cells.ExportDataTable(0, 0, cells.MaxDataRow + 1, cells.MaxColumn, true);//showTitle

        }
    }
}