namespace ProyectoOctavo.PantallaPermisosUsuario
{
    partial class PermisosSuperUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPermisoNew = new System.Windows.Forms.TextBox();
            this.txtAgregarPermiso = new System.Windows.Forms.Button();
            this.chkbPrivilegios = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Permiso nuevo";
            // 
            // txtPermisoNew
            // 
            this.txtPermisoNew.Location = new System.Drawing.Point(115, 37);
            this.txtPermisoNew.Name = "txtPermisoNew";
            this.txtPermisoNew.Size = new System.Drawing.Size(130, 20);
            this.txtPermisoNew.TabIndex = 1;
            // 
            // txtAgregarPermiso
            // 
            this.txtAgregarPermiso.Location = new System.Drawing.Point(281, 35);
            this.txtAgregarPermiso.Name = "txtAgregarPermiso";
            this.txtAgregarPermiso.Size = new System.Drawing.Size(105, 23);
            this.txtAgregarPermiso.TabIndex = 2;
            this.txtAgregarPermiso.Text = "Agregar";
            this.txtAgregarPermiso.UseVisualStyleBackColor = true;
            // 
            // chkbPrivilegios
            // 
            this.chkbPrivilegios.AutoSize = true;
            this.chkbPrivilegios.Location = new System.Drawing.Point(15, 82);
            this.chkbPrivilegios.Name = "chkbPrivilegios";
            this.chkbPrivilegios.Size = new System.Drawing.Size(80, 17);
            this.chkbPrivilegios.TabIndex = 3;
            this.chkbPrivilegios.Text = "checkBox1";
            this.chkbPrivilegios.UseVisualStyleBackColor = true;
            // 
            // PermisosSuperUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 438);
            this.Controls.Add(this.chkbPrivilegios);
            this.Controls.Add(this.txtAgregarPermiso);
            this.Controls.Add(this.txtPermisoNew);
            this.Controls.Add(this.label1);
            this.Name = "PermisosSuperUsuario";
            this.Text = "PermisosSuperUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPermisoNew;
        private System.Windows.Forms.Button txtAgregarPermiso;
        private System.Windows.Forms.CheckBox chkbPrivilegios;
    }
}