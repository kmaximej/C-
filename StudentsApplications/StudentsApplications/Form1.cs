using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace StudentsApplications
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            


            for(int day = 1; day <= 31; day++) {
                comboBox1.Items.Add(day);
            }

            String[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };


            foreach(string m in month)
            {
                comboBox2.Items.Add(m);
            }
            for(int year = 1900; year <= 2024; year++)
            {
                comboBox3.Items.Add(year);
            }

            ArrayList programs = new ArrayList();
            programs.Add("Bachelor of Science in Computer Science");
            programs.Add("Bachelor of Science in Information Technology");
            programs.Add("Bachelor of Science in Information Systems");
            programs.Add("Bachelor of Science in Computer Engineering");
            
            foreach (string p in programs)
            {
                comboBox4.Items.Add(p);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String lastName, firstName, middleName;
            String gender;
            String program = comboBox4.Text; 
            String day = comboBox3.Text;
            String month = comboBox4.Text;  
            String year = comboBox3.Text;
            
           

            lastName = textBox1.Text;
            firstName = textBox2.Text;
            middleName = textBox3.Text;

            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else { 
                radioButton2.Checked = false;
                gender = radioButton2.Text;
            }

            if (firstName != null && middleName != null && lastName != null && gender != null && program != null && day != "-Day-" && month != "-Month-" && year != "-Year-")
            {

                PersonalInfo(lastName, firstName, middleName, gender, program, day, month, year);

            }
            else if (firstName != null && middleName != null && lastName != null && program != null) {

                PersonalInfo(lastName, firstName, middleName, program);

            }
            else if (firstName != null && lastName != null && program != null){

                PersonalInfo(lastName, firstName, program);
            }


        }
        private void PersonalInfo(string lastName, string firstName, string middleName, string gender, string program, string day,string month, string year) {

            MessageBox.Show("Student name: " + firstName + " " + middleName + " " + lastName
                + "\nGender: " + radioButton1.Text
                + " \nDate of birth: " + day + "/" + month + "/" + year
                + "\nProgram: " + comboBox4.Text);
        }

        private void PersonalInfo(string lastName, string firstName, string middleName, string program) {

            MessageBox.Show("Student name: " + firstName + " " + middleName + " " + lastName
                   + "\nPrograms: " + comboBox4.Text);

        }
        private void PersonalInfo(string LastName, string FirstName, string program) {

            MessageBox.Show("Student name: " + FirstName + " " + " " + LastName
                     + "\nPrograms: " + comboBox4.Text);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

            openFileDialog1.InitialDirectory = "";
            openFileDialog1.Title = "Picures";
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);       

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
