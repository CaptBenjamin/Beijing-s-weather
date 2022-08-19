using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 北京天气
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "北京";
            webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/beijing.html");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh(WebBrowserRefreshOption.Completely);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "北京")
            {
                webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/beijing.html");
                webBrowser1.ScriptErrorsSuppressed = true;
            }
            if (comboBox1.Text == "昌平")
            {
                webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/changping.html");
                webBrowser1.ScriptErrorsSuppressed = true;
            }
            if (comboBox1.Text == "朝阳")
            {
                webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/chaoyang.html");
                webBrowser1.ScriptErrorsSuppressed = true;
            }
            if (comboBox1.Text == "大兴")
            {
                webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/daxing.html");
                webBrowser1.ScriptErrorsSuppressed = true;
            }
            if (comboBox1.Text == "房山")
            {
                webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/fangshan.html");
                webBrowser1.ScriptErrorsSuppressed = true;
            }
            if (comboBox1.Text == "丰台")
            {
                webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/fengtai.html");
                webBrowser1.ScriptErrorsSuppressed = true;
            }
            if (comboBox1.Text == "海淀")
            {
                webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/haidian.html");
                webBrowser1.ScriptErrorsSuppressed = true;
            }
            if (comboBox1.Text == "怀柔")
            {
                webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/huairou.html");
                webBrowser1.ScriptErrorsSuppressed = true;
            }
            if (comboBox1.Text == "门头沟")
            {
                webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/mentougou.html");
                webBrowser1.ScriptErrorsSuppressed = true;
            }
            if (comboBox1.Text == "密云")
            {
                webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/miyun.html");
                webBrowser1.ScriptErrorsSuppressed = true;
            }
            if (comboBox1.Text == "平谷")
            {
                webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/pinggu.html");
                webBrowser1.ScriptErrorsSuppressed = true;
            }
            if (comboBox1.Text == "石景山")
            {
                webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/shijingshan.html");
                webBrowser1.ScriptErrorsSuppressed = true;
            }
            if (comboBox1.Text == "顺义")
            {
                webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/shunyi.html");
                webBrowser1.ScriptErrorsSuppressed = true;
            }
            if (comboBox1.Text == "通州")
            {
                webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/tongzhou.html");
                webBrowser1.ScriptErrorsSuppressed = true;
            }
            if (comboBox1.Text == "延庆")
            {
                webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/yanqing.html");
                webBrowser1.ScriptErrorsSuppressed = true;
            }
        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            Uri n = webBrowser1.Url;
            if (comboBox1.Text == "北京")
            {
                Uri c = new Uri("http://www.nmc.cn/publish/forecast/ABJ/beijing.html");
                if (n != c)
                {
                    webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/beijing.html");
                    webBrowser1.ScriptErrorsSuppressed = true;
                }
            }
            if (comboBox1.Text == "昌平")
            {
                Uri c = new Uri("http://www.nmc.cn/publish/forecast/ABJ/changping.html");
                if (n != c)
                {
                    webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/changping.html");
                    webBrowser1.ScriptErrorsSuppressed = true;
                }
            }
            if (comboBox1.Text == "朝阳")
            {
                Uri c = new Uri("http://www.nmc.cn/publish/forecast/ABJ/chaoyang.html");
                if (n != c)
                {
                    webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/chaoyang.html");
                    webBrowser1.ScriptErrorsSuppressed = true;
                }
            }
            if (comboBox1.Text == "大兴")
            {
                Uri c = new Uri("http://www.nmc.cn/publish/forecast/ABJ/daxing.html");
                if (n != c)
                {
                    webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/daxing.html");
                    webBrowser1.ScriptErrorsSuppressed = true;
                }
            }
            if (comboBox1.Text == "房山")
            {
                Uri c = new Uri("http://www.nmc.cn/publish/forecast/ABJ/fangshan.html");
                if (n != c)
                {
                    webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/fangshan.html");
                    webBrowser1.ScriptErrorsSuppressed = true;
                }
            }
            if (comboBox1.Text == "丰台")
            {
                Uri c = new Uri("http://www.nmc.cn/publish/forecast/ABJ/fengtai.html");
                if (n != c)
                {
                    webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/fengtai.html");
                    webBrowser1.ScriptErrorsSuppressed = true;
                }
            }
            if (comboBox1.Text == "海淀")
            {
                Uri c = new Uri("http://www.nmc.cn/publish/forecast/ABJ/haidian.html");
                if (n != c)
                {
                    webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/haidian.html");
                    webBrowser1.ScriptErrorsSuppressed = true;
                }
            }
            if (comboBox1.Text == "怀柔")
            {
                Uri c = new Uri("http://www.nmc.cn/publish/forecast/ABJ/huairou.html");
                if (n != c)
                {
                    webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/huairou.html");
                    webBrowser1.ScriptErrorsSuppressed = true;
                }
            }
            if (comboBox1.Text == "门头沟")
            {
                Uri c = new Uri("http://www.nmc.cn/publish/forecast/ABJ/mentougou.html");
                if (n != c)
                {
                    webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/mentougou.html");
                    webBrowser1.ScriptErrorsSuppressed = true;
                }
            }
            if (comboBox1.Text == "密云")
            {
                Uri c = new Uri("http://www.nmc.cn/publish/forecast/ABJ/miyun.html");
                if (n != c)
                {
                    webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/miyun.html");
                    webBrowser1.ScriptErrorsSuppressed = true;
                }
            }
            if (comboBox1.Text == "平谷")
            {
                Uri c = new Uri("http://www.nmc.cn/publish/forecast/ABJ/pinggu.html");
                if (n != c)
                {
                    webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/pinggu.html");
                    webBrowser1.ScriptErrorsSuppressed = true;
                }
            }
            if (comboBox1.Text == "石景山")
            {
                Uri c = new Uri("http://www.nmc.cn/publish/forecast/ABJ/shijingshan.html");
                if (n != c)
                {
                    webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/shijingshan.html");
                    webBrowser1.ScriptErrorsSuppressed = true;
                }
            }
            if (comboBox1.Text == "顺义")
            {
                Uri c = new Uri("http://www.nmc.cn/publish/forecast/ABJ/shunyi.html");
                if (n != c)
                {
                    webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/shunyi.html");
                    webBrowser1.ScriptErrorsSuppressed = true;
                }
            }
            if (comboBox1.Text == "通州")
            {
                Uri c = new Uri("http://www.nmc.cn/publish/forecast/ABJ/tongzhou.html");
                if (n != c)
                {
                    webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/tongzhou.html");
                    webBrowser1.ScriptErrorsSuppressed = true;
                }
            }
            if (comboBox1.Text == "延庆")
            {
                Uri c = new Uri("http://www.nmc.cn/publish/forecast/ABJ/yanqing.html");
                if (n != c)
                {
                    webBrowser1.Navigate("http://www.nmc.cn/publish/forecast/ABJ/yanqing.html");
                    webBrowser1.ScriptErrorsSuppressed = true;
                }
            }
        }

    }
}
