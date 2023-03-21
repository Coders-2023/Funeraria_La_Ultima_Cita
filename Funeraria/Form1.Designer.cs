
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btncontinuar = new System.Windows.Forms.Button();
            this.lblplanfunera = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxeconomico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxoro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxestandar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxdiamante)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxeconomico
            // 
            this.pboxeconomico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxeconomico.BackgroundImage")));
            this.pboxeconomico.Location = new System.Drawing.Point(188, 123);
            this.pboxeconomico.Name = "pboxeconomico";
            this.pboxeconomico.Size = new System.Drawing.Size(160, 127);
            this.pboxeconomico.TabIndex = 4;
            this.pboxeconomico.TabStop = false;
            // 
            // pboxoro
            // 
            this.pboxoro.Location = new System.Drawing.Point(188, 325);
            this.pboxoro.Name = "pboxoro";
            this.pboxoro.Size = new System.Drawing.Size(160, 127);
            this.pboxoro.TabIndex = 5;
            this.pboxoro.TabStop = false;
            // 
            // pboxestandar
            // 
            this.pboxestandar.Location = new System.Drawing.Point(518, 123);
            this.pboxestandar.Name = "pboxestandar";
            this.pboxestandar.Size = new System.Drawing.Size(160, 127);
            this.pboxestandar.TabIndex = 6;
            this.pboxestandar.TabStop = false;
            // 
            // pboxdiamante
            // 
            this.pboxdiamante.Location = new System.Drawing.Point(518, 325);
            this.pboxdiamante.Name = "pboxdiamante";
            this.pboxdiamante.Size = new System.Drawing.Size(160, 127);
            this.pboxdiamante.TabIndex = 7;
            this.pboxdiamante.TabStop = false;
            // 
            // lblnombrefuneraria
            // 
            this.lblnombrefuneraria.AutoSize = true;
            this.lblnombrefuneraria.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrefuneraria.Location = new System.Drawing.Point(337, 9);
            this.lblnombrefuneraria.Name = "lblnombrefuneraria";
            this.lblnombrefuneraria.Size = new System.Drawing.Size(213, 20);
            this.lblnombrefuneraria.TabIndex = 8;
            this.lblnombrefuneraria.Text = "Funeraria \"La Última Cita\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Economico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(561, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Estandar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Oro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(557, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Diamante";
            // 
            // btncontinuar
            // 
            this.btncontinuar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncontinuar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncontinuar.Location = new System.Drawing.Point(786, 500);
            this.btncontinuar.Name = "btncontinuar";
            this.btncontinuar.Size = new System.Drawing.Size(117, 29);
            this.btncontinuar.TabIndex = 13;
            this.btncontinuar.Text = "Continuar";
            this.btncontinuar.UseVisualStyleBackColor = false;
            // 
            // lblplanfunera
            // 
            this.lblplanfunera.AutoSize = true;
            this.lblplanfunera.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplanfunera.Location = new System.Drawing.Point(327, 71);
            this.lblplanfunera.Name = "lblplanfunera";
            this.lblplanfunera.Size = new System.Drawing.Size(234, 20);
            this.lblplanfunera.TabIndex = 14;
            this.lblplanfunera.Text = "Planes Funerarios Disponibles";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(906, 529);
            this.Controls.Add(this.lblplanfunera);
            this.Controls.Add(this.btncontinuar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblnombrefuneraria);
            this.Controls.Add(this.pboxdiamante);
            this.Controls.Add(this.pboxestandar);
            this.Controls.Add(this.pboxoro);
            this.Controls.Add(this.pboxeconomico);
            this.Name = "Form1";
            this.Text = "La Ultima Cita";
            ((System.ComponentModel.ISupportInitialize)(this.pboxeconomico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxoro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxestandar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxdiamante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxeconomico;
        private System.Windows.Forms.PictureBox pboxoro;
        private System.Windows.Forms.PictureBox pboxestandar;
        private System.Windows.Forms.PictureBox pboxdiamante;
        private System.Windows.Forms.Label lblnombrefuneraria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncontinuar;
        private System.Windows.Forms.Label lblplanfunera;
    }
}

