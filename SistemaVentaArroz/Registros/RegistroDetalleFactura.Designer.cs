namespace SistemaVentaArroz.Registros
{
    partial class RegistroDetalleFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroDetalleFactura));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProductocomboBox = new System.Windows.Forms.ComboBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.ProductosdataGridView = new System.Windows.Forms.DataGridView();
            this.Idbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.FechaVentadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.IdClientetextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductocomboBox);
            this.groupBox1.Controls.Add(this.Agregarbutton);
            this.groupBox1.Controls.Add(this.ProductosdataGridView);
            this.groupBox1.Location = new System.Drawing.Point(14, 141);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(499, 223);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista";
            // 
            // ProductocomboBox
            // 
            this.ProductocomboBox.FormattingEnabled = true;
            this.ProductocomboBox.Location = new System.Drawing.Point(21, 32);
            this.ProductocomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductocomboBox.Name = "ProductocomboBox";
            this.ProductocomboBox.Size = new System.Drawing.Size(161, 24);
            this.ProductocomboBox.TabIndex = 62;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(379, 32);
            this.Agregarbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(84, 30);
            this.Agregarbutton.TabIndex = 61;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // ProductosdataGridView
            // 
            this.ProductosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosdataGridView.Location = new System.Drawing.Point(21, 66);
            this.ProductosdataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductosdataGridView.Name = "ProductosdataGridView";
            this.ProductosdataGridView.RowTemplate.Height = 24;
            this.ProductosdataGridView.Size = new System.Drawing.Size(440, 150);
            this.ProductosdataGridView.TabIndex = 59;
            // 
            // Idbutton
            // 
            this.Idbutton.Image = ((System.Drawing.Image)(resources.GetObject("Idbutton.Image")));
            this.Idbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Idbutton.Location = new System.Drawing.Point(142, 18);
            this.Idbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Idbutton.Name = "Idbutton";
            this.Idbutton.Size = new System.Drawing.Size(89, 43);
            this.Idbutton.TabIndex = 86;
            this.Idbutton.Text = "Id";
            this.Idbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Idbutton.UseVisualStyleBackColor = true;
            this.Idbutton.Click += new System.EventHandler(this.Idbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(14, 384);
            this.Nuevobutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(103, 41);
            this.Nuevobutton.TabIndex = 85;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(270, 384);
            this.Eliminarbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(103, 41);
            this.Eliminarbutton.TabIndex = 84;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(142, 384);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(103, 41);
            this.Guardarbutton.TabIndex = 83;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 82;
            this.label5.Text = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 17);
            this.label6.TabIndex = 81;
            this.label6.Text = "Id";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(14, 28);
            this.IdtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(78, 22);
            this.IdtextBox.TabIndex = 79;
            // 
            // FechaVentadateTimePicker
            // 
            this.FechaVentadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaVentadateTimePicker.Location = new System.Drawing.Point(396, 104);
            this.FechaVentadateTimePicker.Name = "FechaVentadateTimePicker";
            this.FechaVentadateTimePicker.Size = new System.Drawing.Size(93, 22);
            this.FechaVentadateTimePicker.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 90;
            this.label1.Text = "FechaVenta";
            // 
            // IdClientetextBox
            // 
            this.IdClientetextBox.Location = new System.Drawing.Point(12, 103);
            this.IdClientetextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdClientetextBox.Name = "IdClientetextBox";
            this.IdClientetextBox.Size = new System.Drawing.Size(80, 22);
            this.IdClientetextBox.TabIndex = 91;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(248, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 43);
            this.button1.TabIndex = 92;
            this.button1.Text = "Id";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(116, 103);
            this.NombretextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(115, 22);
            this.NombretextBox.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 94;
            this.label2.Text = "Nombre";
            // 
            // RegistroDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 435);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IdClientetextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaVentadateTimePicker);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Idbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IdtextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroDetalleFactura";
            this.Text = "RegistroDetalleFactura";
            this.Load += new System.EventHandler(this.RegistroDetalleFactura_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ProductocomboBox;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.DataGridView ProductosdataGridView;
        private System.Windows.Forms.Button Idbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.DateTimePicker FechaVentadateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdClientetextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Label label2;
    }
}