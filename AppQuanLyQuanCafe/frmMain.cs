﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyQuanCafe
{
    public partial class frmMain : Form
    {
        Timer timer;
        public frmMain()
        {
            InitializeComponent();
           
            DateTime currentTime = DateTime.Now;
            timer = new Timer();
            timer.Interval = 100;

            // Gắn sự kiện Tick của Timer với phương thức xử lý sự kiện Timer_Tick
            timer.Tick += Timer_Tick;
            
            // Bắt đầu Timer
            timer.Start();
            OpenChildForm(new frmHome());

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Lấy thời gian đồng hồ hiện tại
            DateTime currentTime = DateTime.Now;

            // Gán thời gian vào một Label có tên là labelClock
            lblHi.Text = " Hế nhô, hiện tại là: " + currentTime.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
             OpenChildForm(new frmHome());
            
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null) { 
            currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle=FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnTableList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTableList());
        }
        private void btnBill_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBill());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMenu());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCategory());
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRevuene2());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAccount());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void lblPage_Click(object sender, EventArgs e)
        {

        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Top_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
