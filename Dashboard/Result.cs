using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Total;
//using Average;
using System.Reflection;

namespace Dashboard
{
    public partial class Result : Form
    {
        public static int selectedOption { get; set; }
        public static string currentDirectory;
        
        public Result()
        {
            InitializeComponent();
            //MessageBox.Show(Convert.ToString(selectedOption));
        }

        public void FLoad(string fileName)
        {
            
        }
        

        private void Result_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            string fileName = DashBoard.FileName;
            //MessageBox.Show(fileName);
            txtFileName.Text = fileName;

            gridResult.DataSource = null;
            gridResult.AutoGenerateColumns = false;
            gridResult.ColumnCount = 3;

            gridResult.Columns[0].Name = "serialNo";
            gridResult.Columns[0].HeaderText = "S No.";
            gridResult.Columns[0].DataPropertyName = "serialNo";

            gridResult.Columns[1].Name = "force";
            gridResult.Columns[1].HeaderText = "Force";
            gridResult.Columns[1].DataPropertyName = "Force";

            gridResult.Columns[2].Name = "displacement";
            gridResult.Columns[2].HeaderText = "Displacement";
            gridResult.Columns[2].DataPropertyName = "displacement";
            gridResult.DataSource = GetData(fileName);
        }

        private DataTable GetData(string fileName)
        {
            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[3]
            {
                new DataColumn("serialNo"),
                new DataColumn("force"),
                new DataColumn("displacement")
            });

            dt.Columns["serialNo"].AutoIncrement = true;
            dt.Columns["serialNo"].AutoIncrementSeed = 1;
            dt.Columns["serialNo"].AutoIncrementStep = 1;

            List<decimal> listForce = new List<decimal>();
            List<decimal> listDisplacement = new List<decimal>();

            string[] x = null;
            var input = x;
            long lineCount = 0;

            try
            {
                input = File.ReadAllLines(@fileName);
                lineCount = input.Length;

                for (int i = 13; i < lineCount; i++)
                {
                    var line = input[i];
                    var values = line.Split(',');
                    dt.Rows.Add(null, values[0], values[1]);
                    listForce.Add(Convert.ToDecimal(values[0]));
                    listDisplacement.Add(Convert.ToDecimal(values[1]));
                }
                //MessageBox.Show(selectedOption.ToString());
                if (selectedOption == 0)
                {
                    findTotal(listForce,listDisplacement);
                    
                }
                if (selectedOption == 1)
                {
                    findAverage(listForce,listDisplacement);
                    
                }

            }
            catch(Exception ex)
            {

            }
                return dt;
        }

        private void findAverage(List<decimal> listForce, List<decimal> listDisplacement)
        {
            currentDirectory = Directory.GetCurrentDirectory();
            //MessageBox.Show(currentDirectory);

            //string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                Type[] externalDLLTypes = Assembly.LoadFrom(currentDirectory + "\\AddInFolder\\Average.dll").GetTypes();

                dynamic avgFinder = Activator.CreateInstance(externalDLLTypes[0]);

                var avgValues = avgFinder.FindAverage(listForce, listDisplacement);
                txtTotalForce.Text = Convert.ToString(avgValues.Item1);
                txtTotalDisplacement.Text = Convert.ToString(avgValues.Item2);
                lblResult.Text = "Average";
                lblResultForce.Text = "Average Force";
                lblResultDisplacement.Text = "Average Displacement";
                pnlColor.BackColor = Color.LawnGreen;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void findTotal(List<decimal> listForce, List<decimal> listDisplacement)
        {
            currentDirectory = Directory.GetCurrentDirectory();
            /*total t = new total();
            var totalValues = t.FindTotalForce(listForce, listDisplacement);
            
            */
            try
            {
                Type[] externalDLLType = Assembly.LoadFrom(currentDirectory + "\\AddInFolder\\Total.dll").GetTypes();

                dynamic totalFinder = Activator.CreateInstance(externalDLLType[0]);

                var totalValues = totalFinder.FindTotalForce(listForce, listDisplacement);
                txtTotalForce.Text = Convert.ToString(totalValues.Item1);
                txtTotalDisplacement.Text = Convert.ToString(totalValues.Item2);
                lblResult.Text = "Total";
                lblResultForce.Text = "Total Force";
                lblResultDisplacement.Text = "Total Displacement";
                pnlColor.BackColor = Color.Fuchsia;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
