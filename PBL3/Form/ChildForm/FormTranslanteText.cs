using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft;
namespace PBL3
{
    public partial class FormTranslanteText : Form
    {
        public delegate void ExitForm(Form childForm, FormStack.FormType formType = FormStack.FormType.Weak);
        public ExitForm exitForm;
        public FormTranslanteText()
        {
            InitializeComponent();
        }
        private string TranslateText(string input,string languae_start,string language_end)
        {

            string url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
            languae_start,language_end, Uri.EscapeUriString(input));
            HttpClient httpClient = new HttpClient();
            string result = httpClient.GetStringAsync(url).Result;
            var jsonData = JsonConvert.DeserializeObject<List<dynamic>>(result);
            var translationItems = jsonData[0];

            return translationItems[0][0].ToString();
        }
        private void btnATV_Click(object sender, EventArgs e)
        {
            string value = txt1.Text;
            Console.ForegroundColor = ConsoleColor.Red;
            txt2.Text=TranslateText(value, "en", "vi");
        }

        private void btnVTA_Click(object sender, EventArgs e)
        {
            string value = txt1.Text;
            Console.ForegroundColor = ConsoleColor.Red;
            txt2.Text = TranslateText(value, "vi", "en");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            exitForm(FormStack.Pop(), FormStack.FormType.Strong);
        }
    }
}
