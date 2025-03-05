using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace Ram
{
    public partial class Form1 : Form
    {
        public ulong TotalMemory { get; set; }
        public string Manufacturer { get; set; }
        public string PartNumber { get; set; }

        public string PartVersion { get; set; }

        public string PartSpeed { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = GetForm1();

            textBox1.Text = "Total RAM: " + Form1.TotalMemory/ 1073741824 + " Gb." + Environment.NewLine;
            textBox1.Text += "Manufacturer: " + Form1.Manufacturer + Environment.NewLine;
            textBox1.Text += "Part Number: " + Form1.PartNumber + Environment.NewLine;
            textBox1.Text += "Product version: " + Form1.PartVersion + Environment.NewLine;
            textBox1.Text += "Product name: " + Form1.ProductName + Environment.NewLine;
            textBox1.Text += "Freq: "+Form1.PartSpeed+Environment.NewLine;

        }
        public static Form1 GetForm1()
        {
            Form1 Form1 = new Form1();

            try
            {
                ManagementScope scope = new ManagementScope();
                ObjectQuery query = new ObjectQuery("SELECT Capacity, Manufacturer, PartNumber FROM Win32_PhysicalMemory");
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query))
                {
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        Form1.TotalMemory += Convert.ToUInt64(obj["Capacity"]);
                        Form1.Manufacturer = obj["Manufacturer"].ToString();
                        Form1.PartNumber = obj["PartNumber"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Form1;
        }
    }
}
