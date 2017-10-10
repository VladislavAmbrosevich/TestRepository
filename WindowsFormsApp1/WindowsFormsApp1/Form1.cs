using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var http = GetHttp().Result;
            label1.Text = http.Split(' ')[0];
        }

        private async Task<string> GetHttp()
        {
            var client = new HttpClient();
            //            var msg = await client.GetAsync("http://tut.by/").ConfigureAwait(false);
            var msg = await client.GetAsync("http://tut.by/");

            //            return await msg.Content.ReadAsStringAsync().ConfigureAwait(false);
            return await msg.Content.ReadAsStringAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoAsync().Wait();
            MessageBox.Show(@"Hello");
        }

        private static async Task DoAsync()
        {
            await Task.Delay(1000);
        }
    }
}
