namespace practica1
{
    partial class paints
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paints));
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncolor = new System.Windows.Forms.Button();
            this.btnpaint = new System.Windows.Forms.Button();
            this.btnpencil = new System.Windows.Forms.Button();
            this.btneraser = new System.Windows.Forms.Button();
            this.btnline = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(1, 107);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(806, 357);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.btnline);
            this.panel1.Controls.Add(this.btneraser);
            this.panel1.Controls.Add(this.btnpencil);
            this.panel1.Controls.Add(this.btnpaint);
            this.panel1.Controls.Add(this.btncolor);
            this.panel1.Location = new System.Drawing.Point(127, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 98);
            this.panel1.TabIndex = 1;
            // 
            // btncolor
            // 
            this.btncolor.Image = ((System.Drawing.Image)(resources.GetObject("btncolor.Image")));
            this.btncolor.Location = new System.Drawing.Point(22, 13);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(75, 67);
            this.btncolor.TabIndex = 0;
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // btnpaint
            // 
            this.btnpaint.Image = ((System.Drawing.Image)(resources.GetObject("btnpaint.Image")));
            this.btnpaint.Location = new System.Drawing.Point(117, 13);
            this.btnpaint.Name = "btnpaint";
            this.btnpaint.Size = new System.Drawing.Size(75, 67);
            this.btnpaint.TabIndex = 1;
            this.btnpaint.UseVisualStyleBackColor = true;
            this.btnpaint.Click += new System.EventHandler(this.btnpaint_Click);
            this.btnpaint.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnpaint_MouseClick);
            // 
            // btnpencil
            // 
            this.btnpencil.Image = ((System.Drawing.Image)(resources.GetObject("btnpencil.Image")));
            this.btnpencil.Location = new System.Drawing.Point(213, 13);
            this.btnpencil.Name = "btnpencil";
            this.btnpencil.Size = new System.Drawing.Size(75, 67);
            this.btnpencil.TabIndex = 2;
            this.btnpencil.UseVisualStyleBackColor = true;
            this.btnpencil.Click += new System.EventHandler(this.btnpencil_Click);
            // 
            // btneraser
            // 
            this.btneraser.Image = ((System.Drawing.Image)(resources.GetObject("btneraser.Image")));
            this.btneraser.Location = new System.Drawing.Point(305, 13);
            this.btneraser.Name = "btneraser";
            this.btneraser.Size = new System.Drawing.Size(75, 67);
            this.btneraser.TabIndex = 3;
            this.btneraser.UseVisualStyleBackColor = true;
            this.btneraser.Click += new System.EventHandler(this.btneraser_Click);
            // 
            // btnline
            // 
            this.btnline.Image = ((System.Drawing.Image)(resources.GetObject("btnline.Image")));
            this.btnline.Location = new System.Drawing.Point(398, 13);
            this.btnline.Name = "btnline";
            this.btnline.Size = new System.Drawing.Size(75, 67);
            this.btnline.TabIndex = 4;
            this.btnline.UseVisualStyleBackColor = true;
            this.btnline.Click += new System.EventHandler(this.btnline_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(508, 13);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 30);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(508, 49);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // paints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.Name = "paints";
            this.Text = "paints";
            this.Load += new System.EventHandler(this.paints_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnline;
        private System.Windows.Forms.Button btneraser;
        private System.Windows.Forms.Button btnpencil;
        private System.Windows.Forms.Button btnpaint;
        private System.Windows.Forms.Button btncolor;
    }
}