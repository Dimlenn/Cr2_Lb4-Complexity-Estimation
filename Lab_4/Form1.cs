using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void SetGraphic(object sender, EventArgs e)
        {
            double n, y1, y2;
            for (n = 0.01; n < 30; n += 0.01)
            {
                y1 = 10.5 * n * n * n + 5 * n * n + 5 * n + 18;
                y2 = 5045 * n + 5;

                chart1.Series[0].Points.AddXY(n, y1);
                chart1.Series[1].Points.AddXY(n, y2);
            }
        }
    }
}
