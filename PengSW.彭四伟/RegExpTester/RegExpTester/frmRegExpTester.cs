using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RegExpTester
{
    public partial class frmRegExpTester : Form
    {
        public frmRegExpTester()
        {
            InitializeComponent();
        }

        private System.Text.RegularExpressions.Regex RegExp
        {
            get
            {
                System.Text.RegularExpressions.RegexOptions anOptions = System.Text.RegularExpressions.RegexOptions.None;
                if (chkMultiLine.Checked) anOptions |= System.Text.RegularExpressions.RegexOptions.Multiline;
                if (chkIgnoreCase.Checked) anOptions |= System.Text.RegularExpressions.RegexOptions.IgnoreCase;
                if (chkSingleLine.Checked) anOptions |= System.Text.RegularExpressions.RegexOptions.Singleline;
                return new System.Text.RegularExpressions.Regex(txtPattern.Text, anOptions);
            }
        }

        private void cmdExecute_Click(object sender, EventArgs e)
        {
            try
            {
                //System.Text.RegularExpressions.Match aMatch = RegExp.Match(txtText.Text);
                //if (aMatch.Success)
                //{
                //    txtResult.Text = "";
                //    while (aMatch.Success)
                //    {
                //        txtResult.Text += "∆•≈‰Œƒ±æ£∫\r\n";
                //        txtResult.Text += aMatch.Value + "\r\n";
                //        foreach (System.Text.RegularExpressions.Group aGroup in aMatch.Groups)
                //        {
                //            txtResult.Text += "Group: \r\n";
                //            txtResult.Text += aGroup.Value;
                //            txtResult.Text += "\r\n";
                //        }
                //        foreach (System.Text.RegularExpressions.Capture c in aMatch.Captures)
                //        {
                //            txtResult.Text += "Capture£∫\r\n";
                //            txtResult.Text += c.Value;
                //            txtResult.Text += "\r\n";
                //        }
                //        txtResult.Update();
                //        aMatch = aMatch.NextMatch();
                //    }
                //}
                //else
                //{
                //    txtResult.Text = "∆•≈‰ ß∞‹£°";
                //}
                System.Text.RegularExpressions.MatchCollection aMatches = RegExp.Matches(txtText.Text);
                if (aMatches.Count > 0)
                {
                    txtResult.Clear();
                    foreach (System.Text.RegularExpressions.Match aMatch in aMatches)
                    {
                        txtResult.AppendText("∆•≈‰Œƒ±æ£∫\r\n");
                        txtResult.AppendText(aMatch.Value + "\r\n");
                        int i = 0;
                        foreach (System.Text.RegularExpressions.Group aGroup in aMatch.Groups)
                        {
                            txtResult.AppendText(string.Format("Group[{0}]: \r\n", i++));
                            txtResult.AppendText(aGroup.Value);
                            txtResult.AppendText("\r\n");
                        }
                        i = 0;
                        foreach (System.Text.RegularExpressions.Capture c in aMatch.Captures)
                        {
                            txtResult.AppendText(string.Format("Capture[{0}]£∫\r\n", i++));
                            txtResult.AppendText(c.Value);
                            txtResult.AppendText("\r\n");
                        }
                    }
                }
                else
                {
                    txtResult.Text = "∆•≈‰ ß∞‹£°";
                }
            }
            catch (Exception anException)
            {
                MessageBox.Show(anException.Message);
            }
        }

        private void cmdReplace_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = RegExp.Replace(txtText.Text, txtReplacePattern.Text);
            }
            catch (Exception anException)
            {
                MessageBox.Show(anException.Message);
            }
        }
    }
}