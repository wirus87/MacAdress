using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacAdress {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            
            Random rand = new Random();
            List <String> macdigits= new List<string> {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0"};
            int x;

            textBox1.Text = "";

            //mac adres- 16 znakow-> xx:xx:xx:xx:xx:xx
            macdigits.Add("A");
            macdigits.Add("B");
            macdigits.Add("C");
            macdigits.Add("D");
            macdigits.Add("E");
            macdigits.Add("F");

            for (int i = 0; i <= 16; i++) {

                if ((i + 1) % 3 == 0) {
                    textBox1.Text += ":";
                }
                else {
                    x= rand.Next(0, macdigits.Count);
                    textBox1.Text += macdigits.ElementAt(x);
                }
            }
        }
    }
}
