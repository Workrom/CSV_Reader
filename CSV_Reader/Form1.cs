using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        public string csvFilePath = "C:\\Users\\Workrom\\source\\repos\\CSV_Reader\\CSV_Reader\\Employees.csv";
        private CsvHandler csvHandler;

        public DataTable newDataTable;
        public Form1()
        {
            InitializeComponent();
            csvHandler = new CsvHandler();

            Write_PRbool.Items.Add("True");
            Write_PRbool.Items.Add("False");

            newDataTable = new DataTable();
            newDataTable.Columns.Add("Name");
            newDataTable.Columns.Add("Age");
            newDataTable.Columns.Add("Programmer");
        }

        private void Readbtn_Click(object sender, EventArgs e)
        {
            DataTable csvData = csvHandler.ReadCsv(csvFilePath);

            dataGridView1.DataSource = csvData;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Writebtn_Click(object sender, EventArgs e)
        {
            csvHandler.WriteCsv(csvFilePath, newDataTable);

            MessageBox.Show("Data saved successfully!");
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            Load();
        }
        public DataTable Load()
        {
            string name = Write_Nametxb.Text;
            int age = (int)WRite_AgeNum.Value;
            bool programmer = false;
            if (Write_PRbool.SelectedIndex != -1)
            {
                programmer = bool.Parse(Write_PRbool.SelectedItem.ToString());
            }

            newDataTable.Rows.Add(name, age, programmer);
            dataGridView2.DataSource = newDataTable;

            return newDataTable;
        }

        private void ClearAllbtn_Click(object sender, EventArgs e)
        {
            newDataTable.Rows.Clear();
            dataGridView2.DataSource = null;
        }
    }
}
