using printScreen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace printScreen
{
    public partial class Other : Form
    {
      
        AddNewWork main;
        public Other(AddNewWork main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void Other_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float f;
            if (float.TryParse(textBox4.Text, out f))
            {
                if (!richTextBox1.Text.Equals(String.Empty))
                {
                    //Creating a model
                    Models.Other Obj = new Models.Other();
                    Obj.Amount = f;
                    Obj.Description = richTextBox1.Text;
                    //send model to update table
                    main.UpdateTableOther(Obj);

                    richTextBox1.Clear();
                    textBox4.Clear();
                }
                else { MessageBox.Show("Description is compulsory","Invalid Input"); }
            }
            else { MessageBox.Show("Invalid input for amount", "Invalid Input");}
            

            
        }
    }
}
