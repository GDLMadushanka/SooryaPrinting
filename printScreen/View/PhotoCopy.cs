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
    public partial class PhotoCopy : Form
    {
        float rate;
        AddNewWork main;
        public PhotoCopy(AddNewWork main)
        {
            this.main = main;
            InitializeComponent();
        }
        private void textBox2_GotFocus(object sender, EventArgs e)
        {
            int amount;
            if (int.TryParse(textBox1.Text, out amount))
            {
                textBox2.Text = (rate * amount).ToString();
            }
        }
        private void PhotoCopy_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0: { rate = Properties.Settings.Default.PhotoCopy_ID; break; }
                    case 1: { rate = Properties.Settings.Default.PhotoCopy_A5S; break; }
                    case 2: { rate = Properties.Settings.Default.PhotoCopy_A4S; break; }
                    case 3: { rate = Properties.Settings.Default.PhotoCopy_B5S; break; }
                    case 4: { rate = Properties.Settings.Default.PhotoCopy_B4S; break; }
                    case 5: { rate = Properties.Settings.Default.PhotoCopy_A3S; break; }
                    case 6: { rate = Properties.Settings.Default.PhotoCopy_LegalS; break; }
                }
            }
            else if (radioButton4.Checked)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0: { rate = Properties.Settings.Default.PhotoCopy_ID; break; }
                    case 1: { rate = Properties.Settings.Default.PhotoCopy_A5D; break; }
                    case 2: { rate = Properties.Settings.Default.PhotoCopy_A4D; break; }
                    case 3: { rate = Properties.Settings.Default.PhotoCopy_B5D; break; }
                    case 4: { rate = Properties.Settings.Default.PhotoCopy_B4D; break; }
                    case 5: { rate = Properties.Settings.Default.PhotoCopy_A3D; break; }
                    case 6: { rate = Properties.Settings.Default.PhotoCopy_LegalD; break; }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float f;
            int quantity;
            if (float.TryParse(textBox2.Text, out f))
            {
                if (int.TryParse(textBox1.Text, out quantity))
                {
                    if (!comboBox1.Text.Equals(String.Empty))
                    {
                        //Creating a model
                        Models.PhotoCopy Obj = new Models.PhotoCopy();
                        Obj.Amount = f;
                        Obj.Size = comboBox1.Text;
                        Obj.Quantity = quantity;
                        if (radioButton3.Checked) { Obj.ISSingleSide = true; }
                        else if (radioButton4.Checked) { Obj.ISSingleSide = false; }
                        //send model to update table
                        main.UpdateTablePCopy(Obj);
                    }
                    else { MessageBox.Show("Please select a size", "Invalid Input"); }
                }
                else { MessageBox.Show("Invalid Quantity", "Invalid Input"); }
            }
            else { MessageBox.Show("Invalid input for amount", "Invalid Input"); }
        }
    }
}
