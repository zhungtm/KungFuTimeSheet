using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
           
            string sDataFile = "D:\\tomwork\\KungfuTimeSheet\\timesheet.xlsx";

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

        private void btnSummary_Click(object sender, EventArgs e)
        {
            string studentName = cbName.SelectedText;
            DateTime currentDate = DateTime.Now;
            string currentDateStr = currentDate.ToString("MMMM dd, yyyy");

            btnSummary.Text = "Hiding Summary";
            lbCheckedIn.Visible = true;

            exlWS = (Microsoft.Office.Interop.Excel.Worksheet)exlWB.Worksheets[1];
            string loctionStr = "";
            string dateStr;
            int cnt=0;
            string foundDateStr = "";
            while (true)
            {
                loctionStr = "A"+(cnt+2).ToString();
                dateStr = exlWS.Range[loctionStr].Formula;
                double d = double.Parse(dateStr);
                DateTime conv = DateTime.FromOADate(d);
                dateStr = conv.ToString("MMMM dd, yyyy");
                loctionStr = "B"+(cnt+2).ToString();
                if(exlWS.Range[loctionStr].Formula=="x")
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
