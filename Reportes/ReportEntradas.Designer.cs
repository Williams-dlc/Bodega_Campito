﻿namespace Bodega.Reportes
{
    partial class ReportEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportEntradas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_Fecha = new System.Windows.Forms.Button();
            this.btn_codigo = new System.Windows.Forms.Button();
            this.btn_propietario = new System.Windows.Forms.Button();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.btn_aceptarDate = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.btn_aceptarCod = new System.Windows.Forms.Button();
            this.btn_aceparPro = new System.Windows.Forms.Button();
            this.dgv_Entradas = new System.Windows.Forms.DataGridView();
            this.cmb_propietario = new System.Windows.Forms.ComboBox();
            this.dtp_FechaPro = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entradas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 70);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(301, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(355, 18);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(149, 32);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "ENTRADAS";
            // 
            // btn_Fecha
            // 
            this.btn_Fecha.BackColor = System.Drawing.Color.Orange;
            this.btn_Fecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fecha.FlatAppearance.BorderSize = 0;
            this.btn_Fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fecha.Image = ((System.Drawing.Image)(resources.GetObject("btn_Fecha.Image")));
            this.btn_Fecha.Location = new System.Drawing.Point(74, 93);
            this.btn_Fecha.Name = "btn_Fecha";
            this.btn_Fecha.Size = new System.Drawing.Size(67, 61);
            this.btn_Fecha.TabIndex = 6;
            this.btn_Fecha.UseVisualStyleBackColor = false;
            this.btn_Fecha.Click += new System.EventHandler(this.btn_Fecha_Click);
            // 
            // btn_codigo
            // 
            this.btn_codigo.BackColor = System.Drawing.Color.Orange;
            this.btn_codigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_codigo.FlatAppearance.BorderSize = 0;
            this.btn_codigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_codigo.Image = ((System.Drawing.Image)(resources.GetObject("btn_codigo.Image")));
            this.btn_codigo.Location = new System.Drawing.Point(399, 93);
            this.btn_codigo.Name = "btn_codigo";
            this.btn_codigo.Size = new System.Drawing.Size(67, 61);
            this.btn_codigo.TabIndex = 7;
            this.btn_codigo.UseVisualStyleBackColor = false;
            this.btn_codigo.Click += new System.EventHandler(this.btn_codigo_Click);
            // 
            // btn_propietario
            // 
            this.btn_propietario.BackColor = System.Drawing.Color.Orange;
            this.btn_propietario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_propietario.FlatAppearance.BorderSize = 0;
            this.btn_propietario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_propietario.Image = ((System.Drawing.Image)(resources.GetObject("btn_propietario.Image")));
            this.btn_propietario.Location = new System.Drawing.Point(696, 93);
            this.btn_propietario.Name = "btn_propietario";
            this.btn_propietario.Size = new System.Drawing.Size(67, 61);
            this.btn_propietario.TabIndex = 8;
            this.btn_propietario.UseVisualStyleBackColor = false;
            this.btn_propietario.Click += new System.EventHandler(this.btn_propietario_Click);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(80, 72);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(54, 18);
            this.lbl_fecha.TabIndex = 9;
            this.lbl_fecha.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(686, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Propietario";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(28, 172);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha.TabIndex = 12;
            // 
            // btn_aceptarDate
            // 
            this.btn_aceptarDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_aceptarDate.FlatAppearance.BorderSize = 0;
            this.btn_aceptarDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_aceptarDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_aceptarDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptarDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptarDate.ForeColor = System.Drawing.Color.Silver;
            this.btn_aceptarDate.Location = new System.Drawing.Point(69, 213);
            this.btn_aceptarDate.Name = "btn_aceptarDate";
            this.btn_aceptarDate.Size = new System.Drawing.Size(84, 31);
            this.btn_aceptarDate.TabIndex = 14;
            this.btn_aceptarDate.Tag = "3";
            this.btn_aceptarDate.Text = "Aceptar";
            this.btn_aceptarDate.UseVisualStyleBackColor = false;
            this.btn_aceptarDate.Click += new System.EventHandler(this.btn_aceptarDate_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(373, 175);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(121, 20);
            this.txt_codigo.TabIndex = 15;
            // 
            // btn_aceptarCod
            // 
            this.btn_aceptarCod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_aceptarCod.FlatAppearance.BorderSize = 0;
            this.btn_aceptarCod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_aceptarCod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_aceptarCod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptarCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptarCod.ForeColor = System.Drawing.Color.Silver;
            this.btn_aceptarCod.Location = new System.Drawing.Point(393, 216);
            this.btn_aceptarCod.Name = "btn_aceptarCod";
            this.btn_aceptarCod.Size = new System.Drawing.Size(84, 31);
            this.btn_aceptarCod.TabIndex = 16;
            this.btn_aceptarCod.Tag = "3";
            this.btn_aceptarCod.Text = "Aceptar";
            this.btn_aceptarCod.UseVisualStyleBackColor = false;
            this.btn_aceptarCod.Click += new System.EventHandler(this.btn_aceptarCod_Click);
            // 
            // btn_aceparPro
            // 
            this.btn_aceparPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_aceparPro.FlatAppearance.BorderSize = 0;
            this.btn_aceparPro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_aceparPro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_aceparPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceparPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceparPro.ForeColor = System.Drawing.Color.Silver;
            this.btn_aceparPro.Location = new System.Drawing.Point(690, 216);
            this.btn_aceparPro.Name = "btn_aceparPro";
            this.btn_aceparPro.Size = new System.Drawing.Size(84, 31);
            this.btn_aceparPro.TabIndex = 18;
            this.btn_aceparPro.Tag = "3";
            this.btn_aceparPro.Text = "Aceptar";
            this.btn_aceparPro.UseVisualStyleBackColor = false;
            this.btn_aceparPro.Click += new System.EventHandler(this.btn_aceparPro_Click);
            // 
            // dgv_Entradas
            // 
            this.dgv_Entradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Entradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Entradas.Location = new System.Drawing.Point(28, 250);
            this.dgv_Entradas.Name = "dgv_Entradas";
            this.dgv_Entradas.Size = new System.Drawing.Size(771, 333);
            this.dgv_Entradas.TabIndex = 19;
            // 
            // cmb_propietario
            // 
            this.cmb_propietario.FormattingEnabled = true;
            this.cmb_propietario.Location = new System.Drawing.Point(669, 160);
            this.cmb_propietario.Name = "cmb_propietario";
            this.cmb_propietario.Size = new System.Drawing.Size(121, 21);
            this.cmb_propietario.TabIndex = 20;
            // 
            // dtp_FechaPro
            // 
            this.dtp_FechaPro.Location = new System.Drawing.Point(638, 187);
            this.dtp_FechaPro.Name = "dtp_FechaPro";
            this.dtp_FechaPro.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaPro.TabIndex = 21;
            // 
            // ReportEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 615);
            this.Controls.Add(this.dtp_FechaPro);
            this.Controls.Add(this.cmb_propietario);
            this.Controls.Add(this.dgv_Entradas);
            this.Controls.Add(this.btn_aceparPro);
            this.Controls.Add(this.btn_aceptarCod);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.btn_aceptarDate);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.btn_propietario);
            this.Controls.Add(this.btn_codigo);
            this.Controls.Add(this.btn_Fecha);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportEntradas";
            this.Text = "ReportEntradas";
            this.Load += new System.EventHandler(this.ReportEntradas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_Fecha;
        private System.Windows.Forms.Button btn_codigo;
        private System.Windows.Forms.Button btn_propietario;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Button btn_aceptarDate;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Button btn_aceptarCod;
        private System.Windows.Forms.Button btn_aceparPro;
        private System.Windows.Forms.DataGridView dgv_Entradas;
        private System.Windows.Forms.ComboBox cmb_propietario;
        private System.Windows.Forms.DateTimePicker dtp_FechaPro;
    }
}