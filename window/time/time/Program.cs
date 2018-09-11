using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace time
{
    public class Program:Form
    {
        TextBox txt1 = new TextBox();
        TextBox txt2 = new TextBox();
        Button btn = new Button();
        Label lbl = new Label();
        public void init()
        {
            this.Controls.Add(txt1);
            this.Controls.Add(txt2);
            this.Controls.Add(btn);
            this.Controls.Add(lbl);
            txt1.Location = new System.Drawing.Point(0, 0);
            txt1.AutoSize = false;
            txt1.Size = new System.Drawing.Size(300, 90);
            txt2.Location = new System.Drawing.Point(0, 90);
            txt2.AutoSize = false;
            txt2.Size = new System.Drawing.Size(300, 90);
            btn.Location = new System.Drawing.Point(0, 180);
            btn.Size = new System.Drawing.Size(300, 130);
            lbl.Location = new System.Drawing.Point(0, 310);
            lbl.AutoSize = false;
            lbl.Size = new System.Drawing.Size(300, 90);
            // txt1.Dock = System.Windows.Forms.DockStyle.Top;

            //lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            btn.Text = "求平方";
            lbl.Text = "用于显示计算的结果";
            this.Size = new Size(300, 500);
            btn.Click += new System.EventHandler(this.btn_Click);
        }
        public void btn_Click(object sender,EventArgs e)
        {
            string s1 = txt1.Text;
            string s2 = txt2.Text;
            double d1 = double.Parse(s1);
            double d2 = double.Parse(s2);
            double time = d1 * d2;
            lbl.Text = d1 + "与" + d2 + "的平方是：" + time;
        }
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Program ti = new Program();
            ti.Text = "CalPro";
            ti.init();
            Application.Run(ti);
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
        }
    }
}
