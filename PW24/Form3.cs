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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => a + b);
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => a - b);
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => a * b);
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => a / b);
        }

        private void PerformOperation(Func<decimal, decimal, decimal> operation)
        {
            if (decimal.TryParse(textBoxNum1.Text, out decimal num1) && decimal.TryParse(textBoxNum2.Text, out decimal num2))
            {
                try
                {
                    decimal result = operation(num1, num2);
                    labelResult.Text = $"Результат: {result}";
                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("Деление на ноль невозможно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числа", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
        }
    }
}