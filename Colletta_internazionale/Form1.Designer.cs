﻿namespace Colletta_internazionale
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
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxImporto = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxValuta = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.buttonOrdinaimporto = new System.Windows.Forms.Button();
            this.buttonOrdinanome = new System.Windows.Forms.Button();
            this.buttonCercaImporto = new System.Windows.Forms.Button();
            this.buttonCercaNome = new System.Windows.Forms.Button();
            this.buttonSampleVakute = new System.Windows.Forms.Button();
            this.buttonTotale = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAggiungi.Location = new System.Drawing.Point(12, 333);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(190, 32);
            this.buttonAggiungi.TabIndex = 0;
            this.buttonAggiungi.Text = "Aggiungi";
            this.buttonAggiungi.UseVisualStyleBackColor = true;
            this.buttonAggiungi.Click += new System.EventHandler(this.buttonAggiungi_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNome.Location = new System.Drawing.Point(27, 58);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(164, 29);
            this.textBoxNome.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(27, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nome";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(27, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Importo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxImporto
            // 
            this.textBoxImporto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxImporto.Location = new System.Drawing.Point(27, 138);
            this.textBoxImporto.Name = "textBoxImporto";
            this.textBoxImporto.Size = new System.Drawing.Size(164, 29);
            this.textBoxImporto.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(27, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Valuta";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBoxValuta
            // 
            this.textBoxValuta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxValuta.Location = new System.Drawing.Point(27, 218);
            this.textBoxValuta.Name = "textBoxValuta";
            this.textBoxValuta.Size = new System.Drawing.Size(164, 29);
            this.textBoxValuta.TabIndex = 5;
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(268, 23);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(361, 376);
            this.listView.TabIndex = 7;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // buttonOrdinaimporto
            // 
            this.buttonOrdinaimporto.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOrdinaimporto.Location = new System.Drawing.Point(12, 409);
            this.buttonOrdinaimporto.Name = "buttonOrdinaimporto";
            this.buttonOrdinaimporto.Size = new System.Drawing.Size(190, 32);
            this.buttonOrdinaimporto.TabIndex = 8;
            this.buttonOrdinaimporto.Text = "Ordina per importo";
            this.buttonOrdinaimporto.UseVisualStyleBackColor = true;
            this.buttonOrdinaimporto.Click += new System.EventHandler(this.buttonOrdinaimporto_Click);
            // 
            // buttonOrdinanome
            // 
            this.buttonOrdinanome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOrdinanome.Location = new System.Drawing.Point(12, 371);
            this.buttonOrdinanome.Name = "buttonOrdinanome";
            this.buttonOrdinanome.Size = new System.Drawing.Size(190, 32);
            this.buttonOrdinanome.TabIndex = 9;
            this.buttonOrdinanome.Text = "Ordina per nome";
            this.buttonOrdinanome.UseVisualStyleBackColor = true;
            this.buttonOrdinanome.Click += new System.EventHandler(this.buttonOrdinanome_Click);
            // 
            // buttonCercaImporto
            // 
            this.buttonCercaImporto.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCercaImporto.Location = new System.Drawing.Point(12, 485);
            this.buttonCercaImporto.Name = "buttonCercaImporto";
            this.buttonCercaImporto.Size = new System.Drawing.Size(190, 32);
            this.buttonCercaImporto.TabIndex = 10;
            this.buttonCercaImporto.Text = "Cerca per importo";
            this.buttonCercaImporto.UseVisualStyleBackColor = true;
            this.buttonCercaImporto.Click += new System.EventHandler(this.buttonCercaimporto_Click);
            // 
            // buttonCercaNome
            // 
            this.buttonCercaNome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCercaNome.Location = new System.Drawing.Point(12, 447);
            this.buttonCercaNome.Name = "buttonCercaNome";
            this.buttonCercaNome.Size = new System.Drawing.Size(190, 32);
            this.buttonCercaNome.TabIndex = 11;
            this.buttonCercaNome.Text = "Cerca per nome";
            this.buttonCercaNome.UseVisualStyleBackColor = true;
            this.buttonCercaNome.Click += new System.EventHandler(this.buttonCercaNome_Click);
            // 
            // buttonSampleVakute
            // 
            this.buttonSampleVakute.Enabled = false;
            this.buttonSampleVakute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSampleVakute.Location = new System.Drawing.Point(27, 253);
            this.buttonSampleVakute.Name = "buttonSampleVakute";
            this.buttonSampleVakute.Size = new System.Drawing.Size(132, 29);
            this.buttonSampleVakute.TabIndex = 12;
            this.buttonSampleVakute.Text = "$, £, RUB, €, ¥";
            this.buttonSampleVakute.UseVisualStyleBackColor = true;
            // 
            // buttonTotale
            // 
            this.buttonTotale.Enabled = false;
            this.buttonTotale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTotale.Location = new System.Drawing.Point(268, 412);
            this.buttonTotale.Name = "buttonTotale";
            this.buttonTotale.Size = new System.Drawing.Size(178, 29);
            this.buttonTotale.TabIndex = 13;
            this.buttonTotale.UseVisualStyleBackColor = true;
            this.buttonTotale.Click += new System.EventHandler(this.buttonTotale_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(452, 412);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 29);
            this.button4.TabIndex = 14;
            this.button4.Text = "0.00";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 541);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonTotale);
            this.Controls.Add(this.buttonSampleVakute);
            this.Controls.Add(this.buttonCercaNome);
            this.Controls.Add(this.buttonCercaImporto);
            this.Controls.Add(this.buttonOrdinanome);
            this.Controls.Add(this.buttonOrdinaimporto);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxValuta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxImporto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonAggiungi);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAggiungi;
        private TextBox textBoxNome;
        private Button button1;
        private Button button2;
        private TextBox textBoxImporto;
        private Button button3;
        private TextBox textBoxValuta;
        private ListView listView;
        private Button buttonOrdinaimporto;
        private Button buttonOrdinanome;
        private Button buttonCercaImporto;
        private Button buttonCercaNome;
        private Button buttonSampleVakute;
        private Button buttonTotale;
        private Button button4;
    }
}