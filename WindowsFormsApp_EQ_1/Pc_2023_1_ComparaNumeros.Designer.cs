﻿namespace WindowsFormsApp_EQ_1
{
    partial class Pc_2023_1_ComparaNumeros
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese datos:";
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(209, 42);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(100, 20);
            this.txtDatos.TabIndex = 2;
            this.txtDatos.TextChanged += new System.EventHandler(this.txtDatos_TextChanged);
            // 
            // Pc_2023_1_ComparaNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 244);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Pc_2023_1_ComparaNumeros";
            this.Text = "Pc_2023_1_ComparaNumeros";
            this.Load += new System.EventHandler(this.Pc_2023_1_ComparaNumeros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatos;
    }
}