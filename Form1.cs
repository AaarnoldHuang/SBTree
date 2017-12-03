using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tree
{
    public partial class Form1 : Form
    {
        TreeClass Q = new TreeClass();   //实例化一个Treeclass的对象Q
        int i;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void getnumber_Click(object sender, EventArgs e)
        {
            displaybox.Text = "";
            displaybox.Text = Q.displayTree();
        }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
             i = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
             i = 2;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                if (ptext.Text == "" || addtext.Text == "")
                {
                    info.Text = "输入不能为空，请检查！";
                }
                else
                {
                    info.Text = "";
                    Q.insertSonNode(Q.searchValue(addtext.Text), ptext.Text);      //添加孩子
                    addtext.Text = "";
                    ptext.Text = "";
                }
            }
            else if (i == 2)
            {
                if (ptext.Text == "" || addtext.Text == "")
                {
                    info.Text = "输入不能为空，请检查！";
                }
                else
                {
                    info.Text = "";
                    Q.insertBroNode(Q.searchValue(addtext.Text), ptext.Text);    //添加兄弟
                    addtext.Text = "";
                    ptext.Text = "";
                }
            }
            else if (i == 3)
            {
                if (addtext.Text != "")
                {
                    info.Text = "";
                    Q.setRootValue(addtext.Text);       //添加Root
                }
                else
                    info.Text = "输入不能为空，请检查！";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void addroot_CheckedChanged(object sender, EventArgs e)
        {
            i = 3;
        }

        private void count_Click(object sender, EventArgs e)
        {
            info.Text = "共有" +  Q.getCount().ToString() + "个结点。" /*+ Q.getHight().ToString()*/;
        }
    }
}
