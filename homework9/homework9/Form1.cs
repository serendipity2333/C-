using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework9
{
    public partial class Form1 : Form
    {
        Crawler myCrawler;
        
        public Form1()
        {
            InitializeComponent();
            dgvResult.DataSource = bindingSource1;
            myCrawler = new Crawler();
            myCrawler.PageDownloaded += Crawler_PageDownloaded;
            myCrawler.CrawlerStopped += Crawler_CrawlerStopped;
        }

        private void Crawler_CrawlerStopped(Crawler obj)
        {
            Action action = () => lblInfo.Text = "爬虫已停止";
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void Crawler_PageDownloaded(Crawler crawler, string url, string info)
        {
            var pageInfo = new { Index = bindingSource1.Count + 1, URL = url, Status = info };
            Action action = () => { bindingSource1.Add(pageInfo); };
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            myCrawler.Start(txtUrl.Text);
            new Thread(myCrawler.Crawl).Start();
            lblInfo.Text = "爬虫已启动....";
        }
    }
}
