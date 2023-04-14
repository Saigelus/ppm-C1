namespace Programa_03_01
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            operacionesToolStripMenuItem = new ToolStripMenuItem();
            sumaToolStripMenuItem = new ToolStripMenuItem();
            restaToolStripMenuItem = new ToolStripMenuItem();
            multiToolStripMenuItem = new ToolStripMenuItem();
            diviToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            habilitarToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            txtA = new TextBox();
            cmnuTxtA = new ContextMenuStrip(components);
            borrarToolStripMenuItem = new ToolStripMenuItem();
            aleatorioToolStripMenuItem = new ToolStripMenuItem();
            txtB = new TextBox();
            lblResultado = new Label();
            tstOperaciones = new ToolStrip();
            tstbSuma = new ToolStripButton();
            tsbResta = new ToolStripButton();
            tsbMulti = new ToolStripButton();
            tsbDiv = new ToolStripButton();
            stsInformación = new StatusStrip();
            menuStrip1.SuspendLayout();
            cmnuTxtA.SuspendLayout();
            tstOperaciones.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, operacionesToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(345, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.AutoToolTip = true;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(121, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.ToolTipText = "Quitar la aplicación";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // operacionesToolStripMenuItem
            // 
            operacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sumaToolStripMenuItem, restaToolStripMenuItem, multiToolStripMenuItem, diviToolStripMenuItem, toolStripSeparator1, habilitarToolStripMenuItem });
            operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            operacionesToolStripMenuItem.Size = new Size(106, 24);
            operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // sumaToolStripMenuItem
            // 
            sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            sumaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            sumaToolStripMenuItem.Size = new Size(179, 26);
            sumaToolStripMenuItem.Text = "Suma";
            sumaToolStripMenuItem.Click += sumaToolStripMenuItem_Click;
            // 
            // restaToolStripMenuItem
            // 
            restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            restaToolStripMenuItem.Size = new Size(179, 26);
            restaToolStripMenuItem.Text = "Resta";
            restaToolStripMenuItem.Click += restaToolStripMenuItem_Click;
            // 
            // multiToolStripMenuItem
            // 
            multiToolStripMenuItem.Name = "multiToolStripMenuItem";
            multiToolStripMenuItem.Size = new Size(179, 26);
            multiToolStripMenuItem.Text = "Multi";
            multiToolStripMenuItem.Click += multiToolStripMenuItem_Click;
            // 
            // diviToolStripMenuItem
            // 
            diviToolStripMenuItem.Name = "diviToolStripMenuItem";
            diviToolStripMenuItem.Size = new Size(179, 26);
            diviToolStripMenuItem.Text = "Divi";
            diviToolStripMenuItem.Click += diviToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(176, 6);
            // 
            // habilitarToolStripMenuItem
            // 
            habilitarToolStripMenuItem.Checked = true;
            habilitarToolStripMenuItem.CheckOnClick = true;
            habilitarToolStripMenuItem.CheckState = CheckState.Checked;
            habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            habilitarToolStripMenuItem.Size = new Size(179, 26);
            habilitarToolStripMenuItem.Text = "Habilitar";
            habilitarToolStripMenuItem.CheckedChanged += habilitarToolStripMenuItem_CheckedChanged;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(65, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(158, 26);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // txtA
            // 
            txtA.ContextMenuStrip = cmnuTxtA;
            txtA.Location = new Point(27, 72);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 1;
            txtA.TextAlign = HorizontalAlignment.Right;
            // 
            // cmnuTxtA
            // 
            cmnuTxtA.ImageScalingSize = new Size(20, 20);
            cmnuTxtA.Items.AddRange(new ToolStripItem[] { borrarToolStripMenuItem, aleatorioToolStripMenuItem });
            cmnuTxtA.Name = "cmnuTxtA";
            cmnuTxtA.Size = new Size(141, 52);
            // 
            // borrarToolStripMenuItem
            // 
            borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            borrarToolStripMenuItem.Size = new Size(140, 24);
            borrarToolStripMenuItem.Text = "Borrar";
            borrarToolStripMenuItem.Click += borrarToolStripMenuItem_Click;
            // 
            // aleatorioToolStripMenuItem
            // 
            aleatorioToolStripMenuItem.Name = "aleatorioToolStripMenuItem";
            aleatorioToolStripMenuItem.Size = new Size(140, 24);
            aleatorioToolStripMenuItem.Text = "Aleatorio";
            aleatorioToolStripMenuItem.Click += aleatorioToolStripMenuItem_Click;
            // 
            // txtB
            // 
            txtB.Location = new Point(27, 132);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 2;
            txtB.TextAlign = HorizontalAlignment.Right;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(189, 75);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(50, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "label1";
            // 
            // tstOperaciones
            // 
            tstOperaciones.ImageScalingSize = new Size(20, 20);
            tstOperaciones.Items.AddRange(new ToolStripItem[] { tstbSuma, tsbResta, tsbMulti, tsbDiv });
            tstOperaciones.Location = new Point(0, 28);
            tstOperaciones.Name = "tstOperaciones";
            tstOperaciones.Size = new Size(345, 27);
            tstOperaciones.TabIndex = 4;
            tstOperaciones.Text = "toolStrip1";
            // 
            // tstbSuma
            // 
            tstbSuma.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tstbSuma.Image = (Image)resources.GetObject("tstbSuma.Image");
            tstbSuma.ImageTransparentColor = Color.Magenta;
            tstbSuma.Name = "tstbSuma";
            tstbSuma.Size = new Size(29, 24);
            tstbSuma.Text = "Suma";
            tstbSuma.Click += sumaToolStripMenuItem_Click;
            // 
            // tsbResta
            // 
            tsbResta.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbResta.Image = (Image)resources.GetObject("tsbResta.Image");
            tsbResta.ImageTransparentColor = Color.Magenta;
            tsbResta.Name = "tsbResta";
            tsbResta.Size = new Size(29, 24);
            tsbResta.Text = "Resta";
            tsbResta.Click += restaToolStripMenuItem_Click;
            // 
            // tsbMulti
            // 
            tsbMulti.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbMulti.Image = (Image)resources.GetObject("tsbMulti.Image");
            tsbMulti.ImageTransparentColor = Color.Magenta;
            tsbMulti.Name = "tsbMulti";
            tsbMulti.Size = new Size(29, 24);
            tsbMulti.Text = "Multiplicación";
            tsbMulti.Click += multiToolStripMenuItem_Click;
            // 
            // tsbDiv
            // 
            tsbDiv.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbDiv.Image = (Image)resources.GetObject("tsbDiv.Image");
            tsbDiv.ImageTransparentColor = Color.Magenta;
            tsbDiv.Name = "tsbDiv";
            tsbDiv.Size = new Size(29, 24);
            tsbDiv.Text = "División";
            tsbDiv.Click += diviToolStripMenuItem_Click;
            // 
            // stsInformación
            // 
            stsInformación.ImageScalingSize = new Size(20, 20);
            stsInformación.Location = new Point(0, 247);
            stsInformación.Name = "stsInformación";
            stsInformación.Size = new Size(345, 22);
            stsInformación.TabIndex = 5;
            stsInformación.Text = "statusStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 269);
            Controls.Add(stsInformación);
            Controls.Add(tstOperaciones);
            Controls.Add(lblResultado);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            cmnuTxtA.ResumeLayout(false);
            tstOperaciones.ResumeLayout(false);
            tstOperaciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem operacionesToolStripMenuItem;
        private ToolStripMenuItem sumaToolStripMenuItem;
        private ToolStripMenuItem restaToolStripMenuItem;
        private ToolStripMenuItem multiToolStripMenuItem;
        private ToolStripMenuItem diviToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private TextBox txtA;
        private TextBox txtB;
        private Label lblResultado;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem habilitarToolStripMenuItem;
        private ContextMenuStrip cmnuTxtA;
        private ToolStripMenuItem borrarToolStripMenuItem;
        private ToolStripMenuItem aleatorioToolStripMenuItem;
        private ToolStrip tstOperaciones;
        private ToolStripButton tstbSuma;
        private ToolStripButton tsbResta;
        private ToolStripButton tsbMulti;
        private ToolStripButton tsbDiv;
        private StatusStrip stsInformación;
    }
}