namespace ProyectoOctavo.PantallaPermisosUsuario
{
    partial class CrearPrivilegio
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNamePrivilegio = new System.Windows.Forms.TextBox();
            this.chkbActivoOrNot = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNamePrivilegio
            // 
            this.txtNamePrivilegio.Location = new System.Drawing.Point(65, 107);
            this.txtNamePrivilegio.Name = "txtNamePrivilegio";
            this.txtNamePrivilegio.Size = new System.Drawing.Size(121, 20);
            this.txtNamePrivilegio.TabIndex = 1;
            // 
            // chkbActivoOrNot
            // 
            this.chkbActivoOrNot.AutoSize = true;
            this.chkbActivoOrNot.Location = new System.Drawing.Point(92, 133);
            this.chkbActivoOrNot.Name = "chkbActivoOrNot";
            this.chkbActivoOrNot.Size = new System.Drawing.Size(59, 17);
            this.chkbActivoOrNot.TabIndex = 3;
            this.chkbActivoOrNot.Text = "Activar";
            this.chkbActivoOrNot.UseVisualStyleBackColor = true;
            this.chkbActivoOrNot.CheckedChanged += new System.EventHandler(this.chkbActivoOrNot_CheckedChanged);
            // 
            // CrearPrivilegio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 252);
            this.Controls.Add(this.chkbActivoOrNot);
            this.Controls.Add(this.txtNamePrivilegio);
            this.Controls.Add(this.button1);
            this.Name = "CrearPrivilegio";
            this.Text = "CrearPrivilegio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNamePrivilegio;
        private System.Windows.Forms.CheckBox chkbActivoOrNot;
    }
}