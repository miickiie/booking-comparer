using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingComparer
{
    public partial class BookingComparer : Form
    {
             
        private OpenFileDialog csv1 = new OpenFileDialog();
        private OpenFileDialog csv2 = new OpenFileDialog();
        private OpenFileDialog a = new OpenFileDialog();
        private OpenFileDialog b = new OpenFileDialog();

        #region basic form
        public BookingComparer()
        {
            InitializeComponent();
        }

        public string userSelectedFilePath1
        {
            get
            {
                return tbFilePath1.Text;
            }
            set
            {
                tbFilePath1.Text = value;
            }
        }

        public string userSelectedFilePath2
        {
            get
            {
                return tbFilePath2.Text;
            }
            set
            {
                tbFilePath2.Text = value;
            }
        }

        public string userSelectedFilePath3
        {
            get
            {
                return tbFilePath3.Text;
            }
            set
            {
                tbFilePath3.Text = value;
            }
        }

        public string userSelectedFilePath4
        {
            get
            {
                return tbFilePath4.Text;
            }
            set
            {
                tbFilePath4.Text = value;
            }
        }

        private void csv_btn_1_Click(object sender, EventArgs e)
        {
            csv1 = new OpenFileDialog();
            csv1.Filter = "CSV|*.csv";
            // Show the dialog and get result.
            DialogResult result = csv1.ShowDialog();
            if (result == DialogResult.OK)
            {
                userSelectedFilePath1 = csv1.FileName;
            }
        }
        private void csv_btn_2_Click(object sender, EventArgs e)
        {
            csv2 = new OpenFileDialog();
            csv2.Filter = "CSV|*.csv";
            // Show the dialog and get result.
            DialogResult result = csv2.ShowDialog();
            if (result == DialogResult.OK)
            {
                userSelectedFilePath2 = csv2.FileName;
            }
        }
        private void a_btn_Click(object sender, EventArgs e)
        {
            a = new OpenFileDialog();
            a.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // Show the dialog and get result.
            DialogResult result = a.ShowDialog();
            if (result == DialogResult.OK)
            {
                userSelectedFilePath3 = a.FileName;
            }
        }
        private void b_button_Click(object sender, EventArgs e)
        {
            b = new OpenFileDialog();
            b.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // Show the dialog and get result.
            DialogResult result = b.ShowDialog();
            if (result == DialogResult.OK)
            {
                userSelectedFilePath4 = b.FileName;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://metabase.agoda.local/question/1315");
        }

        #endregion

        private void process_btn_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 6;
            progressBar1.Step = 1;

            var booking_before = LoadHotelsFromCsv(csv1.FileName);
            var booking_after = LoadHotelsFromCsv(csv2.FileName);
            var a_allocate = LoadAllocateFromText(a.FileName);
            var b_allocate = LoadAllocateFromText(b.FileName);
                             
            progressBar1.Value = 1;
            var A_countBefore = GetBookingCount(booking_before, a_allocate);
            progressBar1.Value = 2;
            var A_countAfter = GetBookingCount(booking_after, a_allocate);
            progressBar1.Value = 3;
            var B_countBefore = GetBookingCount(booking_before, b_allocate);
            progressBar1.Value = 4;
            var B_countAfter = GetBookingCount(booking_after, b_allocate);
            progressBar1.Value = 5;

            var A_diff = A_countAfter - A_countBefore;
            var B_diff = B_countAfter - B_countBefore;
            var A_prc_diff = A_diff != 0 ? (A_countAfter * 100 / A_countBefore) : 0;
            var B_prc_diff = B_diff != 0 ? (B_countAfter * 100 / B_countBefore) : 0;
            A_prc_diff = A_prc_diff - 100 < 0 ? -Math.Abs(A_prc_diff) : A_prc_diff-100;
            B_prc_diff = A_prc_diff - 100 < 0 ? -Math.Abs(B_prc_diff) : B_prc_diff-100;

            using (StreamWriter file =
            new StreamWriter(Path.Combine(Directory.GetCurrentDirectory(), "BookingCount.txt"), true))
            {
                file.WriteLine("================================================");
                file.WriteLine(DateTime.Now);
                file.WriteLine("================================================");
                file.WriteLine("A Total booking before : " + A_countBefore);
                file.WriteLine("A Total booking after : " + A_countAfter);
                file.WriteLine("B Total booking before : " + B_countBefore);
                file.WriteLine("B Total booking after : " + B_countAfter);
                file.WriteLine("A diff : " + A_diff);
                file.WriteLine("B diff : " + B_diff);
                file.WriteLine("A % diff : " + A_prc_diff + "%");
                file.WriteLine("B % diff : " + B_prc_diff + "%");
            }

            resultTextBox.AppendText("A Total booking before : " + A_countBefore);
            resultTextBox.AppendText(Environment.NewLine);
            resultTextBox.AppendText("A Total booking after : " + A_countAfter);
            resultTextBox.AppendText(Environment.NewLine);
            resultTextBox.AppendText("B Total booking before : " + B_countBefore);
            resultTextBox.AppendText(Environment.NewLine);
            resultTextBox.AppendText("B Total booking after : " + B_countAfter);
            resultTextBox.AppendText(Environment.NewLine);
            resultTextBox.AppendText("A diff : " + A_diff);
            resultTextBox.AppendText(Environment.NewLine);
            resultTextBox.AppendText("B diff : " + B_diff);
            resultTextBox.AppendText(Environment.NewLine);
            resultTextBox.AppendText("A % diff : " + A_prc_diff + "%");
            resultTextBox.AppendText(Environment.NewLine);
            resultTextBox.AppendText("B % diff : " + B_prc_diff + "%");
            resultTextBox.AppendText(Environment.NewLine);

            progressBar1.Value = 6;
        }

        private static Dictionary<int,int> LoadHotelsFromCsv(string filePath)
        {
            var reader = new StreamReader(File.OpenRead(filePath));
            reader.ReadLine();
            var result = new Dictionary<int, int>();
            while (!reader.EndOfStream)
            {
                var kvp = HotelBookingCount.FromCsvLine(reader.ReadLine());
                result.Add(kvp.Key, kvp.Value);
            }

            return result;
        }

        private static List<int> LoadAllocateFromText(string filePath)
        {
            var reader = new StreamReader(File.OpenRead(filePath));
            reader.ReadLine();
            var list = new List<int>();
            while (!reader.EndOfStream)
            {
                list.Add(int.Parse(reader.ReadLine()));
            }

            return list;
        }

        private static int GetBookingCount(Dictionary<int,int> bookingCollection, List<int> sampling_group)
        {
            var bookingCount = 0;
          
            foreach (var hotelId in sampling_group)
            {
                var count = 0;
                if (bookingCollection.TryGetValue(hotelId, out count))
                {
                    Console.WriteLine("Found matched hotel id: " + hotelId);
                    bookingCount = bookingCount + count;
                }
            }
            
            return bookingCount;
        }
    }

    public class HotelBookingCount
    {
        public int HotelId { get; private set; }
        public int BookingCount { get; private set; }

        public static KeyValuePair<int, int> FromCsvLine(string line)
        {         
            var split = line.Split(new[] { ',' }, 2);
            return new KeyValuePair<int, int>(int.Parse(split[0]), int.Parse(split[1]));
            
        }
    }
}
