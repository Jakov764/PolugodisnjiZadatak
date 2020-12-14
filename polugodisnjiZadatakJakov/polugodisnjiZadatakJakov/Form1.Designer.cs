namespace polugodisnjiZadatakJakov
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.textBoxOblik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOkus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPreljev = new System.Windows.Forms.ComboBox();
            this.buttonUnos = new System.Windows.Forms.Button();
            this.buttonObradi = new System.Windows.Forms.Button();
            this.buttonIspis = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(13, 32);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(137, 20);
            this.textBoxNaziv.TabIndex = 12;
            // 
            // textBoxOblik
            // 
            this.textBoxOblik.Location = new System.Drawing.Point(12, 88);
            this.textBoxOblik.Name = "textBoxOblik";
            this.textBoxOblik.Size = new System.Drawing.Size(137, 20);
            this.textBoxOblik.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oblik:";
            // 
            // textBoxOkus
            // 
            this.textBoxOkus.Location = new System.Drawing.Point(13, 149);
            this.textBoxOkus.Name = "textBoxOkus";
            this.textBoxOkus.Size = new System.Drawing.Size(137, 20);
            this.textBoxOkus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Okus:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sa preljevom:";
            // 
            // comboBoxPreljev
            // 
            this.comboBoxPreljev.FormattingEnabled = true;
            this.comboBoxPreljev.Items.AddRange(new object[] {
            "Da",
            "Ne"});
            this.comboBoxPreljev.Location = new System.Drawing.Point(12, 212);
            this.comboBoxPreljev.Name = "comboBoxPreljev";
            this.comboBoxPreljev.Size = new System.Drawing.Size(137, 21);
            this.comboBoxPreljev.TabIndex = 7;
            // 
            // buttonUnos
            // 
            this.buttonUnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.buttonUnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUnos.Location = new System.Drawing.Point(205, 25);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(187, 208);
            this.buttonUnos.TabIndex = 9;
            this.buttonUnos.Text = "Unos";
            this.buttonUnos.UseVisualStyleBackColor = false;
            this.buttonUnos.Click += new System.EventHandler(this.buttonUnos_Click);
            // 
            // buttonObradi
            // 
            this.buttonObradi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.buttonObradi.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonObradi.Location = new System.Drawing.Point(403, 25);
            this.buttonObradi.Name = "buttonObradi";
            this.buttonObradi.Size = new System.Drawing.Size(187, 208);
            this.buttonObradi.TabIndex = 10;
            this.buttonObradi.Text = "Obradi";
            this.buttonObradi.UseVisualStyleBackColor = false;
            this.buttonObradi.Click += new System.EventHandler(this.buttonObradi_Click);
            // 
            // buttonIspis
            // 
            this.buttonIspis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.buttonIspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIspis.Location = new System.Drawing.Point(601, 25);
            this.buttonIspis.Name = "buttonIspis";
            this.buttonIspis.Size = new System.Drawing.Size(187, 208);
            this.buttonIspis.TabIndex = 11;
            this.buttonIspis.Text = "Ispis";
            this.buttonIspis.UseVisualStyleBackColor = false;
            this.buttonIspis.Click += new System.EventHandler(this.buttonIspis_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 256);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(776, 356);
            this.richTextBox.TabIndex = 13;
            this.richTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.buttonIspis);
            this.Controls.Add(this.buttonObradi);
            this.Controls.Add(this.buttonUnos);
            this.Controls.Add(this.comboBoxPreljev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOkus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOblik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.TextBox textBoxOblik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOkus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPreljev;
        private System.Windows.Forms.Button buttonUnos;
        private System.Windows.Forms.Button buttonObradi;
        private System.Windows.Forms.Button buttonIspis;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}

