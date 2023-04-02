namespace SvgToPngIconConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnConvert = new System.Windows.Forms.Button();
            this.CbIconSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbFiles = new System.Windows.Forms.ListBox();
            this.TbxOutputFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSetOutput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ProgressBarConvert = new System.Windows.Forms.ProgressBar();
            this.LblFilesCount = new System.Windows.Forms.Label();
            this.BtnAddFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnConvert
            // 
            this.BtnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConvert.Location = new System.Drawing.Point(720, 428);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(85, 23);
            this.BtnConvert.TabIndex = 1;
            this.BtnConvert.Text = "CONVERT";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // CbIconSize
            // 
            this.CbIconSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CbIconSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbIconSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbIconSize.FormattingEnabled = true;
            this.CbIconSize.Items.AddRange(new object[] {
            "Original",
            "16 x 16",
            "24 x 24",
            "32 x 32",
            "64 x 64",
            "128 x 128",
            "256 x 256",
            "512 x 512"});
            this.CbIconSize.Location = new System.Drawing.Point(635, 429);
            this.CbIconSize.Name = "CbIconSize";
            this.CbIconSize.Size = new System.Drawing.Size(79, 21);
            this.CbIconSize.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Drop SVG files to convert";
            // 
            // LbFiles
            // 
            this.LbFiles.AllowDrop = true;
            this.LbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbFiles.FormattingEnabled = true;
            this.LbFiles.Location = new System.Drawing.Point(12, 33);
            this.LbFiles.Name = "LbFiles";
            this.LbFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LbFiles.Size = new System.Drawing.Size(793, 381);
            this.LbFiles.TabIndex = 5;
            this.LbFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.LbFiles_DragDrop);
            this.LbFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.LbFiles_DragEnter);
            this.LbFiles.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LbFiles_KeyUp);
            // 
            // TbxOutputFolder
            // 
            this.TbxOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxOutputFolder.Location = new System.Drawing.Point(89, 430);
            this.TbxOutputFolder.Name = "TbxOutputFolder";
            this.TbxOutputFolder.Size = new System.Drawing.Size(378, 20);
            this.TbxOutputFolder.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Output Folder";
            // 
            // BtnSetOutput
            // 
            this.BtnSetOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSetOutput.Location = new System.Drawing.Point(473, 428);
            this.BtnSetOutput.Name = "BtnSetOutput";
            this.BtnSetOutput.Size = new System.Drawing.Size(75, 23);
            this.BtnSetOutput.TabIndex = 8;
            this.BtnSetOutput.Text = "Change";
            this.BtnSetOutput.UseVisualStyleBackColor = true;
            this.BtnSetOutput.Click += new System.EventHandler(this.BtnSetOutput_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Icon Size";
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.Location = new System.Drawing.Point(753, 7);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(52, 23);
            this.BtnClear.TabIndex = 10;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "SVG Files";
            // 
            // ProgressBarConvert
            // 
            this.ProgressBarConvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBarConvert.Location = new System.Drawing.Point(12, 457);
            this.ProgressBarConvert.Name = "ProgressBarConvert";
            this.ProgressBarConvert.Size = new System.Drawing.Size(793, 23);
            this.ProgressBarConvert.TabIndex = 12;
            // 
            // LblFilesCount
            // 
            this.LblFilesCount.AutoSize = true;
            this.LblFilesCount.Location = new System.Drawing.Point(64, 12);
            this.LblFilesCount.Name = "LblFilesCount";
            this.LblFilesCount.Size = new System.Drawing.Size(16, 13);
            this.LblFilesCount.TabIndex = 13;
            this.LblFilesCount.Text = "(-)";
            // 
            // BtnAddFiles
            // 
            this.BtnAddFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddFiles.Location = new System.Drawing.Point(695, 7);
            this.BtnAddFiles.Name = "BtnAddFiles";
            this.BtnAddFiles.Size = new System.Drawing.Size(52, 23);
            this.BtnAddFiles.TabIndex = 14;
            this.BtnAddFiles.Text = "Add";
            this.BtnAddFiles.UseVisualStyleBackColor = true;
            this.BtnAddFiles.Click += new System.EventHandler(this.BtnAddFiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 492);
            this.Controls.Add(this.BtnAddFiles);
            this.Controls.Add(this.LblFilesCount);
            this.Controls.Add(this.ProgressBarConvert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSetOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxOutputFolder);
            this.Controls.Add(this.LbFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbIconSize);
            this.Controls.Add(this.BtnConvert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SVG to PNG - Icon Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.ComboBox CbIconSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LbFiles;
        private System.Windows.Forms.TextBox TbxOutputFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSetOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar ProgressBarConvert;
        private System.Windows.Forms.Label LblFilesCount;
        private System.Windows.Forms.Button BtnAddFiles;
    }
}

