
namespace Funeraria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pboxeconomico = new System.Windows.Forms.PictureBox();
            this.pboxoro = new System.Windows.Forms.PictureBox();
            this.pboxestandar = new System.Windows.Forms.PictureBox();
            this.pboxdiamante = new System.Windows.Forms.PictureBox();
            this.lblnombrefuneraria = new System.Windows.Forms.Label();
            this.btncontinuar = new System.Windows.Forms.Button();
            this.lblplanfunera = new System.Windows.Forms.Label();
            this.lblslogan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxeconomico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxoro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxestandar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxdiamante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxeconomico
            // 
            this.pboxeconomico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxeconomico.BackgroundImage")));
            this.pboxeconomico.Location = new System.Drawing.Point(250, 151);
            this.pboxeconomico.Name = "pboxeconomico";
            this.pboxeconomico.Size = new System.Drawing.Size(353, 196);
            this.pboxeconomico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboxeconomico.TabIndex = 4;
            this.pboxeconomico.TabStop = false;
            this.pboxeconomico.Click += new System.EventHandler(this.pboxeconomico_Click);
            // 
            // pboxoro
            // 
            this.pboxoro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxoro.BackgroundImage")));
            this.pboxoro.Location = new System.Drawing.Point(250, 380);
            this.pboxoro.Name = "pboxoro";
            this.pboxoro.Size = new System.Drawing.Size(353, 182);
            this.pboxoro.TabIndex = 5;
            this.pboxoro.TabStop = false;
            this.pboxoro.Click += new System.EventHandler(this.pboxoro_Click);
            // 
            // pboxestandar
            // 
            this.pboxestandar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxestandar.BackgroundImage")));
            this.pboxestandar.Location = new System.Drawing.Point(687, 151);
            this.pboxestandar.Name = "pboxestandar";
            this.pboxestandar.Size = new System.Drawing.Size(342, 196);
            this.pboxestandar.TabIndex = 6;
            this.pboxestandar.TabStop = false;
            this.pboxestandar.Click += new System.EventHandler(this.pboxestandar_Click);
            // 
            // pboxdiamante
            // 
            this.pboxdiamante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxdiamante.BackgroundImage")));
            this.pboxdiamante.Location = new System.Drawing.Point(687, 380);
            this.pboxdiamante.Name = "pboxdiamante";
            this.pboxdiamante.Size = new System.Drawing.Size(342, 182);
            this.pboxdiamante.TabIndex = 7;
            this.pboxdiamante.TabStop = false;
            this.pboxdiamante.Click += new System.EventHandler(this.pboxdiamante_Click);
            // 
            // lblnombrefuneraria
            // 
            this.lblnombrefuneraria.AutoSize = true;
            this.lblnombrefuneraria.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrefuneraria.Location = new System.Drawing.Point(400, 6);
            this.lblnombrefuneraria.Name = "lblnombrefuneraria";
            this.lblnombrefuneraria.Size = new System.Drawing.Size(492, 41);
            this.lblnombrefuneraria.TabIndex = 8;
            this.lblnombrefuneraria.Text = "Funeraria \"La Última Cita\"";
            // 
            // btncontinuar
            // 
            this.btncontinuar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btncontinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontinuar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncontinuar.Location = new System.Drawing.Point(557, 568);
            this.btncontinuar.Name = "btncontinuar";
            this.btncontinuar.Size = new System.Drawing.Size(201, 48);
            this.btncontinuar.TabIndex = 13;
            this.btncontinuar.Text = "Continuar";
            this.btncontinuar.UseVisualStyleBackColor = false;
            this.btncontinuar.Click += new System.EventHandler(this.btncontinuar_Click);
            // 
            // lblplanfunera
            // 
            this.lblplanfunera.AutoSize = true;
            this.lblplanfunera.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplanfunera.Location = new System.Drawing.Point(524, 117);
            this.lblplanfunera.Name = "lblplanfunera";
            this.lblplanfunera.Size = new System.Drawing.Size(238, 20);
            this.lblplanfunera.TabIndex = 14;
            this.lblplanfunera.Text = "Planes Funerarios Disponibles:";
            this.lblplanfunera.Click += new System.EventHandler(this.lblplanfunera_Click);
            // 
            // lblslogan
            // 
            this.lblslogan.AutoSize = true;
            this.lblslogan.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblslogan.Location = new System.Drawing.Point(319, 54);
            this.lblslogan.Name = "lblslogan";
            this.lblslogan.Size = new System.Drawing.Size(640, 20);
            this.lblslogan.TabIndex = 15;
            this.lblslogan.Text = "\"Ofrecemos consuelo en tiempos difíciles: la última despedida para aquellos que a" +
    "mas.\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-14, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1363, 704);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblslogan);
            this.Controls.Add(this.lblplanfunera);
            this.Controls.Add(this.btncontinuar);
            this.Controls.Add(this.lblnombrefuneraria);
            this.Controls.Add(this.pboxdiamante);
            this.Controls.Add(this.pboxestandar);
            this.Controls.Add(this.pboxoro);
            this.Controls.Add(this.pboxeconomico);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La Ultima Cita";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxeconomico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxoro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxestandar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxdiamante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxeconomico;
        private System.Windows.Forms.PictureBox pboxoro;
        private System.Windows.Forms.PictureBox pboxestandar;
        private System.Windows.Forms.PictureBox pboxdiamante;
        private System.Windows.Forms.Label lblnombrefuneraria;
        private System.Windows.Forms.Button btncontinuar;
        private System.Windows.Forms.Label lblplanfunera;
        private System.Windows.Forms.Label lblslogan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

