using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace printScreen
{
    public partial class AddNewWork : Form
    {
        DataTable dt = new DataTable();
        List<Models.Work> WorkList = new List<Models.Work>();
        public AddNewWork()
        {
            InitializeComponent();
            dt.Columns.Add(new System.Data.DataColumn("Type", typeof(String)));
            dt.Columns.Add(new System.Data.DataColumn("Amount", typeof(String)));
            dt.Columns.Add(new System.Data.DataColumn("Description", typeof(String)));
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddNewWork_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Other other = new Other(this);
            other.Show();   
        }

        public void UpdateTableOther(Models.Other work)
        {
            // creating a data raw
            work.TableIndex = dataGridView1.NewRowIndex+1;
            DataRow dr;
            dr = dt.NewRow();
            dr[0] = "Other";
            dr[1] = work.Amount;
            dr[2] = work.Description;
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;
            WorkList.Add(work);
        }
        public void UpdateTableTypeSetting(Models.TypeSetting work)
        {
            // creating a data raw
            work.TableIndex = dataGridView1.NewRowIndex + 1;
            DataRow dr;
            dr = dt.NewRow();
            dr[0] = "Type Setting";
            dr[1] = work.Amount;
            dr[2] = "Sinhala " + work.IsSinhala + " pages " + work.Pages + " file " + work.FileName + " size " + work.Size;
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;
            WorkList.Add(work);
        }

        public void UpdateTableLaminate(Models.Laminate work)
        {
            // creating a data raw
            work.TableIndex = dataGridView1.NewRowIndex + 1;
            DataRow dr;
            dr = dt.NewRow();
            dr[0] = "Laminate";
            dr[1] = work.Amount;
            dr[2] = "Size "+work.Size +" Quantity "+work.Quantity;
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;
            WorkList.Add(work);
        }

        public void UpdateTableDuplo(Models.Duplo work)
        {
            // creating a data raw
            work.TableIndex = dataGridView1.NewRowIndex + 1;
            DataRow dr;
            dr = dt.NewRow();
            dr[0] = "Duplo";
            dr[1] = work.Amount;
            dr[2] = "Colour A4 " + work.IsColourA4 + " Single Side " + work.IsSingleSide+" Quantity "+work.Quantity +" Size "+work.Size;
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;
            WorkList.Add(work);
        }

        public void UpdateTablePCopy(Models.PhotoCopy work)
        {
            // creating a data raw
            work.TableIndex = dataGridView1.NewRowIndex + 1;
            DataRow dr;
            dr = dt.NewRow();
            dr[0] = "Photo copy";
            dr[1] = work.Amount;
            dr[2] = " Single Side " + work.ISSingleSide + " Quantity " + work.Quantity + " Size " + work.Size;
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;
            WorkList.Add(work);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int x = dataGridView1.CurrentRow.Index;
                WorkList.RemoveAll(m => m.TableIndex == x);
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (var item in WorkList)
            {
                Console.WriteLine(item.Amount);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Duplo duplo = new Duplo(this);
            duplo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Laminate laminate = new Laminate(this);
            laminate.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhotoCopy pcopy = new PhotoCopy(this);
            pcopy.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TypeSetting TSetting = new TypeSetting(this);
            TSetting.Show();
        }
    }
}
