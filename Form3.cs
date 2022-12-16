using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace EBSSifreYoneticisi
{
    public partial class Form3 : Form
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);
        public Form3()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.panelTitleBar.BackColor = borderColor;
            this.BackColor = borderColor;
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cp;
            }
        }
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }
        private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }
        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }
        private struct FormBoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }
        private FormBoundsColors GetFormBoundsColors()
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);

                //Top Left
                rectBmp.X = this.Bounds.X - 1;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);

                //Top Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);

                //Bottom Left
                rectBmp.X = this.Bounds.X;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);

                //Bottom Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //-> SMOOTH OUTER BORDER
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            var fbColors = GetFormBoundsColors();

            //Top Left
            DrawPath(rectForm, e.Graphics, fbColors.TopLeftColor);

            //Top Right
            Rectangle rectTopRight = new Rectangle(mWidht, rectForm.Y, mWidht, mHeight);
            DrawPath(rectTopRight, e.Graphics, fbColors.TopRightColor);

            //Bottom Left
            Rectangle rectBottomLeft = new Rectangle(rectForm.X, rectForm.X + mHeight, mWidht, mHeight);
            DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor);

            //Bottom Right
            Rectangle rectBottomRight = new Rectangle(mWidht, rectForm.Y + mHeight, mWidht, mHeight);
            DrawPath(rectBottomRight, e.Graphics, fbColors.BottomRightColor);

            //-> SET ROUNDED REGION AND BORDER
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            ControlRegionAndBorder(panelContainer, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
                    dataGridView1.Rows.Add(platform, email, passwd);
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


        private void temizle()
        {
            txt_mailadresi.Text = "";
            txt_platform.Text = "";
            txt_sfr.Text = "";
            dataGridView1.Rows.Clear();
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
            Ebssfryntcs.ProcessStart(Ebssfryntcs.processChroume, "https://www.facebook.com/settings?tab=security");
        }

        private void twitterPasswordsChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ebssfryntcs.ProcessStart(Ebssfryntcs.processChroume, "https://twitter.com/settings/password");

        }

        private void linkedinPasswordsChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ebssfryntcs.ProcessStart(Ebssfryntcs.processChroume, "https://www.linkedin.com/mypreferences/d/change-password");
        }

        private void gmailPasswordsChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ebssfryntcs.ProcessStart(Ebssfryntcs.processChroume, "https://myaccount.google.com/signinoptions/password?continue=https://myaccount.google.com/personal-info?hl%3Dtr&rapt=AEjHL4Oqvyn3k_TEzwm2Q_ckmMkrOH7Kl8KxJPOWsLte23NFm0ZylDjKFrTHyCfpapaQlNlkWgBxLBGxaAUNBzyMrVeBGnMqVA");
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
                MessageBox.Show(ex.Message, Ebssfryntcs.exmsg);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (txt_mailadresi.Text != "" && txt_platform.Text != "" && txt_sfr.Text != "")
                {
                    if (checkBox1.Text == "Ham Passwd")
                    {
                        string msj = Ebssfryntcs.EBSVeriKaydet(Application.StartupPath + "\\config", Ebssfryntcs.SifreleVeyaCoz(txt_platform.Text + ":" + txt_mailadresi.Text + ":" + txt_sfr.Text, Ebssfryntcs.passwd), dataGridView1);
                        if (msj == "Kayıt Başarılı")
                        {
                            temizle();
                            EBSTxtOku(Application.StartupPath + "\\config");
                        }
                    }
                    else
                    {
                        string msj = Ebssfryntcs.EBSVeriKaydet(Application.StartupPath + "\\config", Ebssfryntcs.SifreleVeyaCoz(txt_platform.Text + ":" + txt_mailadresi.Text + ":" + Ebssfryntcs.Sha1Hash(txt_sfr.Text, 2), Ebssfryntcs.passwd), dataGridView1);
                        if (msj == "Kayıt Başarılı")
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
                        errorProvider1.SetError(txt_mailadresi, "Bu alan boş geçilemez");
                    }
                    if (txt_platform.Text == "")
                    {
                        errorProvider1.SetError(txt_platform, "Bu alan boş geçilemez");
                    }
                    if (txt_sfr.Text == "")
                    {
                        errorProvider1.SetError(txt_sfr, "Bu alan boş geçilemez");
                    }

                    MessageBox.Show("Please Fill All Boxes");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Ebssfryntcs.exmsg);
            }
        }
    }
}
