namespace Programa10_03
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
            lblArchivo = new Label();
            txtContenido = new TextBox();
            SuspendLayout();
            // 
            // lblArchivo
            // 
            lblArchivo.AutoSize = true;
            lblArchivo.Location = new Point(12, 29);
            lblArchivo.Name = "lblArchivo";
            lblArchivo.Size = new Size(50, 20);
            lblArchivo.TabIndex = 0;
            lblArchivo.Text = "label1";
            // 
            // txtContenido
            // 
            txtContenido.AllowDrop = true;
            txtContenido.Location = new Point(12, 96);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.ScrollBars = ScrollBars.Both;
            txtContenido.Size = new Size(430, 289);
            txtContenido.TabIndex = 1;
            txtContenido.DragDrop += txtContenido_DragDrop;
            txtContenido.DragEnter += txtContenido_DragEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 396);
            Controls.Add(txtContenido);
            Controls.Add(lblArchivo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblArchivo;
        private TextBox txtContenido;
    }
}