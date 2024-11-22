using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hanoi_Tower
{
    public partial class Form1 : Form
    {
        public static string Hanoi_Tower(decimal n, char A, char B, char C, ref int movecount)
        {
            if (n == 0)
                return "";

            string moves = Hanoi_Tower(n - 1, A, C, B, ref movecount);

            movecount++;
            moves += $"{movecount}) {A} -> {C} \r\n";

            moves += Hanoi_Tower(n - 1, B, A, C, ref movecount);

            return moves;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                lblNumberOfMoves.RightToLeft = RightToLeft.Yes;
                lblNumberOfMoves.Text = $"برای حرکت دادن {numericUpDown1.Value} مهره به {Math.Pow(2, Convert.ToDouble(numericUpDown1.Value)) - 1} حرکت نیاز داریم!";
                int movecount = 0;
                textBox1.Text = $"{Hanoi_Tower(numericUpDown1.Value, 'A', 'B', 'C', ref movecount)} \r\n ساخته شده توسط امیررضا سعدی";
            }

            else
            {
                MessageBox.Show("لطفا تعداد مهره ها را وارد کنید!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
