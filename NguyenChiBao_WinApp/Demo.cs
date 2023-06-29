using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NguyenChiBao_WinApp.Contexts;
using NguyenChiBao_WinApp.Models;
using System.Collections;

namespace NguyenChiBao_WinApp
{
    public partial class Demo : Form
    {
        TimeKeepingFirebaseContext timeKeepingFirebaseContext = new TimeKeepingFirebaseContext();
        TimeKeeping timeKeeping = new TimeKeeping();
        public Demo()
        {
            InitializeComponent();
            monthCalendar1.Visible = false;
            LoadDataAsync();

        }

        private async Task LoadDataAsync()
        {
            TimeKeepingFirebaseContext timeKeepingFirebaseContext = new TimeKeepingFirebaseContext();
            List<TimeKeeping> timeKeepingList = await timeKeepingFirebaseContext.GetAllTimekeepings();

            comboBox2.DisplayMember = "Id";
            comboBox2.ValueMember = "Employee";
            comboBox2.DataSource = timeKeepingList;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            comboBox1.Text = e.Start.ToShortDateString();
            comboBox1.Items.Add(e.Start.ToShortDateString());
            label1.Text = comboBox1.Text;
            monthCalendar1.Visible = false;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeKeeping =new TimeKeeping();
            
            timeKeeping.Employee = 1;
            timeKeeping.Timekeeping = DateTime.Now;
            timeKeeping.TimekeepingLocation = 1;
            timeKeepingFirebaseContext = new TimeKeepingFirebaseContext();
            timeKeepingFirebaseContext.AddTimekeeping(timeKeeping);
        }
        private string ExtractDataFromPDF(PdfReader reader)
        {
            string extractedData = string.Empty;

            //for (int page = 1; page <= reader.NumberOfPages; page++)
            //{
            //    //ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
            //    //string currentPageText = PdfTextExtractor.GetTextFromPage(reader, page, strategy);

            //    //string phonePattern = @"\b\d{10,}\b";
            //    //MatchCollection phoneMatches = Regex.Matches(currentPageText, phonePattern);
            //    //foreach (Match match in phoneMatches)
            //    //{
            //    //    extractedData += "Phone: " + match.Value + Environment.NewLine;
            //    //}

            //    //string emailPattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";
            //    //MatchCollection emailMatches = Regex.Matches(currentPageText, emailPattern);
            //    //foreach (Match match in emailMatches)
            //    //{
            //    //    extractedData += "Email: " + match.Value + Environment.NewLine;
            //    //}
            //}
            string extractedText = string.Empty;

            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                string currentPageText = PdfTextExtractor.GetTextFromPage(reader, page, strategy);

                extractedText += currentPageText;
            }
            string address = ExtractAddressFromText(extractedText);
            return address;
            //return extractedData;
        }
        private string ExtractAddressFromText(string text)
        {
            string address = string.Empty;
            string pattern = @"(?<!\s)\b(?:TP\.HCM|Hồ Chí Minh|HCM|Thủ Đức|Thành phố Thủ Đức|TĐ)\b(?!\s)";

            Match match = Regex.Match(text, pattern);
            if (match.Success)
            {
                address = match.Value;
            }



            return address;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //pictureBox1 = new PictureBox();
                Bitmap bitmap = new Bitmap(openFileDialog.FileName);
                pb.Image = bitmap;
                label1.Text = openFileDialog.FileName;
            }
        }
    }
}
