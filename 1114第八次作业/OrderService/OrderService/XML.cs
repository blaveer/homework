using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace OrderService
{
    public partial class XML : Form
    {
        public XML()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)    //查询订单数量
        {
            SeeOrderNum seeOrder = new SeeOrderNum
            {
                Location = new System.Drawing.Point(200, 400)
            };
            seeOrder.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)  //生成HTML
        {
            try
            {
                /*
                 * 生成XML文件
                 */
                XmlSerializer serializer = new XmlSerializer(OrderService.list.GetType());
                TextWriter writerXml = new StreamWriter(@".\List.xml");//, FileMode.Open,FileAccess.Write);
                serializer.Serialize(writerXml, OrderService.list);
                writerXml.Close();

                /*
                 * 依据XSLT生成HTML
                 */
                XmlDocument doc = new XmlDocument();
                doc.Load(@".\List.xml");

                XPathNavigator nav = doc.CreateNavigator();
                nav.MoveToRoot();

                XslCompiledTransform xt = new XslCompiledTransform();
                xt.Load(@".\OrderXslt.xslt");

                FileStream outFileStream = File.OpenWrite(@".\ListT.html");
                XmlTextWriter writerHtml =new XmlTextWriter(outFileStream, System.Text.Encoding.UTF8);
                xt.Transform(nav, null, writerHtml);
                SucessScene sucess = new SucessScene();
                sucess.ShowDialog();
            }
            catch(Exception ex)
            {
                ErrorScene errorScene = new ErrorScene();
                errorScene.ShowDialog();
            }
           

        }
        private void button3_Click(object sender, EventArgs e)  //读取HTML
        {
            System.Diagnostics.Process.Start(@".\ListT.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        /*public static List<OrderDetatils> XmlRead()
{
   XmlSerializer serializer = new XmlSerializer(list.GetType());
   FileStream stream = new FileStream(@"E:\vs date\C#\Windows\111101\beifen\OrderService\OrderService\OrderCheck\bin\Debug\List.xml", FileMode.Open);
   List<OrderDetatils> list1 = (List<OrderDetatils>)serializer.Deserialize(stream);
   stream.Close();
   return list1;
}
*/

    }
}
