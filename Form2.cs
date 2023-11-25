using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Infrastucture;
using WinFormsApp1.Model;
using WinFormsApp1.ViewModel;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Token token = new Token();

        public Form2()
        {
            InitializeComponent();

            FillFormCreate fillForm = new FillFormCreate();
            comboBox1.Items.AddRange(fillForm.types);
            comboBox2.Items.AddRange(fillForm.departments);
            comboBox3.Items.AddRange(fillForm.destinys);
            comboBox4.Items.AddRange(fillForm.actions);
            comboBox5.Items.AddRange(fillForm.statuses);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            token = new Token(form1.listView1.Items.Count + 1, 
                comboBox1.SelectedItem.ToString(),
                textBox1.Text,
                comboBox2.SelectedItem.ToString(),
                comboBox3.SelectedItem.ToString(),
                comboBox4.SelectedItem.ToString(),
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                comboBox5.SelectedItem.ToString(),
                dateTimePicker1.Value,
                dateTimePicker2.Value
                );

            form1.Tokens.Append(token);

            this.Close();
        }
    }
}
