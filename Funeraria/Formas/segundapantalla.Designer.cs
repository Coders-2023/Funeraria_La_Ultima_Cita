
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
            this.components = new System.ComponentModel.Container();
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
            this.BTN_Guardar = new System.Windows.Forms.Button();
            this.txtingresomen = new System.Windows.Forms.TextBox();
            this.txtingresoacu = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblslogan = new System.Windows.Forms.Label();
            this.lblnombrefuneraria = new System.Windows.Forms.Label();
            this.btnregresar = new System.Windows.Forms.Button();
            this.cboxhijos = new System.Windows.Forms.ComboBox();
            this.cboxplansugerido = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadocivilDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hijosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresoMenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresoAcumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Funeraria = new Funeraria.DS_Funeraria();
            this.clientesTableAdapter = new Funeraria.DS_FunerariaTableAdapters.clientesTableAdapter();
            this.TXB_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Funeraria)).BeginInit();
            this.SuspendLayout();
            // 
            // lblplanfunera
            // 
            this.lblplanfunera.AutoSize = true;
            this.lblplanfunera.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplanfunera.Location = new System.Drawing.Point(9, 136);
            this.lblplanfunera.Name = "lblplanfunera";
            this.lblplanfunera.Size = new System.Drawing.Size(156, 20);
            this.lblplanfunera.TabIndex = 15;
            this.lblplanfunera.Text = "Nombre del Cliente:";
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(167, 136);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(470, 20);
            this.txtnombrecliente.TabIndex = 16;
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.Location = new System.Drawing.Point(167, 178);
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.Size = new System.Drawing.Size(470, 20);
            this.txtdomicilio.TabIndex = 18;
            // 
            // lbldomicilio
            // 
            this.lbldomicilio.AutoSize = true;
            this.lbldomicilio.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldomicilio.Location = new System.Drawing.Point(83, 178);
            this.lbldomicilio.Name = "lbldomicilio";
            this.lbldomicilio.Size = new System.Drawing.Size(82, 20);
            this.lbldomicilio.TabIndex = 17;
            this.lbldomicilio.Text = "Domicilio:";
            // 
            // lvlestadocivil
            // 
            this.lvlestadocivil.AutoSize = true;
            this.lvlestadocivil.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlestadocivil.Location = new System.Drawing.Point(61, 215);
            this.lvlestadocivil.Name = "lvlestadocivil";
            this.lvlestadocivil.Size = new System.Drawing.Size(104, 20);
            this.lvlestadocivil.TabIndex = 19;
            this.lvlestadocivil.Text = "Estado Civil:";
            // 
            // rbtncasado
            // 
            this.rbtncasado.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtncasado.Location = new System.Drawing.Point(171, 201);
            this.rbtncasado.Name = "rbtncasado";
            this.rbtncasado.Size = new System.Drawing.Size(114, 49);
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
            this.rbtnsoltero.Location = new System.Drawing.Point(330, 213);
            this.rbtnsoltero.Name = "rbtnsoltero";
            this.rbtnsoltero.Size = new System.Drawing.Size(114, 24);
            this.rbtnsoltero.TabIndex = 21;
            this.rbtnsoltero.TabStop = true;
            this.rbtnsoltero.Text = "SOLTERO";
            this.rbtnsoltero.UseVisualStyleBackColor = true;
            // 
            // lblhijos
            // 
            this.lblhijos.AutoSize = true;
            this.lblhijos.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhijos.Location = new System.Drawing.Point(193, 253);
            this.lblhijos.Name = "lblhijos";
            this.lblhijos.Size = new System.Drawing.Size(64, 20);
            this.lblhijos.TabIndex = 22;
            this.lblhijos.Text = "HIJOS:";
            // 
            // lblingresosmensuales
            // 
            this.lblingresosmensuales.AutoSize = true;
            this.lblingresosmensuales.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblingresosmensuales.Location = new System.Drawing.Point(26, 295);
            this.lblingresosmensuales.Name = "lblingresosmensuales";
            this.lblingresosmensuales.Size = new System.Drawing.Size(159, 20);
            this.lblingresosmensuales.TabIndex = 24;
            this.lblingresosmensuales.Text = "Ingresos Mensuales:";
            // 
            // lblingresosacumulables
            // 
            this.lblingresosacumulables.AutoSize = true;
            this.lblingresosacumulables.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblingresosacumulables.Location = new System.Drawing.Point(9, 348);
            this.lblingresosacumulables.Name = "lblingresosacumulables";
            this.lblingresosacumulables.Size = new System.Drawing.Size(176, 20);
            this.lblingresosacumulables.TabIndex = 25;
            this.lblingresosacumulables.Text = "Ingresos Acumulables:";
            // 
            // lblplansugerido
            // 
            this.lblplansugerido.AutoSize = true;
            this.lblplansugerido.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplansugerido.Location = new System.Drawing.Point(61, 407);
            this.lblplansugerido.Name = "lblplansugerido";
            this.lblplansugerido.Size = new System.Drawing.Size(118, 20);
            this.lblplansugerido.TabIndex = 26;
            this.lblplansugerido.Text = "Plan Sugerido:";
            // 
            // BTN_Guardar
            // 
            this.BTN_Guardar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Guardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Guardar.Location = new System.Drawing.Point(12, 461);
            this.BTN_Guardar.Name = "BTN_Guardar";
            this.BTN_Guardar.Size = new System.Drawing.Size(173, 48);
            this.BTN_Guardar.TabIndex = 27;
            this.BTN_Guardar.Text = "Guardar";
            this.BTN_Guardar.UseVisualStyleBackColor = false;
            this.BTN_Guardar.Click += new System.EventHandler(this.BTN_Guardar_Click);
            // 
            // txtingresomen
            // 
            this.txtingresomen.Location = new System.Drawing.Point(197, 297);
            this.txtingresomen.Name = "txtingresomen";
            this.txtingresomen.Size = new System.Drawing.Size(166, 20);
            this.txtingresomen.TabIndex = 28;
            // 
            // txtingresoacu
            // 
            this.txtingresoacu.Location = new System.Drawing.Point(197, 350);
            this.txtingresoacu.Name = "txtingresoacu";
            this.txtingresoacu.Size = new System.Drawing.Size(166, 20);
            this.txtingresoacu.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -12);
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
            this.lblslogan.Location = new System.Drawing.Point(360, 57);
            this.lblslogan.Name = "lblslogan";
            this.lblslogan.Size = new System.Drawing.Size(640, 20);
            this.lblslogan.TabIndex = 33;
            this.lblslogan.Text = "\"Ofrecemos consuelo en tiempos difíciles: la última despedida para aquellos que a" +
    "mas.\"";
            // 
            // lblnombrefuneraria
            // 
            this.lblnombrefuneraria.AutoSize = true;
            this.lblnombrefuneraria.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrefuneraria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblnombrefuneraria.Location = new System.Drawing.Point(441, 9);
            this.lblnombrefuneraria.Name = "lblnombrefuneraria";
            this.lblnombrefuneraria.Size = new System.Drawing.Size(492, 41);
            this.lblnombrefuneraria.TabIndex = 32;
            this.lblnombrefuneraria.Text = "Funeraria \"La Última Cita\"";
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnregresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnregresar.Location = new System.Drawing.Point(13, 545);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(172, 48);
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
            this.cboxhijos.Location = new System.Drawing.Point(259, 252);
            this.cboxhijos.Margin = new System.Windows.Forms.Padding(2);
            this.cboxhijos.Name = "cboxhijos";
            this.cboxhijos.Size = new System.Drawing.Size(140, 21);
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
            this.cboxplansugerido.Location = new System.Drawing.Point(197, 410);
            this.cboxplansugerido.Margin = new System.Windows.Forms.Padding(2);
            this.cboxplansugerido.Name = "cboxplansugerido";
            this.cboxplansugerido.Size = new System.Drawing.Size(202, 21);
            this.cboxplansugerido.TabIndex = 36;
            this.cboxplansugerido.Text = "Seleccione una opcion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclienteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.domicilioDataGridViewTextBoxColumn,
            this.estadocivilDataGridViewCheckBoxColumn,
            this.hijosDataGridViewTextBoxColumn,
            this.ingresoMenDataGridViewTextBoxColumn,
            this.ingresoAcumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(448, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(552, 341);
            this.dataGridView1.TabIndex = 37;
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "idcliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "idcliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // domicilioDataGridViewTextBoxColumn
            // 
            this.domicilioDataGridViewTextBoxColumn.DataPropertyName = "domicilio";
            this.domicilioDataGridViewTextBoxColumn.HeaderText = "domicilio";
            this.domicilioDataGridViewTextBoxColumn.Name = "domicilioDataGridViewTextBoxColumn";
            this.domicilioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadocivilDataGridViewCheckBoxColumn
            // 
            this.estadocivilDataGridViewCheckBoxColumn.DataPropertyName = "estadocivil";
            this.estadocivilDataGridViewCheckBoxColumn.HeaderText = "estadocivil";
            this.estadocivilDataGridViewCheckBoxColumn.Name = "estadocivilDataGridViewCheckBoxColumn";
            this.estadocivilDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // hijosDataGridViewTextBoxColumn
            // 
            this.hijosDataGridViewTextBoxColumn.DataPropertyName = "hijos";
            this.hijosDataGridViewTextBoxColumn.HeaderText = "hijos";
            this.hijosDataGridViewTextBoxColumn.Name = "hijosDataGridViewTextBoxColumn";
            this.hijosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ingresoMenDataGridViewTextBoxColumn
            // 
            this.ingresoMenDataGridViewTextBoxColumn.DataPropertyName = "ingresoMen";
            this.ingresoMenDataGridViewTextBoxColumn.HeaderText = "ingresoMen";
            this.ingresoMenDataGridViewTextBoxColumn.Name = "ingresoMenDataGridViewTextBoxColumn";
            this.ingresoMenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ingresoAcumDataGridViewTextBoxColumn
            // 
            this.ingresoAcumDataGridViewTextBoxColumn.DataPropertyName = "ingresoAcum";
            this.ingresoAcumDataGridViewTextBoxColumn.HeaderText = "ingresoAcum";
            this.ingresoAcumDataGridViewTextBoxColumn.Name = "ingresoAcumDataGridViewTextBoxColumn";
            this.ingresoAcumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.dS_Funeraria;
            // 
            // dS_Funeraria
            // 
            this.dS_Funeraria.DataSetName = "DS_Funeraria";
            this.dS_Funeraria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // TXB_ID
            // 
            this.TXB_ID.Location = new System.Drawing.Point(675, 136);
            this.TXB_ID.Name = "TXB_ID";
            this.TXB_ID.Size = new System.Drawing.Size(166, 20);
            this.TXB_ID.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(671, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Folio Cliente:";
            // 
            // BTN_Eliminar
            // 
            this.BTN_Eliminar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Eliminar.Location = new System.Drawing.Point(197, 461);
            this.BTN_Eliminar.Name = "BTN_Eliminar";
            this.BTN_Eliminar.Size = new System.Drawing.Size(173, 48);
            this.BTN_Eliminar.TabIndex = 40;
            this.BTN_Eliminar.Text = "Eliminar";
            this.BTN_Eliminar.UseVisualStyleBackColor = false;
            // 
            // segundapantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1035, 618);
            this.Controls.Add(this.BTN_Eliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXB_ID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboxplansugerido);
            this.Controls.Add(this.cboxhijos);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.lblslogan);
            this.Controls.Add(this.lblnombrefuneraria);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtingresoacu);
            this.Controls.Add(this.txtingresomen);
            this.Controls.Add(this.BTN_Guardar);
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
            this.Name = "segundapantalla";
            this.Text = "La Última Cena";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.segundapantalla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Funeraria)).EndInit();
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
        private System.Windows.Forms.Button BTN_Guardar;
        private System.Windows.Forms.TextBox txtingresomen;
        private System.Windows.Forms.TextBox txtingresoacu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblslogan;
        private System.Windows.Forms.Label lblnombrefuneraria;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.ComboBox cboxhijos;
        private System.Windows.Forms.ComboBox cboxplansugerido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DS_Funeraria dS_Funeraria;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DS_FunerariaTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadocivilDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hijosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresoMenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresoAcumDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TXB_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Eliminar;
    }
}