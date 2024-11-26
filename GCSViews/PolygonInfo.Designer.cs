namespace MissionPlanner.GCSViews
{
    partial class PolygonInfo
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonGetFd = new System.Windows.Forms.Button();
            this.buttonTargetImage = new System.Windows.Forms.Button();
            this.buttonGetTD = new System.Windows.Forms.Button();
            this.labelAreaName = new System.Windows.Forms.Label();
            this.labelAreaValue = new System.Windows.Forms.Label();
            this.labelRmseName = new System.Windows.Forms.Label();
            this.labelRmseValue = new System.Windows.Forms.Label();
            this.labelSdAvgName = new System.Windows.Forms.Label();
            this.labelSdYValue = new System.Windows.Forms.Label();
            this.labelSdYName = new System.Windows.Forms.Label();
            this.labelSdAvgValue = new System.Windows.Forms.Label();
            this.labelBeamValue = new System.Windows.Forms.Label();
            this.labelWidthValue = new System.Windows.Forms.Label();
            this.labelSdXName = new System.Windows.Forms.Label();
            this.labelLatValue = new System.Windows.Forms.Label();
            this.labelMagValue = new System.Windows.Forms.Label();
            this.labelBeamName = new System.Windows.Forms.Label();
            this.labelWidthName = new System.Windows.Forms.Label();
            this.labelFreqValue = new System.Windows.Forms.Label();
            this.labelLatName = new System.Windows.Forms.Label();
            this.labelNumPtValue = new System.Windows.Forms.Label();
            this.labelMagName = new System.Windows.Forms.Label();
            this.labelSdXValue = new System.Windows.Forms.Label();
            this.labelFreqName = new System.Windows.Forms.Label();
            this.labelNumPtName = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonGetFd);
            this.groupBox.Controls.Add(this.buttonTargetImage);
            this.groupBox.Controls.Add(this.buttonGetTD);
            this.groupBox.Controls.Add(this.labelAreaName);
            this.groupBox.Controls.Add(this.labelAreaValue);
            this.groupBox.Controls.Add(this.labelRmseName);
            this.groupBox.Controls.Add(this.labelRmseValue);
            this.groupBox.Controls.Add(this.labelSdAvgName);
            this.groupBox.Controls.Add(this.labelSdYValue);
            this.groupBox.Controls.Add(this.labelSdYName);
            this.groupBox.Controls.Add(this.labelSdAvgValue);
            this.groupBox.Controls.Add(this.labelBeamValue);
            this.groupBox.Controls.Add(this.labelWidthValue);
            this.groupBox.Controls.Add(this.labelSdXName);
            this.groupBox.Controls.Add(this.labelLatValue);
            this.groupBox.Controls.Add(this.labelMagValue);
            this.groupBox.Controls.Add(this.labelBeamName);
            this.groupBox.Controls.Add(this.labelWidthName);
            this.groupBox.Controls.Add(this.labelFreqValue);
            this.groupBox.Controls.Add(this.labelLatName);
            this.groupBox.Controls.Add(this.labelNumPtValue);
            this.groupBox.Controls.Add(this.labelMagName);
            this.groupBox.Controls.Add(this.labelSdXValue);
            this.groupBox.Controls.Add(this.labelFreqName);
            this.groupBox.Controls.Add(this.labelNumPtName);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(0, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(633, 438);
            this.groupBox.TabIndex = 21;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Info";
            // 
            // buttonGetFd
            // 
            this.buttonGetFd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGetFd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetFd.Location = new System.Drawing.Point(230, 345);
            this.buttonGetFd.Name = "buttonGetFd";
            this.buttonGetFd.Size = new System.Drawing.Size(170, 70);
            this.buttonGetFd.TabIndex = 26;
            this.buttonGetFd.Text = "Freq.-domain \r\nsignature";
            this.buttonGetFd.UseVisualStyleBackColor = true;
            this.buttonGetFd.Click += new System.EventHandler(this.OnGetFDClicked);
            // 
            // buttonTargetImage
            // 
            this.buttonTargetImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTargetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTargetImage.Location = new System.Drawing.Point(440, 345);
            this.buttonTargetImage.Name = "buttonTargetImage";
            this.buttonTargetImage.Size = new System.Drawing.Size(170, 70);
            this.buttonTargetImage.TabIndex = 25;
            this.buttonTargetImage.Text = "Target \r\nimage";
            this.buttonTargetImage.UseVisualStyleBackColor = true;
            this.buttonTargetImage.Click += new System.EventHandler(this.OnGetTargetImageClicked);
            // 
            // buttonGetTD
            // 
            this.buttonGetTD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGetTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetTD.Location = new System.Drawing.Point(23, 345);
            this.buttonGetTD.Name = "buttonGetTD";
            this.buttonGetTD.Size = new System.Drawing.Size(170, 70);
            this.buttonGetTD.TabIndex = 24;
            this.buttonGetTD.Text = "Time-domain \r\nsignature";
            this.buttonGetTD.UseVisualStyleBackColor = true;
            this.buttonGetTD.Click += new System.EventHandler(this.OnGetTDClicked);
            // 
            // labelAreaName
            // 
            this.labelAreaName.AutoSize = true;
            this.labelAreaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAreaName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAreaName.Location = new System.Drawing.Point(18, 282);
            this.labelAreaName.Name = "labelAreaName";
            this.labelAreaName.Size = new System.Drawing.Size(270, 25);
            this.labelAreaName.TabIndex = 23;
            this.labelAreaName.Text = "Площа невизначеності, м2:";
            // 
            // labelAreaValue
            // 
            this.labelAreaValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAreaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAreaValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAreaValue.Location = new System.Drawing.Point(294, 282);
            this.labelAreaValue.Name = "labelAreaValue";
            this.labelAreaValue.Size = new System.Drawing.Size(316, 25);
            this.labelAreaValue.TabIndex = 22;
            this.labelAreaValue.Text = "0.00";
            this.labelAreaValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRmseName
            // 
            this.labelRmseName.AutoSize = true;
            this.labelRmseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRmseName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelRmseName.Location = new System.Drawing.Point(18, 257);
            this.labelRmseName.Name = "labelRmseName";
            this.labelRmseName.Size = new System.Drawing.Size(327, 25);
            this.labelRmseName.TabIndex = 21;
            this.labelRmseName.Text = "Середня квадратична похибка, м:";
            // 
            // labelRmseValue
            // 
            this.labelRmseValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRmseValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRmseValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelRmseValue.Location = new System.Drawing.Point(351, 257);
            this.labelRmseValue.Name = "labelRmseValue";
            this.labelRmseValue.Size = new System.Drawing.Size(259, 25);
            this.labelRmseValue.TabIndex = 20;
            this.labelRmseValue.Text = "0.00";
            this.labelRmseValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSdAvgName
            // 
            this.labelSdAvgName.AutoSize = true;
            this.labelSdAvgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSdAvgName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSdAvgName.Location = new System.Drawing.Point(18, 232);
            this.labelSdAvgName.Name = "labelSdAvgName";
            this.labelSdAvgName.Size = new System.Drawing.Size(342, 25);
            this.labelSdAvgName.TabIndex = 19;
            this.labelSdAvgName.Text = "Стандартне відхилення SD_avg, м:";
            // 
            // labelSdYValue
            // 
            this.labelSdYValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSdYValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSdYValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSdYValue.Location = new System.Drawing.Point(338, 207);
            this.labelSdYValue.Name = "labelSdYValue";
            this.labelSdYValue.Size = new System.Drawing.Size(272, 25);
            this.labelSdYValue.TabIndex = 18;
            this.labelSdYValue.Text = "0.00";
            this.labelSdYValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSdYName
            // 
            this.labelSdYName.AutoSize = true;
            this.labelSdYName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSdYName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSdYName.Location = new System.Drawing.Point(18, 205);
            this.labelSdYName.Name = "labelSdYName";
            this.labelSdYName.Size = new System.Drawing.Size(320, 25);
            this.labelSdYName.TabIndex = 17;
            this.labelSdYName.Text = "Стандартне відхилення SD_y, м:";
            // 
            // labelSdAvgValue
            // 
            this.labelSdAvgValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSdAvgValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSdAvgValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSdAvgValue.Location = new System.Drawing.Point(356, 232);
            this.labelSdAvgValue.Name = "labelSdAvgValue";
            this.labelSdAvgValue.Size = new System.Drawing.Size(254, 25);
            this.labelSdAvgValue.TabIndex = 16;
            this.labelSdAvgValue.Text = "0.00";
            this.labelSdAvgValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBeamValue
            // 
            this.labelBeamValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBeamValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeamValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelBeamValue.Location = new System.Drawing.Point(307, 155);
            this.labelBeamValue.Name = "labelBeamValue";
            this.labelBeamValue.Size = new System.Drawing.Size(303, 25);
            this.labelBeamValue.TabIndex = 15;
            this.labelBeamValue.Text = "0.00";
            this.labelBeamValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWidthValue
            // 
            this.labelWidthValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWidthValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidthValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelWidthValue.Location = new System.Drawing.Point(312, 130);
            this.labelWidthValue.Name = "labelWidthValue";
            this.labelWidthValue.Size = new System.Drawing.Size(298, 25);
            this.labelWidthValue.TabIndex = 13;
            this.labelWidthValue.Text = "0.00";
            this.labelWidthValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSdXName
            // 
            this.labelSdXName.AutoSize = true;
            this.labelSdXName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSdXName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSdXName.Location = new System.Drawing.Point(18, 180);
            this.labelSdXName.Name = "labelSdXName";
            this.labelSdXName.Size = new System.Drawing.Size(320, 25);
            this.labelSdXName.TabIndex = 12;
            this.labelSdXName.Text = "Стандартне відхилення SD_x, м:";
            // 
            // labelLatValue
            // 
            this.labelLatValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLatValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelLatValue.Location = new System.Drawing.Point(269, 105);
            this.labelLatValue.Name = "labelLatValue";
            this.labelLatValue.Size = new System.Drawing.Size(341, 25);
            this.labelLatValue.TabIndex = 11;
            this.labelLatValue.Text = "0.00 / 0.00";
            this.labelLatValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelLatValue.Click += new System.EventHandler(this.labelLatValue_Click);
            // 
            // labelMagValue
            // 
            this.labelMagValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMagValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMagValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMagValue.Location = new System.Drawing.Point(312, 80);
            this.labelMagValue.Name = "labelMagValue";
            this.labelMagValue.Size = new System.Drawing.Size(298, 25);
            this.labelMagValue.TabIndex = 10;
            this.labelMagValue.Text = "0.00";
            this.labelMagValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBeamName
            // 
            this.labelBeamName.AutoSize = true;
            this.labelBeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeamName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelBeamName.Location = new System.Drawing.Point(18, 155);
            this.labelBeamName.Name = "labelBeamName";
            this.labelBeamName.Size = new System.Drawing.Size(212, 25);
            this.labelBeamName.TabIndex = 9;
            this.labelBeamName.Text = "Ширина проміня, рад:";
            // 
            // labelWidthName
            // 
            this.labelWidthName.AutoSize = true;
            this.labelWidthName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidthName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelWidthName.Location = new System.Drawing.Point(18, 130);
            this.labelWidthName.Name = "labelWidthName";
            this.labelWidthName.Size = new System.Drawing.Size(245, 25);
            this.labelWidthName.TabIndex = 8;
            this.labelWidthName.Text = "Тривалість імпульса, мс:";
            // 
            // labelFreqValue
            // 
            this.labelFreqValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFreqValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFreqValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelFreqValue.Location = new System.Drawing.Point(307, 55);
            this.labelFreqValue.Name = "labelFreqValue";
            this.labelFreqValue.Size = new System.Drawing.Size(303, 25);
            this.labelFreqValue.TabIndex = 7;
            this.labelFreqValue.Text = "0.00";
            this.labelFreqValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLatName
            // 
            this.labelLatName.AutoSize = true;
            this.labelLatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelLatName.Location = new System.Drawing.Point(18, 105);
            this.labelLatName.Name = "labelLatName";
            this.labelLatName.Size = new System.Drawing.Size(172, 25);
            this.labelLatName.TabIndex = 6;
            this.labelLatName.Text = "Координати цілі: ";
            // 
            // labelNumPtValue
            // 
            this.labelNumPtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumPtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumPtValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNumPtValue.Location = new System.Drawing.Point(302, 30);
            this.labelNumPtValue.Name = "labelNumPtValue";
            this.labelNumPtValue.Size = new System.Drawing.Size(308, 25);
            this.labelNumPtValue.TabIndex = 5;
            this.labelNumPtValue.Text = "0.00";
            this.labelNumPtValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMagName
            // 
            this.labelMagName.AutoSize = true;
            this.labelMagName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMagName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMagName.Location = new System.Drawing.Point(18, 80);
            this.labelMagName.Name = "labelMagName";
            this.labelMagName.Size = new System.Drawing.Size(144, 25);
            this.labelMagName.TabIndex = 4;
            this.labelMagName.Text = "Магнітуда, дБ:";
            // 
            // labelSdXValue
            // 
            this.labelSdXValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSdXValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSdXValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSdXValue.Location = new System.Drawing.Point(339, 180);
            this.labelSdXValue.Name = "labelSdXValue";
            this.labelSdXValue.Size = new System.Drawing.Size(271, 25);
            this.labelSdXValue.TabIndex = 2;
            this.labelSdXValue.Text = "0.00";
            this.labelSdXValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFreqName
            // 
            this.labelFreqName.AutoSize = true;
            this.labelFreqName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFreqName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelFreqName.Location = new System.Drawing.Point(18, 55);
            this.labelFreqName.Name = "labelFreqName";
            this.labelFreqName.Size = new System.Drawing.Size(222, 25);
            this.labelFreqName.TabIndex = 1;
            this.labelFreqName.Text = "Частота проміння, Гц:";
            // 
            // labelNumPtName
            // 
            this.labelNumPtName.AutoSize = true;
            this.labelNumPtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumPtName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNumPtName.Location = new System.Drawing.Point(18, 30);
            this.labelNumPtName.Name = "labelNumPtName";
            this.labelNumPtName.Size = new System.Drawing.Size(216, 25);
            this.labelNumPtName.TabIndex = 0;
            this.labelNumPtName.Text = "Кількість вимірювань:";
            // 
            // PolygonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.groupBox);
            this.Name = "PolygonInfo";
            this.Text = "PolygonInfo";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelBeamValue;
        private System.Windows.Forms.Label labelWidthValue;
        private System.Windows.Forms.Label labelSdXName;
        private System.Windows.Forms.Label labelLatValue;
        private System.Windows.Forms.Label labelMagValue;
        private System.Windows.Forms.Label labelBeamName;
        private System.Windows.Forms.Label labelWidthName;
        private System.Windows.Forms.Label labelFreqValue;
        private System.Windows.Forms.Label labelLatName;
        private System.Windows.Forms.Label labelNumPtValue;
        private System.Windows.Forms.Label labelMagName;
        private System.Windows.Forms.Label labelSdXValue;
        private System.Windows.Forms.Label labelFreqName;
        private System.Windows.Forms.Label labelNumPtName;
        private System.Windows.Forms.Label labelAreaName;
        private System.Windows.Forms.Label labelAreaValue;
        private System.Windows.Forms.Label labelRmseName;
        private System.Windows.Forms.Label labelRmseValue;
        private System.Windows.Forms.Label labelSdAvgName;
        private System.Windows.Forms.Label labelSdYValue;
        private System.Windows.Forms.Label labelSdYName;
        private System.Windows.Forms.Label labelSdAvgValue;
        private System.Windows.Forms.Button buttonGetFd;
        private System.Windows.Forms.Button buttonTargetImage;
        private System.Windows.Forms.Button buttonGetTD;
    }
}