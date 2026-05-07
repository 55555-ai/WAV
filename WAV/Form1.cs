using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WAV.Properties;

namespace WAV
{
    public partial class frmWAVPlayer : Form
    {
        SoundPlayer player = new SoundPlayer();

        public frmWAVPlayer()
        {
            InitializeComponent();
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.music1);
            //player.Play();

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "WAV Files (*.wav)|*.wav";
           
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.SoundLocation = txtPath.Text;
            player.Load();
            player.Play();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            player.SoundLocation = txtPath.Text;
            player.Load();
            player.PlayLooping();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            FileStream fsWAV = new FileStream(txtPath.Text, FileMode.Open);
            SoundPlayer player3 = new SoundPlayer(fsWAV);
            player3.Stop();
            fsWAV.Close();
            player.Stop();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
