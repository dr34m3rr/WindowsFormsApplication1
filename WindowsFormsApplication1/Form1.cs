using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double func(double ix)
        {
            // return ix * Math.Exp(-(1 / ((ix + 1) * (ix + 1) + 1))) - (ix + 1) * Math.Exp(-(1 / ((ix - 1) * (ix - 1) + 1)));
             //return Math.Cos(ix);
             return Math.Pow(ix,3)-ix;
        }

        private double funcL(double ix)
        {
           // return Math.Abs(Math.Sin(ix));
             return Math.Abs(3*Math.Pow(ix,2)-1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, ep, L, x1=0, x2=0, fx1, fx2,i,x0;
            a = double.Parse(pa.Text.Replace('.',','));
            b = Convert.ToDouble(pb.Text.Replace('.', ','));
            ep = Convert.ToDouble(eps.Text.Replace('.', ','));
            L = funcL(a);
            for (i = a; i <= b; i += ep)
            {
                if (funcL(i) > L)
                {
                    L = funcL(i);
                }
            }
            Lip.Text = L.ToString() ;
            // x0 = (a + b) / 2 + (Math.Cos(a) / (a * a) - Math.Cos(b) / (b * b)) / (2 * L);
            x0 = Convert.ToDouble(x0tb.Text);
            // x0tb.Text = x0.ToString();
            resultBox.Text = "";
            int iter = 1;
            while(Math.Abs(a- b) >= ep)
            {
                x1 = ((a + x0) / 2) + ((func(a) - func(x0)) / (2 * L));
                x2 = ((x0 + b) / 2) + ((func(x0) - func(b)) / (2 * L));
                fx1 = func(x1);
                fx2 = func(x2);
                resultBox.Text += "Iter: " + iter + " ..  x1: " + Math.Round(x1, 3) + "  x2: " + Math.Round(x2, 3) + "  f(x1): " + Math.Round(fx1, 3) + " f(x2): " + Math.Round(fx2, 3) + Environment.NewLine;
                if(fx1 > fx2)
                {
                    a = x1;
                    x0 = x2;
                }
                else
                {
                    b = x2;
                    x0 = x1;
                }
                iter++;
                
            }
            if(func(x1) < func(x2))
            {
                xbox.Text = Math.Round(x1, 4).ToString();
                fxbox.Text = Math.Round(func(x1), 5).ToString();
            }
            else
            {
                xbox.Text = Math.Round(x2, 4).ToString();
                float temp = (float)Math.Round(func(x2), 5);
                fxbox.Text = temp.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
