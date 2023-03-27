using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            /*
            H-высота
            v0-начальная скорость
            hmax-максимальная высота
            k0-кинетическая энергия
            Pmax-потенциальная энергия
            m-масса прыгуна
            g-9.81
            m*g*hmax=(m*v0^2)/2
            Cp - коэффициент лобового сопротивления парашюта
            A - площадь поперечного сечения парашюта
            ρ - плотность воздуха
            v - скорость приземления
            Pp - потенциальная энергия, которая тратится на подъем парашюта
            0.5*Cp*A*ρ*v^2 = m*g*(H-hmax) + m*g*hmax + Pp
            A=(+ m*g*(H-hmax) + m*g*hmax + Pp)/(+0.5*Cp**ρ*v**2 )

            V = sqrt(2*m*g*(1-Cd)*A/ρ) * sqrt(h)

            Скорость приземления (V) зависит от
            высоты прыжка (h),
            площади парашюта (A), 
            массы прыгающего (m), 
            аэродинамических свойств парашюта (Cd) 
            воздушного сопротивления (ρ):

                V = sqrt(2*m*g*(1-Cd)*A/ρ) * sqrt(h)

                где g - ускорение свободного падения.
            */

            double H, m, A, p, Cd;
            double g = 9.81;
            m = 80;
            A = 3;
            p = 1.29;
            Cd = 1.22;
            H = 2000;

            double V = Math.Sqrt(2 * m * g * (1 - Cd) * A / p) * Math.Sqrt(H);
            Mass.Text = V.ToString();






            this.chart1.Series[0].Points.Clear();


            

        }
    }
}
