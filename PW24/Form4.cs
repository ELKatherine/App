using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PW24
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            PerformTrigonometricOperation(Math.Sin);
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            PerformTrigonometricOperation(Math.Cos);
        }

        private void buttonCtan_Click(object sender, EventArgs e)
        {
            PerformTrigonometricOperation(Math.Tan);
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            PerformTrigonometricOperation(angle => 1 / Math.Tan(angle));
        }
        private void PerformTrigonometricOperation(Func<double, double> operation)
        {
            if (double.TryParse(textBoxAngle.Text, out double angle))
            {
                double angleInRadians = angle * (Math.PI / 180);
                double result = operation(angleInRadians);
                labelResult.Text = $"Результат: {result}";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректный угол.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Form1 newform = new Form1();
                newform.Show();
            }
        }
    }
