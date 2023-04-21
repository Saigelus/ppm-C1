namespace Programa08_02
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
            txtmensaje = new TextBox();
            rbtManzana = new RadioButton();
            rbtPera = new RadioButton();
            groupBox1 = new GroupBox();
            rbtCiruela = new RadioButton();
            chkImportado = new CheckBox();
            chkOrganico = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtmensaje
            // 
            txtmensaje.Location = new Point(21, 40);
            txtmensaje.Margin = new Padding(3, 4, 3, 4);
            txtmensaje.Name = "txtmensaje";
            txtmensaje.Size = new Size(182, 27);
            txtmensaje.TabIndex = 0;
            // 
            // rbtManzana
            // 
            rbtManzana.AutoSize = true;
            rbtManzana.Checked = true;
            rbtManzana.Location = new Point(7, 47);
            rbtManzana.Margin = new Padding(3, 4, 3, 4);
            rbtManzana.Name = "rbtManzana";
            rbtManzana.Size = new Size(90, 24);
            rbtManzana.TabIndex = 2;
            rbtManzana.TabStop = true;
            rbtManzana.Text = "Manzana";
            rbtManzana.UseVisualStyleBackColor = true;
            // 
            // rbtPera
            // 
            rbtPera.AutoSize = true;
            rbtPera.Location = new Point(7, 112);
            rbtPera.Margin = new Padding(3, 4, 3, 4);
            rbtPera.Name = "rbtPera";
            rbtPera.Size = new Size(58, 24);
            rbtPera.TabIndex = 3;
            rbtPera.Text = "Pera";
            rbtPera.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtCiruela);
            groupBox1.Controls.Add(rbtManzana);
            groupBox1.Controls.Add(rbtPera);
            groupBox1.Location = new Point(14, 104);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(318, 255);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rbtCiruela
            // 
            rbtCiruela.AutoSize = true;
            rbtCiruela.Location = new Point(7, 188);
            rbtCiruela.Margin = new Padding(3, 4, 3, 4);
            rbtCiruela.Name = "rbtCiruela";
            rbtCiruela.Size = new Size(76, 24);
            rbtCiruela.TabIndex = 4;
            rbtCiruela.Text = "Ciruela";
            rbtCiruela.UseVisualStyleBackColor = true;
            // 
            // chkImportado
            // 
            chkImportado.AutoSize = true;
            chkImportado.Location = new Point(390, 131);
            chkImportado.Margin = new Padding(3, 4, 3, 4);
            chkImportado.Name = "chkImportado";
            chkImportado.Size = new Size(102, 24);
            chkImportado.TabIndex = 8;
            chkImportado.Text = "Importado";
            chkImportado.UseVisualStyleBackColor = true;
            // 
            // chkOrganico
            // 
            chkOrganico.AutoSize = true;
            chkOrganico.Location = new Point(390, 217);
            chkOrganico.Margin = new Padding(3, 4, 3, 4);
            chkOrganico.Name = "chkOrganico";
            chkOrganico.Size = new Size(92, 24);
            chkOrganico.TabIndex = 9;
            chkOrganico.Text = "Organico";
            chkOrganico.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 407);
            Controls.Add(chkOrganico);
            Controls.Add(chkImportado);
            Controls.Add(groupBox1);
            Controls.Add(txtmensaje);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtmensaje;
        private RadioButton rbtManzana;
        private RadioButton rbtPera;
        private GroupBox groupBox1;
        private RadioButton rbtCiruela;
        private CheckBox chkImportado;
        private CheckBox chkOrganico;
    }
}