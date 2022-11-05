using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class frTextEditor : Form
    {
        string doc;
        public frTextEditor()
        {
            InitializeComponent();
            pnTextTools.Visible = false;
        }
        private void mostrarSubMenu()
        {
            if (pnTextTools.Visible == false)
            {
                pnTextTools.Visible = true;
            }
            else
            {
                pnTextTools.Visible = false;
            }
        }
        private void btnTextTools_Click(object sender, EventArgs e)
        {
            mostrarSubMenu();
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            txtText.Clear();
            doc = null;
            frTextEditor.ActiveForm.Text = doc + "TextEditor";
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Texto|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                doc = openFile.FileName;

                using (StreamReader sr = new StreamReader(doc))
                {
                    txtText.Text = sr.ReadToEnd();
                }
                frTextEditor.ActiveForm.Text = doc + " | TextPaint";
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Texto|*.txt";

            if (doc != null)
            {
                using (StreamWriter sw = new StreamWriter(doc))
                {
                    sw.Write(txtText.Text);
                }
            }
            else
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    doc = saveFile.FileName;
                    using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                    {
                        sw.Write(txtText.Text);
                    }

                }
            }
            frTextEditor.ActiveForm.Text = doc + " | TextPaint";
        }

        private void btnTextStyle_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            if (fontDlg.ShowDialog() == DialogResult.OK)
            {
                fontDlg.ShowColor = true;
                fontDlg.ShowApply = true;
                fontDlg.ShowEffects = true;
                fontDlg.ShowHelp = true;
                fontDlg.MaxSize = 36;
                fontDlg.MinSize = 10;
                txtText.Font = fontDlg.Font;
            }
        }
    }
}
