using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace KungfuSheetTool
{
    public partial class Form1 : Form
    {
        private int studentCnt = 0;
        private Microsoft.Office.Interop.Excel.Workbook exlWB;
        private Microsoft.Office.Interop.Excel.Worksheet exlWS;
        private Microsoft.Office.Interop.Excel.Application exlApp;

        public Form1()
        {
            InitializeComponent();

            exlApp = new Microsoft.Office.Interop.Excel.Application();
            exlApp.Visible = false;
           
            string sDataFile = "D:\\DanielCode\\KungFuTool\\KungFuTimeSheet\\KungfuSheetTool\\bin\\Debug\\timesheet.xlsx";

            exlWB = exlApp.Workbooks.Open(sDataFile, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing);

            // Payment plan sheet
            exlWS = (Microsoft.Office.Interop.Excel.Worksheet)exlWB.Worksheets[3];
            string tmpName = "";
            studentCnt = 0;
            string loctionStr = "";
            while (true)
            {
                loctionStr = "A"+(studentCnt+2).ToString();
                tmpName = exlWS.Range[loctionStr].Formula;
                if (tmpName == "")
                    break;
                cbName.Items.Add(tmpName);
                studentCnt++;
            }          
        }

        private int findStudent(string name)
        {
            for (int i = 2; i < studentCnt + 2; i++)
            {
                Microsoft.Office.Interop.Excel.Range rng = (Microsoft.Office.Interop.Excel.Range)exlWS.Cells[1, i];
                string tmpName = (string)rng.Value2;
                if (tmpName.Contains(name))
                {
                    return i;
                }
            }

            return 0;

        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            string studentName = cbName.SelectedItem.ToString();
            DateTime currentDate = DateTime.Now;
            string currentDateStr = currentDate.ToString("MMMM dd, yyyy");

            btnSummary.Text = "Hiding Summary";
            lbCheckedIn.Visible = true;

            exlWS = (Microsoft.Office.Interop.Excel.Worksheet)exlWB.Worksheets[1];
            string loctionStr = "";
            string dateStr;
            int cnt=0;
            string foundDateStr = "";

            int column = 0;
            // find this student's correspond column in timesheet
            column = findStudent(studentName);
          
            while (true)
            {
                loctionStr = "A"+(cnt+2).ToString();
                dateStr = exlWS.Range[loctionStr].Formula;
                double d = double.Parse(dateStr);
                DateTime conv = DateTime.FromOADate(d);
                dateStr = conv.ToString("MMMM dd, yyyy");
                //loctionStr = "C"+(cnt+2).ToString();
                Microsoft.Office.Interop.Excel.Range rng = (Microsoft.Office.Interop.Excel.Range)exlWS.Cells[cnt+2, column];
                //if(exlWS.Range[loctionStr].Formula=="x")
                if(rng.Formula=="x")
                {
                    foundDateStr = dateStr;
                }

                if (dateStr.Contains(currentDateStr))               
                    break;
                
                cnt++;    
                
            }

            lbTime.Text = foundDateStr;
            lbTime.Visible = true;

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {

        }
    }
}
