using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hashiv
{
    public partial class Form1 : Form
    {
        int result = 0;
        List<int> data= new List<int>();
        List<string> date = new List<string>();
        List<string> expenses = new List<string>();

        int change = 0;
        string dateTime;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            result = 0;
            data.Clear();
            if(string.IsNullOrWhiteSpace(textBox1.Text))
            {
                data.Add(0);
            }
            else
            {
                data.Add(Convert.ToInt32(textBox1.Text));

            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                data.Add(0);
            }
            else
            {
                data.Add(Convert.ToInt32(textBox2.Text));
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                data.Add(0);
            }
            else
            {
                data.Add(Convert.ToInt32(textBox3.Text));
            }
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                data.Add(0);
            }
            else
            {
                data.Add(Convert.ToInt32(textBox4.Text));
            }
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                data.Add(0);
            }
            else
            {
                data.Add(Convert.ToInt32(textBox5.Text));
            }
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                data.Add(0);
            }
            else
            {
                data.Add(Convert.ToInt32(textBox6.Text));
            }

            for(int i=0; i<data.Count;i++)
            {
                result = result + data[i];
            }
            dateTime = $"{dateTimePicker1.Value.Year} / {dateTimePicker1.Value.Month} / {dateTimePicker1.Value.Day}";
            date.Add(dateTime);


            label9.Visible = false; 
            Label labelnew = new Label();

            labelnew.AutoSize = true;
            labelnew.Text = dateTime;
            //labelnew.Font.Size = 15f;
            change += 30;
            labelnew.Location= new Point(labelnew.Location.X, labelnew.Location.Y+change);

            panel2.Controls.Add(labelnew);
            panel1.Visible = false;
            panel2.Visible = true;

           // Label results = new Label();
           // results.Text = dateTime;
            string last = $"Transport: {data[0]} \n Lunch: {data[1]} \n Coffee: {data[2]} \n Others: {data[4]} \n _______________\n Result: {result}";
            expenses.Add(last);
            // results.Location = new Point(32, 12+ (+ change+50));
            //   results.AutoSize= true;
            //  this.Controls.Add(results);

            labelnew.Click += new EventHandler(labelClick);

        }

        private void labelClick(object sender, EventArgs e)
        {
            label9.Visible = true;
            Label Clicked= sender as Label;

            int index = date.IndexOf(Clicked.Text);
            label9.Text = expenses[index];
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Visible = false;  
            panel1.Visible = true;
            panel2.Visible=false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label9.Visible = false;
        }
    }
}
