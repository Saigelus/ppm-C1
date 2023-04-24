namespace Programa10_06
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
            txtUno = new TextBox();
            txtDos = new TextBox();
            pictureBox1 = new PictureBox();
            rtbuno = new RichTextBox();
            menuStrip1 = new MenuStrip();
            ediciónToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            pegarToolStripMenuItem = new ToolStripMenuItem();
            limpiarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUno
            // 
            txtUno.Location = new Point(7, 54);
            txtUno.Multiline = true;
            txtUno.Name = "txtUno";
            txtUno.Size = new Size(174, 158);
            txtUno.TabIndex = 0;
            // 
            // txtDos
            // 
            txtDos.Location = new Point(236, 12);
            txtDos.Multiline = true;
            txtDos.Name = "txtDos";
            txtDos.Size = new Size(200, 200);
            txtDos.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(505, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // rtbuno
            // 
            rtbuno.Location = new Point(7, 295);
            rtbuno.Name = "rtbuno";
            rtbuno.Size = new Size(200, 200);
            rtbuno.TabIndex = 3;
            rtbuno.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ediciónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // ediciónToolStripMenuItem
            // 
            ediciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copiarToolStripMenuItem, pegarToolStripMenuItem, limpiarToolStripMenuItem });
            ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            ediciónToolStripMenuItem.Size = new Size(72, 24);
            ediciónToolStripMenuItem.Text = "Edición";
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(224, 26);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.Click += copiarToolStripMenuItem_Click;
            // 
            // pegarToolStripMenuItem
            // 
            pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            pegarToolStripMenuItem.Size = new Size(224, 26);
            pegarToolStripMenuItem.Text = "Pegar";
            pegarToolStripMenuItem.Click += pegarToolStripMenuItem_Click;
            // 
            // limpiarToolStripMenuItem
            // 
            limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            limpiarToolStripMenuItem.Size = new Size(224, 26);
            limpiarToolStripMenuItem.Text = "Limpiar";
            limpiarToolStripMenuItem.Click += limpiarToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbuno);
            Controls.Add(pictureBox1);
            Controls.Add(txtDos);
            Controls.Add(txtUno);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUno;
        private TextBox txtDos;
        private PictureBox pictureBox1;
        private RichTextBox rtbuno;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ediciónToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem pegarToolStripMenuItem;
        private ToolStripMenuItem limpiarToolStripMenuItem;
    }
}