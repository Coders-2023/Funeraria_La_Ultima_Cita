
namespace Funeraria
{
    partial class segundapantalla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(segundapantalla));
            this.lblplanfunera = new System.Windows.Forms.Label();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.txtdomicilio = new System.Windows.Forms.TextBox();
            this.lbldomicilio = new System.Windows.Forms.Label();
            this.lvlestadocivil = new System.Windows.Forms.Label();
            this.rbtncasado = new System.Windows.Forms.RadioButton();
            this.rbtnsoltero = new System.Windows.Forms.RadioButton();
            this.lblhijos = new System.Windows.Forms.Label();
            this.lblingresosmensuales = new System.Windows.Forms.Label();
            this.lblingresosacumulables = new System.Windows.Forms.Label();
            this.lblplansugerido = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtingresomen = new System.Windows.Forms.TextBox();
            this.txtingresoacu = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblslogan = new System.Windows.Forms.Label();
            this.lblnombrefuneraria = new System.Windows.Forms.Label();
            this.btnregresar = new System.Windows.Forms.Button();
            this.cboxhijos = new System.Windows.Forms.ComboBox();
            this.cboxplansugerido = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblplanfunera
            // 
            this.lblplanfunera.AutoSize = true;
            this.lblplanfunera.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplanfunera.Location = new System.Drawing.Point(12, 167);
            this.lblplanfunera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblplanfunera.Name = "lblplanfunera";
            this.lblplanfunera.Size = new System.Drawing.Size(195, 23);
            this.lblplanfunera.TabIndex = 15;
            this.lblplanfunera.Text = "Nombre del Cliente:";
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(223, 167);
            this.txtnombrecliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(625, 22);
            this.txtnombrecliente.TabIndex = 16;
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.Location = new System.Drawing.Point(223, 219);
            this.txtdomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.Size = new System.Drawing.Size(625, 22);
            this.txtdomicilio.TabIndex = 18;
            // 
            // lbldomicilio
            // 
            this.lbldomicilio.AutoSize = true;
            this.lbldomicilio.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldomicilio.Location = new System.Drawing.Point(111, 219);
            this.lbldomicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldomicilio.Name = "lbldomicilio";
            this.lbldomicilio.Size = new System.Drawing.Size(103, 23);
            this.lbldomicilio.TabIndex = 17;
            this.lbldomicilio.Text = "Domicilio:";
            // 
            // lvlestadocivil
            // 
            this.lvlestadocivil.AutoSize = true;
            this.lvlestadocivil.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlestadocivil.Location = new System.Drawing.Point(81, 265);
            this.lvlestadocivil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlestadocivil.Name = "lvlestadocivil";
            this.lvlestadocivil.Size = new System.Drawing.Size(128, 23);
            this.lvlestadocivil.TabIndex = 19;
            this.lvlestadocivil.Text = "Estado Civil:";
            // 
            // rbtncasado
            // 
            this.rbtncasado.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtncasado.Location = new System.Drawing.Point(228, 247);
            this.rbtncasado.Margin = new System.Windows.Forms.Padding(4);
            this.rbtncasado.Name = "rbtncasado";
            this.rbtncasado.Size = new System.Drawing.Size(152, 60);
            this.rbtncasado.TabIndex = 20;
            this.rbtncasado.TabStop = true;
            this.rbtncasado.Text = "CASADO";
            this.rbtncasado.UseVisualStyleBackColor = true;
            this.rbtncasado.CheckedChanged += new System.EventHandler(this.rbtncasado_CheckedChanged);
            // 
            // rbtnsoltero
            // 
            this.rbtnsoltero.AutoSize = true;
            this.rbtnsoltero.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnsoltero.Location = new System.Drawing.Point(440, 262);
            this.rbtnsoltero.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnsoltero.Name = "rbtnsoltero";
            this.rbtnsoltero.Size = new System.Drawing.Size(137, 27);
            this.rbtnsoltero.TabIndex = 21;
            this.rbtnsoltero.TabStop = true;
            this.rbtnsoltero.Text = "SOLTERO";
            this.rbtnsoltero.UseVisualStyleBackColor = true;
            // 
            // lblhijos
            // 
            this.lblhijos.AutoSize = true;
            this.lblhijos.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhijos.Location = new System.Drawing.Point(257, 311);
            this.lblhijos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhijos.Name = "lblhijos";
            this.lblhijos.Size = new System.Drawing.Size(81, 23);
            this.lblhijos.TabIndex = 22;
            this.lblhijos.Text = "HIJOS:";
            // 
            // lblingresosmensuales
            // 
            this.lblingresosmensuales.AutoSize = true;
            this.lblingresosmensuales.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblingresosmensuales.Location = new System.Drawing.Point(35, 363);
            this.lblingresosmensuales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblingresosmensuales.Name = "lblingresosmensuales";
            this.lblingresosmensuales.Size = new System.Drawing.Size(198, 23);
            this.lblingresosmensuales.TabIndex = 24;
            this.lblingresosmensuales.Text = "Ingresos Mensuales:";
            // 
            // lblingresosacumulables
            // 
            this.lblingresosacumulables.AutoSize = true;
            this.lblingresosacumulables.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblingresosacumulables.Location = new System.Drawing.Point(12, 428);
            this.lblingresosacumulables.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblingresosacumulables.Name = "lblingresosacumulables";
            this.lblingresosacumulables.Size = new System.Drawing.Size(218, 23);
            this.lblingresosacumulables.TabIndex = 25;
            this.lblingresosacumulables.Text = "Ingresos Acumulables:";
            // 
            // lblplansugerido
            // 
            this.lblplansugerido.AutoSize = true;
            this.lblplansugerido.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplansugerido.Location = new System.Drawing.Point(81, 501);
            this.lblplansugerido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblplansugerido.Name = "lblplansugerido";
            this.lblplansugerido.Size = new System.Drawing.Size(146, 23);
            this.lblplansugerido.TabIndex = 26;
            this.lblplansugerido.Text = "Plan Sugerido:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(263, 592);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 59);
            this.button1.TabIndex = 27;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtingresomen
            // 
            this.txtingresomen.Location = new System.Drawing.Point(263, 366);
            this.txtingresomen.Margin = new System.Windows.Forms.Padding(4);
            this.txtingresomen.Name = "txtingresomen";
            this.txtingresomen.Size = new System.Drawing.Size(220, 22);
            this.txtingresomen.TabIndex = 28;
            // 
            // txtingresoacu
            // 
            this.txtingresoacu.Location = new System.Drawing.Point(263, 431);
            this.txtingresoacu.Margin = new System.Windows.Forms.Padding(4);
            this.txtingresoacu.Name = "txtingresoacu";
            this.txtingresoacu.Size = new System.Drawing.Size(220, 22);
            this.txtingresoacu.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // lblslogan
            // 
            this.lblslogan.AutoSize = true;
            this.lblslogan.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblslogan.Location = new System.Drawing.Point(480, 70);
            this.lblslogan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblslogan.Name = "lblslogan";
            this.lblslogan.Size = new System.Drawing.Size(811, 23);
            this.lblslogan.TabIndex = 33;
            this.lblslogan.Text = "\"Ofrecemos consuelo en tiempos difíciles: la última despedida para aquellos que a" +
    "mas.\"";
            // 
            // lblnombrefuneraria
            // 
            this.lblnombrefuneraria.AutoSize = true;
            this.lblnombrefuneraria.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrefuneraria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblnombrefuneraria.Location = new System.Drawing.Point(588, 11);
            this.lblnombrefuneraria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombrefuneraria.Name = "lblnombrefuneraria";
            this.lblnombrefuneraria.Size = new System.Drawing.Size(610, 54);
            this.lblnombrefuneraria.TabIndex = 32;
            this.lblnombrefuneraria.Text = "Funeraria \"La Última Cita\"";
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnregresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnregresar.Location = new System.Drawing.Point(648, 592);
            this.btnregresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(268, 59);
            this.btnregresar.TabIndex = 34;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // cboxhijos
            // 
            this.cboxhijos.Enabled = false;
            this.cboxhijos.FormattingEnabled = true;
            this.cboxhijos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3+"});
            this.cboxhijos.Location = new System.Drawing.Point(345, 310);
            this.cboxhijos.Name = "cboxhijos";
            this.cboxhijos.Size = new System.Drawing.Size(186, 24);
            this.cboxhijos.TabIndex = 35;
            this.cboxhijos.Text = "Seleccione una opcion";
            // 
            // cboxplansugerido
            // 
            this.cboxplansugerido.FormattingEnabled = true;
            this.cboxplansugerido.Items.AddRange(new object[] {
            "Economico",
            "Estandar",
            "Oro",
            "Diamante"});
            this.cboxplansugerido.Location = new System.Drawing.Point(263, 504);
            this.cboxplansugerido.Name = "cboxplansugerido";
            this.cboxplansugerido.Size = new System.Drawing.Size(268, 24);
            this.cboxplansugerido.TabIndex = 36;
            this.cboxplansugerido.Text = "Seleccione una opcion";
            // 
            // segundapantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1380, 761);
            this.Controls.Add(this.cboxplansugerido);
            this.Controls.Add(this.cboxhijos);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.lblslogan);
            this.Controls.Add(this.lblnombrefuneraria);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtingresoacu);
            this.Controls.Add(this.txtingresomen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblplansugerido);
            this.Controls.Add(this.lblingresosacumulables);
            this.Controls.Add(this.lblingresosmensuales);
            this.Controls.Add(this.lblhijos);
            this.Controls.Add(this.rbtnsoltero);
            this.Controls.Add(this.rbtncasado);
            this.Controls.Add(this.lvlestadocivil);
            this.Controls.Add(this.txtdomicilio);
            this.Controls.Add(this.lbldomicilio);
            this.Controls.Add(this.txtnombrecliente);
            this.Controls.Add(this.lblplanfunera);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "segundapantalla";
            this.Text = "La Última Cena";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblplanfunera;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.TextBox txtdomicilio;
        private System.Windows.Forms.Label lbldomicilio;
        private System.Windows.Forms.Label lvlestadocivil;
        private System.Windows.Forms.RadioButton rbtncasado;
        private System.Windows.Forms.RadioButton rbtnsoltero;
        private System.Windows.Forms.Label lblhijos;
        private System.Windows.Forms.Label lblingresosmensuales;
        private System.Windows.Forms.Label lblingresosacumulables;
        private System.Windows.Forms.Label lblplansugerido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtingresomen;
        private System.Windows.Forms.TextBox txtingresoacu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblslogan;
        private System.Windows.Forms.Label lblnombrefuneraria;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.ComboBox cboxhijos;
        private System.Windows.Forms.ComboBox cboxplansugerido;
    }
}