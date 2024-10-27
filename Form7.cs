using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace froggame
{
    public partial class Form7 : Form
    {
        String connectionString = "Data source=frogdb.db;Version=3";
        List<int> top5 = new List<int>();
        List<String> topnames = new List<String>();
        SQLiteConnection connection2;
        public Form7(SQLiteConnection connection)
        {
            InitializeComponent();
            connection2 = connection;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB.Show_Levels(ref connectionString, ref connection2, "1", ref top5, ref topnames);

            label2.Text = "-";
            label3.Text = "-";
            label4.Text = "-";
            label5.Text = "-";
            label6.Text = "-";

            label7.Text = "-";
            label8.Text = "-";
            label9.Text = "-";
            label10.Text = "-";
            label11.Text = "-";
            if (top5.Count >= 5)
            {
                label2.Text = topnames[0];
                label3.Text = topnames[1];
                label4.Text = topnames[2];
                label5.Text = topnames[3];
                label6.Text = topnames[4];

                label7.Text = top5[0].ToString();
                label8.Text = top5[1].ToString();
                label9.Text = top5[2].ToString();
                label10.Text = top5[3].ToString();
                label11.Text = top5[4].ToString();
            }
            else if (top5.Count == 4)
            {
                label2.Text = topnames[0];
                label3.Text = topnames[1];
                label4.Text = topnames[2];
                label5.Text = topnames[3];
                label6.Text = "-";

                label7.Text = top5[0].ToString();
                label8.Text = top5[1].ToString();
                label9.Text = top5[2].ToString();
                label10.Text = top5[3].ToString();
                label11.Text = "-";
            }
            else if (top5.Count == 3)
            {
                label2.Text = topnames[0];
                label3.Text = topnames[1];
                label4.Text = topnames[2];
                label5.Text = "-";
                label6.Text = "-";

                label7.Text = top5[0].ToString();
                label8.Text = top5[1].ToString();
                label9.Text = top5[2].ToString();
                label10.Text = "-";
                label11.Text = "-";
            }
            else if (top5.Count == 2)
            {
                label2.Text = topnames[0];
                label3.Text = topnames[1];
                label4.Text = "-";
                label5.Text = "-";
                label6.Text = "-";

                label7.Text = top5[0].ToString();
                label8.Text = top5[1].ToString();
                label9.Text = "-";
                label10.Text = "-";
                label11.Text = "-";
            }
            else if (top5.Count == 1)
            {
                label2.Text = topnames[0];
                label3.Text = "-";
                label4.Text = "-";
                label5.Text = "-";
                label6.Text = "-";

                label7.Text = top5[0].ToString();
                label8.Text = "-";
                label9.Text = "-";
                label10.Text = "-";
                label11.Text = "-";
            }
            else if (top5.Count == 0)
            {
                label2.Text = "-";
                label3.Text = "-";
                label4.Text = "-";
                label5.Text = "-";
                label6.Text = "-";

                label7.Text = "-";
                label8.Text = "-";
                label9.Text = "-";
                label10.Text = "-";
                label11.Text = "-";
            }
            top5.Clear();
            topnames.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB.Show_Levels(ref connectionString, ref connection2, "2", ref top5, ref topnames);

            label2.Text = "-";
            label3.Text = "-";
            label4.Text = "-";
            label5.Text = "-";
            label6.Text = "-";

            label7.Text = "-";
            label8.Text = "-";
            label9.Text = "-";
            label10.Text = "-";
            label11.Text = "-";
            if (top5.Count >= 5)
            {
                label2.Text = topnames[0];
                label3.Text = topnames[1];
                label4.Text = topnames[2];
                label5.Text = topnames[3];
                label6.Text = topnames[4];

                label7.Text = top5[0].ToString();
                label8.Text = top5[1].ToString();
                label9.Text = top5[2].ToString();
                label10.Text = top5[3].ToString();
                label11.Text = top5[4].ToString();
            }
            else if (top5.Count == 4)
            {
                label2.Text = topnames[0];
                label3.Text = topnames[1];
                label4.Text = topnames[2];
                label5.Text = topnames[3];
                label6.Text = "-";

                label7.Text = top5[0].ToString();
                label8.Text = top5[1].ToString();
                label9.Text = top5[2].ToString();
                label10.Text = top5[3].ToString();
                label11.Text = "-";
            }
            else if (top5.Count == 3)
            {
                label2.Text = topnames[0];
                label3.Text = topnames[1];
                label4.Text = topnames[2];
                label5.Text = "-";
                label6.Text = "-";

                label7.Text = top5[0].ToString();
                label8.Text = top5[1].ToString();
                label9.Text = top5[2].ToString();
                label10.Text = "-";
                label11.Text = "-";
            }
            else if (top5.Count == 2)
            {
                label2.Text = topnames[0];
                label3.Text = topnames[1];
                label4.Text = "-";
                label5.Text = "-";
                label6.Text = "-";

                label7.Text = top5[0].ToString();
                label8.Text = top5[1].ToString();
                label9.Text = "-";
                label10.Text = "-";
                label11.Text = "-";
            }
            else if (top5.Count == 1)
            {
                label2.Text = topnames[0];
                label3.Text = "-";
                label4.Text = "-";
                label5.Text = "-";
                label6.Text = "-";

                label7.Text = top5[0].ToString();
                label8.Text = "-";
                label9.Text = "-";
                label10.Text = "-";
                label11.Text = "-";
            }
            else if (top5.Count == 0)
            {
                label2.Text = "-";
                label3.Text = "-";
                label4.Text = "-";
                label5.Text = "-";
                label6.Text = "-";

                label7.Text = "-";
                label8.Text = "-";
                label9.Text = "-";
                label10.Text = "-";
                label11.Text = "-";
            }
            top5.Clear();
            topnames.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB.Show_Levels(ref connectionString, ref connection2, "3", ref top5, ref topnames);

            label2.Text = "-";
            label3.Text = "-";
            label4.Text = "-";
            label5.Text = "-";
            label6.Text = "-";

            label7.Text = "-";
            label8.Text = "-";
            label9.Text = "-";
            label10.Text = "-";
            label11.Text = "-";
            if (top5.Count >= 5)
            {
                label2.Text = topnames[0];
                label3.Text = topnames[1];
                label4.Text = topnames[2];
                label5.Text = topnames[3];
                label6.Text = topnames[4];

                label7.Text = top5[0].ToString();
                label8.Text = top5[1].ToString();
                label9.Text = top5[2].ToString();
                label10.Text = top5[3].ToString();
                label11.Text = top5[4].ToString();
            }
            else if (top5.Count == 4)
            {
                label2.Text = topnames[0];
                label3.Text = topnames[1];
                label4.Text = topnames[2];
                label5.Text = topnames[3];
                label6.Text = "-";

                label7.Text = top5[0].ToString();
                label8.Text = top5[1].ToString();
                label9.Text = top5[2].ToString();
                label10.Text = top5[3].ToString();
                label11.Text = "-";
            }
            else if (top5.Count == 3)
            {
                label2.Text = topnames[0];
                label3.Text = topnames[1];
                label4.Text = topnames[2];
                label5.Text = "-";
                label6.Text = "-";

                label7.Text = top5[0].ToString();
                label8.Text = top5[1].ToString();
                label9.Text = top5[2].ToString();
                label10.Text = "-";
                label11.Text = "-";
            }
            else if (top5.Count == 2)
            {
                label2.Text = topnames[0];
                label3.Text = topnames[1];
                label4.Text = "-";
                label5.Text = "-";
                label6.Text = "-";

                label7.Text = top5[0].ToString();
                label8.Text = top5[1].ToString();
                label9.Text = "-";
                label10.Text = "-";
                label11.Text = "-";
            }
            else if (top5.Count == 1)
            {
                label2.Text = topnames[0];
                label3.Text = "-";
                label4.Text = "-";
                label5.Text = "-";
                label6.Text = "-";

                label7.Text = top5[0].ToString();
                label8.Text = "-";
                label9.Text = "-";
                label10.Text = "-";
                label11.Text = "-";
            }
            else if (top5.Count == 0)
            {
                label2.Text = "-";
                label3.Text = "-";
                label4.Text = "-";
                label5.Text = "-";
                label6.Text = "-";

                label7.Text = "-";
                label8.Text = "-";
                label9.Text = "-";
                label10.Text = "-";
                label11.Text = "-";
            }
            top5.Clear();
            topnames.Clear();

        }
    }
}
