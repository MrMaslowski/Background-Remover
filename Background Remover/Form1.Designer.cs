namespace Background_Remover
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rmBg = new System.Windows.Forms.Button();
            this.downlaod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRange = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.fLP1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tbRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.fLP1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rmBg
            // 
            this.rmBg.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rmBg.Location = new System.Drawing.Point(128, 473);
            this.rmBg.Name = "rmBg";
            this.rmBg.Size = new System.Drawing.Size(168, 31);
            this.rmBg.TabIndex = 0;
            this.rmBg.Text = "Remove Color";
            this.rmBg.UseVisualStyleBackColor = true;
            this.rmBg.Click += new System.EventHandler(this.rmBg_Click);
            // 
            // downlaod
            // 
            this.downlaod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.downlaod.Location = new System.Drawing.Point(163, 510);
            this.downlaod.Name = "downlaod";
            this.downlaod.Size = new System.Drawing.Size(88, 36);
            this.downlaod.TabIndex = 1;
            this.downlaod.Text = "Download";
            this.downlaod.UseVisualStyleBackColor = true;
            this.downlaod.Click += new System.EventHandler(this.downlaod_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(137, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "--";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(27, 21);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(330, 15);
            this.description.TabIndex = 5;
            this.description.Text = "Click on the color from the background in order to remove it.";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Color to remove: ";
            // 
            // tbRange
            // 
            this.tbRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRange.Location = new System.Drawing.Point(172, 428);
            this.tbRange.Maximum = 100;
            this.tbRange.Name = "tbRange";
            this.tbRange.Size = new System.Drawing.Size(192, 45);
            this.tbRange.TabIndex = 8;
            this.tbRange.Value = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Abweichung der Farbe:";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(350, 350);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
            this.pictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragEnter);
            // 
            // fLP1
            // 
            this.fLP1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fLP1.AutoScroll = true;
            this.fLP1.BackColor = System.Drawing.Color.Transparent;
            this.fLP1.Controls.Add(this.pictureBox);
            this.fLP1.Location = new System.Drawing.Point(27, 49);
            this.fLP1.Name = "fLP1";
            this.fLP1.Size = new System.Drawing.Size(358, 358);
            this.fLP1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 558);
            this.Controls.Add(this.fLP1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.downlaod);
            this.Controls.Add(this.rmBg);
            this.MinimumSize = new System.Drawing.Size(427, 597);
            this.Name = "Form1";
            this.Text = "Background Remover";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.fLP1.ResumeLayout(false);
            this.fLP1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button rmBg;
        private Button downlaod;
        private Label label1;
        private Label description;
        private Label label4;
        private TrackBar tbRange;
        private Label label2;
        private PictureBox pictureBox;
        private FlowLayoutPanel fLP1;
    }
}