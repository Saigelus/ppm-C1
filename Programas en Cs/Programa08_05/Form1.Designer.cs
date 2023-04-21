namespace Programa08_05
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
            menuStrip1 = new MenuStrip();
            ventanaToolStripMenuItem = new ToolStripMenuItem();
            adicionarVentana1ToolStripMenuItem = new ToolStripMenuItem();
            adicionarVentana2ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ventanaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(595, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ventanaToolStripMenuItem
            // 
            ventanaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarVentana1ToolStripMenuItem, adicionarVentana2ToolStripMenuItem });
            ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            ventanaToolStripMenuItem.Size = new Size(76, 24);
            ventanaToolStripMenuItem.Text = "Ventana";
            // 
            // adicionarVentana1ToolStripMenuItem
            // 
            adicionarVentana1ToolStripMenuItem.Name = "adicionarVentana1ToolStripMenuItem";
            adicionarVentana1ToolStripMenuItem.Size = new Size(224, 26);
            adicionarVentana1ToolStripMenuItem.Text = "Adicionar Ventana1";
            adicionarVentana1ToolStripMenuItem.Click += adicionarVentana1ToolStripMenuItem_Click;
            // 
            // adicionarVentana2ToolStripMenuItem
            // 
            adicionarVentana2ToolStripMenuItem.Name = "adicionarVentana2ToolStripMenuItem";
            adicionarVentana2ToolStripMenuItem.Size = new Size(224, 26);
            adicionarVentana2ToolStripMenuItem.Text = "Adicionar Ventana2";
            adicionarVentana2ToolStripMenuItem.Click += adicionarVentana2ToolStripMenuItem_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(595, 317);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ventanaToolStripMenuItem;
        private ToolStripMenuItem adicionarVentana1ToolStripMenuItem;
        private ToolStripMenuItem adicionarVentana2ToolStripMenuItem;
    }
}