namespace ProyectoOctavo.PantallaPermisosUsuario
{
    partial class VistaTotal
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StatusPrivilegio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePrivilegio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTypeUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StatusPrivilegio,
            this.NamePrivilegio,
            this.NameTypeUser,
            this.NameUser});
            this.dataGridView1.Location = new System.Drawing.Point(51, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(452, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // StatusPrivilegio
            // 
            this.StatusPrivilegio.HeaderText = "StatusPrivilegio";
            this.StatusPrivilegio.Name = "StatusPrivilegio";
            this.StatusPrivilegio.ReadOnly = true;
            // 
            // NamePrivilegio
            // 
            this.NamePrivilegio.HeaderText = "NamePrivilegio";
            this.NamePrivilegio.Name = "NamePrivilegio";
            this.NamePrivilegio.ReadOnly = true;
            // 
            // NameTypeUser
            // 
            this.NameTypeUser.HeaderText = "NameTypeUser";
            this.NameTypeUser.Name = "NameTypeUser";
            this.NameTypeUser.ReadOnly = true;
            // 
            // NameUser
            // 
            this.NameUser.HeaderText = "NameUser";
            this.NameUser.Name = "NameUser";
            this.NameUser.ReadOnly = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(469, 448);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // VistaTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 488);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VistaTotal";
            this.Text = "VistaTotal";
            this.Load += new System.EventHandler(this.VistaTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusPrivilegio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePrivilegio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTypeUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUser;
        private System.Windows.Forms.Button btnRegresar;
    }
}