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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            #region getProp

            textBox1.Text = Properties.Settings.Default.ServerIp;
            textBox2.Text = Properties.Settings.Default.PhotoCopy_A4S.ToString();
            textBox3.Text = Properties.Settings.Default.PhotoCopy_A4D.ToString();
            textBox4.Text = Properties.Settings.Default.PhotoCopy_A3S.ToString();
            textBox5.Text = Properties.Settings.Default.PhotoCopy_A3D.ToString();
            textBox6.Text = Properties.Settings.Default.PhotoCopy_B4S.ToString();
            textBox7.Text = Properties.Settings.Default.PhotoCopy_B4D.ToString();
            textBox8.Text = Properties.Settings.Default.PhotoCopy_A5S.ToString();
            textBox9.Text = Properties.Settings.Default.PhotoCopy_A5D.ToString();
            textBox10.Text = Properties.Settings.Default.PhotoCopy_LegalS.ToString();
            textBox11.Text = Properties.Settings.Default.PhotoCopy_LegalD.ToString();
            textBox12.Text = Properties.Settings.Default.PhotoCopy_ID.ToString();
            textBox13.Text = Properties.Settings.Default.PhotoCopy_B5S.ToString();
            textBox14.Text = Properties.Settings.Default.PhotoCopy_B5D.ToString();

            textBox27.Text = Properties.Settings.Default.LaminateID.ToString();
            textBox26.Text = Properties.Settings.Default.Laminate3R.ToString();
            textBox25.Text = Properties.Settings.Default.Laminate4R.ToString();
            textBox24.Text = Properties.Settings.Default.LaminateA5.ToString();
            textBox22.Text = Properties.Settings.Default.LaminateA4.ToString();
            textBox20.Text = Properties.Settings.Default.LaminateB4.ToString();
            textBox18.Text = Properties.Settings.Default.LaminateA3.ToString();
            textBox16.Text = Properties.Settings.Default.LaminateLegal.ToString();

            textBox30.Text = Properties.Settings.Default.DuploA4S.ToString();
            textBox29.Text = Properties.Settings.Default.DuploA4D.ToString();
            textBox28.Text = Properties.Settings.Default.DuploColourA4S.ToString();
            textBox23.Text = Properties.Settings.Default.DuploColourA4D.ToString();
            textBox21.Text = Properties.Settings.Default.DuploB4S.ToString();
            textBox19.Text = Properties.Settings.Default.DuploB4D.ToString();
            textBox17.Text = Properties.Settings.Default.DuploLegalS.ToString();
            textBox15.Text = Properties.Settings.Default.DuploLegalD.ToString();

            textBox31.Text = Properties.Settings.Default.FolderPath;
            #endregion getProp
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServerIp =  textBox1.Text;
            Properties.Settings.Default.Save();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                Properties.Settings.Default.ServerIp = textBox1.Text.ToString();

                Properties.Settings.Default.PhotoCopy_A4S = float.Parse(textBox2.Text);
                Properties.Settings.Default.PhotoCopy_A4D = float.Parse(textBox3.Text);
                Properties.Settings.Default.PhotoCopy_A3S = float.Parse(textBox4.Text);
                Properties.Settings.Default.PhotoCopy_A3D = float.Parse(textBox5.Text);
                Properties.Settings.Default.PhotoCopy_B4S = float.Parse(textBox6.Text);
                Properties.Settings.Default.PhotoCopy_B4D = float.Parse(textBox7.Text);
                Properties.Settings.Default.PhotoCopy_A5S = float.Parse(textBox8.Text);
                Properties.Settings.Default.PhotoCopy_A5D = float.Parse(textBox9.Text);
                Properties.Settings.Default.PhotoCopy_LegalS = float.Parse(textBox10.Text);
                Properties.Settings.Default.PhotoCopy_LegalD = float.Parse(textBox11.Text);
                Properties.Settings.Default.PhotoCopy_ID = float.Parse(textBox12.Text);
                Properties.Settings.Default.PhotoCopy_B5S = float.Parse(textBox13.Text);
                Properties.Settings.Default.PhotoCopy_B5D = float.Parse(textBox14.Text);

                Properties.Settings.Default.LaminateID = float.Parse(textBox27.Text);
                Properties.Settings.Default.Laminate3R = float.Parse(textBox26.Text);
                Properties.Settings.Default.Laminate4R = float.Parse(textBox25.Text);
                Properties.Settings.Default.LaminateA5 = float.Parse(textBox24.Text);
                Properties.Settings.Default.LaminateA4 = float.Parse(textBox22.Text);
                Properties.Settings.Default.LaminateB4 = float.Parse(textBox20.Text);
                Properties.Settings.Default.LaminateA3 = float.Parse(textBox18.Text);
                Properties.Settings.Default.LaminateLegal = float.Parse(textBox16.Text);

                Properties.Settings.Default.DuploA4S = float.Parse(textBox30.Text);
                Properties.Settings.Default.DuploA4D = float.Parse(textBox29.Text);
                Properties.Settings.Default.DuploColourA4S = float.Parse(textBox28.Text);
                Properties.Settings.Default.DuploColourA4D = float.Parse(textBox23.Text);
                Properties.Settings.Default.DuploB4S = float.Parse(textBox21.Text);
                Properties.Settings.Default.DuploB4D = float.Parse(textBox19.Text);
                Properties.Settings.Default.DuploLegalS = float.Parse(textBox17.Text);
                Properties.Settings.Default.DuploLegalD = float.Parse(textBox15.Text);

                Properties.Settings.Default.FolderPath = textBox31.Text.ToString();
                Properties.Settings.Default.Save();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox31.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
