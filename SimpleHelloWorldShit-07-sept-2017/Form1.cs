using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleHelloWorldShit_07_sept_2017
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.Name = "A nice form";
        }

        private void BtnShowMessage_Click(object sender, EventArgs e) {
            changeTextDSte("Hello World");
        }

        private void BtnClearMessageDSte_Click(object sender, EventArgs e) {
            changeTextDSte("");
        }

        private void changeTextDSte(String text) {
            LblClickDSte.Text = text;
        }
    }
}
