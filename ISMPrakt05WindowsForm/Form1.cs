using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArrLibrary;

namespace ISMPrakt05WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(numericUpDownArrSize.Value);
            if(size<1)
            {
                MessageBox.Show("Неправильно введений розмір масиву");
            }
            else
            {
                Random ran = new Random();
                int[] arr = new int[size];
                for (int i = 0; i < size; i++)
                {
                    arr[i] = ran.Next(-10, 10);
                }
                dataGridViewArr.ColumnCount = size;
                dataGridViewArr.RowCount = 1;
                for (int i = 0; i < size; i++)
                {
                    dataGridViewArr.Columns[i].HeaderText = i.ToString();
                    dataGridViewArr[i, 0].Value = arr[i];
                }
                int res, max, totalnum, index, num, sum, total;
                var af = new ArrayFormulas();
                af.NegSum(arr, size, out res);
                af.MaxEvenNumber(arr, size, out max);
                af.TotalNumEvenIndex(arr, size, out totalnum);
                af.MaxNumIndex(arr, size, out index);
                af.MaxNumber(arr, size, out num);
                af.PositiveNumIndexSum(arr, size, out sum);
                af.TotalNumOddNumbers(arr, size, out total);
                textBox_res.Text = res.ToString();
                textBox_max.Text = max.ToString();
                textBox_totalnum.Text = totalnum.ToString();
                textBox_index.Text = index.ToString();
                textBox_num.Text = num.ToString();
                textBox_sum.Text = sum.ToString();
                textBox_total.Text = total.ToString();
            }
        }

    }
}
