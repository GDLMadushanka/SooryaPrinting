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
    public partial class Duplo : Form
    {
        AddNewWork main;
        float rate=0f;
     
        public Duplo(AddNewWork main)
        {
            this.main = main;
            InitializeComponent();
        }
      
        private void Duplo_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (radioButton3.Checked)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0: { rate = Properties.Settings.Default.DuploA4S; break; }
                    case 1: { rate = Properties.Settings.Default.DuploColourA4S; break; }
                    case 2: { rate = Properties.Settings.Default.DuploB4S; break; }
                    case 3: { rate = Properties.Settings.Default.DuploLegalS; break; }
                }
            }
            else if (radioButton4.Checked)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0: { rate = Properties.Settings.Default.DuploA4D; break; }
                    case 1: { rate = Properties.Settings.Default.DuploColourA4D; break; }
                    case 2: { rate = Properties.Settings.Default.DuploB4D; break; }
                    case 3: { rate = Properties.Settings.Default.DuploLegalD; break; }
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
                        Models.Duplo Obj = new Models.Duplo();
                        Obj.Amount = f;
                        Obj.Size = comboBox1.Text;
                        if (comboBox1.Text.Contains("Colour"))
                        {
                            Obj.IsColourA4 = true;
                            Obj.Size = "A4";
                        }
                        else { Obj.IsColourA4 = false; }
                        Obj.Quantity = quantity;
                        if (radioButton3.Checked) { Obj.IsSingleSide = true; }
                        else if (radioButton4.Checked) { Obj.IsSingleSide = false; }


                        //send model to update table
                        main.UpdateTableDuplo(Obj);
                    }
                    else { MessageBox.Show("Please select a size", "Invalid Input"); }
                }
                else { MessageBox.Show("Invalid Quantity","Invalid Input"); }
            }
            else { MessageBox.Show("Invalid input for amount", "Invalid Input");}
        }



        private void textBox2_GotFocus(Object sender, EventArgs e)
        {
            int amount;
            if (int.TryParse(textBox1.Text,out amount))
            {
                textBox2.Text = (rate * amount).ToString();
            }
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
