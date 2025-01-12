
namespace OnlineRadio
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.codeeloToggleButton1 = new CodeeloUI.Controls.CodeeloToggleButton();
            this.codeeloGradientPanel1 = new CodeeloUI.Controls.CodeeloGradientPanel();
            this.codeeloCircularProgressBar1 = new CodeeloUI.Controls.CodeeloCircularProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.codeeloButton1 = new CodeeloUI.Controls.CodeeloButton();
            this.codeeloComboBox1 = new CodeeloUI.Controls.CodeeloComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.codeeloGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.BackColor = System.Drawing.Color.Aqua;
            this.trackBarVolume.LargeChange = 1;
            this.trackBarVolume.Location = new System.Drawing.Point(1, 257);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVolume.Size = new System.Drawing.Size(45, 104);
            this.trackBarVolume.TabIndex = 4;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // codeeloToggleButton1
            // 
            this.codeeloToggleButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.codeeloToggleButton1.AreaColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.codeeloToggleButton1.AreaColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(220)))), ((int)(((byte)(95)))));
            this.codeeloToggleButton1.BackColor = System.Drawing.Color.Transparent;
            this.codeeloToggleButton1.DrawCircle = true;
            this.codeeloToggleButton1.Location = new System.Drawing.Point(101, 100);
            this.codeeloToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.codeeloToggleButton1.Name = "codeeloToggleButton1";
            this.codeeloToggleButton1.Size = new System.Drawing.Size(109, 56);
            this.codeeloToggleButton1.TabIndex = 6;
            this.codeeloToggleButton1.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.codeeloToggleButton1.ToggleColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.codeeloToggleButton1.UseTransparentBackColor = false;
            this.codeeloToggleButton1.UseVisualStyleBackColor = false;
            this.codeeloToggleButton1.CheckedChanged += new System.EventHandler(this.codeeloToggleButton1_CheckedChanged);
            // 
            // codeeloGradientPanel1
            // 
            this.codeeloGradientPanel1.AccessibleRole = null;
            this.codeeloGradientPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeeloGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.codeeloGradientPanel1.CausesValidation = false;
            this.codeeloGradientPanel1.ColorFillFirst = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(233)))), ((int)(((byte)(172)))));
            this.codeeloGradientPanel1.ColorFillSecond = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.codeeloGradientPanel1.Controls.Add(this.codeeloCircularProgressBar1);
            this.codeeloGradientPanel1.Controls.Add(this.pictureBox1);
            this.codeeloGradientPanel1.Controls.Add(this.codeeloButton1);
            this.codeeloGradientPanel1.Controls.Add(this.codeeloComboBox1);
            this.codeeloGradientPanel1.Controls.Add(this.trackBarVolume);
            this.codeeloGradientPanel1.Controls.Add(this.codeeloToggleButton1);
            this.codeeloGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeeloGradientPanel1.DrawGradient = true;
            this.codeeloGradientPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.codeeloGradientPanel1.Name = "codeeloGradientPanel1";
            this.codeeloGradientPanel1.Size = new System.Drawing.Size(302, 361);
            this.codeeloGradientPanel1.TabIndex = 7;
            // 
            // codeeloCircularProgressBar1
            // 
            this.codeeloCircularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.codeeloCircularProgressBar1.BarFirstColor = System.Drawing.Color.LightSkyBlue;
            this.codeeloCircularProgressBar1.BarSecondColor = System.Drawing.Color.DodgerBlue;
            this.codeeloCircularProgressBar1.BarShapeEnd = System.Drawing.Drawing2D.LineCap.Round;
            this.codeeloCircularProgressBar1.BarShapeStart = System.Drawing.Drawing2D.LineCap.Round;
            this.codeeloCircularProgressBar1.BarWidth = 14F;
            this.codeeloCircularProgressBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.codeeloCircularProgressBar1.DisplayedTextType = CodeeloUI.Controls.CodeeloCircularProgressBar.TextMode.Value;
            this.codeeloCircularProgressBar1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.codeeloCircularProgressBar1.ForeColor = System.Drawing.Color.DimGray;
            this.codeeloCircularProgressBar1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloCircularProgressBar1.LineColor = System.Drawing.Color.DimGray;
            this.codeeloCircularProgressBar1.LineWidth = 1;
            this.codeeloCircularProgressBar1.Location = new System.Drawing.Point(172, 231);
            this.codeeloCircularProgressBar1.MaxValue = 100;
            this.codeeloCircularProgressBar1.MinimumSize = new System.Drawing.Size(100, 100);
            this.codeeloCircularProgressBar1.Name = "codeeloCircularProgressBar1";
            this.codeeloCircularProgressBar1.Size = new System.Drawing.Size(130, 130);
            this.codeeloCircularProgressBar1.TabIndex = 5;
            this.codeeloCircularProgressBar1.Text = "0";
            this.codeeloCircularProgressBar1.Value = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(23, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // codeeloButton1
            // 
            this.codeeloButton1.AccessibleRole = null;
            this.codeeloButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeeloButton1.BackColor = System.Drawing.Color.Transparent;
            this.codeeloButton1.BorderColor_1 = System.Drawing.Color.Transparent;
            this.codeeloButton1.BorderColor_2 = System.Drawing.Color.Transparent;
            this.codeeloButton1.BorderRadius = 20;
            this.codeeloButton1.BorderSize = 3;
            this.codeeloButton1.CausesValidation = false;
            this.codeeloButton1.ColorFill_1 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(112)))), ((int)(((byte)(232)))));
            this.codeeloButton1.ColorFill_2 = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(189)))));
            this.codeeloButton1.DialogResult = false;
            this.codeeloButton1.FlatAppearance.BorderSize = 0;
            this.codeeloButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.codeeloButton1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeeloButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.codeeloButton1.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloButton1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloButton1.Location = new System.Drawing.Point(210, 3);
            this.codeeloButton1.Name = "codeeloButton1";
            this.codeeloButton1.OnClick_BorderColor_1 = System.Drawing.Color.Transparent;
            this.codeeloButton1.OnClick_BorderColor_2 = System.Drawing.Color.Transparent;
            this.codeeloButton1.OnClick_FillColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(184)))), ((int)(((byte)(216)))));
            this.codeeloButton1.OnClick_FillColor_2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(225)))), ((int)(((byte)(229)))));
            this.codeeloButton1.OnOver_BorderColor_1 = System.Drawing.Color.Transparent;
            this.codeeloButton1.OnOver_BorderColor_2 = System.Drawing.Color.Transparent;
            this.codeeloButton1.OnOver_FillColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.codeeloButton1.OnOver_FillColor_2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(205)))), ((int)(((byte)(209)))));
            this.codeeloButton1.Size = new System.Drawing.Size(90, 36);
            this.codeeloButton1.TabIndex = 8;
            this.codeeloButton1.TabStop = false;
            this.codeeloButton1.Text = "Добавить";
            this.codeeloButton1.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            this.codeeloButton1.UseGradient = true;
            this.codeeloButton1.UseGradientBorder = true;
            this.codeeloButton1.UseMnemonic = false;
            this.codeeloButton1.UseVisualStyleBackColor = false;
            this.codeeloButton1.Click += new System.EventHandler(this.codeeloButton1_Click);
            // 
            // codeeloComboBox1
            // 
            this.codeeloComboBox1.ArrowColor = System.Drawing.Color.MediumSlateBlue;
            this.codeeloComboBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.codeeloComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.codeeloComboBox1.BorderSize = 1;
            this.codeeloComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.codeeloComboBox1.DropDownWidth = 148;
            this.codeeloComboBox1.DroppedDown = false;
            this.codeeloComboBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.codeeloComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.codeeloComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.codeeloComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.codeeloComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.codeeloComboBox1.Location = new System.Drawing.Point(66, 51);
            this.codeeloComboBox1.Name = "codeeloComboBox1";
            this.codeeloComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.codeeloComboBox1.SelectedIndex = -1;
            this.codeeloComboBox1.SelectedItem = null;
            this.codeeloComboBox1.SelectedText = "";
            this.codeeloComboBox1.SelectedValue = null;
            this.codeeloComboBox1.Size = new System.Drawing.Size(178, 37);
            this.codeeloComboBox1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(302, 361);
            this.Controls.Add(this.codeeloGradientPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Радио Online";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.codeeloGradientPanel1.ResumeLayout(false);
            this.codeeloGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarVolume;
        private CodeeloUI.Controls.CodeeloToggleButton codeeloToggleButton1;
        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel1;
        private CodeeloUI.Controls.CodeeloComboBox codeeloComboBox1;
        private CodeeloUI.Controls.CodeeloButton codeeloButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CodeeloUI.Controls.CodeeloCircularProgressBar codeeloCircularProgressBar1;
    }
}

