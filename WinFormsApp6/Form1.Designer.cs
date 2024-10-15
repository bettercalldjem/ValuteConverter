namespace CurrencyConverter
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            comboBoxFrom = new ComboBox();
            comboBoxTo = new ComboBox();
            textBoxAmount = new TextBox();
            btnConvert = new Button();
            labelResult = new Label();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // comboBoxFrom
            // 
            comboBoxFrom.FormattingEnabled = true;
            comboBoxFrom.Location = new Point(14, 14);
            comboBoxFrom.Margin = new Padding(4, 3, 4, 3);
            comboBoxFrom.Name = "comboBoxFrom";
            comboBoxFrom.Size = new Size(140, 23);
            comboBoxFrom.TabIndex = 0;
            // 
            // comboBoxTo
            // 
            comboBoxTo.FormattingEnabled = true;
            comboBoxTo.Location = new Point(162, 14);
            comboBoxTo.Margin = new Padding(4, 3, 4, 3);
            comboBoxTo.Name = "comboBoxTo";
            comboBoxTo.Size = new Size(140, 23);
            comboBoxTo.TabIndex = 1;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(14, 45);
            textBoxAmount.Margin = new Padding(4, 3, 4, 3);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(140, 23);
            textBoxAmount.TabIndex = 2;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(162, 45);
            btnConvert.Margin = new Padding(4, 3, 4, 3);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(88, 27);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "Конвертация";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.BackColor = Color.WhiteSmoke;
            labelResult.BorderStyle = BorderStyle.Fixed3D;
            labelResult.Location = new Point(14, 81);
            labelResult.Margin = new Padding(4, 0, 4, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(65, 17);
            labelResult.TabIndex = 3;
            labelResult.Text = "Результат:";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = WinFormsApp6.Properties.Resources.wise;
            ClientSize = new Size(331, 117);
            Controls.Add(labelResult);
            Controls.Add(btnConvert);
            Controls.Add(textBoxAmount);
            Controls.Add(comboBoxTo);
            Controls.Add(comboBoxFrom);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Конвертер валютни";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label labelResult;
        private ImageList imageList1;
    }
}
