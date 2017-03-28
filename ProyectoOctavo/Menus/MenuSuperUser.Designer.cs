namespace ProyectoOctavo.Menus
{
    partial class MenuSuperUser
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
            this.txtPermisos = new System.Windows.Forms.Button();
            this.txtTipoDeUsuario = new System.Windows.Forms.Button();
            this.txtUsuarios = new System.Windows.Forms.Button();
            this.txtSalir = new System.Windows.Forms.Button();
            this.btnPrivilegio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPermisos
            // 
            this.txtPermisos.Location = new System.Drawing.Point(139, 101);
            this.txtPermisos.Name = "txtPermisos";
            this.txtPermisos.Size = new System.Drawing.Size(140, 47);
            this.txtPermisos.TabIndex = 0;
            this.txtPermisos.Text = "Permisos";
            this.txtPermisos.UseVisualStyleBackColor = true;
            this.txtPermisos.Click += new System.EventHandler(this.txtPermisos_Click);
            // 
            // txtTipoDeUsuario
            // 
            this.txtTipoDeUsuario.Location = new System.Drawing.Point(139, 205);
            this.txtTipoDeUsuario.Name = "txtTipoDeUsuario";
            this.txtTipoDeUsuario.Size = new System.Drawing.Size(140, 45);
            this.txtTipoDeUsuario.TabIndex = 1;
            this.txtTipoDeUsuario.Text = "Tipo de Usuario";
            this.txtTipoDeUsuario.UseVisualStyleBackColor = true;
            this.txtTipoDeUsuario.Click += new System.EventHandler(this.txtTipoDeUsuario_Click);
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.Location = new System.Drawing.Point(139, 154);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(140, 45);
            this.txtUsuarios.TabIndex = 2;
            this.txtUsuarios.Text = "Usuarios";
            this.txtUsuarios.UseVisualStyleBackColor = true;
            this.txtUsuarios.Click += new System.EventHandler(this.txtUsuarios_Click);
            // 
            // txtSalir
            // 
            this.txtSalir.Location = new System.Drawing.Point(356, 353);
            this.txtSalir.Name = "txtSalir";
            this.txtSalir.Size = new System.Drawing.Size(75, 23);
            this.txtSalir.TabIndex = 3;
            this.txtSalir.Text = "Salir";
            this.txtSalir.UseVisualStyleBackColor = true;
            this.txtSalir.Click += new System.EventHandler(this.txtSalir_Click);
            // 
            // btnPrivilegio
            // 
            this.btnPrivilegio.Location = new System.Drawing.Point(139, 256);
            this.btnPrivilegio.Name = "btnPrivilegio";
            this.btnPrivilegio.Size = new System.Drawing.Size(140, 45);
            this.btnPrivilegio.TabIndex = 4;
            this.btnPrivilegio.Text = "Privilegio";
            this.btnPrivilegio.UseVisualStyleBackColor = true;
            this.btnPrivilegio.Click += new System.EventHandler(this.btnPrivilegio_Click);
            // 
            // MenuSuperUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 388);
            this.Controls.Add(this.btnPrivilegio);
            this.Controls.Add(this.txtSalir);
            this.Controls.Add(this.txtUsuarios);
            this.Controls.Add(this.txtTipoDeUsuario);
            this.Controls.Add(this.txtPermisos);
            this.Name = "MenuSuperUser";
            this.Text = "MenuSuperUser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtPermisos;
        private System.Windows.Forms.Button txtTipoDeUsuario;
        private System.Windows.Forms.Button txtUsuarios;
        private System.Windows.Forms.Button txtSalir;
        private System.Windows.Forms.Button btnPrivilegio;
    }
}