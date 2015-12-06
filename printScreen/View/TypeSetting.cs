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
    public partial class TypeSetting : Form
    {
        AddNewWork main;
        public TypeSetting(AddNewWork main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void TypeSetting_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string filepath = openFileDialog1.FileName;
                string file = openFileDialog1.SafeFileName;
                textBox3.Text = file;
                if (!filepath.Contains(Properties.Settings.Default.FolderPath))
                {
                    MessageBox.Show("File outside your default saving folder","Invalid directory");
                    textBox3.Clear();
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float f;
            int quantity;
            if (float.TryParse(textBox4.Text, out f))
            {
                if (int.TryParse(textBox1.Text, out quantity))
                {
                    if (!comboBox1.Text.Equals(String.Empty))
                    {
                        if (!textBox3.Text.Equals(String.Empty))
                        {
                            //Creating a model
                            Models.TypeSetting Obj = new Models.TypeSetting();
                            Obj.Amount = f;
                            Obj.Pages = quantity;
                            Obj.Size = comboBox1.Text;
                            if (radioButton3.Checked){Obj.IsSinhala = true;}
                            else if (radioButton4.Checked) { Obj.IsSinhala =false; }
                            Obj.FileName = textBox3.Text;
                            //send model to update table
                            main.UpdateTableTypeSetting(Obj);
                        }
                        else { MessageBox.Show("Please select your file", "Invalid Input"); }
                    }
                    else { MessageBox.Show("Please select a size", "Invalid Input"); }
                }
                else { MessageBox.Show("Invalid Quantity", "Invalid Input"); }
            }
            else { MessageBox.Show("Invalid input for amount", "Invalid Input"); }
            comboBox1.Text = String.Empty;
            textBox1.Text= String.Empty; 
            textBox3.Text= String.Empty;
            textBox4.Text= String.Empty;
        }
    }
}
