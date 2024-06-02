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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string product = textBoxProduct.Text;
            if (decimal.TryParse(textBoxPrice.Text, out decimal price) && int.TryParse(textBoxQuantity.Text, out int quantity))
            {
                // Вычисление общей стоимости
                decimal totalCost = price * quantity;

                // Отображение результата
                labelResult.Text = $"Стоимость {product}: {totalCost} руб.";
            }
            else
            {
                // Вывод ошибки, если данные некорректны
                MessageBox.Show("Пожалуйста, введите корректные значения для цены и количества.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
        }
    }
}
