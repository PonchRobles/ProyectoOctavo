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
            this.button1 = new System.Windows.Forms.Button();
            this.txtDarTipoUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPermisos
            // 
            this.txtPermisos.Location = new System.Drawing.Point(13, 7);
            this.txtPermisos.Name = "txtPermisos";
            this.txtPermisos.Size = new System.Drawing.Size(140, 45);
            this.txtPermisos.TabIndex = 0;
            this.txtPermisos.Text = "Ver Permisos";
            this.txtPermisos.UseVisualStyleBackColor = true;
            this.txtPermisos.Click += new System.EventHandler(this.txtPermisos_Click);
            // 
            // txtTipoDeUsuario
            // 
            this.txtTipoDeUsuario.Location = new System.Drawing.Point(13, 58);
            this.txtTipoDeUsuario.Name = "txtTipoDeUsuario";
            this.txtTipoDeUsuario.Size = new System.Drawing.Size(140, 45);
            this.txtTipoDeUsuario.TabIndex = 1;
            this.txtTipoDeUsuario.Text = "Crear Tipo de Usuario";
            this.txtTipoDeUsuario.UseVisualStyleBackColor = true;
            this.txtTipoDeUsuario.Click += new System.EventHandler(this.txtTipoDeUsuario_Click);
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.Location = new System.Drawing.Point(159, 58);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(140, 45);
            this.txtUsuarios.TabIndex = 2;
            this.txtUsuarios.Text = "Crear Usuarios";
            this.txtUsuarios.UseVisualStyleBackColor = true;
            this.txtUsuarios.Click += new System.EventHandler(this.txtUsuarios_Click);
            // 
            // txtSalir
            // 
            this.txtSalir.Location = new System.Drawing.Point(118, 212);
            this.txtSalir.Name = "txtSalir";
            this.txtSalir.Size = new System.Drawing.Size(75, 23);
            this.txtSalir.TabIndex = 3;
            this.txtSalir.Text = "Salir";
            this.txtSalir.UseVisualStyleBackColor = true;
            this.txtSalir.Click += new System.EventHandler(this.txtSalir_Click);
            // 
            // btnPrivilegio
            // 
            this.btnPrivilegio.Location = new System.Drawing.Point(159, 7);
            this.btnPrivilegio.Name = "btnPrivilegio";
            this.btnPrivilegio.Size = new System.Drawing.Size(140, 45);
            this.btnPrivilegio.TabIndex = 4;
            this.btnPrivilegio.Text = "Crear Privilegio";
            this.btnPrivilegio.UseVisualStyleBackColor = true;
            this.btnPrivilegio.Click += new System.EventHandler(this.btnPrivilegio_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "VistaTotal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDarTipoUser
            // 
            this.txtDarTipoUser.Location = new System.Drawing.Point(90, 109);
            this.txtDarTipoUser.Name = "txtDarTipoUser";
            this.txtDarTipoUser.Size = new System.Drawing.Size(130, 42);
            this.txtDarTipoUser.TabIndex = 6;
            this.txtDarTipoUser.Text = "Dar Tipo a usuario";
            this.txtDarTipoUser.UseVisualStyleBackColor = true;
            this.txtDarTipoUser.Click += new System.EventHandler(this.txtDarTipoUser_Click);
            // 
            // MenuSuperUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 388);
            this.Controls.Add(this.txtDarTipoUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrivilegio);
            this.Controls.Add(this.txtSalir);
            this.Controls.Add(this.txtUsuarios);
            this.Controls.Add(this.txtTipoDeUsuario);
            this.Controls.Add(this.txtPermisos);
            this.Name = "MenuSuperUser";
            this.Text = "MenuSuperUser";
            this.Load += new System.EventHandler(this.MenuSuperUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtPermisos;
        private System.Windows.Forms.Button txtTipoDeUsuario;
        private System.Windows.Forms.Button txtUsuarios;
        private System.Windows.Forms.Button txtSalir;
        private System.Windows.Forms.Button btnPrivilegio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txtDarTipoUser;
    }
}