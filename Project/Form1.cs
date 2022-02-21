using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace Project
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
       
       
        public Form1()
        {


            InitializeComponent();
            
           

            var skinManger = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);



            this.MaximizeBox = false;
            panelAbout.Hide();
            SidePanel.Height = btnPatient.Height;
            SidePanel.Top = btnPatient.Top;


            Patients.BringToFront();
        }

        private void btnPatient_click(object sender, EventArgs e)
        {
            SidePanel.Height = btnPatient.Height;
            SidePanel.Top = btnPatient.Top;
            Patients.BringToFront();

        }

        private void btnDoctor_click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDoctor.Height;
            SidePanel.Top = btnDoctor.Top;
            Doctors.BringToFront();
        }

        private void btnRooms_click(object sender, EventArgs e)
        {
            SidePanel.Height = btnRooms.Height;
            SidePanel.Top = btnRooms.Top;
            Rooms.BringToFront();



        }

        private void btnStats_click(object sender, EventArgs e)
        {
            SidePanel.Height = btnStats.Height;
            SidePanel.Top = btnStats.Top;
            Planner.BringToFront();
        }

        private void btnMedicine_click(object sender, EventArgs e)
        {
            SidePanel.Height = btnMedicine.Height;
            SidePanel.Top = btnMedicine.Top;
            Medicine.BringToFront();
        }

        private void btnEmail_click(object sender, EventArgs e)
        {
            SidePanel.Height = btnEmail.Height;
            SidePanel.Top = btnEmail.Top;
            Email.BringToFront();

        }

      

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            panelAbout.BringToFront();
            panelAbout.Show();
        }

        private void closeAbout_click(object sender, EventArgs e)
        {
            panelAbout.Hide();
        }

     

       
    }
}
