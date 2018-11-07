using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Mail;
using Excel = Microsoft.Office.Interop.Excel;

namespace SMTP_Email_Customizer
{
    public partial class Form1 : Form
    {
        private Excel.Application xlApp;
        private Excel.Workbook xlWorkbook;
        private Excel.Worksheet xlWorksheet;

        private int port;
        private string host;
        private string body;
        private static string DEFAULTHOST = "USCHQSMTP.Unifrax.com";

        public Form1()
        {
            InitializeComponent();

            xlApp = null;
            port = 25;
            host = DEFAULTHOST;
        }

        private void sendEmailsButton_Click(object sender, EventArgs e)
        {
            SetUpExcel();
            SetUpAndSendMailMessage();
            CleanUpExcel();
            System.Environment.Exit(1);
        }

        private void SetUpAndSendMailMessage()
        {

            if (richTextBox.Enabled)
            {
                string body = richTextBox.Text;
            }

            string toAddress;
            string fromAddress;
            string subject;
            string[] customValues;

            int rowCount = xlWorksheet.Rows.Count;
            int colCount = xlWorksheet.Columns.Count;

            // i starts at 2 because the worksheet has headers (i.e. data starts at row 2)
            for (int currentRow = 2; currentRow <= rowCount; currentRow++)
            {
                toAddress = xlWorksheet.Cells[currentRow, 1].Value.ToString();
                fromAddress = xlWorksheet.Cells[currentRow, 2].Value.ToString();
                subject = xlWorksheet.Cells[currentRow, 3].Value.ToString();
                customValues = new string[colCount - 3];

                // TODO: Custom values hardcoded to start in column 4... any way to make this variable?  
                for(int currentCol = 0; currentCol <= colCount - 3; currentCol++)
                {
                    customValues[i] = 
                }
                //SendMailMessage();
            }
        }

        private void SendMailMessage(string toAddress, string fromAddress, string subject, string body, string[] customValues)
        {
            MailMessage Msg = new MailMessage();

            Msg.From = new MailAddress(fromAddress);
            Msg.To.Add(toAddress);
            Msg.Subject = subject;
            Msg.Body = body;
            Msg.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = host;
            smtp.Port = port;
            //smtp.Credentials = new System.Net.NetworkCredential(txtUsername.Text, txtpwd.Text);

            smtp.Send(Msg);
        }

        private void CleanUpExcel()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.ReleaseComObject(xlWorksheet);

            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }

        private void SetUpExcel()
        {           
            xlApp = new Excel.Application();
            xlWorkbook = xlApp.Workbooks.Open("C:/Users/dgagliardi/Desktop/smtpEmailTestBook.xlsx"); //HARD CODED FILE FOR TESTING PURPOSES
            xlWorksheet = xlWorkbook.ActiveSheet;                               
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void useRichTextCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox.Enabled = useRichTextCheckBox.Checked ? true : false;
        }
    }
}
