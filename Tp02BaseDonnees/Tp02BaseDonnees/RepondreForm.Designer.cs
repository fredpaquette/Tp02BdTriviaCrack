﻿namespace Tp02BaseDonnees
{
   partial class RepondreForm
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
            this.Btn_A = new System.Windows.Forms.Button();
            this.Btn_B = new System.Windows.Forms.Button();
            this.Btn_C = new System.Windows.Forms.Button();
            this.Btn_D = new System.Windows.Forms.Button();
            this.Lb_Cat = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.Pn_couleur = new System.Windows.Forms.Panel();
            this.Lb_Question = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_A
            // 
            this.Btn_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_A.Location = new System.Drawing.Point(85, 188);
            this.Btn_A.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_A.Name = "Btn_A";
            this.Btn_A.Size = new System.Drawing.Size(223, 46);
            this.Btn_A.TabIndex = 10;
            this.Btn_A.Text = "Reponse A";
            this.Btn_A.UseVisualStyleBackColor = true;
            this.Btn_A.Click += new System.EventHandler(this.Btn_A_Click);
            // 
            // Btn_B
            // 
            this.Btn_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_B.Location = new System.Drawing.Point(85, 252);
            this.Btn_B.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_B.Name = "Btn_B";
            this.Btn_B.Size = new System.Drawing.Size(223, 46);
            this.Btn_B.TabIndex = 11;
            this.Btn_B.Text = "Reponse B";
            this.Btn_B.UseVisualStyleBackColor = true;
            this.Btn_B.Click += new System.EventHandler(this.Btn_B_Click);
            // 
            // Btn_C
            // 
            this.Btn_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_C.Location = new System.Drawing.Point(85, 319);
            this.Btn_C.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_C.Name = "Btn_C";
            this.Btn_C.Size = new System.Drawing.Size(223, 46);
            this.Btn_C.TabIndex = 12;
            this.Btn_C.Text = "Reponse C";
            this.Btn_C.UseVisualStyleBackColor = true;
            this.Btn_C.Click += new System.EventHandler(this.Btn_C_Click);
            // 
            // Btn_D
            // 
            this.Btn_D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_D.Location = new System.Drawing.Point(85, 389);
            this.Btn_D.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_D.Name = "Btn_D";
            this.Btn_D.Size = new System.Drawing.Size(223, 46);
            this.Btn_D.TabIndex = 13;
            this.Btn_D.Text = "Reponse D";
            this.Btn_D.UseVisualStyleBackColor = true;
            this.Btn_D.Click += new System.EventHandler(this.Btn_D_Click);
            // 
            // Lb_Cat
            // 
            this.Lb_Cat.AutoSize = true;
            this.Lb_Cat.Location = new System.Drawing.Point(76, 11);
            this.Lb_Cat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Cat.Name = "Lb_Cat";
            this.Lb_Cat.Size = new System.Drawing.Size(87, 17);
            this.Lb_Cat.TabIndex = 15;
            this.Lb_Cat.Text = "La categorie";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Pn_couleur
            // 
            this.Pn_couleur.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pn_couleur.Location = new System.Drawing.Point(52, 15);
            this.Pn_couleur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pn_couleur.Name = "Pn_couleur";
            this.Pn_couleur.Size = new System.Drawing.Size(16, 12);
            this.Pn_couleur.TabIndex = 16;
            // 
            // Lb_Question
            // 
            this.Lb_Question.Enabled = false;
            this.Lb_Question.Location = new System.Drawing.Point(85, 47);
            this.Lb_Question.Multiline = true;
            this.Lb_Question.Name = "Lb_Question";
            this.Lb_Question.Size = new System.Drawing.Size(217, 96);
            this.Lb_Question.TabIndex = 17;
            // 
            // RepondreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 487);
            this.Controls.Add(this.Lb_Question);
            this.Controls.Add(this.Pn_couleur);
            this.Controls.Add(this.Lb_Cat);
            this.Controls.Add(this.Btn_D);
            this.Controls.Add(this.Btn_C);
            this.Controls.Add(this.Btn_B);
            this.Controls.Add(this.Btn_A);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RepondreForm";
            this.Load += new System.EventHandler(this.RepondreForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button Btn_A;
      private System.Windows.Forms.Button Btn_B;
      private System.Windows.Forms.Button Btn_C;
      private System.Windows.Forms.Button Btn_D;
      private System.Windows.Forms.Label Lb_Cat;
      private System.DirectoryServices.DirectorySearcher directorySearcher1;
      private System.Windows.Forms.Panel Pn_couleur;
      private System.Windows.Forms.TextBox Lb_Question;
   }
}