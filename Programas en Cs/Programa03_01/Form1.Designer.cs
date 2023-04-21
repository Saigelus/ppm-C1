namespace Programa03_01
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
            txtA = new TextBox();
            cmnuTxtA = new ContextMenuStrip(components);
            borrarToolStripMenuItem = new ToolStripMenuItem();
            aleatorioToolStripMenuItem = new ToolStripMenuItem();
            txtB = new TextBox();
            lblResultado = new Label();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            operacionesToolStripMenuItem = new ToolStripMenuItem();
            sumaToolStripMenuItem = new ToolStripMenuItem();
            restaToolStripMenuItem = new ToolStripMenuItem();
            multiToolStripMenuItem = new ToolStripMenuItem();
            divToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            habilitarToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            tstOperaciones = new ToolStrip();
            tstBSuma = new ToolStripButton();
            tstBResta = new ToolStripButton();
            tstBMulti = new ToolStripButton();
            tstBDiv = new ToolStripButton();
            stsInformacion = new StatusStrip();
            slblValores = new ToolStripStatusLabel();
            slblOperaciones = new ToolStripStatusLabel();
            slblResultado = new ToolStripStatusLabel();
            cmnuTxtA.SuspendLayout();
            menuStrip2.SuspendLayout();
            tstOperaciones.SuspendLayout();
            stsInformacion.SuspendLayout();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.ContextMenuStrip = cmnuTxtA;
            txtA.Location = new Point(28, 58);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 0;
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
            txtB.Location = new Point(28, 95);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 1;
            txtB.TextAlign = HorizontalAlignment.Right;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(226, 61);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(50, 20);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "label1";
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
            operacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sumaToolStripMenuItem, restaToolStripMenuItem, multiToolStripMenuItem, divToolStripMenuItem, toolStripSeparator1, habilitarToolStripMenuItem });
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
            // divToolStripMenuItem
            // 
            divToolStripMenuItem.Name = "divToolStripMenuItem";
            divToolStripMenuItem.Size = new Size(179, 26);
            divToolStripMenuItem.Text = "Div";
            divToolStripMenuItem.Click += divToolStripMenuItem_Click;
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
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 24);
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, operacionesToolStripMenuItem, ayudaToolStripMenuItem, toolStripMenuItem1 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(383, 28);
            menuStrip2.TabIndex = 4;
            menuStrip2.Text = "menuStrip2";
            // 
            // tstOperaciones
            // 
            tstOperaciones.ImageScalingSize = new Size(20, 20);
            tstOperaciones.Items.AddRange(new ToolStripItem[] { tstBSuma, tstBResta, tstBMulti, tstBDiv });
            tstOperaciones.Location = new Point(0, 28);
            tstOperaciones.Name = "tstOperaciones";
            tstOperaciones.Size = new Size(383, 27);
            tstOperaciones.TabIndex = 5;
            tstOperaciones.Text = "toolStrip1";
            // 
            // tstBSuma
            // 
            tstBSuma.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tstBSuma.Image = (Image)resources.GetObject("tstBSuma.Image");
            tstBSuma.ImageTransparentColor = Color.Magenta;
            tstBSuma.Name = "tstBSuma";
            tstBSuma.Size = new Size(29, 24);
            tstBSuma.Text = "Suma";
            tstBSuma.Click += sumaToolStripMenuItem_Click;
            // 
            // tstBResta
            // 
            tstBResta.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tstBResta.Image = (Image)resources.GetObject("tstBResta.Image");
            tstBResta.ImageTransparentColor = Color.Magenta;
            tstBResta.Name = "tstBResta";
            tstBResta.Size = new Size(29, 24);
            tstBResta.Text = "Resta";
            tstBResta.Click += restaToolStripMenuItem_Click;
            // 
            // tstBMulti
            // 
            tstBMulti.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tstBMulti.Image = (Image)resources.GetObject("tstBMulti.Image");
            tstBMulti.ImageTransparentColor = Color.Magenta;
            tstBMulti.Name = "tstBMulti";
            tstBMulti.Size = new Size(29, 24);
            tstBMulti.Text = "Multiplicación";
            tstBMulti.Click += multiToolStripMenuItem_Click;
            // 
            // tstBDiv
            // 
            tstBDiv.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tstBDiv.Image = (Image)resources.GetObject("tstBDiv.Image");
            tstBDiv.ImageTransparentColor = Color.Magenta;
            tstBDiv.Name = "tstBDiv";
            tstBDiv.Size = new Size(29, 24);
            tstBDiv.Text = "División";
            tstBDiv.Click += divToolStripMenuItem_Click;
            // 
            // stsInformacion
            // 
            stsInformacion.ImageScalingSize = new Size(20, 20);
            stsInformacion.Items.AddRange(new ToolStripItem[] { slblValores, slblOperaciones, slblResultado });
            stsInformacion.Location = new Point(0, 287);
            stsInformacion.Name = "stsInformacion";
            stsInformacion.Size = new Size(383, 30);
            stsInformacion.TabIndex = 6;
            stsInformacion.Text = "statusStrip1";
            // 
            // slblValores
            // 
            slblValores.AutoSize = false;
            slblValores.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            slblValores.BorderStyle = Border3DStyle.SunkenInner;
            slblValores.Name = "slblValores";
            slblValores.Size = new Size(100, 24);
            slblValores.Text = "A=0; B=0";
            // 
            // slblOperaciones
            // 
            slblOperaciones.AutoSize = false;
            slblOperaciones.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            slblOperaciones.BorderStyle = Border3DStyle.Bump;
            slblOperaciones.Name = "slblOperaciones";
            slblOperaciones.Size = new Size(110, 24);
            slblOperaciones.Text = "Sin seleccionar";
            // 
            // slblResultado
            // 
            slblResultado.AutoSize = false;
            slblResultado.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            slblResultado.BorderStyle = Border3DStyle.RaisedInner;
            slblResultado.Name = "slblResultado";
            slblResultado.Size = new Size(60, 24);
            slblResultado.Text = "R = 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 317);
            Controls.Add(stsInformacion);
            Controls.Add(tstOperaciones);
            Controls.Add(lblResultado);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(menuStrip2);
            Name = "Form1";
            Text = "Form1";
            cmnuTxtA.ResumeLayout(false);
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            tstOperaciones.ResumeLayout(false);
            tstOperaciones.PerformLayout();
            stsInformacion.ResumeLayout(false);
            stsInformacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private Label lblResultado;
        private ContextMenuStrip cmnuTxtA;
        private ToolStripMenuItem borrarToolStripMenuItem;
        private ToolStripMenuItem aleatorioToolStripMenuItem;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem operacionesToolStripMenuItem;
        private ToolStripMenuItem sumaToolStripMenuItem;
        private ToolStripMenuItem restaToolStripMenuItem;
        private ToolStripMenuItem multiToolStripMenuItem;
        private ToolStripMenuItem divToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem habilitarToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private MenuStrip menuStrip2;
        private ToolStrip tstOperaciones;
        private ToolStripButton tstBSuma;
        private ToolStripButton tstBResta;
        private ToolStripButton tstBMulti;
        private ToolStripButton tstBDiv;
        private StatusStrip stsInformacion;
        private ToolStripStatusLabel slblValores;
        private ToolStripStatusLabel slblOperaciones;
        private ToolStripStatusLabel slblResultado;
    }
}