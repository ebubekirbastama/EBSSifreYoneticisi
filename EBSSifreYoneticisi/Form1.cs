using System.Diagnostics;
using System.Windows.Forms;

namespace EBSSifreYoneticisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Platform";
            dataGridView1.Columns[1].Name = "Email";
            dataGridView1.Columns[2].Name = "Password";
            EBSTxtOku(Application.StartupPath + "\\config");
        }

        private void EBSTxtOku(string DosyaYolu)
        {
            try
            {
                FileStream fs = new FileStream(DosyaYolu, FileMode.Open, FileAccess.Read);
                StreamReader sw = new StreamReader(fs);
                string yazi = sw.ReadLine();

                while (yazi != null)
                {
                    //listBox1.Items.Add(Ebssfryntcs.SifreleVeyaCoz(yazi, -Ebssfryntcs.passwd));
                    string platform = Ebssfryntcs.SifreleVeyaCoz(yazi, -Ebssfryntcs.passwd).Split(':')[0];
                    string email = Ebssfryntcs.SifreleVeyaCoz(yazi, -Ebssfryntcs.passwd).Split(':')[1];
                    string passwd = Ebssfryntcs.SifreleVeyaCoz(yazi, -Ebssfryntcs.passwd).Split(':')[2];
                    dataGridView1.Rows.Add(platform,email,passwd);
                    yazi = sw.ReadLine();
                }
                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Ebssfryntcs.exmsg);
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (txt_mailadresi.Text != "" && txt_platform.Text != "" && txt_sfr.Text != "")
                {
                    if (checkBox1.Text == "Ham Passwd")
                    {
                        string msj = Ebssfryntcs.EBSVeriKaydet(Application.StartupPath + "\\config", Ebssfryntcs.SifreleVeyaCoz(txt_platform.Text + ":" + txt_mailadresi.Text + ":" + txt_sfr.Text, Ebssfryntcs.passwd), dataGridView1);
                        if (msj == "Kayýt Baþarýlý")
                        {
                            temizle();
                            EBSTxtOku(Application.StartupPath + "\\config");
                        }
                    }
                    else
                    {
                        string msj = Ebssfryntcs.EBSVeriKaydet(Application.StartupPath + "\\config", Ebssfryntcs.SifreleVeyaCoz(txt_platform.Text + ":" + txt_mailadresi.Text + ":" + Ebssfryntcs.Sha1Hash(txt_sfr.Text, 2), Ebssfryntcs.passwd), dataGridView1);
                        if (msj == "Kayýt Baþarýlý")
                        {
                            temizle();
                            EBSTxtOku(Application.StartupPath + "\\config");
                        }
                    }

                }
                else
                {
                    if (txt_mailadresi.Text == "")
                    {
                        errorProvider1.SetError(txt_mailadresi, "Bu alan boþ geçilemez");
                    }
                    if (txt_platform.Text == "")
                    {
                        errorProvider1.SetError(txt_platform, "Bu alan boþ geçilemez");
                    }
                    if (txt_sfr.Text == "")
                    {
                        errorProvider1.SetError(txt_sfr, "Bu alan boþ geçilemez");
                    }

                    MessageBox.Show("Please Fill All Boxes");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Ebssfryntcs.exmsg);
            }
        }

        private void temizle()
        {
            txt_mailadresi.Text = "";
            txt_platform.Text = "";
            txt_sfr.Text = "";
            dataGridView1.Rows.Clear();
        }


        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                checkBox1.Text = "Encrypted Passwd";
            }
            else
            {
                checkBox1.Text = "Ham Passwd";
            }
        }

        private void facebookPasswordsChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/settings?tab=security");
        }

        private void twitterPasswordsChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/settings/password");
        }

        private void linkedinPasswordsChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/mypreferences/d/change-password");
        }

        private void gmailPasswordsChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://myaccount.google.com/signinoptions/password?continue=https://myaccount.google.com/personal-info?hl%3Dtr&rapt=AEjHL4Oqvyn3k_TEzwm2Q_ckmMkrOH7Kl8KxJPOWsLte23NFm0ZylDjKFrTHyCfpapaQlNlkWgBxLBGxaAUNBzyMrVeBGnMqVA");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                txt_platform.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_mailadresi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_sfr.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,Ebssfryntcs.exmsg);
            }
        }
    }
}