namespace RiddleProgram
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
            btnGenerate = new Button();
            btnVerify = new Button();
            txtNumMin = new TextBox();
            txtNumMax = new TextBox();
            txtRiddle = new TextBox();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(229, 264);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(94, 29);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnVerify
            // 
            btnVerify.Location = new Point(374, 264);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(94, 29);
            btnVerify.TabIndex = 1;
            btnVerify.Text = "Verify";
            btnVerify.UseVisualStyleBackColor = true;
            btnVerify.Click += btnVerify_Click;
            // 
            // txtNumMin
            // 
            txtNumMin.Location = new Point(294, 127);
            txtNumMin.Name = "txtNumMin";
            txtNumMin.Size = new Size(125, 27);
            txtNumMin.TabIndex = 2;
            txtNumMin.TextChanged += textBox1_TextChanged;
            // 
            // txtNumMax
            // 
            txtNumMax.Location = new Point(294, 169);
            txtNumMax.Name = "txtNumMax";
            txtNumMax.Size = new Size(125, 27);
            txtNumMax.TabIndex = 3;
            // 
            // txtRiddle
            // 
            txtRiddle.Location = new Point(294, 209);
            txtRiddle.Name = "txtRiddle";
            txtRiddle.Size = new Size(125, 27);
            txtRiddle.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRiddle);
            Controls.Add(txtNumMax);
            Controls.Add(txtNumMin);
            Controls.Add(btnVerify);
            Controls.Add(btnGenerate);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private Button btnVerify;
        private TextBox txtNumMin;
        private TextBox txtNumMax;
        private TextBox txtRiddle;
    }
}
