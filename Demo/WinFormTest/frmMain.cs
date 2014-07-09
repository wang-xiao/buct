using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormTest
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Image m_Image = null;
        private void OnForm_Paint(object sender, PaintEventArgs e)
        {
            if (m_Image == null) return;
            e.Graphics.DrawImage(m_Image, 0, 0);
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog aDlg = new OpenFileDialog();
            aDlg.Filter = "Jpeg files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            if (aDlg.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            try
            {
                m_Image = Image.FromFile(aDlg.FileName);
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "加载图片错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
