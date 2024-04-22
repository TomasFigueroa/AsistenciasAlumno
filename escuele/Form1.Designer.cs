namespace escuele
{
    partial class Z
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Z));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Apellido = new System.Windows.Forms.Label();
            this.Txt_DNI = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Bt_cargar = new System.Windows.Forms.Button();
            this.Bt_Borrar = new System.Windows.Forms.Button();
            this.Bt_Modificar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.dataasistencia = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Bt_Cargar_Asis = new System.Windows.Forms.Button();
            this.Bt_Borrar_Asis = new System.Windows.Forms.Button();
            this.Bt_Modificar_Asis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.DateTimePicker();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Bt_Report = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataasistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(321, 34);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.Size = new System.Drawing.Size(542, 200);
            this.dataGrid.TabIndex = 0;
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.Location = new System.Drawing.Point(693, 406);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(136, 27);
            this.check.TabIndex = 1;
            this.check.Text = "Asistencia";
            this.check.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.AutoSize = true;
            this.Txt_Apellido.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Apellido.Location = new System.Drawing.Point(33, 174);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Size = new System.Drawing.Size(92, 23);
            this.Txt_Apellido.TabIndex = 4;
            this.Txt_Apellido.Text = "Apellido";
            this.Txt_Apellido.Click += new System.EventHandler(this.label3_Click);
            // 
            // Txt_DNI
            // 
            this.Txt_DNI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_DNI.Location = new System.Drawing.Point(37, 62);
            this.Txt_DNI.Name = "Txt_DNI";
            this.Txt_DNI.Size = new System.Drawing.Size(100, 22);
            this.Txt_DNI.TabIndex = 5;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_Nombre.Location = new System.Drawing.Point(37, 135);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(100, 22);
            this.Txt_Nombre.TabIndex = 6;
            // 
            // Bt_cargar
            // 
            this.Bt_cargar.BackColor = System.Drawing.Color.Lime;
            this.Bt_cargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_cargar.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_cargar.Location = new System.Drawing.Point(182, 62);
            this.Bt_cargar.Name = "Bt_cargar";
            this.Bt_cargar.Size = new System.Drawing.Size(133, 38);
            this.Bt_cargar.TabIndex = 8;
            this.Bt_cargar.Text = "CARGAR";
            this.Bt_cargar.UseVisualStyleBackColor = false;
            this.Bt_cargar.Click += new System.EventHandler(this.Bt_cargar_Click);
            // 
            // Bt_Borrar
            // 
            this.Bt_Borrar.BackColor = System.Drawing.Color.Red;
            this.Bt_Borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Borrar.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Borrar.Location = new System.Drawing.Point(182, 106);
            this.Bt_Borrar.Name = "Bt_Borrar";
            this.Bt_Borrar.Size = new System.Drawing.Size(133, 41);
            this.Bt_Borrar.TabIndex = 9;
            this.Bt_Borrar.Text = "BORRAR";
            this.Bt_Borrar.UseVisualStyleBackColor = false;
            this.Bt_Borrar.Click += new System.EventHandler(this.Bt_Borrar_Click);
            // 
            // Bt_Modificar
            // 
            this.Bt_Modificar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Bt_Modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Modificar.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Modificar.Location = new System.Drawing.Point(180, 163);
            this.Bt_Modificar.Name = "Bt_Modificar";
            this.Bt_Modificar.Size = new System.Drawing.Size(135, 40);
            this.Bt_Modificar.TabIndex = 10;
            this.Bt_Modificar.Text = "MODIFICAR";
            this.Bt_Modificar.UseVisualStyleBackColor = false;
            this.Bt_Modificar.Click += new System.EventHandler(this.Bt_Modificar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(39, 331);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 16);
            this.lblMensaje.TabIndex = 11;
            // 
            // apellido
            // 
            this.apellido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apellido.Location = new System.Drawing.Point(37, 200);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(100, 22);
            this.apellido.TabIndex = 12;
            // 
            // dataasistencia
            // 
            this.dataasistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataasistencia.Location = new System.Drawing.Point(321, 288);
            this.dataasistencia.Name = "dataasistencia";
            this.dataasistencia.RowHeadersWidth = 51;
            this.dataasistencia.RowTemplate.Height = 24;
            this.dataasistencia.Size = new System.Drawing.Size(344, 150);
            this.dataasistencia.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Alumnos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Asistencias";
            // 
            // Bt_Cargar_Asis
            // 
            this.Bt_Cargar_Asis.BackColor = System.Drawing.Color.Lime;
            this.Bt_Cargar_Asis.Location = new System.Drawing.Point(684, 297);
            this.Bt_Cargar_Asis.Name = "Bt_Cargar_Asis";
            this.Bt_Cargar_Asis.Size = new System.Drawing.Size(98, 29);
            this.Bt_Cargar_Asis.TabIndex = 16;
            this.Bt_Cargar_Asis.Text = "Cargar";
            this.Bt_Cargar_Asis.UseVisualStyleBackColor = false;
            this.Bt_Cargar_Asis.Click += new System.EventHandler(this.Bt_Cargar_Asis_Click);
            // 
            // Bt_Borrar_Asis
            // 
            this.Bt_Borrar_Asis.BackColor = System.Drawing.Color.Red;
            this.Bt_Borrar_Asis.Location = new System.Drawing.Point(217, 370);
            this.Bt_Borrar_Asis.Name = "Bt_Borrar_Asis";
            this.Bt_Borrar_Asis.Size = new System.Drawing.Size(98, 37);
            this.Bt_Borrar_Asis.TabIndex = 17;
            this.Bt_Borrar_Asis.Text = "Borrar";
            this.Bt_Borrar_Asis.UseVisualStyleBackColor = false;
            this.Bt_Borrar_Asis.Click += new System.EventHandler(this.Bt_Borrar_Asis_Click);
            // 
            // Bt_Modificar_Asis
            // 
            this.Bt_Modificar_Asis.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Bt_Modificar_Asis.Location = new System.Drawing.Point(217, 413);
            this.Bt_Modificar_Asis.Name = "Bt_Modificar_Asis";
            this.Bt_Modificar_Asis.Size = new System.Drawing.Size(98, 30);
            this.Bt_Modificar_Asis.TabIndex = 18;
            this.Bt_Modificar_Asis.Text = "Modificar";
            this.Bt_Modificar_Asis.UseVisualStyleBackColor = false;
            this.Bt_Modificar_Asis.Click += new System.EventHandler(this.Bt_Modificar_Asis_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(788, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(693, 370);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(200, 22);
            this.Time.TabIndex = 20;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(215, 342);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(100, 22);
            this.Txt_Codigo.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Codigo";
            // 
            // Bt_Report
            // 
            this.Bt_Report.Location = new System.Drawing.Point(905, 300);
            this.Bt_Report.Name = "Bt_Report";
            this.Bt_Report.Size = new System.Drawing.Size(75, 23);
            this.Bt_Report.TabIndex = 23;
            this.Bt_Report.Text = "Reporte";
            this.Bt_Report.UseVisualStyleBackColor = true;
            this.Bt_Report.Click += new System.EventHandler(this.Bt_Report_Click);
            // 
            // Z
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.Bt_Report);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Codigo);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bt_Modificar_Asis);
            this.Controls.Add(this.Bt_Borrar_Asis);
            this.Controls.Add(this.Bt_Cargar_Asis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataasistencia);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.Bt_Modificar);
            this.Controls.Add(this.Bt_Borrar);
            this.Controls.Add(this.Bt_cargar);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Txt_DNI);
            this.Controls.Add(this.Txt_Apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check);
            this.Controls.Add(this.dataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Z";
            this.Text = "ASISTENCIAS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataasistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.CheckBox check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Txt_Apellido;
        private System.Windows.Forms.TextBox Txt_DNI;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Button Bt_cargar;
        private System.Windows.Forms.Button Bt_Borrar;
        private System.Windows.Forms.Button Bt_Modificar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.DataGridView dataasistencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Bt_Cargar_Asis;
        private System.Windows.Forms.Button Bt_Borrar_Asis;
        private System.Windows.Forms.Button Bt_Modificar_Asis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker Time;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Bt_Report;
    }
}

