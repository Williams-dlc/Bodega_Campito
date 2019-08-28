namespace Bodega
{
    partial class Prinicipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prinicipal));
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.btn_minizar = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.Panel();
            this.pnl_traslados = new System.Windows.Forms.Panel();
            this.btn_traslados = new System.Windows.Forms.Button();
            this.pnl_subreportes = new System.Windows.Forms.Panel();
            this.btn_reportSalidas = new System.Windows.Forms.Button();
            this.btn_reportEntradas = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_reportes = new System.Windows.Forms.Panel();
            this.pnl_productos = new System.Windows.Forms.Panel();
            this.btn_producto = new System.Windows.Forms.Button();
            this.pnl_subTraslados = new System.Windows.Forms.Panel();
            this.btn_trasladosEntradas = new System.Windows.Forms.Button();
            this.btn_trasladosSalidas = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.menu.SuspendLayout();
            this.pnl_subreportes.SuspendLayout();
            this.pnl_subTraslados.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(192)))), ((int)(((byte)(227)))));
            this.pnl_titulo.Controls.Add(this.btn_minizar);
            this.pnl_titulo.Controls.Add(this.btn_salir);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(1070, 35);
            this.pnl_titulo.TabIndex = 0;
            this.pnl_titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_titulo_Paint);
            this.pnl_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_titulo_MouseDown);
            // 
            // btn_minizar
            // 
            this.btn_minizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minizar.Image")));
            this.btn_minizar.Location = new System.Drawing.Point(992, 0);
            this.btn_minizar.Name = "btn_minizar";
            this.btn_minizar.Size = new System.Drawing.Size(33, 35);
            this.btn_minizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minizar.TabIndex = 2;
            this.btn_minizar.TabStop = false;
            this.btn_minizar.Click += new System.EventHandler(this.btn_minizar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.Location = new System.Drawing.Point(1029, 0);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(37, 35);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_salir.TabIndex = 1;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menu.Controls.Add(this.pnl_traslados);
            this.menu.Controls.Add(this.btn_traslados);
            this.menu.Controls.Add(this.pnl_subreportes);
            this.menu.Controls.Add(this.pnl_reportes);
            this.menu.Controls.Add(this.pnl_productos);
            this.menu.Controls.Add(this.btn_producto);
            this.menu.Controls.Add(this.pnl_subTraslados);
            this.menu.Controls.Add(this.btn_reportes);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 35);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(220, 615);
            this.menu.TabIndex = 1;
            // 
            // pnl_traslados
            // 
            this.pnl_traslados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.pnl_traslados.Location = new System.Drawing.Point(0, 138);
            this.pnl_traslados.Name = "pnl_traslados";
            this.pnl_traslados.Size = new System.Drawing.Size(16, 45);
            this.pnl_traslados.TabIndex = 5;
            // 
            // btn_traslados
            // 
            this.btn_traslados.FlatAppearance.BorderSize = 0;
            this.btn_traslados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(192)))), ((int)(((byte)(227)))));
            this.btn_traslados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_traslados.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_traslados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_traslados.Image = ((System.Drawing.Image)(resources.GetObject("btn_traslados.Image")));
            this.btn_traslados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_traslados.Location = new System.Drawing.Point(16, 138);
            this.btn_traslados.Name = "btn_traslados";
            this.btn_traslados.Size = new System.Drawing.Size(204, 45);
            this.btn_traslados.TabIndex = 6;
            this.btn_traslados.Text = "Traslados";
            this.btn_traslados.UseVisualStyleBackColor = true;
            this.btn_traslados.Click += new System.EventHandler(this.btn_traslados_Click);
            // 
            // pnl_subreportes
            // 
            this.pnl_subreportes.Controls.Add(this.btn_reportSalidas);
            this.pnl_subreportes.Controls.Add(this.btn_reportEntradas);
            this.pnl_subreportes.Controls.Add(this.panel6);
            this.pnl_subreportes.Controls.Add(this.panel3);
            this.pnl_subreportes.Location = new System.Drawing.Point(20, 240);
            this.pnl_subreportes.Name = "pnl_subreportes";
            this.pnl_subreportes.Size = new System.Drawing.Size(200, 75);
            this.pnl_subreportes.TabIndex = 3;
            this.pnl_subreportes.Visible = false;
            // 
            // btn_reportSalidas
            // 
            this.btn_reportSalidas.FlatAppearance.BorderSize = 0;
            this.btn_reportSalidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(192)))), ((int)(((byte)(227)))));
            this.btn_reportSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportSalidas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportSalidas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reportSalidas.Image = ((System.Drawing.Image)(resources.GetObject("btn_reportSalidas.Image")));
            this.btn_reportSalidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportSalidas.Location = new System.Drawing.Point(10, 40);
            this.btn_reportSalidas.Name = "btn_reportSalidas";
            this.btn_reportSalidas.Size = new System.Drawing.Size(190, 34);
            this.btn_reportSalidas.TabIndex = 4;
            this.btn_reportSalidas.Text = "Salidas";
            this.btn_reportSalidas.UseVisualStyleBackColor = true;
            this.btn_reportSalidas.Click += new System.EventHandler(this.btn_reportSalidas_Click);
            // 
            // btn_reportEntradas
            // 
            this.btn_reportEntradas.FlatAppearance.BorderSize = 0;
            this.btn_reportEntradas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(192)))), ((int)(((byte)(227)))));
            this.btn_reportEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportEntradas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportEntradas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reportEntradas.Image = ((System.Drawing.Image)(resources.GetObject("btn_reportEntradas.Image")));
            this.btn_reportEntradas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportEntradas.Location = new System.Drawing.Point(10, 0);
            this.btn_reportEntradas.Name = "btn_reportEntradas";
            this.btn_reportEntradas.Size = new System.Drawing.Size(190, 34);
            this.btn_reportEntradas.TabIndex = 2;
            this.btn_reportEntradas.Text = "Entradas";
            this.btn_reportEntradas.UseVisualStyleBackColor = true;
            this.btn_reportEntradas.Click += new System.EventHandler(this.btn_reportEntradas_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.panel6.Location = new System.Drawing.Point(0, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 34);
            this.panel6.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 34);
            this.panel3.TabIndex = 1;
            // 
            // pnl_reportes
            // 
            this.pnl_reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.pnl_reportes.Location = new System.Drawing.Point(0, 189);
            this.pnl_reportes.Name = "pnl_reportes";
            this.pnl_reportes.Size = new System.Drawing.Size(16, 45);
            this.pnl_reportes.TabIndex = 3;
            // 
            // pnl_productos
            // 
            this.pnl_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.pnl_productos.Location = new System.Drawing.Point(0, 87);
            this.pnl_productos.Name = "pnl_productos";
            this.pnl_productos.Size = new System.Drawing.Size(16, 45);
            this.pnl_productos.TabIndex = 0;
            // 
            // btn_producto
            // 
            this.btn_producto.FlatAppearance.BorderSize = 0;
            this.btn_producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(192)))), ((int)(((byte)(227)))));
            this.btn_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_producto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_producto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_producto.Image = ((System.Drawing.Image)(resources.GetObject("btn_producto.Image")));
            this.btn_producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_producto.Location = new System.Drawing.Point(16, 87);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Size = new System.Drawing.Size(204, 45);
            this.btn_producto.TabIndex = 0;
            this.btn_producto.Text = "Productos";
            this.btn_producto.UseVisualStyleBackColor = true;
            this.btn_producto.Click += new System.EventHandler(this.btn_producto_Click);
            // 
            // pnl_subTraslados
            // 
            this.pnl_subTraslados.Controls.Add(this.btn_trasladosEntradas);
            this.pnl_subTraslados.Controls.Add(this.btn_trasladosSalidas);
            this.pnl_subTraslados.Controls.Add(this.panel5);
            this.pnl_subTraslados.Controls.Add(this.panel8);
            this.pnl_subTraslados.Location = new System.Drawing.Point(20, 191);
            this.pnl_subTraslados.Name = "pnl_subTraslados";
            this.pnl_subTraslados.Size = new System.Drawing.Size(200, 75);
            this.pnl_subTraslados.TabIndex = 7;
            this.pnl_subTraslados.Visible = false;
            // 
            // btn_trasladosEntradas
            // 
            this.btn_trasladosEntradas.FlatAppearance.BorderSize = 0;
            this.btn_trasladosEntradas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(192)))), ((int)(((byte)(227)))));
            this.btn_trasladosEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trasladosEntradas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trasladosEntradas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_trasladosEntradas.Image = ((System.Drawing.Image)(resources.GetObject("btn_trasladosEntradas.Image")));
            this.btn_trasladosEntradas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trasladosEntradas.Location = new System.Drawing.Point(10, 0);
            this.btn_trasladosEntradas.Name = "btn_trasladosEntradas";
            this.btn_trasladosEntradas.Size = new System.Drawing.Size(190, 34);
            this.btn_trasladosEntradas.TabIndex = 2;
            this.btn_trasladosEntradas.Text = "Entradas";
            this.btn_trasladosEntradas.UseVisualStyleBackColor = true;
            this.btn_trasladosEntradas.Click += new System.EventHandler(this.btn_trasladosEntradas_Click);
            // 
            // btn_trasladosSalidas
            // 
            this.btn_trasladosSalidas.FlatAppearance.BorderSize = 0;
            this.btn_trasladosSalidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(192)))), ((int)(((byte)(227)))));
            this.btn_trasladosSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trasladosSalidas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trasladosSalidas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_trasladosSalidas.Image = ((System.Drawing.Image)(resources.GetObject("btn_trasladosSalidas.Image")));
            this.btn_trasladosSalidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trasladosSalidas.Location = new System.Drawing.Point(10, 40);
            this.btn_trasladosSalidas.Name = "btn_trasladosSalidas";
            this.btn_trasladosSalidas.Size = new System.Drawing.Size(190, 34);
            this.btn_trasladosSalidas.TabIndex = 4;
            this.btn_trasladosSalidas.Text = "Salidas";
            this.btn_trasladosSalidas.UseVisualStyleBackColor = true;
            this.btn_trasladosSalidas.Click += new System.EventHandler(this.btn_trasladosSalidas_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.panel5.Location = new System.Drawing.Point(0, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 34);
            this.panel5.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 34);
            this.panel8.TabIndex = 1;
            // 
            // btn_reportes
            // 
            this.btn_reportes.FlatAppearance.BorderSize = 0;
            this.btn_reportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(192)))), ((int)(((byte)(227)))));
            this.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reportes.Image = ((System.Drawing.Image)(resources.GetObject("btn_reportes.Image")));
            this.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.Location = new System.Drawing.Point(22, 189);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(198, 45);
            this.btn_reportes.TabIndex = 4;
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.UseVisualStyleBackColor = true;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(850, 615);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // Prinicipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Prinicipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prinicipal";
            this.pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.menu.ResumeLayout(false);
            this.pnl_subreportes.ResumeLayout(false);
            this.pnl_subTraslados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.PictureBox btn_minizar;
        private System.Windows.Forms.Panel pnl_productos;
        private System.Windows.Forms.Button btn_producto;
        private System.Windows.Forms.Panel pnl_reportes;
        private System.Windows.Forms.Button btn_reportes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_reportEntradas;
        private System.Windows.Forms.Panel pnl_traslados;
        private System.Windows.Forms.Button btn_traslados;
        private System.Windows.Forms.Panel pnl_subreportes;
        private System.Windows.Forms.Button btn_reportSalidas;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel pnl_subTraslados;
        private System.Windows.Forms.Button btn_trasladosSalidas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_trasladosEntradas;
        private System.Windows.Forms.Panel panel8;
    }
}