
namespace praktuchna02
{
    partial class ZipFileFolder
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
            this.label1 = new System.Windows.Forms.Label();
            this.textFolder = new System.Windows.Forms.TextBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnZipFolder = new System.Windows.Forms.Button();
            this.btnZipFile = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.textFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder";
            // 
            // textFolder
            // 
            this.textFolder.Location = new System.Drawing.Point(90, 31);
            this.textFolder.Name = "textFolder";
            this.textFolder.Size = new System.Drawing.Size(358, 27);
            this.textFolder.TabIndex = 1;
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(464, 31);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(30, 29);
            this.btnFolder.TabIndex = 2;
            this.btnFolder.Text = "...";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnZipFolder
            // 
            this.btnZipFolder.Location = new System.Drawing.Point(521, 31);
            this.btnZipFolder.Name = "btnZipFolder";
            this.btnZipFolder.Size = new System.Drawing.Size(94, 29);
            this.btnZipFolder.TabIndex = 3;
            this.btnZipFolder.Text = "Zip";
            this.btnZipFolder.UseVisualStyleBackColor = true;
            // 
            // btnZipFile
            // 
            this.btnZipFile.Location = new System.Drawing.Point(521, 84);
            this.btnZipFile.Name = "btnZipFile";
            this.btnZipFile.Size = new System.Drawing.Size(94, 29);
            this.btnZipFile.TabIndex = 7;
            this.btnZipFile.Text = "Zip";
            this.btnZipFile.UseVisualStyleBackColor = true;
            this.btnZipFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(464, 84);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(30, 29);
            this.btnFile.TabIndex = 6;
            this.btnFile.Text = "...";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.button4_Click);
            // 
            // textFile
            // 
            this.textFile.Location = new System.Drawing.Point(90, 84);
            this.textFile.Name = "textFile";
            this.textFile.Size = new System.Drawing.Size(358, 27);
            this.textFile.TabIndex = 5;
            this.textFile.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "File";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(90, 151);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(358, 29);
            this.progressBar1.TabIndex = 8;
            // 
            // ZipFileFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 217);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnZipFile);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.textFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnZipFolder);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.textFolder);
            this.Controls.Add(this.label1);
            this.Name = "ZipFileFolder";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFolder;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnZipFolder;
        private System.Windows.Forms.Button btnZipFile;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox textFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

