
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
            this.DTG_Clientes = new System.Windows.Forms.DataGridView();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadocivilDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hijosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresoMenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresoAcumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plansugeridoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Clientes_Melisa = new Funeraria.DS_Clientes_Melisa();
            this.TXB_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            this.clientesTableAdapter = new Funeraria.DS_Clientes_MelisaTableAdapters.clientesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncontinuar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Clientes_Melisa)).BeginInit();
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
            // BTN_Guardar
            // 
            this.BTN_Guardar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Guardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Guardar.Location = new System.Drawing.Point(16, 567);
            this.BTN_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Guardar.Name = "BTN_Guardar";
            this.BTN_Guardar.Size = new System.Drawing.Size(231, 59);
            this.BTN_Guardar.TabIndex = 27;
            this.BTN_Guardar.Text = "Guardar";
            this.BTN_Guardar.UseVisualStyleBackColor = false;
            this.BTN_Guardar.Click += new System.EventHandler(this.BTN_Guardar_Click);
            // 
            // txtingresomen
            // 
            this.txtingresomen.Location = new System.Drawing.Point(263, 366);
            this.txtingresomen.Margin = new System.Windows.Forms.Padding(4);
            this.txtingresomen.Name = "txtingresomen";
            this.txtingresomen.Size = new System.Drawing.Size(220, 22);
            this.txtingresomen.TabIndex = 28;
            this.txtingresomen.TextChanged += new System.EventHandler(this.txtingresomen_TextChanged);
            this.txtingresomen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtingresomen_KeyPress);
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
            this.btnregresar.Location = new System.Drawing.Point(17, 671);
            this.btnregresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(229, 59);
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
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cboxhijos.Location = new System.Drawing.Point(345, 310);
            this.cboxhijos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxhijos.Name = "cboxhijos";
            this.cboxhijos.Size = new System.Drawing.Size(185, 24);
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
            this.cboxplansugerido.Location = new System.Drawing.Point(263, 505);
            this.cboxplansugerido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxplansugerido.Name = "cboxplansugerido";
            this.cboxplansugerido.Size = new System.Drawing.Size(268, 24);
            this.cboxplansugerido.TabIndex = 36;
            this.cboxplansugerido.Text = "Seleccione una opcion";
            // 
            // DTG_Clientes
            // 
            this.DTG_Clientes.AllowUserToAddRows = false;
            this.DTG_Clientes.AllowUserToDeleteRows = false;
            this.DTG_Clientes.AutoGenerateColumns = false;
            this.DTG_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclienteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.domicilioDataGridViewTextBoxColumn,
            this.estadocivilDataGridViewCheckBoxColumn,
            this.hijosDataGridViewTextBoxColumn,
            this.ingresoMenDataGridViewTextBoxColumn,
            this.ingresoAcumDataGridViewTextBoxColumn,
            this.plansugeridoDataGridViewTextBoxColumn});
            this.DTG_Clientes.DataSource = this.clientesBindingSource;
            this.DTG_Clientes.Location = new System.Drawing.Point(639, 363);
            this.DTG_Clientes.Margin = new System.Windows.Forms.Padding(4);
            this.DTG_Clientes.Name = "DTG_Clientes";
            this.DTG_Clientes.ReadOnly = true;
            this.DTG_Clientes.RowHeadersWidth = 51;
            this.DTG_Clientes.Size = new System.Drawing.Size(1054, 420);
            this.DTG_Clientes.TabIndex = 37;
            this.DTG_Clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_Clientes_CellClick);
            this.DTG_Clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_Clientes_CellContentClick);
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "idcliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "idcliente";
            this.idclienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // domicilioDataGridViewTextBoxColumn
            // 
            this.domicilioDataGridViewTextBoxColumn.DataPropertyName = "domicilio";
            this.domicilioDataGridViewTextBoxColumn.HeaderText = "domicilio";
            this.domicilioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.domicilioDataGridViewTextBoxColumn.Name = "domicilioDataGridViewTextBoxColumn";
            this.domicilioDataGridViewTextBoxColumn.ReadOnly = true;
            this.domicilioDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadocivilDataGridViewCheckBoxColumn
            // 
            this.estadocivilDataGridViewCheckBoxColumn.DataPropertyName = "estadocivil";
            this.estadocivilDataGridViewCheckBoxColumn.HeaderText = "estadocivil";
            this.estadocivilDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.estadocivilDataGridViewCheckBoxColumn.Name = "estadocivilDataGridViewCheckBoxColumn";
            this.estadocivilDataGridViewCheckBoxColumn.ReadOnly = true;
            this.estadocivilDataGridViewCheckBoxColumn.Width = 125;
            // 
            // hijosDataGridViewTextBoxColumn
            // 
            this.hijosDataGridViewTextBoxColumn.DataPropertyName = "hijos";
            this.hijosDataGridViewTextBoxColumn.HeaderText = "hijos";
            this.hijosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hijosDataGridViewTextBoxColumn.Name = "hijosDataGridViewTextBoxColumn";
            this.hijosDataGridViewTextBoxColumn.ReadOnly = true;
            this.hijosDataGridViewTextBoxColumn.Width = 125;
            // 
            // ingresoMenDataGridViewTextBoxColumn
            // 
            this.ingresoMenDataGridViewTextBoxColumn.DataPropertyName = "ingresoMen";
            this.ingresoMenDataGridViewTextBoxColumn.HeaderText = "ingresoMen";
            this.ingresoMenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ingresoMenDataGridViewTextBoxColumn.Name = "ingresoMenDataGridViewTextBoxColumn";
            this.ingresoMenDataGridViewTextBoxColumn.ReadOnly = true;
            this.ingresoMenDataGridViewTextBoxColumn.Width = 125;
            // 
            // ingresoAcumDataGridViewTextBoxColumn
            // 
            this.ingresoAcumDataGridViewTextBoxColumn.DataPropertyName = "ingresoAcum";
            this.ingresoAcumDataGridViewTextBoxColumn.HeaderText = "ingresoAcum";
            this.ingresoAcumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ingresoAcumDataGridViewTextBoxColumn.Name = "ingresoAcumDataGridViewTextBoxColumn";
            this.ingresoAcumDataGridViewTextBoxColumn.ReadOnly = true;
            this.ingresoAcumDataGridViewTextBoxColumn.Width = 125;
            // 
            // plansugeridoDataGridViewTextBoxColumn
            // 
            this.plansugeridoDataGridViewTextBoxColumn.DataPropertyName = "plansugerido";
            this.plansugeridoDataGridViewTextBoxColumn.HeaderText = "plansugerido";
            this.plansugeridoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plansugeridoDataGridViewTextBoxColumn.Name = "plansugeridoDataGridViewTextBoxColumn";
            this.plansugeridoDataGridViewTextBoxColumn.ReadOnly = true;
            this.plansugeridoDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.dS_Clientes_Melisa;
            // 
            // dS_Clientes_Melisa
            // 
            this.dS_Clientes_Melisa.DataSetName = "DS_Clientes_Melisa";
            this.dS_Clientes_Melisa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TXB_ID
            // 
            this.TXB_ID.Location = new System.Drawing.Point(900, 167);
            this.TXB_ID.Margin = new System.Windows.Forms.Padding(4);
            this.TXB_ID.Name = "TXB_ID";
            this.TXB_ID.Size = new System.Drawing.Size(220, 22);
            this.TXB_ID.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(895, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "Folio Cliente:";
            // 
            // BTN_Eliminar
            // 
            this.BTN_Eliminar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Eliminar.Location = new System.Drawing.Point(263, 567);
            this.BTN_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Eliminar.Name = "BTN_Eliminar";
            this.BTN_Eliminar.Size = new System.Drawing.Size(231, 59);
            this.BTN_Eliminar.TabIndex = 40;
            this.BTN_Eliminar.Text = "Eliminar";
            this.BTN_Eliminar.UseVisualStyleBackColor = false;
            this.BTN_Eliminar.Click += new System.EventHandler(this.BTN_Eliminar_Click);
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "$";
            // 
            // btncontinuar
            // 
            this.btncontinuar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btncontinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontinuar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncontinuar.Location = new System.Drawing.Point(265, 671);
            this.btncontinuar.Margin = new System.Windows.Forms.Padding(4);
            this.btncontinuar.Name = "btncontinuar";
            this.btncontinuar.Size = new System.Drawing.Size(229, 59);
            this.btncontinuar.TabIndex = 43;
            this.btncontinuar.Text = "Continuar";
            this.btncontinuar.UseVisualStyleBackColor = false;
            this.btncontinuar.Click += new System.EventHandler(this.btncontinuar_Click);
            // 
            // segundapantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1647, 761);
            this.Controls.Add(this.btncontinuar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_Eliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXB_ID);
            this.Controls.Add(this.DTG_Clientes);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "segundapantalla";
            this.Text = "La Última Cena";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.segundapantalla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Clientes_Melisa)).EndInit();
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
        private System.Windows.Forms.DataGridView DTG_Clientes;
        private System.Windows.Forms.TextBox TXB_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Eliminar;
        private DS_Clientes_Melisa dS_Clientes_Melisa;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DS_Clientes_MelisaTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadocivilDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hijosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresoMenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresoAcumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plansugeridoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncontinuar;
        public System.Windows.Forms.ComboBox cboxplansugerido;
    }
}