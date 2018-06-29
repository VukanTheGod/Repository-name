using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace slike
{
    public partial class Form1 : Form
    {
        private class Greska
        {
            public int Code { get; set; }
            public string Description { get; set; }

            public void Error(int code, string desc)
            {
                Code = code;
                Description = desc;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtimenovo.Enabled = false;
            lblista.Visible = false;
        }

        private void txtIme_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var images = SlikeKao(txtIme.Text);

                if (images.Count() == 1)
                {
                    var err = PrikaziSliku(images.ElementAt(0));
                    if (err != null)
                    {
                        MessageBox.Show(err.Description);
                    }
                }
                else if (images.Count() > 1)
                {
                    PrikaziListuDostupnihSlika(images);
                }
                else
                {

                }
                txtIme.Text = "";
                lblista.Visible = true;
            }
        }

        private Greska PrikaziSliku(string filename)
        {
            bool exists = false;
            string shortName = Path.GetFileNameWithoutExtension(filename);
            String[] ImageFiles = Directory.GetFiles(@"..\..\slike");
            foreach (var file in ImageFiles)
            {
                if (txtIme.Text == shortName)
                {
                    string fileName = Path.GetFileName(filename);
                    exists = true;
                    pbSlika.Image = new Bitmap(file);
                    lblIme.Text = shortName;
                    txtIme.Text = "";
                }
            }

            if (!exists)
            {
                return new Greska() { Code = 1, Description = "Slika ne postoji" };
            }
            return null;
        }

        private List<string> SlikeKao(string patern)
        {
            var kao = new List<string>();
            var exact = false;

            String[] ImageFiles = Directory.GetFiles(@"..\..\slike");
            foreach (var file in ImageFiles)
            {
                string shortName = Path.GetFileName(file);

                if (shortName.Equals(patern))
                {
                    exact = true;
                    kao.Add(shortName);
                }
            }

            if (!exact)
            {
                foreach (var file in ImageFiles)
                {
                    string shortName = Path.GetFileName(file);
                    if (shortName.IndexOf(patern) >= 0)
                    {
                        kao.Add(shortName);
                    }
                }
            }

            return kao;
        }

        private void PrikaziListuDostupnihSlika(List<string> images)
        {
            for (int i = 0; i < images.Count(); i++)
            {
                lblista.DataSource = images;
            }
        }

        OpenFileDialog dlg = new OpenFileDialog();

        private void btnUcitaj_Click(object sender, EventArgs e)
        {         
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string srcPath = dlg.FileName;
                txtimenovo.Enabled = true;
                lblista.Visible = false;
            }
        } 

        private void lblista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lblista.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                String[] ImageFiles = Directory.GetFiles(@"..\..\slike");
                foreach (var file in ImageFiles)
                {
                    string shortName = Path.GetFileName(file);
                    if (lblista.Text == shortName)
                    {
                        string FileName = Path.GetFileNameWithoutExtension(file);
                        pbSlika.Image = new Bitmap(file);
                        lblIme.Text = FileName;
                    }
                }
            }
        }
        
        private void btnnovo_Click(object sender, EventArgs e)
        {
            string srcPath = dlg.FileName;
            string destinationDir = "..\\..\\slike\\";
            string destName = txtimenovo.Text;
            string Extension = Path.GetExtension(srcPath);
            File.Copy(srcPath, destinationDir + destName + Extension);
            txtimenovo.Text = "";
            txtimenovo.Enabled = false;
        }

        private void txtIme_MouseClick(object sender, MouseEventArgs e)
        {
            lblista.Visible = false;
        }
    }
}
