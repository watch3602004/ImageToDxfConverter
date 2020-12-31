
namespace ImageToDxfConverter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._SelectedPath = new System.Windows.Forms.TextBox();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._buttonSaveDxf = new System.Windows.Forms.Button();
            this._labelPitch = new System.Windows.Forms.Label();
            this._numericLinePitch = new System.Windows.Forms.NumericUpDown();
            this._buttonReadImage = new System.Windows.Forms.Button();
            this._numericUpDownThreshold = new System.Windows.Forms.NumericUpDown();
            this._labelThreshold = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericLinePitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // _SelectedPath
            // 
            this._SelectedPath.Location = new System.Drawing.Point(9, 7);
            this._SelectedPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._SelectedPath.Name = "_SelectedPath";
            this._SelectedPath.ReadOnly = true;
            this._SelectedPath.Size = new System.Drawing.Size(301, 19);
            this._SelectedPath.TabIndex = 2;
            // 
            // _pictureBox
            // 
            this._pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pictureBox.Location = new System.Drawing.Point(9, 28);
            this._pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(300, 300);
            this._pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._pictureBox.TabIndex = 3;
            this._pictureBox.TabStop = false;
            // 
            // _buttonSaveDxf
            // 
            this._buttonSaveDxf.Location = new System.Drawing.Point(312, 310);
            this._buttonSaveDxf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._buttonSaveDxf.Name = "_buttonSaveDxf";
            this._buttonSaveDxf.Size = new System.Drawing.Size(92, 18);
            this._buttonSaveDxf.TabIndex = 4;
            this._buttonSaveDxf.Text = "Save as DXF";
            this._buttonSaveDxf.UseVisualStyleBackColor = true;
            this._buttonSaveDxf.Click += new System.EventHandler(this._buttonSaveDxf_Click);
            // 
            // _labelPitch
            // 
            this._labelPitch.AutoSize = true;
            this._labelPitch.Location = new System.Drawing.Point(312, 267);
            this._labelPitch.Name = "_labelPitch";
            this._labelPitch.Size = new System.Drawing.Size(83, 12);
            this._labelPitch.TabIndex = 6;
            this._labelPitch.Text = "Line Pitch [um]";
            // 
            // _numericLinePitch
            // 
            this._numericLinePitch.DecimalPlaces = 1;
            this._numericLinePitch.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this._numericLinePitch.Location = new System.Drawing.Point(312, 281);
            this._numericLinePitch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numericLinePitch.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._numericLinePitch.Name = "_numericLinePitch";
            this._numericLinePitch.Size = new System.Drawing.Size(92, 19);
            this._numericLinePitch.TabIndex = 7;
            this._numericLinePitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._numericLinePitch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _buttonReadImage
            // 
            this._buttonReadImage.Location = new System.Drawing.Point(314, 7);
            this._buttonReadImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._buttonReadImage.Name = "_buttonReadImage";
            this._buttonReadImage.Size = new System.Drawing.Size(92, 18);
            this._buttonReadImage.TabIndex = 0;
            this._buttonReadImage.Text = "Read Image";
            this._buttonReadImage.UseVisualStyleBackColor = true;
            this._buttonReadImage.Click += new System.EventHandler(this._buttonReadImage_Click);
            // 
            // _numericUpDownThreshold
            // 
            this._numericUpDownThreshold.Location = new System.Drawing.Point(313, 243);
            this._numericUpDownThreshold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numericUpDownThreshold.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._numericUpDownThreshold.Name = "_numericUpDownThreshold";
            this._numericUpDownThreshold.Size = new System.Drawing.Size(92, 19);
            this._numericUpDownThreshold.TabIndex = 8;
            this._numericUpDownThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._numericUpDownThreshold.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this._numericUpDownThreshold.ValueChanged += new System.EventHandler(this._numericUpDownThreshold_ValueChanged);
            // 
            // _labelThreshold
            // 
            this._labelThreshold.AutoSize = true;
            this._labelThreshold.Location = new System.Drawing.Point(312, 229);
            this._labelThreshold.Name = "_labelThreshold";
            this._labelThreshold.Size = new System.Drawing.Size(92, 12);
            this._labelThreshold.TabIndex = 9;
            this._labelThreshold.Text = "Binary Threshold";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 335);
            this.Controls.Add(this._labelThreshold);
            this.Controls.Add(this._numericUpDownThreshold);
            this.Controls.Add(this._numericLinePitch);
            this.Controls.Add(this._labelPitch);
            this.Controls.Add(this._buttonSaveDxf);
            this.Controls.Add(this._pictureBox);
            this.Controls.Add(this._SelectedPath);
            this.Controls.Add(this._buttonReadImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Image to DXF Converter";
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericLinePitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox _SelectedPath;
        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.Button _buttonSaveDxf;
        private System.Windows.Forms.Label _labelPitch;
        private System.Windows.Forms.NumericUpDown _numericLinePitch;
        private System.Windows.Forms.Button _buttonReadImage;
        private System.Windows.Forms.NumericUpDown _numericUpDownThreshold;
        private System.Windows.Forms.Label _labelThreshold;
    }
}

