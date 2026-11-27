namespace NOMINA_QUINCENAL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnRegistrar = new Button();
            btnResumen = new Button();
            btnSalir = new Button();
            btnLimpiar = new Button();
            chkTransporte = new CheckBox();
            txtNombre = new TextBox();
            cmbCargo = new ComboBox();
            rdbFijo = new RadioButton();
            rdbTemporal = new RadioButton();
            txtHoras = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lstNomina = new ListBox();
            groupBox4 = new GroupBox();
            lblNeto = new Label();
            lblDeducciones = new Label();
            lblBruto = new Label();
            lblEmpleados = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 49);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 113);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 1;
            label2.Text = "Contrato:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 43);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 2;
            label3.Text = "Cargo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 92);
            label4.Name = "label4";
            label4.Size = new Size(268, 25);
            label4.TabIndex = 3;
            label4.Text = "Horas trabajadas en la quincena:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(5, 240);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(385, 34);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar empleado";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(9, 501);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(242, 34);
            btnResumen.TabIndex = 5;
            btnResumen.Text = "Mostrar resumen";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(669, 501);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(212, 34);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(345, 501);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(220, 34);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // chkTransporte
            // 
            chkTransporte.AutoSize = true;
            chkTransporte.Location = new Point(5, 182);
            chkTransporte.Name = "chkTransporte";
            chkTransporte.Size = new Size(277, 29);
            chkTransporte.TabIndex = 8;
            chkTransporte.Text = "Recibe incentivo de transporte";
            chkTransporte.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(93, 49);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(297, 31);
            txtNombre.TabIndex = 9;
            // 
            // cmbCargo
            // 
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new Point(76, 43);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(270, 33);
            cmbCargo.TabIndex = 10;
            // 
            // rdbFijo
            // 
            rdbFijo.AutoSize = true;
            rdbFijo.Location = new Point(98, 113);
            rdbFijo.Name = "rdbFijo";
            rdbFijo.Size = new Size(65, 29);
            rdbFijo.TabIndex = 11;
            rdbFijo.TabStop = true;
            rdbFijo.Text = "Fijo";
            rdbFijo.UseVisualStyleBackColor = true;
            // 
            // rdbTemporal
            // 
            rdbTemporal.AutoSize = true;
            rdbTemporal.Location = new Point(182, 113);
            rdbTemporal.Name = "rdbTemporal";
            rdbTemporal.Size = new Size(110, 29);
            rdbTemporal.TabIndex = 12;
            rdbTemporal.TabStop = true;
            rdbTemporal.Text = "Temporal";
            rdbTemporal.UseVisualStyleBackColor = true;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(6, 129);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(150, 31);
            txtHoras.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(rdbTemporal);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rdbFijo);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 167);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del empleado";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cmbCargo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(chkTransporte);
            groupBox2.Controls.Add(txtHoras);
            groupBox2.Controls.Add(btnRegistrar);
            groupBox2.Location = new Point(11, 185);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(396, 297);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registro de pago";
            // 
            // lstNomina
            // 
            lstNomina.FormattingEnabled = true;
            lstNomina.Location = new Point(433, 42);
            lstNomina.Name = "lstNomina";
            lstNomina.Size = new Size(448, 204);
            lstNomina.TabIndex = 17;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblNeto);
            groupBox4.Controls.Add(lblDeducciones);
            groupBox4.Controls.Add(lblBruto);
            groupBox4.Controls.Add(lblEmpleados);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(425, 252);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(456, 230);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Resumen";
            // 
            // lblNeto
            // 
            lblNeto.AutoSize = true;
            lblNeto.Location = new Point(244, 182);
            lblNeto.Name = "lblNeto";
            lblNeto.Size = new Size(22, 25);
            lblNeto.TabIndex = 7;
            lblNeto.Text = "0";
            // 
            // lblDeducciones
            // 
            lblDeducciones.AutoSize = true;
            lblDeducciones.Location = new Point(244, 131);
            lblDeducciones.Name = "lblDeducciones";
            lblDeducciones.Size = new Size(22, 25);
            lblDeducciones.TabIndex = 6;
            lblDeducciones.Text = "0";
            // 
            // lblBruto
            // 
            lblBruto.AutoSize = true;
            lblBruto.Location = new Point(244, 84);
            lblBruto.Name = "lblBruto";
            lblBruto.Size = new Size(22, 25);
            lblBruto.TabIndex = 5;
            lblBruto.Text = "0";
            // 
            // lblEmpleados
            // 
            lblEmpleados.AutoSize = true;
            lblEmpleados.Location = new Point(244, 39);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(22, 25);
            lblEmpleados.TabIndex = 4;
            lblEmpleados.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 178);
            label8.Name = "label8";
            label8.Size = new Size(94, 25);
            label8.TabIndex = 3;
            label8.Text = "Total neto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 131);
            label7.Name = "label7";
            label7.Size = new Size(157, 25);
            label7.TabIndex = 2;
            label7.Text = "Total deducciones:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 84);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 1;
            label6.Text = "Total bruto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 39);
            label5.Name = "label5";
            label5.Size = new Size(198, 25);
            label5.TabIndex = 0;
            label5.Text = "Empleados registrados:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(433, 14);
            label9.Name = "label9";
            label9.Size = new Size(159, 25);
            label9.TabIndex = 18;
            label9.Text = "Nomina registrada";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 560);
            Controls.Add(label9);
            Controls.Add(lstNomina);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(btnResumen);
            Name = "Form1";
            Text = "Nomina Quincenal";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRegistrar;
        private Button btnResumen;
        private Button btnSalir;
        private Button btnLimpiar;
        private CheckBox chkTransporte;
        private TextBox txtNombre;
        private ComboBox cmbCargo;
        private RadioButton rdbFijo;
        private RadioButton rdbTemporal;
        private TextBox txtHoras;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox lstNomina;
        private GroupBox groupBox4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lblNeto;
        private Label lblDeducciones;
        private Label lblBruto;
        private Label lblEmpleados;
        private Label label9;
    }
}
