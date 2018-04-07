namespace LSB
{
    partial class Form1
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnencode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.txtOpenFile = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(21, 21);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(280, 280);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(586, 49);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(76, 20);
            this.btnLoadImage.TabIndex = 1;
            this.btnLoadImage.Text = "Open File";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnencode
            // 
            this.btnencode.Location = new System.Drawing.Point(348, 173);
            this.btnencode.Name = "btnencode";
            this.btnencode.Size = new System.Drawing.Size(97, 26);
            this.btnencode.TabIndex = 2;
            this.btnencode.Text = "Encode";
            this.btnencode.UseVisualStyleBackColor = true;
            this.btnencode.Click += new System.EventHandler(this.btnencode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(565, 173);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(97, 26);
            this.btnDecode.TabIndex = 3;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // txtOpenFile
            // 
            this.txtOpenFile.Location = new System.Drawing.Point(348, 49);
            this.txtOpenFile.Name = "txtOpenFile";
            this.txtOpenFile.Size = new System.Drawing.Size(232, 20);
            this.txtOpenFile.TabIndex = 4;
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(348, 135);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(314, 20);
            this.txtMsg.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập plain text cần mã hoá:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chọn file ảnh *.png hoặc *.jpg:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtOpenFile);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnencode);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Giấu tin trong ảnh bằng thuật toán LSB";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnencode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.TextBox txtOpenFile;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

