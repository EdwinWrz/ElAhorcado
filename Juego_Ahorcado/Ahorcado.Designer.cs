namespace Juego_Ahorcado
{
    partial class Ahorcado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ahorcado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tWin = new System.Windows.Forms.TextBox();
            this.tEquivocaciones = new System.Windows.Forms.TextBox();
            this.tAciertos = new System.Windows.Forms.TextBox();
            this.tJuegosTotal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.p10 = new System.Windows.Forms.PictureBox();
            this.p0 = new System.Windows.Forms.PictureBox();
            this.bIntentar = new System.Windows.Forms.Button();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.tIntento = new System.Windows.Forms.TextBox();
            this.p6 = new System.Windows.Forms.PictureBox();
            this.p9 = new System.Windows.Forms.PictureBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.p5 = new System.Windows.Forms.PictureBox();
            this.p8 = new System.Windows.Forms.PictureBox();
            this.p7 = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.bSeleccionar = new System.Windows.Forms.Button();
            this.pAhorcado = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAhorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tWin);
            this.panel1.Controls.Add(this.tEquivocaciones);
            this.panel1.Controls.Add(this.tAciertos);
            this.panel1.Controls.Add(this.tJuegosTotal);
            this.panel1.Location = new System.Drawing.Point(9, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 47);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Juegos Ganado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Equivocaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aciertos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intentos";
            // 
            // tWin
            // 
            this.tWin.Enabled = false;
            this.tWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tWin.Location = new System.Drawing.Point(561, 3);
            this.tWin.Name = "tWin";
            this.tWin.Size = new System.Drawing.Size(82, 29);
            this.tWin.TabIndex = 2;
            // 
            // tEquivocaciones
            // 
            this.tEquivocaciones.Enabled = false;
            this.tEquivocaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEquivocaciones.Location = new System.Drawing.Point(375, 3);
            this.tEquivocaciones.Name = "tEquivocaciones";
            this.tEquivocaciones.Size = new System.Drawing.Size(82, 29);
            this.tEquivocaciones.TabIndex = 2;
            // 
            // tAciertos
            // 
            this.tAciertos.Enabled = false;
            this.tAciertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAciertos.Location = new System.Drawing.Point(194, 3);
            this.tAciertos.Name = "tAciertos";
            this.tAciertos.Size = new System.Drawing.Size(82, 29);
            this.tAciertos.TabIndex = 2;
            // 
            // tJuegosTotal
            // 
            this.tJuegosTotal.Enabled = false;
            this.tJuegosTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tJuegosTotal.Location = new System.Drawing.Point(55, 5);
            this.tJuegosTotal.Name = "tJuegosTotal";
            this.tJuegosTotal.Size = new System.Drawing.Size(82, 29);
            this.tJuegosTotal.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.p10);
            this.groupBox1.Controls.Add(this.p0);
            this.groupBox1.Controls.Add(this.bIntentar);
            this.groupBox1.Controls.Add(this.p2);
            this.groupBox1.Controls.Add(this.tIntento);
            this.groupBox1.Controls.Add(this.p6);
            this.groupBox1.Controls.Add(this.p9);
            this.groupBox1.Controls.Add(this.p4);
            this.groupBox1.Controls.Add(this.p5);
            this.groupBox1.Controls.Add(this.p8);
            this.groupBox1.Controls.Add(this.p7);
            this.groupBox1.Controls.Add(this.p1);
            this.groupBox1.Controls.Add(this.p3);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.groupBox1.Location = new System.Drawing.Point(3, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 173);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ahorcado";
            // 
            // p10
            // 
            this.p10.Image = ((System.Drawing.Image)(resources.GetObject("p10.Image")));
            this.p10.Location = new System.Drawing.Point(631, 19);
            this.p10.Name = "p10";
            this.p10.Size = new System.Drawing.Size(58, 48);
            this.p10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p10.TabIndex = 4;
            this.p10.TabStop = false;
            this.p10.Visible = false;
            // 
            // p0
            // 
            this.p0.Image = ((System.Drawing.Image)(resources.GetObject("p0.Image")));
            this.p0.Location = new System.Drawing.Point(6, 19);
            this.p0.Name = "p0";
            this.p0.Size = new System.Drawing.Size(55, 48);
            this.p0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p0.TabIndex = 1;
            this.p0.TabStop = false;
            this.p0.Visible = false;
            // 
            // bIntentar
            // 
            this.bIntentar.Enabled = false;
            this.bIntentar.Location = new System.Drawing.Point(6, 118);
            this.bIntentar.Name = "bIntentar";
            this.bIntentar.Size = new System.Drawing.Size(100, 40);
            this.bIntentar.TabIndex = 3;
            this.bIntentar.Text = "Intentar";
            this.bIntentar.UseVisualStyleBackColor = true;
            this.bIntentar.Click += new System.EventHandler(this.bIntentar_Click);
            // 
            // p2
            // 
            this.p2.Image = ((System.Drawing.Image)(resources.GetObject("p2.Image")));
            this.p2.Location = new System.Drawing.Point(131, 19);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(55, 48);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 1;
            this.p2.TabStop = false;
            this.p2.Visible = false;
            // 
            // tIntento
            // 
            this.tIntento.Enabled = false;
            this.tIntento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tIntento.Location = new System.Drawing.Point(6, 83);
            this.tIntento.MaxLength = 1;
            this.tIntento.Name = "tIntento";
            this.tIntento.Size = new System.Drawing.Size(100, 29);
            this.tIntento.TabIndex = 2;
            this.tIntento.TextChanged += new System.EventHandler(this.tIntento_TextChanged);
            this.tIntento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tIntento_KeyDown);
            // 
            // p6
            // 
            this.p6.Image = ((System.Drawing.Image)(resources.GetObject("p6.Image")));
            this.p6.Location = new System.Drawing.Point(381, 19);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(55, 48);
            this.p6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p6.TabIndex = 1;
            this.p6.TabStop = false;
            this.p6.Visible = false;
            // 
            // p9
            // 
            this.p9.Image = ((System.Drawing.Image)(resources.GetObject("p9.Image")));
            this.p9.Location = new System.Drawing.Point(567, 19);
            this.p9.Name = "p9";
            this.p9.Size = new System.Drawing.Size(58, 48);
            this.p9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p9.TabIndex = 1;
            this.p9.TabStop = false;
            this.p9.Visible = false;
            // 
            // p4
            // 
            this.p4.Image = ((System.Drawing.Image)(resources.GetObject("p4.Image")));
            this.p4.Location = new System.Drawing.Point(256, 19);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(55, 48);
            this.p4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p4.TabIndex = 1;
            this.p4.TabStop = false;
            this.p4.Visible = false;
            // 
            // p5
            // 
            this.p5.Image = ((System.Drawing.Image)(resources.GetObject("p5.Image")));
            this.p5.Location = new System.Drawing.Point(317, 19);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(58, 48);
            this.p5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p5.TabIndex = 1;
            this.p5.TabStop = false;
            this.p5.Visible = false;
            // 
            // p8
            // 
            this.p8.Image = ((System.Drawing.Image)(resources.GetObject("p8.Image")));
            this.p8.Location = new System.Drawing.Point(506, 19);
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(55, 48);
            this.p8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p8.TabIndex = 1;
            this.p8.TabStop = false;
            this.p8.Visible = false;
            // 
            // p7
            // 
            this.p7.Image = ((System.Drawing.Image)(resources.GetObject("p7.Image")));
            this.p7.Location = new System.Drawing.Point(442, 19);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(58, 48);
            this.p7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p7.TabIndex = 1;
            this.p7.TabStop = false;
            this.p7.Visible = false;
            // 
            // p1
            // 
            this.p1.Image = ((System.Drawing.Image)(resources.GetObject("p1.Image")));
            this.p1.Location = new System.Drawing.Point(67, 19);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(58, 48);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 1;
            this.p1.TabStop = false;
            this.p1.Visible = false;
            this.p1.Click += new System.EventHandler(this.p1_Click);
            // 
            // p3
            // 
            this.p3.Image = ((System.Drawing.Image)(resources.GetObject("p3.Image")));
            this.p3.Location = new System.Drawing.Point(192, 19);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(58, 48);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p3.TabIndex = 1;
            this.p3.TabStop = false;
            this.p3.Visible = false;
            // 
            // bSeleccionar
            // 
            this.bSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.bSeleccionar.Location = new System.Drawing.Point(3, 12);
            this.bSeleccionar.Name = "bSeleccionar";
            this.bSeleccionar.Size = new System.Drawing.Size(91, 33);
            this.bSeleccionar.TabIndex = 7;
            this.bSeleccionar.Text = "Seleccionar";
            this.bSeleccionar.UseVisualStyleBackColor = false;
            this.bSeleccionar.Click += new System.EventHandler(this.bSeleccionar_Click);
            // 
            // pAhorcado
            // 
            this.pAhorcado.BackColor = System.Drawing.Color.Transparent;
            this.pAhorcado.ErrorImage = null;
            this.pAhorcado.Location = new System.Drawing.Point(705, 71);
            this.pAhorcado.Name = "pAhorcado";
            this.pAhorcado.Size = new System.Drawing.Size(210, 205);
            this.pAhorcado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAhorcado.TabIndex = 10;
            this.pAhorcado.TabStop = false;
            // 
            // Ahorcado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(927, 292);
            this.Controls.Add(this.pAhorcado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bSeleccionar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ahorcado";
            this.Text = "Ahorcado";
            this.Load += new System.EventHandler(this.Ahorcado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAhorcado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tWin;
        private System.Windows.Forms.TextBox tEquivocaciones;
        private System.Windows.Forms.TextBox tAciertos;
        private System.Windows.Forms.TextBox tJuegosTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox p0;
        private System.Windows.Forms.Button bIntentar;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.TextBox tIntento;
        private System.Windows.Forms.PictureBox p6;
        private System.Windows.Forms.PictureBox p9;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.PictureBox p5;
        private System.Windows.Forms.PictureBox p8;
        private System.Windows.Forms.PictureBox p7;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.Button bSeleccionar;
        private System.Windows.Forms.PictureBox p10;
        private System.Windows.Forms.PictureBox pAhorcado;
    }
}