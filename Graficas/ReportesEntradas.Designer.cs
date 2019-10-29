namespace Bodega.Reportes
{
    partial class ReportesEntradas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesEntradas));
            this.grf_Barras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmb_propietario = new System.Windows.Forms.ComboBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.rdb_Mes = new System.Windows.Forms.RadioButton();
            this.rdb_año = new System.Windows.Forms.RadioButton();
            this.grf_pie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_barras = new System.Windows.Forms.Panel();
            this.btn_pie = new System.Windows.Forms.Panel();
            this.cmb_mes = new System.Windows.Forms.ComboBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grf_Barras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grf_pie)).BeginInit();
            this.SuspendLayout();
            // 
            // grf_Barras
            // 
            this.grf_Barras.BackColor = System.Drawing.Color.Transparent;
            this.grf_Barras.BackSecondaryColor = System.Drawing.Color.White;
            this.grf_Barras.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.grf_Barras.BorderlineWidth = 0;
            this.grf_Barras.BorderSkin.BackColor = System.Drawing.Color.White;
            this.grf_Barras.BorderSkin.BorderWidth = 10;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.grf_Barras.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.grf_Barras.Legends.Add(legend1);
            this.grf_Barras.Location = new System.Drawing.Point(118, 164);
            this.grf_Barras.Name = "grf_Barras";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grf_Barras.Series.Add(series1);
            this.grf_Barras.Size = new System.Drawing.Size(575, 295);
            this.grf_Barras.TabIndex = 0;
            this.grf_Barras.Text = "chart1";
            // 
            // cmb_propietario
            // 
            this.cmb_propietario.FormattingEnabled = true;
            this.cmb_propietario.Location = new System.Drawing.Point(59, 73);
            this.cmb_propietario.Name = "cmb_propietario";
            this.cmb_propietario.Size = new System.Drawing.Size(121, 21);
            this.cmb_propietario.TabIndex = 1;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_aceptar.Location = new System.Drawing.Point(485, 63);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(112, 30);
            this.btn_aceptar.TabIndex = 2;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // rdb_Mes
            // 
            this.rdb_Mes.AutoSize = true;
            this.rdb_Mes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Mes.Location = new System.Drawing.Point(294, 66);
            this.rdb_Mes.Name = "rdb_Mes";
            this.rdb_Mes.Size = new System.Drawing.Size(65, 27);
            this.rdb_Mes.TabIndex = 5;
            this.rdb_Mes.TabStop = true;
            this.rdb_Mes.Text = "Mes";
            this.rdb_Mes.UseVisualStyleBackColor = true;
            // 
            // rdb_año
            // 
            this.rdb_año.AutoSize = true;
            this.rdb_año.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_año.Location = new System.Drawing.Point(386, 66);
            this.rdb_año.Name = "rdb_año";
            this.rdb_año.Size = new System.Drawing.Size(65, 27);
            this.rdb_año.TabIndex = 6;
            this.rdb_año.TabStop = true;
            this.rdb_año.Text = "Año";
            this.rdb_año.UseVisualStyleBackColor = true;
            // 
            // grf_pie
            // 
            this.grf_pie.BackColor = System.Drawing.Color.Transparent;
            this.grf_pie.BackSecondaryColor = System.Drawing.Color.Black;
            this.grf_pie.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.grf_pie.BorderlineWidth = 0;
            this.grf_pie.BorderSkin.BackColor = System.Drawing.Color.White;
            this.grf_pie.BorderSkin.BorderWidth = 10;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.grf_pie.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.grf_pie.Legends.Add(legend2);
            this.grf_pie.Location = new System.Drawing.Point(146, 180);
            this.grf_pie.Name = "grf_pie";
            this.grf_pie.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.grf_pie.Series.Add(series2);
            this.grf_pie.Size = new System.Drawing.Size(570, 318);
            this.grf_pie.TabIndex = 7;
            this.grf_pie.Text = "chart1";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(56, 39);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(125, 25);
            this.lbl_nombre.TabIndex = 8;
            this.lbl_nombre.Text = "Distribuidor";
            // 
            // btn_barras
            // 
            this.btn_barras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_barras.BackgroundImage")));
            this.btn_barras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_barras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_barras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_barras.Location = new System.Drawing.Point(644, 50);
            this.btn_barras.Name = "btn_barras";
            this.btn_barras.Size = new System.Drawing.Size(49, 46);
            this.btn_barras.TabIndex = 9;
            this.btn_barras.Click += new System.EventHandler(this.btn_barras_Click);
            // 
            // btn_pie
            // 
            this.btn_pie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pie.BackgroundImage")));
            this.btn_pie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_pie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pie.Location = new System.Drawing.Point(717, 50);
            this.btn_pie.Name = "btn_pie";
            this.btn_pie.Size = new System.Drawing.Size(49, 46);
            this.btn_pie.TabIndex = 10;
            this.btn_pie.Click += new System.EventHandler(this.btn_pie_Click);
            // 
            // cmb_mes
            // 
            this.cmb_mes.FormattingEnabled = true;
            this.cmb_mes.Items.AddRange(new object[] {
            "Enero",
            "Febrero\t",
            "Marzo\t",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmb_mes.Location = new System.Drawing.Point(59, 111);
            this.cmb_mes.Name = "cmb_mes";
            this.cmb_mes.Size = new System.Drawing.Size(121, 21);
            this.cmb_mes.TabIndex = 11;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(186, 111);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(46, 20);
            this.txt_numero.TabIndex = 12;
            // 
            // ReportesEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 615);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.cmb_mes);
            this.Controls.Add(this.btn_pie);
            this.Controls.Add(this.btn_barras);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.grf_pie);
            this.Controls.Add(this.rdb_año);
            this.Controls.Add(this.rdb_Mes);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.cmb_propietario);
            this.Controls.Add(this.grf_Barras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportesEntradas";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.grf_Barras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grf_pie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grf_Barras;
        private System.Windows.Forms.ComboBox cmb_propietario;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.RadioButton rdb_Mes;
        private System.Windows.Forms.RadioButton rdb_año;
        private System.Windows.Forms.DataVisualization.Charting.Chart grf_pie;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Panel btn_barras;
        private System.Windows.Forms.Panel btn_pie;
        private System.Windows.Forms.ComboBox cmb_mes;
        private System.Windows.Forms.TextBox txt_numero;
    }
}