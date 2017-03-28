﻿namespace ProyectoOctavo.PantallaPermisosUsuario
{
    partial class CrearTipoDeUsuario
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtTypeUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.privilegiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoOctavoUserTypesDataSet = new ProyectoOctavo.ProyectoOctavoUserTypesDataSet();
            this.privilegiosTableAdapter = new ProyectoOctavo.ProyectoOctavoUserTypesDataSetTableAdapters.PrivilegiosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typeUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeUserTableAdapter = new ProyectoOctavo.ProyectoOctavoUserTypesDataSetTableAdapters.TypeUserTableAdapter();
            this.nameTypeUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.privilegiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoOctavoUserTypesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(45, 126);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtTypeUserName
            // 
            this.txtTypeUserName.Location = new System.Drawing.Point(20, 36);
            this.txtTypeUserName.Name = "txtTypeUserName";
            this.txtTypeUserName.Size = new System.Drawing.Size(100, 20);
            this.txtTypeUserName.TabIndex = 1;
            this.txtTypeUserName.TextChanged += new System.EventHandler(this.txtTypeUserName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de TypeUser";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(45, 155);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.privilegiosBindingSource;
            this.comboBox1.DisplayMember = "NamePrivilegio";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "IdPrivilegio";
            // 
            // privilegiosBindingSource
            // 
            this.privilegiosBindingSource.DataMember = "Privilegios";
            this.privilegiosBindingSource.DataSource = this.proyectoOctavoUserTypesDataSet;
            // 
            // proyectoOctavoUserTypesDataSet
            // 
            this.proyectoOctavoUserTypesDataSet.DataSetName = "ProyectoOctavoUserTypesDataSet";
            this.proyectoOctavoUserTypesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // privilegiosTableAdapter
            // 
            this.privilegiosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameTypeUserDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.typeUserBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(157, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 387);
            this.dataGridView1.TabIndex = 5;
            // 
            // typeUserBindingSource
            // 
            this.typeUserBindingSource.DataMember = "TypeUser";
            this.typeUserBindingSource.DataSource = this.proyectoOctavoUserTypesDataSet;
            // 
            // typeUserTableAdapter
            // 
            this.typeUserTableAdapter.ClearBeforeFill = true;
            // 
            // nameTypeUserDataGridViewTextBoxColumn
            // 
            this.nameTypeUserDataGridViewTextBoxColumn.DataPropertyName = "NameTypeUser";
            this.nameTypeUserDataGridViewTextBoxColumn.HeaderText = "NameTypeUser";
            this.nameTypeUserDataGridViewTextBoxColumn.Name = "nameTypeUserDataGridViewTextBoxColumn";
            // 
            // CrearTipoDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 419);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTypeUserName);
            this.Controls.Add(this.btnCrear);
            this.Name = "CrearTipoDeUsuario";
            this.Text = "CrearTipoDeUsuario";
            this.Load += new System.EventHandler(this.CrearTipoDeUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.privilegiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoOctavoUserTypesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtTypeUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ComboBox comboBox1;
        private ProyectoOctavoUserTypesDataSet proyectoOctavoUserTypesDataSet;
        private System.Windows.Forms.BindingSource privilegiosBindingSource;
        private ProyectoOctavoUserTypesDataSetTableAdapters.PrivilegiosTableAdapter privilegiosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource typeUserBindingSource;
        private ProyectoOctavoUserTypesDataSetTableAdapters.TypeUserTableAdapter typeUserTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTypeUserDataGridViewTextBoxColumn;
    }
}