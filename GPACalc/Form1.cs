using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GPACalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBox cbGrade = new ComboBox();
            cbGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrade.Items.Add("AA");
            cbGrade.Items.Add("BA");
            cbGrade.Items.Add("BB");
            cbGrade.Items.Add("CB");
            cbGrade.Items.Add("CC");
            cbGrade.Items.Add("DC");
            cbGrade.Items.Add("DD");
            cbGrade.Items.Add("FD");
            cbGrade.Items.Add("FF");
            cbGrade.Width = 50;
            cbGrade.SelectedIndex = 0;
            flowLayoutPanel1.Controls.Add(cbGrade);
            TextBox txtCredit = new TextBox();
            txtCredit.Width = 60;
            txtCredit.TextAlign = HorizontalAlignment.Right;
            flowLayoutPanel1.Controls.Add(txtCredit);
            TextBox txtGPA = new TextBox();
            txtGPA.Width = 80;
            txtGPA.ReadOnly = true;
            txtGPA.TextAlign = HorizontalAlignment.Right;
            flowLayoutPanel1.Controls.Add(txtGPA);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComboBox cbGrade = new ComboBox();
            cbGrade.Items.Add("AA");
            cbGrade.Items.Add("BA");
            cbGrade.Items.Add("BB");
            cbGrade.Items.Add("CB");
            cbGrade.Items.Add("CC");
            cbGrade.Items.Add("DC");
            cbGrade.Items.Add("DD");
            cbGrade.Items.Add("FD");
            cbGrade.Items.Add("FF");
            cbGrade.Width = 50;
            cbGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrade.SelectedIndex = 0;
            flowLayoutPanel1.Controls.Add(cbGrade);

            TextBox txtCredit = new TextBox();
            txtCredit.Width = 60;
            txtCredit.TextAlign = HorizontalAlignment.Right;
            flowLayoutPanel1.Controls.Add(txtCredit);
            
            TextBox txtGPA = new TextBox();
            txtGPA.Width = 80;
            txtGPA.ReadOnly = true;
            txtGPA.TextAlign = HorizontalAlignment.Right;
            flowLayoutPanel1.Controls.Add(txtGPA);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count > 3)
            {
                flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
                flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
                flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double grade = 0.0;
            double credit = 0.0;
            double totalCredit = 0.0;
            double gpa = 0.0;
            double totalGpa = 0.0;

            double cgpa = 0.0;

            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i+=3)
            {
                switch ((flowLayoutPanel1.Controls[i] as Control).Text)
	            {
                    case "AA":
                        grade = 4.0;
                    break;
                    case "BA":
                        grade = 3.5;
                    break;
                    case "BB":
                        grade = 3.0;
                    break;
                    case "CB":
                        grade = 2.5;
                    break;
                    case "CC":
                        grade = 2.0;
                    break;
                    case "DC":
                        grade = 1.5;
                    break;
                    case "DD":
                        grade = 1.0;
                    break;
                    case "FD":
                        grade = 0.5;
                    break;
                    case "FF":
                        grade = 0.0;
                    break;
                }
                credit = Convert.ToDouble((flowLayoutPanel1.Controls[i + 1] as Control).Text == "" ? "0" : (flowLayoutPanel1.Controls[i + 1] as Control).Text);
                (flowLayoutPanel1.Controls[i + 2] as Control).Text = (grade * credit).ToString();
                gpa = grade * credit;
                totalCredit += credit;
                totalGpa += gpa;
            }
            cgpa = Math.Round(Convert.ToDouble(totalGpa/totalCredit),2);
            lblTotalCredit.Text = "Total Credit: " + totalCredit.ToString();
            lblGPA.Text = "CGPA: " + cgpa.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,"Author Harun CETIN (c) 2019 (hcetin01@hotmail.com)","About");
        }
    }
}
