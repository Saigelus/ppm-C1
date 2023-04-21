namespace Programa10_01
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
            btnUno = new Button();
            btnDos = new Button();
            btnTres = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // btnUno
            // 
            btnUno.Location = new Point(32, 33);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(94, 29);
            btnUno.TabIndex = 0;
            btnUno.Text = "Uno";
            btnUno.UseVisualStyleBackColor = true;
            btnUno.Click += btnUno_Click;
            // 
            // btnDos
            // 
            btnDos.Location = new Point(132, 33);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(94, 29);
            btnDos.TabIndex = 1;
            btnDos.Text = "Dos";
            btnDos.UseVisualStyleBackColor = true;
            btnDos.Click += btnUno_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(232, 33);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(94, 29);
            btnTres.TabIndex = 2;
            btnTres.Text = "Tres";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnUno_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(16, 178);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(50, 20);
            lblMensaje.TabIndex = 3;
            lblMensaje.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 381);
            Controls.Add(lblMensaje);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnUno);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUno;
        private Button btnDos;
        private Button btnTres;
        private Label lblMensaje;
    }
}