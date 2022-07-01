using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B0226497_段昱如_PDPR_week16_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int index = 0;
        List<Bitmap> b = new List<Bitmap>();
        void showpic()
        {
            pictureBox1.Image = b[index];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                b.Add(new Bitmap($"Week16_{i + 1}.jpg"));
            }
            showpic();
        }

        private void 第一張ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 0;
            showpic();
        }

        private void 上一張ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
                index = 0;
            showpic();
        }

        private void 下一張ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index++;
            if (index > 3)
                index = 3;
            showpic();
        }

        private void 最末張ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index=3;
            showpic();
        }
    }
}
