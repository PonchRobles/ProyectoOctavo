namespace ProyectoOctavo.PantallaPermisosUsuario
{
    partial class DarTipoAUsuario
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.typeUserBindingSource = new System.Windows.Forms.BindingSource(this.components);   this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.privilegiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.privilegiosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.privilegiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.privilegiosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.usersBindingSource;
            this.comboBox1.DisplayMember = "NameUser";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(76, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "IdUser";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // usersBindingSource
         
            // comboBox3
            // 
            this.comboBox3.DataSource = this.privilegiosBindingSource;
            this.comboBox3.DisplayMember = "NamePrivilegio";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(76, 128);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.ValueMember = "IdPrivilegio";
            // 
            // privilegiosBindingSource
            // 
       
            // 
            this.btnCrear.Location = new System.Drawing.Point(76, 170);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(75, 200);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // DarTipoAUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "DarTipoAUsuario";
            this.Text = "DarTipoAUsuario";
            this.Load += new System.EventHandler(this.DarTipoAUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.privilegiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.privilegiosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
      
        private System.Windows.Forms.BindingSource usersBindingSource;
       
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource typeUserBindingSource;
       
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource privilegiosBindingSource;
     
        private System.Windows.Forms.BindingSource privilegiosBindingSource1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnRegresar;
    }
}