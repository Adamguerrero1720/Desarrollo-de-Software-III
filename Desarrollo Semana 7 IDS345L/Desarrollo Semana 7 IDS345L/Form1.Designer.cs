namespace Desarrollo_Semana_7_IDS345L
{
    partial class Form1
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
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.bto_Pagar = new System.Windows.Forms.Button();
            this.bton_VerListado = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.dtp_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaNacimiento = new System.Windows.Forms.Label();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.cb_TipoDoc = new System.Windows.Forms.ComboBox();
            this.lbl_TipoDoc = new System.Windows.Forms.Label();
            this.lbl_Documento = new System.Windows.Forms.Label();
            this.txt_Documento = new System.Windows.Forms.TextBox();
            this.cb_Sexo = new System.Windows.Forms.ComboBox();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.lbl_Nota = new System.Windows.Forms.Label();
            this.cb_Estado = new System.Windows.Forms.ComboBox();
            this.txt_Nota = new System.Windows.Forms.TextBox();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_MetodoPago = new System.Windows.Forms.Label();
            this.cb_MetodoPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bton_Imprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(35, 296);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(90, 25);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombres:";
            this.lbl_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bto_Pagar
            // 
            this.bto_Pagar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bto_Pagar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bto_Pagar.Location = new System.Drawing.Point(266, 517);
            this.bto_Pagar.Name = "bto_Pagar";
            this.bto_Pagar.Size = new System.Drawing.Size(99, 41);
            this.bto_Pagar.TabIndex = 10;
            this.bto_Pagar.Text = "Pagar";
            this.bto_Pagar.UseVisualStyleBackColor = true;
            this.bto_Pagar.Click += new System.EventHandler(this.bto_Pagar_Click);
            // 
            // bton_VerListado
            // 
            this.bton_VerListado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bton_VerListado.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bton_VerListado.Location = new System.Drawing.Point(517, 517);
            this.bton_VerListado.Name = "bton_VerListado";
            this.bton_VerListado.Size = new System.Drawing.Size(106, 41);
            this.bton_VerListado.TabIndex = 11;
            this.bton_VerListado.Text = "Listado";
            this.bton_VerListado.UseVisualStyleBackColor = true;
            this.bton_VerListado.Click += new System.EventHandler(this.bton_VerListado_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nombre.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(202, 288);
            this.txt_Nombre.MaxLength = 25;
            this.txt_Nombre.Multiline = true;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(195, 33);
            this.txt_Nombre.TabIndex = 3;
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // dtp_FechaNacimiento
            // 
            this.dtp_FechaNacimiento.CalendarForeColor = System.Drawing.Color.BurlyWood;
            this.dtp_FechaNacimiento.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtp_FechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaNacimiento.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dtp_FechaNacimiento.Location = new System.Drawing.Point(621, 244);
            this.dtp_FechaNacimiento.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtp_FechaNacimiento.MinDate = new System.DateTime(2023, 6, 15, 0, 0, 0, 0);
            this.dtp_FechaNacimiento.Name = "dtp_FechaNacimiento";
            this.dtp_FechaNacimiento.Size = new System.Drawing.Size(195, 31);
            this.dtp_FechaNacimiento.TabIndex = 6;
            // 
            // lbl_FechaNacimiento
            // 
            this.lbl_FechaNacimiento.AutoSize = true;
            this.lbl_FechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaNacimiento.Location = new System.Drawing.Point(440, 250);
            this.lbl_FechaNacimiento.Name = "lbl_FechaNacimiento";
            this.lbl_FechaNacimiento.Size = new System.Drawing.Size(156, 25);
            this.lbl_FechaNacimiento.TabIndex = 6;
            this.lbl_FechaNacimiento.Text = "Fecha Nacimiento:";
            this.lbl_FechaNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellidos.Location = new System.Drawing.Point(35, 343);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(90, 25);
            this.lbl_Apellidos.TabIndex = 7;
            this.lbl_Apellidos.Text = "Apellidos:";
            this.lbl_Apellidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Apellidos.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellidos.Location = new System.Drawing.Point(202, 334);
            this.txt_Apellidos.MaxLength = 25;
            this.txt_Apellidos.Multiline = true;
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(195, 34);
            this.txt_Apellidos.TabIndex = 4;
            this.txt_Apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Apellidos_KeyPress);
            // 
            // cb_TipoDoc
            // 
            this.cb_TipoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_TipoDoc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TipoDoc.FormattingEnabled = true;
            this.cb_TipoDoc.Location = new System.Drawing.Point(202, 192);
            this.cb_TipoDoc.Name = "cb_TipoDoc";
            this.cb_TipoDoc.Size = new System.Drawing.Size(195, 33);
            this.cb_TipoDoc.TabIndex = 1;
            this.cb_TipoDoc.TextChanged += new System.EventHandler(this.cb_TipoDoc_TextChanged);
            this.cb_TipoDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_TipoDoc_KeyPress);
            // 
            // lbl_TipoDoc
            // 
            this.lbl_TipoDoc.AutoSize = true;
            this.lbl_TipoDoc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoDoc.Location = new System.Drawing.Point(35, 200);
            this.lbl_TipoDoc.Name = "lbl_TipoDoc";
            this.lbl_TipoDoc.Size = new System.Drawing.Size(150, 25);
            this.lbl_TipoDoc.TabIndex = 10;
            this.lbl_TipoDoc.Text = "Tipo Documento:";
            this.lbl_TipoDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Documento
            // 
            this.lbl_Documento.AutoSize = true;
            this.lbl_Documento.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Documento.Location = new System.Drawing.Point(35, 250);
            this.lbl_Documento.Name = "lbl_Documento";
            this.lbl_Documento.Size = new System.Drawing.Size(110, 25);
            this.lbl_Documento.TabIndex = 11;
            this.lbl_Documento.Text = "Documento:";
            this.lbl_Documento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Documento
            // 
            this.txt_Documento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Documento.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Documento.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_Documento.Location = new System.Drawing.Point(202, 240);
            this.txt_Documento.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.txt_Documento.MaxLength = 13;
            this.txt_Documento.Multiline = true;
            this.txt_Documento.Name = "txt_Documento";
            this.txt_Documento.Size = new System.Drawing.Size(195, 35);
            this.txt_Documento.TabIndex = 2;
            this.txt_Documento.TextChanged += new System.EventHandler(this.txt_Documento_TextChanged);
            this.txt_Documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Documento_KeyPress);
            // 
            // cb_Sexo
            // 
            this.cb_Sexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Sexo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Sexo.FormattingEnabled = true;
            this.cb_Sexo.Location = new System.Drawing.Point(621, 192);
            this.cb_Sexo.Name = "cb_Sexo";
            this.cb_Sexo.Size = new System.Drawing.Size(195, 33);
            this.cb_Sexo.TabIndex = 5;
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sexo.Location = new System.Drawing.Point(440, 200);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(54, 25);
            this.lbl_Sexo.TabIndex = 14;
            this.lbl_Sexo.Text = "Sexo:";
            this.lbl_Sexo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Nota
            // 
            this.lbl_Nota.AutoSize = true;
            this.lbl_Nota.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nota.Location = new System.Drawing.Point(440, 298);
            this.lbl_Nota.Name = "lbl_Nota";
            this.lbl_Nota.Size = new System.Drawing.Size(55, 25);
            this.lbl_Nota.TabIndex = 15;
            this.lbl_Nota.Text = "Nota:";
            this.lbl_Nota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_Estado
            // 
            this.cb_Estado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Estado.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Estado.Location = new System.Drawing.Point(621, 335);
            this.cb_Estado.Name = "cb_Estado";
            this.cb_Estado.Size = new System.Drawing.Size(195, 33);
            this.cb_Estado.TabIndex = 8;
            // 
            // txt_Nota
            // 
            this.txt_Nota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nota.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nota.Location = new System.Drawing.Point(621, 290);
            this.txt_Nota.MaxLength = 50;
            this.txt_Nota.Multiline = true;
            this.txt_Nota.Name = "txt_Nota";
            this.txt_Nota.Size = new System.Drawing.Size(195, 33);
            this.txt_Nota.TabIndex = 7;
            this.txt_Nota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nota_KeyPress);
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado.Location = new System.Drawing.Point(440, 346);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(70, 25);
            this.lbl_Estado.TabIndex = 17;
            this.lbl_Estado.Text = "Estado:";
            this.lbl_Estado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_MetodoPago
            // 
            this.lbl_MetodoPago.AutoSize = true;
            this.lbl_MetodoPago.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MetodoPago.Location = new System.Drawing.Point(213, 427);
            this.lbl_MetodoPago.Name = "lbl_MetodoPago";
            this.lbl_MetodoPago.Size = new System.Drawing.Size(152, 25);
            this.lbl_MetodoPago.TabIndex = 18;
            this.lbl_MetodoPago.Text = "Metodo de pago:";
            this.lbl_MetodoPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_MetodoPago
            // 
            this.cb_MetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_MetodoPago.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MetodoPago.FormattingEnabled = true;
            this.cb_MetodoPago.Location = new System.Drawing.Point(371, 424);
            this.cb_MetodoPago.Name = "cb_MetodoPago";
            this.cb_MetodoPago.Size = new System.Drawing.Size(195, 33);
            this.cb_MetodoPago.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(560, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monto a pagar: 9,000 DOP";
            // 
            // bton_Imprimir
            // 
            this.bton_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bton_Imprimir.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bton_Imprimir.Location = new System.Drawing.Point(388, 517);
            this.bton_Imprimir.Name = "bton_Imprimir";
            this.bton_Imprimir.Size = new System.Drawing.Size(106, 41);
            this.bton_Imprimir.TabIndex = 19;
            this.bton_Imprimir.Text = "Imprimir";
            this.bton_Imprimir.UseVisualStyleBackColor = true;
            this.bton_Imprimir.Click += new System.EventHandler(this.bton_Imprimir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(868, 600);
            this.Controls.Add(this.bton_Imprimir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_MetodoPago);
            this.Controls.Add(this.lbl_MetodoPago);
            this.Controls.Add(this.lbl_Estado);
            this.Controls.Add(this.txt_Nota);
            this.Controls.Add(this.lbl_Nota);
            this.Controls.Add(this.lbl_Sexo);
            this.Controls.Add(this.cb_Sexo);
            this.Controls.Add(this.txt_Documento);
            this.Controls.Add(this.lbl_Documento);
            this.Controls.Add(this.lbl_TipoDoc);
            this.Controls.Add(this.cb_TipoDoc);
            this.Controls.Add(this.txt_Apellidos);
            this.Controls.Add(this.lbl_Apellidos);
            this.Controls.Add(this.lbl_FechaNacimiento);
            this.Controls.Add(this.dtp_FechaNacimiento);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.cb_Estado);
            this.Controls.Add(this.bton_VerListado);
            this.Controls.Add(this.bto_Pagar);
            this.Controls.Add(this.lbl_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Button bto_Pagar;
        private System.Windows.Forms.Button bton_VerListado;
        private System.Windows.Forms.Label lbl_FechaNacimiento;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.ComboBox cb_TipoDoc;
        private System.Windows.Forms.Label lbl_TipoDoc;
        private System.Windows.Forms.Label lbl_Documento;
        private System.Windows.Forms.ComboBox cb_Sexo;
        private System.Windows.Forms.Label lbl_Sexo;
        private System.Windows.Forms.Label lbl_Nota;
        private System.Windows.Forms.ComboBox cb_Estado;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_MetodoPago;
        private System.Windows.Forms.ComboBox cb_MetodoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.TextBox txt_Documento;
        private System.Windows.Forms.TextBox txt_Nota;
        private System.Windows.Forms.DateTimePicker dtp_FechaNacimiento;
        private System.Windows.Forms.Button bton_Imprimir;
    }
}

