using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MOONCAFE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton2.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton3.ForeColor = System.Drawing.Color.RosyBrown;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Coffee Cake");
            comboBox1.Items.Add("Cheese Danish");
            comboBox1.Items.Add("Pumpkin Muffin");
            comboBox1.Items.Add("Almond Croissant");
            comboBox1.Items.Add("Brownies");
            comboBox1.Items.Add("Glazed Donut");
            comboBox1.Items.Add("Cookies");
            comboBox1.Items.Add("Vanilla Scone");
            comboBox1.Items.Add("Banna Walnut");
            comboBox1.Items.Add("Blueberry Muffin");
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton2.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton3.ForeColor = System.Drawing.Color.RosyBrown;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Spanish Latte");
            comboBox1.Items.Add("Vanilla Latte");
            comboBox1.Items.Add("Sea Salt Latte");
            comboBox1.Items.Add("Cappucino");
            comboBox1.Items.Add("Americano");
            comboBox1.Items.Add("Caramel Macchiato");
            comboBox1.Items.Add("Hazelnut Latte");
            comboBox1.Items.Add("Creme Brulee Latte");
            comboBox1.Items.Add("Strawberry Tiramisu Latte");
            comboBox1.Items.Add("Vanilla Bean Latte");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton2.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton3.ForeColor = System.Drawing.Color.BlueViolet;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Matcha Latte");
            comboBox1.Items.Add("Strawberry Acai");
            comboBox1.Items.Add("Lychee Yogurt");
            comboBox1.Items.Add("Strawberry Foam Latte");
            comboBox1.Items.Add("Peach Mango");
            comboBox1.Items.Add("Mixed Berries");
            comboBox1.Items.Add("Red Velvet");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Coffee Cake")
            {
                textBox1.Text = "80";
            }
            else if (comboBox1.SelectedItem.ToString() == "Cheese Danish")
            {
                textBox1.Text = "90";
            }
            else if (comboBox1.SelectedItem.ToString() == "Pumpkin Muffin")
            {
                textBox1.Text = "95";
            }
            else if (comboBox1.SelectedItem.ToString() == "Almond Croissant")
            {
                textBox1.Text = "110";
            }
            else if (comboBox1.SelectedItem.ToString() == "Brownies")
            {
                textBox1.Text = "60";
            }
            else if (comboBox1.SelectedItem.ToString() == "Glazed Donut")
            {
                textBox1.Text = "60";
            }
            else if (comboBox1.SelectedItem.ToString() == "Cookies")
            {
                textBox1.Text = "55";
            }
            else if (comboBox1.SelectedItem.ToString() == "Vanilla Scone")
            {
                textBox1.Text = "75";
            }
            else if (comboBox1.SelectedItem.ToString() == "Banna Walnut")
            {
                textBox1.Text = "85";
            }
            else if (comboBox1.SelectedItem.ToString() == "Blueberry Muffin")
            {
                textBox1.Text = "100";
            }
            else if (comboBox1.SelectedItem.ToString() == "Spanish Latte")
            {
                textBox1.Text = "180";
            }
            else if (comboBox1.SelectedItem.ToString() == "Vanilla Latte")
            {
                textBox1.Text = "180";
            }
            else if (comboBox1.SelectedItem.ToString() == "Sea Salt Latte")
            {
                textBox1.Text = "180";
            }
            else if (comboBox1.SelectedItem.ToString() == "Cappucino")
            {
                textBox1.Text = "190";
            }
            else if (comboBox1.SelectedItem.ToString() == "Americano")
            {
                textBox1.Text = "170";
            }
            else if (comboBox1.SelectedItem.ToString() == "Caramel Macchiato")
            {
                textBox1.Text = "190";
            }
            else if (comboBox1.SelectedItem.ToString() == "Hazelnut Latte")
            {
                textBox1.Text = "200";
            }
            else if (comboBox1.SelectedItem.ToString() == "Creme Brulee Latte")
            {
                textBox1.Text = "220";
            }
            else if (comboBox1.SelectedItem.ToString() == "Strawberry Tiramisu Latte")
            {
                textBox1.Text = "210";
            }
            else if (comboBox1.SelectedItem.ToString() == "Vanilla Bean Latte")
            {
                textBox1.Text = "200";
            }
            else if (comboBox1.SelectedItem.ToString() == "Matcha Latte")
            {
                textBox1.Text = "230";
            }
            else if (comboBox1.SelectedItem.ToString() == "Strawberry Acai")
            {
                textBox1.Text = "250";
            }
            else if (comboBox1.SelectedItem.ToString() == "Lychee Yogurt")
            {
                textBox1.Text = "220";
            }
            else if (comboBox1.SelectedItem.ToString() == "Strawberry Foam Latte")
            {
                textBox1.Text = "230";
            }
            else if (comboBox1.SelectedItem.ToString() == "Peach Mango")
            {
                textBox1.Text = "210";
            }
            else if (comboBox1.SelectedItem.ToString() == "Mixed Berries")
            {
                textBox1.Text = "260";
            }
            else if (comboBox1.SelectedItem.ToString() == "Red Velvet")
            {
                textBox1.Text = "250";
            }
            else
            {
                textBox1.Text = "0";
            }
            textBox3.Text = "";
            textBox2.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                textBox3.Text = (Convert.ToInt64(textBox1.Text) * Convert.ToInt64(textBox2.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add Data to Datagridview
            dataGridView1.Rows.Add(comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Text);
            //Sum amount 
            textBox4.Text = (Convert.ToInt16(textBox4.Text) + Convert.ToInt16(textBox3.Text)).ToString();
            //Clear data
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Delete Data in Datadridview Data 
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected)
                    {
                        textBox4.Text = (Convert.ToInt16(textBox4.Text) - Convert.ToInt16(dataGridView1.Rows[i].Cells[3].Value)).ToString();
                        dataGridView1.Rows.RemoveAt(i);
                    }
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length > 0)
            {
                textBox6.Text = (Convert.ToInt16(textBox4.Text) - Convert.ToInt16(textBox5.Text)).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.ResetText();
            dataGridView1.Rows.Clear();

        }
    }
}
