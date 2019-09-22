using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Enter && e != null)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
        } 

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e != null)
            {
                listBox2.Items.Add(textBox2.Text);
                textBox2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndices.Count >0)
            {
                foreach(int p in listBox1.SelectedIndices)
                {
                   
                    listBox2.Items.Add(listBox1.Items[p]);
                    listBox1.Items.RemoveAt(p);
                }
                
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //move todos os itens de listbox1 para listbox2
            while(listBox1.Items.Count >0)
            {
                listBox2.Items.Add(listBox1.Items[0]);
                listBox1.Items.RemoveAt(0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //limpar listbox1

            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndices.Count > 0)
            {
                foreach (int p in listBox2.SelectedIndices)
                {
                    listBox1.Items.Add(listBox2.Items[p]);
                    listBox2.Items.RemoveAt(p);
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            while (listBox2.Items.Count > 0)
            {
                listBox1.Items.Add(listBox2.Items[0]);
                listBox2.Items.RemoveAt(0);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                listBox1.SelectionMode = SelectionMode.MultiExtended;
                listBox2.SelectionMode = SelectionMode.MultiExtended;
            }

            else
            {
                listBox1.SelectionMode = SelectionMode.One;
                listBox2.SelectionMode = SelectionMode.One;
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e != null)
            {
                listBox1.Items.Add(comboBox1.Text);
                comboBox1.Text = "";
            }
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e != null)
            {
                listBox2.Items.Add(comboBox2.Text);
                comboBox2.Text = "";
            }
        }
    }
}
