using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace froggame
{
    public partial class Form6 : Form
    {

        String connectionString = "Data source=frogdb.db;Version=3";
        SQLiteConnection connection;
        private void Form6_Load(object sender, EventArgs e)
        {
            DB.Creation_DB(ref connectionString, ref connection);
        }
        int counter6;
        String level6;
        public Form6(int counter, int level)
        {
            InitializeComponent();
            label2.Text = counter.ToString();
            counter6=counter;
            level6=level.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 5)
            {
                MessageBox.Show("Username must be at least 6 characters long.");
                textBox1.Clear();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[a-z0-9_{_}]*$"))
            {
                MessageBox.Show("You must only use lowercase alphabetical characters, numbers and the underscore");
                textBox1.Clear();
            }
            else
            {
                DB.Insert_DB(ref connectionString, ref connection, textBox1.Text, level6, counter6);
                System.Windows.Forms.Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 5)
            {
                MessageBox.Show("Username must be at least 6 characters long.");
                textBox1.Clear();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[a-z0-9_{_}]*$"))
            {
                MessageBox.Show("You must only use lowercase alphabetical characters, numbers and the underscore");
                textBox1.Clear();
            }
            else
            {
                DB.Insert_DB(ref connectionString, ref connection, textBox1.Text, level6, counter6);
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
        }

    }
}
