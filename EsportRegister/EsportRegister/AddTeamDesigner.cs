using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsportRegister
{
    public partial class AddTeamDesigner : Form

    {
        public static string Setname = "";
        public static string Setusername = "username";
        public AddTeamDesigner()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void selectplayer(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            PlayDesigner playDesigner = new PlayDesigner();
            playDesigner.ShowDialog();

            if (playDesigner.DialogResult == DialogResult.OK)
            {
                string name = PlayDesigner.Setname;
                string usermame = PlayDesigner.SetUsername;
                if (button.Name == "button1")
                {
                    this.textBox2.Text = name;
                    this.textBox7.Text = usermame;
                }
                if (button.Name == "button2")
                {
                    this.textBox3.Text = name;
                    this.textBox8.Text = usermame;
                }
                if (button.Name == "button3")
                {
                    this.textBox4.Text = name;
                    this.textBox9.Text = usermame;
                }
                if (button.Name == "button4")
                {
                    this.textBox5.Text = name;
                    this.textBox10.Text = usermame;
                }
                if (button.Name == "button5")
                {
                    this.textBox6.Text = name;
                    this.textBox11.Text = usermame;
                }

            }
        }

        private void AddTeamDesigner_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string team = this.textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
