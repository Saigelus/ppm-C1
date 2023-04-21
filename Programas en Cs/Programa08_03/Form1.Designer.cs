namespace Programa08_03
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
            label1 = new Label();
            label2 = new Label();
            txtFreq = new TextBox();
            txtDura = new TextBox();
            btnBeep = new Button();
            btnTono = new Button();
            btnTocar = new Button();
            btnSistema = new Button();
            btnCargar = new Button();
            lblRuta = new Label();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 55);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Freq";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 88);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Dura";
            // 
            // txtFreq
            // 
            txtFreq.Location = new Point(163, 52);
            txtFreq.Name = "txtFreq";
            txtFreq.Size = new Size(125, 27);
            txtFreq.TabIndex = 2;
            txtFreq.Text = "3000";
            // 
            // txtDura
            // 
            txtDura.Location = new Point(163, 85);
            txtDura.Name = "txtDura";
            txtDura.Size = new Size(125, 27);
            txtDura.TabIndex = 3;
            txtDura.Text = "200";
            // 
            // btnBeep
            // 
            btnBeep.Location = new Point(409, 12);
            btnBeep.Name = "btnBeep";
            btnBeep.Size = new Size(94, 29);
            btnBeep.TabIndex = 4;
            btnBeep.Text = "Beep";
            btnBeep.UseVisualStyleBackColor = true;
            btnBeep.Click += btnBeep_Click;
            // 
            // btnTono
            // 
            btnTono.Location = new Point(409, 73);
            btnTono.Name = "btnTono";
            btnTono.Size = new Size(94, 29);
            btnTono.TabIndex = 5;
            btnTono.Text = "Todo";
            btnTono.UseVisualStyleBackColor = true;
            // 
            // btnTocar
            // 
            btnTocar.Location = new Point(409, 169);
            btnTocar.Name = "btnTocar";
            btnTocar.Size = new Size(94, 29);
            btnTocar.TabIndex = 7;
            btnTocar.Text = "Tocar";
            btnTocar.UseVisualStyleBackColor = true;
            btnTocar.Click += btnTocar_Click;
            // 
            // btnSistema
            // 
            btnSistema.Location = new Point(409, 108);
            btnSistema.Name = "btnSistema";
            btnSistema.Size = new Size(94, 29);
            btnSistema.TabIndex = 6;
            btnSistema.Text = "Sistema";
            btnSistema.UseVisualStyleBackColor = true;
            btnSistema.Click += btnSistema_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(104, 221);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(94, 29);
            btnCargar.TabIndex = 8;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Location = new Point(68, 308);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(50, 20);
            lblRuta.TabIndex = 9;
            lblRuta.Text = "label3";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "wav|*.wav";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 358);
            Controls.Add(lblRuta);
            Controls.Add(btnCargar);
            Controls.Add(btnTocar);
            Controls.Add(btnSistema);
            Controls.Add(btnTono);
            Controls.Add(btnBeep);
            Controls.Add(txtDura);
            Controls.Add(txtFreq);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFreq;
        private TextBox txtDura;
        private Button btnBeep;
        private Button btnTono;
        private Button btnTocar;
        private Button btnSistema;
        private Button btnCargar;
        private Label lblRuta;
        private OpenFileDialog openFileDialog1;
    }
}