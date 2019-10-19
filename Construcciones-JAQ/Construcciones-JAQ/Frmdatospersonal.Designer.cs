namespace Construcciones_JAQ
{
    partial class Frmdatospersonal
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
            System.Windows.Forms.Label id_PersonalLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label salarioLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmdatospersonal));
            this.personalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.id_PersonalTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.salarioTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.personalDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.construccionesJAQDataSet = new Construcciones_JAQ.ConstruccionesJAQDataSet();
            this.personalTableAdapter = new Construcciones_JAQ.ConstruccionesJAQDataSetTableAdapters.PersonalTableAdapter();
            this.tableAdapterManager = new Construcciones_JAQ.ConstruccionesJAQDataSetTableAdapters.TableAdapterManager();
            id_PersonalLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            salarioLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingNavigator)).BeginInit();
            this.personalBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.construccionesJAQDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // id_PersonalLabel
            // 
            id_PersonalLabel.AutoSize = true;
            id_PersonalLabel.Location = new System.Drawing.Point(23, 20);
            id_PersonalLabel.Name = "id_PersonalLabel";
            id_PersonalLabel.Size = new System.Drawing.Size(63, 13);
            id_PersonalLabel.TabIndex = 1;
            id_PersonalLabel.Text = "Id Personal:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(23, 46);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(325, 17);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 5;
            apellidoLabel.Text = "Apellido:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(325, 49);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 7;
            telefonoLabel.Text = "Telefono:";
            // 
            // salarioLabel
            // 
            salarioLabel.AutoSize = true;
            salarioLabel.Location = new System.Drawing.Point(23, 80);
            salarioLabel.Name = "salarioLabel";
            salarioLabel.Size = new System.Drawing.Size(42, 13);
            salarioLabel.TabIndex = 9;
            salarioLabel.Text = "Salario:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(325, 83);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(41, 13);
            correoLabel.TabIndex = 11;
            correoLabel.Text = "Correo:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(23, 106);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 13;
            direccionLabel.Text = "Direccion:";
            // 
            // personalBindingNavigator
            // 
            this.personalBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personalBindingNavigator.BindingSource = this.personalBindingSource;
            this.personalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personalBindingNavigator.DeleteItem = null;
            this.personalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem});
            this.personalBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personalBindingNavigator.Name = "personalBindingNavigator";
            this.personalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personalBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.personalBindingNavigator.TabIndex = 0;
            this.personalBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // id_PersonalTextBox
            // 
            this.id_PersonalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Id_Personal", true));
            this.id_PersonalTextBox.Location = new System.Drawing.Point(97, 17);
            this.id_PersonalTextBox.Name = "id_PersonalTextBox";
            this.id_PersonalTextBox.Size = new System.Drawing.Size(137, 20);
            this.id_PersonalTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(97, 43);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(137, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(393, 14);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(145, 20);
            this.apellidoTextBox.TabIndex = 6;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(393, 46);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(145, 20);
            this.telefonoTextBox.TabIndex = 8;
            // 
            // salarioTextBox
            // 
            this.salarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Salario", true));
            this.salarioTextBox.Location = new System.Drawing.Point(97, 77);
            this.salarioTextBox.Name = "salarioTextBox";
            this.salarioTextBox.Size = new System.Drawing.Size(137, 20);
            this.salarioTextBox.TabIndex = 10;
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(393, 80);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(260, 20);
            this.correoTextBox.TabIndex = 12;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(97, 103);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(204, 20);
            this.direccionTextBox.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Buscar);
            this.panel1.Controls.Add(this.txt_Buscar);
            this.panel1.Controls.Add(id_PersonalLabel);
            this.panel1.Controls.Add(this.direccionTextBox);
            this.panel1.Controls.Add(direccionLabel);
            this.panel1.Controls.Add(this.id_PersonalTextBox);
            this.panel1.Controls.Add(this.correoTextBox);
            this.panel1.Controls.Add(nombreLabel);
            this.panel1.Controls.Add(correoLabel);
            this.panel1.Controls.Add(this.nombreTextBox);
            this.panel1.Controls.Add(this.salarioTextBox);
            this.panel1.Controls.Add(apellidoLabel);
            this.panel1.Controls.Add(salarioLabel);
            this.panel1.Controls.Add(this.apellidoTextBox);
            this.panel1.Controls.Add(this.telefonoTextBox);
            this.panel1.Controls.Add(telefonoLabel);
            this.panel1.Location = new System.Drawing.Point(31, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 185);
            this.panel1.TabIndex = 16;
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Location = new System.Drawing.Point(23, 151);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(40, 13);
            this.lbl_Buscar.TabIndex = 35;
            this.lbl_Buscar.Text = "Buscar";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(105, 148);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(350, 20);
            this.txt_Buscar.TabIndex = 34;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.Txt_Buscar_TextChanged);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(217, 27);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 38;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(107, 27);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 37;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(3, 27);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarP.TabIndex = 36;
            this.btnAgregarP.Text = "Agregar";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.BtnAgregarP_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Eliminar);
            this.panel2.Controls.Add(this.btnAgregarP);
            this.panel2.Controls.Add(this.btn_Modificar);
            this.panel2.Location = new System.Drawing.Point(31, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 91);
            this.panel2.TabIndex = 39;
            // 
            // personalDataGridView
            // 
            this.personalDataGridView.AutoGenerateColumns = false;
            this.personalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.personalDataGridView.DataSource = this.personalBindingSource;
            this.personalDataGridView.Location = new System.Drawing.Point(31, 370);
            this.personalDataGridView.Name = "personalDataGridView";
            this.personalDataGridView.ReadOnly = true;
            this.personalDataGridView.Size = new System.Drawing.Size(742, 220);
            this.personalDataGridView.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_Personal";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_Personal";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn4.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Salario";
            this.dataGridViewTextBoxColumn6.HeaderText = "Salario";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Correo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn8.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Id_Cargo_1";
            this.dataGridViewTextBoxColumn9.HeaderText = "Id_Cargo_1";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Id_Seguridad_S1";
            this.dataGridViewTextBoxColumn10.HeaderText = "Id_Seguridad_S1";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "Personal";
            this.personalBindingSource.DataSource = this.construccionesJAQDataSet;
            // 
            // construccionesJAQDataSet
            // 
            this.construccionesJAQDataSet.DataSetName = "ConstruccionesJAQDataSet";
            this.construccionesJAQDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CargoTableAdapter = null;
            this.tableAdapterManager.ContractoTableAdapter = null;
            this.tableAdapterManager.Personal_contractoTableAdapter = null;
            this.tableAdapterManager.PersonalTableAdapter = this.personalTableAdapter;
            this.tableAdapterManager.Seguridad_SocialTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Construcciones_JAQ.ConstruccionesJAQDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Frmdatospersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 682);
            this.Controls.Add(this.personalDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.personalBindingNavigator);
            this.Name = "Frmdatospersonal";
            this.Text = "Frmdatospersonal";
            this.Load += new System.EventHandler(this.Frmdatospersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingNavigator)).EndInit();
            this.personalBindingNavigator.ResumeLayout(false);
            this.personalBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.construccionesJAQDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConstruccionesJAQDataSet construccionesJAQDataSet;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private ConstruccionesJAQDataSetTableAdapters.PersonalTableAdapter personalTableAdapter;
        private ConstruccionesJAQDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator personalBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox id_PersonalTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox salarioTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Buscar;
        public System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.DataGridView personalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}