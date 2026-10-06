using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bbaaaaaaaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> list = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9,};
            List<int> list2 = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                listBox1.DataSource = list;
                {
                    if (list[i] <= 5)
                        list2.Add(list[i]);
                }
            }
            listBox1.DataSource = list2.ToList();
        }
    }
}
