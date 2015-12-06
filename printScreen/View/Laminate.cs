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
    public partial class Laminate : Form
    {
        AddNewWork main;
        int quantity;
        float amount;
        float rate;
        public Laminate(AddNewWork main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void Laminate_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: { rate = Properties.Settings.Default.LaminateID; break; }
                case 1: { rate = Properties.Settings.Default.Laminate3R; break; }
                case 2: { rate = Properties.Settings.Default.Laminate4R; break; }
                case 3: { rate = Properties.Settings.Default.LaminateA5; break; }
                case 4: { rate = Properties.Settings.Default.LaminateA4; break; }
                case 5: { rate = Properties.Settings.Default.LaminateB4; break; }
                case 6: { rate = Properties.Settings.Default.LaminateA3; break; }
                case 7: { rate = Properties.Settings.Default.LaminateLegal; break; }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox2.Text, out amount))
            {
                if (int.TryParse(textBox1.Text, out quantity))
                {
                    if (!comboBox1.Text.Equals(String.Empty))
                    {
                        //Creating a model
                        Models.Laminate Obj = new Models.Laminate();
                        Obj.Amount = amount;
                        Obj.Size = comboBox1.Text;
                        Obj.Quantity = quantity;
                        //send model to update table
                        main.UpdateTableLaminate(Obj);
                    }
                    else { MessageBox.Show("Please select a size", "Invalid Input"); }
                }
                else { MessageBox.Show("Invalid Quantity", "Invalid Input"); }
            }
            else { MessageBox.Show("Invalid input for amount", "Invalid Input"); }
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            comboBox1.Text = String.Empty;
        }

        private void textBox2_GotFocus(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out quantity))
            {
                amount = rate * quantity;
                textBox2.Text = amount.ToString();
            }
        }
    }
}
