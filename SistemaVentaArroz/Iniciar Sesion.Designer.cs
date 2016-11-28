namespace SistemaVentaArroz
{
    partial class Iniciar_Sesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Iniciar_Sesion));
            this.ContraseñatextBox = new System.Windows.Forms.TextBox();
            this.IniciarSesionbutton = new System.Windows.Forms.Button();
            this.MostrarContrasenacheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UsuarioerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ContrasenaerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrasenaerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ContraseñatextBox
            // 
            this.ContraseñatextBox.Location = new System.Drawing.Point(193, 135);
            this.ContraseñatextBox.Name = "ContraseñatextBox";
            this.ContraseñatextBox.PasswordChar = '*';
            this.ContraseñatextBox.Size = new System.Drawing.Size(148, 22);
            this.ContraseñatextBox.TabIndex = 16;
            // 
            // IniciarSesionbutton
            // 
            this.IniciarSesionbutton.Location = new System.Drawing.Point(193, 190);
            this.IniciarSesionbutton.Name = "IniciarSesionbutton";
            this.IniciarSesionbutton.Size = new System.Drawing.Size(111, 36);
            this.IniciarSesionbutton.TabIndex = 15;
            this.IniciarSesionbutton.Text = "Iniciar Sesion";
            this.IniciarSesionbutton.UseVisualStyleBackColor = true;
            this.IniciarSesionbutton.Click += new System.EventHandler(this.IniciarSesionbutton_Click);
            // 
            // MostrarContrasenacheckBox
            // 
            this.MostrarContrasenacheckBox.AutoSize = true;
            this.MostrarContrasenacheckBox.Location = new System.Drawing.Point(194, 163);
            this.MostrarContrasenacheckBox.Name = "MostrarContrasenacheckBox";
            this.MostrarContrasenacheckBox.Size = new System.Drawing.Size(155, 21);
            this.MostrarContrasenacheckBox.TabIndex = 14;
            this.MostrarContrasenacheckBox.Text = "Mostrar Contraseña";
            this.MostrarContrasenacheckBox.UseVisualStyleBackColor = true;
            this.MostrarContrasenacheckBox.CheckedChanged += new System.EventHandler(this.MostrarContrasenacheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 53);
            this.label3.TabIndex = 13;
            this.label3.Text = "Login";
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(194, 107);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(147, 22);
            this.UsuariotextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usuario";
            // 
            // UsuarioerrorProvider
            // 
            this.UsuarioerrorProvider.ContainerControl = this;
            // 
            // ContrasenaerrorProvider
            // 
            this.ContrasenaerrorProvider.ContainerControl = this;
            // 
            // Iniciar_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(469, 242);
            this.Controls.Add(this.ContraseñatextBox);
            this.Controls.Add(this.IniciarSesionbutton);
            this.Controls.Add(this.MostrarContrasenacheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Iniciar_Sesion";
            this.Text = "Iniciar_Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrasenaerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ContraseñatextBox;
        private System.Windows.Forms.Button IniciarSesionbutton;
        private System.Windows.Forms.CheckBox MostrarContrasenacheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider UsuarioerrorProvider;
        private System.Windows.Forms.ErrorProvider ContrasenaerrorProvider;
    }
}