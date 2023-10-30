namespace MotorSAC
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
            gbSede = new GroupBox();
            cbDistritos = new ComboBox();
            btCancelaRegistroSede = new Button();
            btRegistroSede = new Button();
            label1 = new Label();
            lbNombreSede = new Label();
            tbNombreSede = new TextBox();
            lvSedes = new ListView();
            gbAuto = new GroupBox();
            btCancelaRegistroAuto = new Button();
            btRegistrarAuto = new Button();
            cbCateg = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            tbNombreAuto = new TextBox();
            lvAutos = new ListView();
            gpVenta = new GroupBox();
            cbAutoVenta = new ComboBox();
            label6 = new Label();
            tbVenta = new TextBox();
            CancelarRegistrarVenta = new Button();
            btRegistrarVenta = new Button();
            cbSedeVenta = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            Totales = new GroupBox();
            lbtu = new Label();
            label9 = new Label();
            lbtv = new Label();
            label7 = new Label();
            gbSede.SuspendLayout();
            gbAuto.SuspendLayout();
            gpVenta.SuspendLayout();
            Totales.SuspendLayout();
            SuspendLayout();
            // 
            // gbSede
            // 
            gbSede.BackColor = Color.FromArgb(255, 192, 128);
            gbSede.Controls.Add(cbDistritos);
            gbSede.Controls.Add(btCancelaRegistroSede);
            gbSede.Controls.Add(btRegistroSede);
            gbSede.Controls.Add(label1);
            gbSede.Controls.Add(lbNombreSede);
            gbSede.Controls.Add(tbNombreSede);
            gbSede.Location = new Point(26, 15);
            gbSede.Margin = new Padding(4);
            gbSede.Name = "gbSede";
            gbSede.Padding = new Padding(4);
            gbSede.Size = new Size(360, 324);
            gbSede.TabIndex = 0;
            gbSede.TabStop = false;
            gbSede.Text = "Registro de sedes :";
            // 
            // cbDistritos
            // 
            cbDistritos.FormattingEnabled = true;
            cbDistritos.Location = new Point(14, 145);
            cbDistritos.Margin = new Padding(4);
            cbDistritos.Name = "cbDistritos";
            cbDistritos.Size = new Size(316, 33);
            cbDistritos.TabIndex = 6;
            cbDistritos.Text = "Seleccione Distrito de la Sede";
            // 
            // btCancelaRegistroSede
            // 
            btCancelaRegistroSede.Location = new Point(214, 266);
            btCancelaRegistroSede.Margin = new Padding(4);
            btCancelaRegistroSede.Name = "btCancelaRegistroSede";
            btCancelaRegistroSede.Size = new Size(118, 36);
            btCancelaRegistroSede.TabIndex = 5;
            btCancelaRegistroSede.Text = "Cancelar";
            btCancelaRegistroSede.UseVisualStyleBackColor = true;
            btCancelaRegistroSede.Click += btCancelaRegistroSede_Click;
            // 
            // btRegistroSede
            // 
            btRegistroSede.Location = new Point(14, 266);
            btRegistroSede.Margin = new Padding(4);
            btRegistroSede.Name = "btRegistroSede";
            btRegistroSede.Size = new Size(118, 36);
            btRegistroSede.TabIndex = 4;
            btRegistroSede.Text = "Registrar";
            btRegistroSede.UseVisualStyleBackColor = true;
            btRegistroSede.Click += btRegistroSede_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 109);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 3;
            label1.Text = "Distrito de la sede";
            // 
            // lbNombreSede
            // 
            lbNombreSede.AutoSize = true;
            lbNombreSede.Location = new Point(8, 29);
            lbNombreSede.Margin = new Padding(4, 0, 4, 0);
            lbNombreSede.Name = "lbNombreSede";
            lbNombreSede.Size = new Size(163, 25);
            lbNombreSede.TabIndex = 1;
            lbNombreSede.Text = "Nombre de la sede";
            // 
            // tbNombreSede
            // 
            tbNombreSede.Location = new Point(14, 58);
            tbNombreSede.Margin = new Padding(4);
            tbNombreSede.Name = "tbNombreSede";
            tbNombreSede.Size = new Size(323, 31);
            tbNombreSede.TabIndex = 0;
            tbNombreSede.TextChanged += tbNombreSede_TextChanged;
            // 
            // lvSedes
            // 
            lvSedes.BackColor = Color.FromArgb(255, 192, 128);
            lvSedes.Location = new Point(26, 364);
            lvSedes.Margin = new Padding(4);
            lvSedes.Name = "lvSedes";
            lvSedes.Size = new Size(360, 255);
            lvSedes.TabIndex = 1;
            lvSedes.UseCompatibleStateImageBehavior = false;
            // 
            // gbAuto
            // 
            gbAuto.BackColor = Color.FromArgb(192, 255, 192);
            gbAuto.Controls.Add(btCancelaRegistroAuto);
            gbAuto.Controls.Add(btRegistrarAuto);
            gbAuto.Controls.Add(cbCateg);
            gbAuto.Controls.Add(label2);
            gbAuto.Controls.Add(label3);
            gbAuto.Controls.Add(tbNombreAuto);
            gbAuto.Location = new Point(450, 15);
            gbAuto.Margin = new Padding(4);
            gbAuto.Name = "gbAuto";
            gbAuto.Padding = new Padding(4);
            gbAuto.Size = new Size(360, 324);
            gbAuto.TabIndex = 2;
            gbAuto.TabStop = false;
            gbAuto.Text = "Registro de autos:";
            // 
            // btCancelaRegistroAuto
            // 
            btCancelaRegistroAuto.Location = new Point(214, 266);
            btCancelaRegistroAuto.Margin = new Padding(4);
            btCancelaRegistroAuto.Name = "btCancelaRegistroAuto";
            btCancelaRegistroAuto.Size = new Size(118, 36);
            btCancelaRegistroAuto.TabIndex = 8;
            btCancelaRegistroAuto.Text = "Cancelar";
            btCancelaRegistroAuto.UseVisualStyleBackColor = true;
            btCancelaRegistroAuto.Click += btCancelaRegistroAuto_Click;
            // 
            // btRegistrarAuto
            // 
            btRegistrarAuto.Location = new Point(21, 266);
            btRegistrarAuto.Margin = new Padding(4);
            btRegistrarAuto.Name = "btRegistrarAuto";
            btRegistrarAuto.Size = new Size(118, 36);
            btRegistrarAuto.TabIndex = 7;
            btRegistrarAuto.Text = "Registrar";
            btRegistrarAuto.UseVisualStyleBackColor = true;
            btRegistrarAuto.Click += btRegistrarAuto_Click;
            // 
            // cbCateg
            // 
            cbCateg.FormattingEnabled = true;
            cbCateg.Location = new Point(14, 145);
            cbCateg.Margin = new Padding(4);
            cbCateg.Name = "cbCateg";
            cbCateg.Size = new Size(316, 33);
            cbCateg.TabIndex = 6;
            cbCateg.Text = "Seleccione Categoría del Vehículo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 109);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 25);
            label2.TabIndex = 3;
            label2.Text = "Categoría del Vehículo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 29);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 1;
            label3.Text = "Nombre vehiculo";
            // 
            // tbNombreAuto
            // 
            tbNombreAuto.Location = new Point(21, 58);
            tbNombreAuto.Margin = new Padding(4);
            tbNombreAuto.Name = "tbNombreAuto";
            tbNombreAuto.Size = new Size(323, 31);
            tbNombreAuto.TabIndex = 0;
            // 
            // lvAutos
            // 
            lvAutos.BackColor = Color.FromArgb(192, 255, 192);
            lvAutos.Location = new Point(450, 364);
            lvAutos.Margin = new Padding(4);
            lvAutos.Name = "lvAutos";
            lvAutos.Size = new Size(360, 255);
            lvAutos.TabIndex = 3;
            lvAutos.UseCompatibleStateImageBehavior = false;
            // 
            // gpVenta
            // 
            gpVenta.BackColor = Color.FromArgb(128, 255, 255);
            gpVenta.Controls.Add(cbAutoVenta);
            gpVenta.Controls.Add(label6);
            gpVenta.Controls.Add(tbVenta);
            gpVenta.Controls.Add(CancelarRegistrarVenta);
            gpVenta.Controls.Add(btRegistrarVenta);
            gpVenta.Controls.Add(cbSedeVenta);
            gpVenta.Controls.Add(label4);
            gpVenta.Controls.Add(label5);
            gpVenta.Location = new Point(885, 15);
            gpVenta.Margin = new Padding(4);
            gpVenta.Name = "gpVenta";
            gpVenta.Padding = new Padding(4);
            gpVenta.Size = new Size(360, 324);
            gpVenta.TabIndex = 4;
            gpVenta.TabStop = false;
            gpVenta.Text = "Asignación de Venta";
            // 
            // cbAutoVenta
            // 
            cbAutoVenta.FormattingEnabled = true;
            cbAutoVenta.Location = new Point(14, 56);
            cbAutoVenta.Margin = new Padding(4);
            cbAutoVenta.Name = "cbAutoVenta";
            cbAutoVenta.Size = new Size(316, 33);
            cbAutoVenta.TabIndex = 11;
            cbAutoVenta.Text = "Seleccione Unidad Vehicular";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 215);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(140, 25);
            label6.TabIndex = 10;
            label6.Text = "Monto de Venta";
            // 
            // tbVenta
            // 
            tbVenta.Location = new Point(175, 206);
            tbVenta.Margin = new Padding(4);
            tbVenta.Name = "tbVenta";
            tbVenta.Size = new Size(155, 31);
            tbVenta.TabIndex = 9;
            // 
            // CancelarRegistrarVenta
            // 
            CancelarRegistrarVenta.Location = new Point(214, 266);
            CancelarRegistrarVenta.Margin = new Padding(4);
            CancelarRegistrarVenta.Name = "CancelarRegistrarVenta";
            CancelarRegistrarVenta.Size = new Size(118, 36);
            CancelarRegistrarVenta.TabIndex = 8;
            CancelarRegistrarVenta.Text = "Cancelar";
            CancelarRegistrarVenta.UseVisualStyleBackColor = true;
            CancelarRegistrarVenta.Click += CancelarRegistrarVenta_Click;
            // 
            // btRegistrarVenta
            // 
            btRegistrarVenta.Location = new Point(28, 266);
            btRegistrarVenta.Margin = new Padding(4);
            btRegistrarVenta.Name = "btRegistrarVenta";
            btRegistrarVenta.Size = new Size(118, 36);
            btRegistrarVenta.TabIndex = 7;
            btRegistrarVenta.Text = "Registrar";
            btRegistrarVenta.UseVisualStyleBackColor = true;
            btRegistrarVenta.Click += btRegistrarVenta_Click;
            // 
            // cbSedeVenta
            // 
            cbSedeVenta.FormattingEnabled = true;
            cbSedeVenta.Location = new Point(14, 145);
            cbSedeVenta.Margin = new Padding(4);
            cbSedeVenta.Name = "cbSedeVenta";
            cbSedeVenta.Size = new Size(316, 33);
            cbSedeVenta.TabIndex = 6;
            cbSedeVenta.Text = "Seleccione Sede de Venta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 109);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(165, 25);
            label4.TabIndex = 3;
            label4.Text = "Nombre de la Sede";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 29);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(157, 25);
            label5.TabIndex = 1;
            label5.Text = "Vehiculo a Asignar";
            // 
            // Totales
            // 
            Totales.BackColor = Color.Yellow;
            Totales.Controls.Add(lbtu);
            Totales.Controls.Add(label9);
            Totales.Controls.Add(lbtv);
            Totales.Controls.Add(label7);
            Totales.Location = new Point(885, 364);
            Totales.Margin = new Padding(4);
            Totales.Name = "Totales";
            Totales.Padding = new Padding(4);
            Totales.Size = new Size(349, 255);
            Totales.TabIndex = 5;
            Totales.TabStop = false;
            Totales.Text = "Totales";
            // 
            // lbtu
            // 
            lbtu.AutoSize = true;
            lbtu.Location = new Point(270, 122);
            lbtu.Margin = new Padding(4, 0, 4, 0);
            lbtu.Name = "lbtu";
            lbtu.Size = new Size(22, 25);
            lbtu.TabIndex = 3;
            lbtu.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 122);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(205, 25);
            label9.TabIndex = 2;
            label9.Text = "Total Unidades Vendidas";
            // 
            // lbtv
            // 
            lbtv.AutoSize = true;
            lbtv.Location = new Point(246, 54);
            lbtv.Margin = new Padding(4, 0, 4, 0);
            lbtv.Name = "lbtv";
            lbtv.Size = new Size(46, 25);
            lbtv.TabIndex = 1;
            lbtv.Text = "0.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 54);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(106, 25);
            label7.TabIndex = 0;
            label7.Text = "Total Ventas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 641);
            Controls.Add(Totales);
            Controls.Add(gpVenta);
            Controls.Add(lvAutos);
            Controls.Add(gbAuto);
            Controls.Add(lvSedes);
            Controls.Add(gbSede);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbSede.ResumeLayout(false);
            gbSede.PerformLayout();
            gbAuto.ResumeLayout(false);
            gbAuto.PerformLayout();
            gpVenta.ResumeLayout(false);
            gpVenta.PerformLayout();
            Totales.ResumeLayout(false);
            Totales.PerformLayout();
            ResumeLayout(false);
        }

        private void btCancelarRegistroAuto_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion

        private GroupBox gbSede;
        private Button btCancelaRegistroSede;
        private Button btRegistroSede;
        private Label label1;
        private Label lbNombreSede;
        private TextBox tbNombreSede;
        private ComboBox cbDistritos;
        private ListView lvSedes;
        private GroupBox gbAuto;
        private ComboBox cbCateg;
        private Label label2;
        private Label label3;
        private TextBox tbNombreAuto;
        private ListView lvAutos;
        private Button btRegistrarAuto;
        private Button btCancelaRegistroAuto;
        private GroupBox gpVenta;
        private Button CancelarRegistrarVenta;
        private Button btRegistrarVenta;
        private ComboBox cbSedeVenta;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbVenta;
        private ComboBox cbAutoVenta;
        private GroupBox Totales;
        private Label lbtv;
        private Label label7;
        private Label lbtu;
        private Label label9;
    }
}