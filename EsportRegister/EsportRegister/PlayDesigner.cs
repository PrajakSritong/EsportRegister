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
    public partial class PlayDesigner : Form
    {
        static BindingList<Player> listPlayer = new BindingList<Player>();
        public static string Setname = "";
        public static string SetUsername = "";
        public int setIndex;
        public PlayDesigner()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.DataSource = listPlayer;
            this.button1.Enabled = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Addplayerdesign addplayerdesign = new Addplayerdesign();
            addplayerdesign.ShowDialog();

            if (addplayerdesign.DialogResult == DialogResult.OK)
            {
                string name = Addplayerdesign.Setname;
                string username = Addplayerdesign.Setusername;

                Player newPlayer = new Player(name, username);
                listPlayer.Add(newPlayer);
                this.dataGridView1.DataSource = listPlayer;
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void selectplayer(object sender, EventArgs e)
        {

        }

        private void select(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string name = row.Cells[0].Value.ToString();
                string username = row.Cells[1].Value.ToString();
                Setname = name;
                SetUsername = username;
                setIndex = e.RowIndex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listPlayer.RemoveAt(setIndex);
            this.DialogResult = DialogResult.OK;
        }
    }
}
