namespace HomeBank1
{
    partial class MsgForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.ButtonLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.MsgLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.Location = new System.Drawing.Point(24, 29);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(44, 45);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.IconPictureBox.TabIndex = 0;
            this.IconPictureBox.TabStop = false;
            // 
            // ButtonLabel
            // 
            this.ButtonLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonLabel.Location = new System.Drawing.Point(0, 86);
            this.ButtonLabel.Name = "ButtonLabel";
            this.ButtonLabel.Size = new System.Drawing.Size(191, 51);
            this.ButtonLabel.TabIndex = 1;
            //            this.ButtonLabel.Move += new System.EventHandler(this.ButtonLabel_Move);
            this.ButtonLabel.Resize += new System.EventHandler(this.ButtonLabel_Resize);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(99, 97);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(80, 28);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;

            //            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // MsgLabel
            // 
            this.MsgLabel.AutoSize = true;
            this.MsgLabel.Location = new System.Drawing.Point(74, 40);
            this.MsgLabel.Name = "MsgLabel";
            this.MsgLabel.Size = new System.Drawing.Size(53, 12);
            this.MsgLabel.TabIndex = 3;
            this.MsgLabel.Text = "MsgLabel";
            // 
            // MsgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(191, 137);
            this.Controls.Add(this.MsgLabel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.IconPictureBox);
            this.Controls.Add(this.ButtonLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MsgForm";
            this.Text = "Form2";
            //            this.Load += new System.EventHandler(this.MsgForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.Label ButtonLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label MsgLabel;
    }
}