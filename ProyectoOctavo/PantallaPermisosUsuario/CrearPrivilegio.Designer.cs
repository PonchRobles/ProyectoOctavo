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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNamePrivilegio = new System.Windows.Forms.TextBox();
            this.chkbActivoOrNot = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.privilegiosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
          
            this.privilegiosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.privilegiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.privilegiosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.privilegiosBindingSource3)).BeginInit();
         
            ((System.ComponentModel.ISupportInitialize)(this.privilegiosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.privilegiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.privilegiosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNamePrivilegio
            // 
            this.txtNamePrivilegio.Location = new System.Drawing.Point(17, 22);
            this.txtNamePrivilegio.Name = "txtNamePrivilegio";
            this.txtNamePrivilegio.Size = new System.Drawing.Size(121, 20);
            this.txtNamePrivilegio.TabIndex = 1;
            // 
            // chkbActivoOrNot
            // 
            this.chkbActivoOrNot.AutoSize = true;
            this.chkbActivoOrNot.Location = new System.Drawing.Point(44, 48);
            this.chkbActivoOrNot.Name = "chkbActivoOrNot";
            this.chkbActivoOrNot.Size = new System.Drawing.Size(59, 17);
            this.chkbActivoOrNot.TabIndex = 3;
            this.chkbActivoOrNot.Text = "Activar";
            this.chkbActivoOrNot.UseVisualStyleBackColor = true;
            this.chkbActivoOrNot.CheckedChanged += new System.EventHandler(this.chkbActivoOrNot_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // privilegiosBindingSource3
          
            // 
            // CrearPrivilegio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 157);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chkbActivoOrNot);
            this.Controls.Add(this.txtNamePrivilegio);
            this.Controls.Add(this.button1);
            this.Name = "CrearPrivilegio";
            this.Text = "CrearPrivilegio";
            this.Load += new System.EventHandler(this.CrearPrivilegio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.privilegiosBindingSource3)).EndInit();
          
            ((System.ComponentModel.ISupportInitialize)(this.privilegiosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.privilegiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.privilegiosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNamePrivilegio;
        private System.Windows.Forms.CheckBox chkbActivoOrNot;
        private System.Windows.Forms.Button button2;
   
        private System.Windows.Forms.BindingSource privilegiosBindingSource;
       
        private System.Windows.Forms.BindingSource privilegiosBindingSource1;
        private System.Windows.Forms.BindingSource privilegiosBindingSource3;
        private System.Windows.Forms.BindingSource privilegiosBindingSource2;
    }
}