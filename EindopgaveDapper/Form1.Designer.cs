namespace EindopgaveDapper
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblCampusNaam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.lstDocent = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFamilienaam = new System.Windows.Forms.TextBox();
            this.txtWedde = new System.Windows.Forms.TextBox();
            this.combCampus = new System.Windows.Forms.ComboBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblResultatVoornaam = new System.Windows.Forms.Label();
            this.lblResultatFamilienaam = new System.Windows.Forms.Label();
            this.lblResultatWedde = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecteer een campus :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecteer een docent :";
            // 
            // lblCampusNaam
            // 
            this.lblCampusNaam.AutoSize = true;
            this.lblCampusNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampusNaam.Location = new System.Drawing.Point(25, 287);
            this.lblCampusNaam.Name = "lblCampusNaam";
            this.lblCampusNaam.Size = new System.Drawing.Size(26, 25);
            this.lblCampusNaam.TabIndex = 2;
            this.lblCampusNaam.Text = "- ";
            this.lblCampusNaam.Click += new System.EventHandler(this.lblCampusNaam_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(676, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Details een docent";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(688, 323);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(11, 16);
            this.lbl_result.TabIndex = 4;
            this.lbl_result.Text = "-";
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(157, 335);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(243, 22);
            this.txtVoornaam.TabIndex = 5;
            // 
            // lstDocent
            // 
            this.lstDocent.FormattingEnabled = true;
            this.lstDocent.ItemHeight = 16;
            this.lstDocent.Location = new System.Drawing.Point(30, 161);
            this.lstDocent.Name = "lstDocent";
            this.lstDocent.Size = new System.Drawing.Size(321, 100);
            this.lstDocent.TabIndex = 6;
            this.lstDocent.SelectedIndexChanged += new System.EventHandler(this.lstDocent_SelectedIndexChanged);
            this.lstDocent.DoubleClick += new System.EventHandler(this.lstDocent_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Voornaam:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Familienaam:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Wedde:";
            // 
            // txtFamilienaam
            // 
            this.txtFamilienaam.Location = new System.Drawing.Point(157, 379);
            this.txtFamilienaam.Name = "txtFamilienaam";
            this.txtFamilienaam.Size = new System.Drawing.Size(243, 22);
            this.txtFamilienaam.TabIndex = 10;
            // 
            // txtWedde
            // 
            this.txtWedde.Location = new System.Drawing.Point(157, 415);
            this.txtWedde.Name = "txtWedde";
            this.txtWedde.Size = new System.Drawing.Size(243, 22);
            this.txtWedde.TabIndex = 11;
            // 
            // combCampus
            // 
            this.combCampus.FormattingEnabled = true;
            this.combCampus.Location = new System.Drawing.Point(30, 77);
            this.combCampus.Name = "combCampus";
            this.combCampus.Size = new System.Drawing.Size(249, 24);
            this.combCampus.TabIndex = 12;
            this.combCampus.SelectedIndexChanged += new System.EventHandler(this.combCampus_SelectedIndexChanged);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegen.Location = new System.Drawing.Point(177, 462);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(195, 33);
            this.btnToevoegen.TabIndex = 13;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(678, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Voornaam:";
            // 
            // lblResultatVoornaam
            // 
            this.lblResultatVoornaam.AutoSize = true;
            this.lblResultatVoornaam.Location = new System.Drawing.Point(836, 114);
            this.lblResultatVoornaam.Name = "lblResultatVoornaam";
            this.lblResultatVoornaam.Size = new System.Drawing.Size(11, 16);
            this.lblResultatVoornaam.TabIndex = 17;
            this.lblResultatVoornaam.Text = "-";
            // 
            // lblResultatFamilienaam
            // 
            this.lblResultatFamilienaam.AutoSize = true;
            this.lblResultatFamilienaam.Location = new System.Drawing.Point(836, 172);
            this.lblResultatFamilienaam.Name = "lblResultatFamilienaam";
            this.lblResultatFamilienaam.Size = new System.Drawing.Size(11, 16);
            this.lblResultatFamilienaam.TabIndex = 18;
            this.lblResultatFamilienaam.Text = "-";
            // 
            // lblResultatWedde
            // 
            this.lblResultatWedde.AutoSize = true;
            this.lblResultatWedde.Location = new System.Drawing.Point(836, 227);
            this.lblResultatWedde.Name = "lblResultatWedde";
            this.lblResultatWedde.Size = new System.Drawing.Size(11, 16);
            this.lblResultatWedde.TabIndex = 19;
            this.lblResultatWedde.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(677, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Familienaam:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(679, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Wedde:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 497);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblResultatWedde);
            this.Controls.Add(this.lblResultatFamilienaam);
            this.Controls.Add(this.lblResultatVoornaam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.combCampus);
            this.Controls.Add(this.txtWedde);
            this.Controls.Add(this.txtFamilienaam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstDocent);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCampusNaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCampusNaam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.ListBox lstDocent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFamilienaam;
        private System.Windows.Forms.TextBox txtWedde;
        private System.Windows.Forms.ComboBox combCampus;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblResultatVoornaam;
        private System.Windows.Forms.Label lblResultatFamilienaam;
        private System.Windows.Forms.Label lblResultatWedde;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

