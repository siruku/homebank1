using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HomeBank1
{
    public partial class MsgForm : Form{
        private Bitmap canvas;
        private Graphics g;

        public MsgForm()
        {
            InitializeComponent();
        }
        private void MsgForm_Load(object sender, EventArgs e){
            this.MaximizeBox = this.MinimizeBox = false;
        }
        private void ButtonLabel_Resize(object sender, EventArgs e)
        {
            OkButton.Left = ButtonLabel.Width - (OkButton.Width + 12);
        }
        private void ButtonLabel_Move(object sender, EventArgs e)
        {
            OkButton.Top = ButtonLabel.Top + 11;
            IconPictureBox.Top = (ButtonLabel.Top / 2) - (IconPictureBox.Height / 2);
        }
        
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Method
        public void ReInitializeForm(string msg, string title, Icon icon)
        {
            this.Text = title;
            MsgLabel.Text = msg;
            //SetIcon
            canvas = new Bitmap(IconPictureBox.Width, IconPictureBox.Height);
            g = Graphics.FromImage(canvas);
            g.DrawIcon(icon, 0, 0);
            g.Dispose();
            IconPictureBox.Image = canvas;
            //ResizeForm
            this.Width += 40;
            int formNewHeight = MsgLabel.Top + MsgLabel.Height + ButtonLabel.Height + 40;
            if (this.Height < formNewHeight) { this.Height = formNewHeight; }
        }

    }
}
