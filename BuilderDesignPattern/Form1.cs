using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Builder;
using Logger;

namespace BuilderDesignPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            logger.listBox = listBox1;
        }
        Builder.Builder builder;
        CS config;
        CS clone;
        Logger.Logger logger = Logger.Logger.GetInstance();
        

        private void button1_Click(object sender, EventArgs e)
        {
            builder = new PoorConfig();
            config = builder.Build();
            pictureBox1.Image = config.picture;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            builder = new RegularConfig();
            config = builder.Build();
            pictureBox1.Image = config.picture;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            builder = new RichConfig();
            config = builder.Build();
            pictureBox1.Image = config.picture;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clone = config.Clone();
            pictureBox2.Image = clone.picture;
            logger.ShowLogs();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            config.GPU = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(config.GPU);
            listBox1.Items.Add(config.CPU);
            listBox1.Items.Add(config.RAM);
            listBox1.Items.Add(config.Memory);
            listBox1.Items.Add(config.Case);
            listBox1.Items.Add(config.Cooling);
            listBox1.Items.Add(config.MB);
            listBox1.Items.Add(config.PowerSupply);
            listBox1.Items.Add("===========================");
            listBox1.Items.Add(clone.GPU);
            listBox1.Items.Add(clone.CPU);
            listBox1.Items.Add(clone.RAM);
            listBox1.Items.Add(clone.Memory);
            listBox1.Items.Add(clone.Case);
            listBox1.Items.Add(clone.Cooling);
            listBox1.Items.Add(clone.MB);
            listBox1.Items.Add(clone.PowerSupply);
            listBox1.Items.Add("===========================");
        }
    }
}
