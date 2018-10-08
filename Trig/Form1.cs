using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           richTextBox1.AppendText("sin(180) = " + sin(180) + "\n");
           richTextBox1.AppendText("sin-1 =" + asin(1) + "\n");
           richTextBox1.AppendText("cos(180) = " + cos(180) + "\n");
           richTextBox1.AppendText("cos-1 = " + acos(1) + "\n");
           richTextBox1.AppendText("tan(180) = " + tan(180) + "\n");
           richTextBox1.AppendText("tan-1 = " + atan(1) + "\n");

            Math.Sin(180);
            Math.Asin(1);
            Math.Cos(180);
            Math.Acos(1);
            Math.Tan(180);
            Math.Atan(1);
        }
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180));
        }
        double asin(double x)
        {
            return (Math.Asin(x*180 / Math.PI));
        }
        double cos(double y)
        {
            return (Math.Cos(y * Math.PI / 180));
        }
        double acos(double y)
        {
            return (Math.Acos(y * 180 / Math.PI));
        }
        double tan(double z)
        {
            return (Math.Tan(z * Math.PI / 180));
        }
        double atan(double z)
        {
            return (Math.Atan(z * 180 / Math.PI));
        }
    }
}
