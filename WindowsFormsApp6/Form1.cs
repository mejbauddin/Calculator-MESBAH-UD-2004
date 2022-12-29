using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {

        Double valu = 0;
        String text = "";
        bool oper_press = false;

        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            //timer interval
            t.Interval = 1000; //in milliseconds

            t.Tick += new EventHandler(this.t_Tick);
            //start timer when form loads
            t.Start(); //this will use t_Tick() method
        }

        //timer eventhandler
        private void t_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";


            //padding leading Zero
            if (hh < 10)
            {

                time += "0" + hh;

            }
            else
            {

                time += hh;

            }
            time += ":";

            if (mm < 10)
            {

                time += "0" + mm;
            }
            else
            {

                time += mm;

            }
            time += ":";

            if (ss < 10)
            {

                time += "0" + ss;

            }
            else
            {

                time += ss;

            }

            //upload label2
            label2.Text = time;

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if ((outpu.Text == "0")||(oper_press))
            {
                outpu.Clear();
            }

            Button button = (Button)sender;
            outpu.Text = outpu.Text + button.Text;
            oper_press = false;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            outpu.Text = "0";
        }

        private void op_pres(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            text = button.Text;
            valu = Double.Parse(outpu.Text);
            oper_press = true;
        }

        private void op_res(object sender, EventArgs e)
        {
            switch (text)
            {
                case "+":
                    outpu.Text = (valu + Double.Parse(outpu.Text)).ToString();
                    break;
                case "-":
                    outpu.Text = (valu - Double.Parse(outpu.Text)).ToString();
                    break;
                case "/":
                    outpu.Text = (valu / Double.Parse(outpu.Text)).ToString();
                    break;
                case "*":
                    outpu.Text = (valu * Double.Parse(outpu.Text)).ToString();
                    break;
                default:
                    break;
            }
            oper_press = false;
        }

        private void c_pres(object sender, EventArgs e)
        {
            outpu.Clear();
            valu = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
