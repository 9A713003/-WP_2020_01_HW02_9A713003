using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_2020_01_HW02_9A713003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Poker p = new Poker();
            List<int> poker = p.GetPoker(13);
            

                string msg = "";
            for (int i = 0; i < poker.Count; i++)
            {
                msg = $"{poker[i]} ,";
            }

                richTextBox1.Text = $"黑桃{ msg}" ;
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
    }

