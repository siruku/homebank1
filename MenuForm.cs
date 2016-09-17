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
using System.Xml.Serialization;



namespace HomeBank1
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            topPictureBox.Visible = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void MenuForm_Load(object sender, EventArgs e)
        {
            Opacity = ComMthd.formOpacity;
//            SavedData.InitializeDataSet();
            topPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            topPictureBox.ImageLocation = Path.Combine(Application.StartupPath, "kansu.jpg");
            InitializeLabel();
            timer.Start();
        }
        //Hand-Made-Function
        private void InitializeLabel()
        {
            BackLabelWrite.Enabled = BackLabelAnalyze.Enabled = false;
            labelOpen.Font = labelWrite.Font = labelAnalyze.Font = labelMakeNew.Font = new Font(labelOpen.Font.FontFamily, 14, FontStyle.Bold);

        }
        private void EnableLabel(bool enableSign)
        {
            if (enableSign == true)
            {
                labelWrite.ForeColor = labelAnalyze.ForeColor = SystemColors.Highlight;
                labelWrite.Cursor = labelAnalyze.Cursor = Cursors.Hand;
            }
            else
            {
                labelWrite.ForeColor = labelAnalyze.ForeColor = SystemColors.ScrollBar;
                labelWrite.Cursor = labelAnalyze.Cursor = Cursors.Arrow;
            }
            BackLabelWrite.Enabled = BackLabelAnalyze.Enabled = enableSign;
        }
        private void UpdateLabelColor(Control label, Color color)
        {
            //double opacity = bounds.Contains(Cursor.Position) ? 1.0 : 0.5;
            //if (Opacity != opacity) Opacity = opacity;
            Color labelColor = label.Bounds.Contains(this.PointToClient(Cursor.Position)) ?
                color : Color.White;
            if (label.BackColor != labelColor) label.BackColor = labelColor;
        }

        //2. Read/Make/Search File
/*        private bool LoadData()
        {
            openDataFileDialog.FileName = "";
            openDataFileDialog.InitialDirectory = Application.StartupPath;
            openDataFileDialog.CheckPathExists = true;
            openDataFileDialog.Filter = "(*.xml)|*.xml";
            if (openDataFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (SavedData.OpenFile(openDataFileDialog.FileName))
                {
                    return true;
                }
            }
            return false;
        }
        private bool NameFile()
        {
            timer.Stop();
            NamingFileForm formName = new NamingFileForm();
            ComMthd.ShowHandMadeDialog(this, formName);
            timer.Start();
            if (formName.DialogResult == DialogResult.OK)
            {
                return true;
            }
            else { return false; }
        }*/

        private bool SearchXmlFile()
        {
            if (Directory.GetFiles(Application.StartupPath, "*.xml").Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
