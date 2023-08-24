using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<product_data> datas = new List<product_data>();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                product_data item = new product_data();
                item.description = dataGridView1.Rows[i].Cells[0].FormattedValue.ToString();
                item.price = dataGridView1.Rows[i].Cells[1].FormattedValue.ToString();
                item.qty = dataGridView1.Rows[i].Cells[2].FormattedValue.ToString();
                item.total_price = dataGridView1.Rows[i].Cells[3].FormattedValue.ToString();
                datas.Add(item);
            }
            reportbill bill = new reportbill(textBox1.Text,textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text,textBox10.Text,textBox11.Text,textBox12.Text,textBox13.Text,"",datas);
            bill.Show();
        }
    }
}
