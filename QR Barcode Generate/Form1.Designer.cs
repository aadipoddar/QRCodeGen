
namespace QR_Barcode_Generate
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
            this.outputPictureBox = new System.Windows.Forms.PictureBox();
            this.barcodeButton = new System.Windows.Forms.Button();
            this.barcodeLabel = new System.Windows.Forms.Label();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.qrCodeTextBox = new System.Windows.Forms.TextBox();
            this.qrCodeLabel = new System.Windows.Forms.Label();
            this.qrCodeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // outputPictureBox
            // 
            this.outputPictureBox.Location = new System.Drawing.Point(12, 12);
            this.outputPictureBox.Name = "outputPictureBox";
            this.outputPictureBox.Size = new System.Drawing.Size(776, 234);
            this.outputPictureBox.TabIndex = 0;
            this.outputPictureBox.TabStop = false;
            // 
            // barcodeButton
            // 
            this.barcodeButton.Location = new System.Drawing.Point(657, 280);
            this.barcodeButton.Name = "barcodeButton";
            this.barcodeButton.Size = new System.Drawing.Size(131, 23);
            this.barcodeButton.TabIndex = 1;
            this.barcodeButton.Text = "Barcode";
            this.barcodeButton.UseVisualStyleBackColor = true;
            this.barcodeButton.Click += new System.EventHandler(this.barcodeButton_Click);
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.AutoSize = true;
            this.barcodeLabel.Location = new System.Drawing.Point(12, 285);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(50, 15);
            this.barcodeLabel.TabIndex = 2;
            this.barcodeLabel.Text = "Barcode";
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.Location = new System.Drawing.Point(77, 281);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(574, 23);
            this.barcodeTextBox.TabIndex = 3;
            this.barcodeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcodeTextBox_KeyDown);
            // 
            // qrCodeTextBox
            // 
            this.qrCodeTextBox.Location = new System.Drawing.Point(77, 327);
            this.qrCodeTextBox.Name = "qrCodeTextBox";
            this.qrCodeTextBox.Size = new System.Drawing.Size(574, 23);
            this.qrCodeTextBox.TabIndex = 6;
            this.qrCodeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.qrCodeTextBox_KeyDown);
            // 
            // qrCodeLabel
            // 
            this.qrCodeLabel.AutoSize = true;
            this.qrCodeLabel.Location = new System.Drawing.Point(12, 331);
            this.qrCodeLabel.Name = "qrCodeLabel";
            this.qrCodeLabel.Size = new System.Drawing.Size(54, 15);
            this.qrCodeLabel.TabIndex = 5;
            this.qrCodeLabel.Text = "QR Code";
            // 
            // qrCodeButton
            // 
            this.qrCodeButton.Location = new System.Drawing.Point(657, 326);
            this.qrCodeButton.Name = "qrCodeButton";
            this.qrCodeButton.Size = new System.Drawing.Size(131, 23);
            this.qrCodeButton.TabIndex = 4;
            this.qrCodeButton.Text = "QR Code";
            this.qrCodeButton.UseVisualStyleBackColor = true;
            this.qrCodeButton.Click += new System.EventHandler(this.qrCodeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.qrCodeTextBox);
            this.Controls.Add(this.qrCodeLabel);
            this.Controls.Add(this.qrCodeButton);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(this.barcodeLabel);
            this.Controls.Add(this.barcodeButton);
            this.Controls.Add(this.outputPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox outputPictureBox;
        private System.Windows.Forms.Button barcodeButton;
        private System.Windows.Forms.Label barcodeLabel;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.TextBox qrCodeTextBox;
        private System.Windows.Forms.Label qrCodeLabel;
        private System.Windows.Forms.Button qrCodeButton;
    }
}

