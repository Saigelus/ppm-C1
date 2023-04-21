namespace Programa09_01
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
            btnInvalidate = new Button();
            btnDibuja = new Button();
            SuspendLayout();
            // 
            // btnInvalidate
            // 
            btnInvalidate.Location = new Point(694, 12);
            btnInvalidate.Name = "btnInvalidate";
            btnInvalidate.Size = new Size(94, 29);
            btnInvalidate.TabIndex = 0;
            btnInvalidate.Text = "Invalidate";
            btnInvalidate.UseVisualStyleBackColor = true;
            btnInvalidate.Click += btnInvalidate_Click;
            // 
            // btnDibuja
            // 
            btnDibuja.Location = new Point(694, 47);
            btnDibuja.Name = "btnDibuja";
            btnDibuja.Size = new Size(94, 29);
            btnDibuja.TabIndex = 1;
            btnDibuja.Text = "Dibuja";
            btnDibuja.UseVisualStyleBackColor = true;
            btnDibuja.Click += btnDibuja_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDibuja);
            Controls.Add(btnInvalidate);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            ResumeLayout(false);
        }

        #endregion

        private Button btnInvalidate;
        private Button btnDibuja;
    }
}