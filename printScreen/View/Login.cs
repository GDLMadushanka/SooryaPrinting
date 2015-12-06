using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Net.Sockets;

namespace printScreen
{
    public partial class Form1 : Form
    {
        private NotifyIcon m_notifyicon;
        private ContextMenu m_menu;
       
        public Form1()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;

     

            m_menu = new ContextMenu();
            m_menu.MenuItems.Add(0,
                new MenuItem("Show", new System.EventHandler(Show_Click)));
            m_menu.MenuItems.Add(1,
                new MenuItem("Hide", new System.EventHandler(Hide_Click)));
            m_menu.MenuItems.Add(2,
                new MenuItem("Exit", new System.EventHandler(Exit_Click)));

            m_notifyicon = notifyIcon1;
            m_notifyicon.Visible = true;
            m_notifyicon.ContextMenu = m_menu;
        }

        protected void Exit_Click(Object sender, System.EventArgs e)
        {
            notifyIcon1.Icon = null;
            Close();
        }
        protected void Hide_Click(Object sender, System.EventArgs e)
        {
            Hide();
        }
        protected void Show_Click(Object sender, System.EventArgs e)
        {
            Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           // clientSocket.Connect("192.168.1.185", 8888);
           
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Icon = null;
        }
        private void Form1_Resize(object sender, System.EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {    
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewWork a = new AddNewWork();
            a.Show();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
