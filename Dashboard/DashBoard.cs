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
//using CsvHelper;
//using Total;

namespace Dashboard
{
    public partial class DashBoard : Form
    {
        public static string FileName { get; set; }
        //public static int selectedOption = 0;
        public DashBoard()
        {
            InitializeComponent();
            cmbResultSelect.SelectedItem = "Total";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            string extension;
            file.ShowDialog();
            file.InitialDirectory = @"C:\";
            file.RestoreDirectory = true;
            file.Title = "Open Data Files";
            file.DefaultExt = "csv";
            file.Filter = "CSV files (*.csv)|*.csv";
            file.CheckFileExists = true;
            file.CheckPathExists = true;
            string fileName = file.FileName;
            FileName = fileName;
            //MessageBox.Show(FileName);
            extension = Path.GetExtension(FileName);
            //MessageBox.Show(extension);

            if (extension == ".csv")
            {
                string valueComboBox;
                valueComboBox = cmbResultSelect.Text;
                //MessageBox.Show(valueComboBox);
                if (valueComboBox=="Total")
                {
                    //start the result for total.
                    Result r = new Result();
                    Result.selectedOption = 0;
                    //MessageBox.Show(FileName);
                    r.Show();
                    
                }
                if (valueComboBox=="Average")
                {
                    Result r = new Result();
                    Result.selectedOption = 1;
                    r.Show();
                    //MessageBox.Show(selectedOption.ToString());
                }
            }
            else
            {
                MessageBox.Show("The file is not csv type please select csv files");
            }
        }
    }
}
