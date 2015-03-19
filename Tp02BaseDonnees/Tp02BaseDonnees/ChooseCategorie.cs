﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Tp02BaseDonnees
{
    public partial class ChooseCategorie : Form
    {
       OracleConnection Lacon;
       String[] alias;
       int NumPartie;
       int tour;
       public ChooseCategorie(OracleConnection con,String[] alias , int NumPartie, int tour)
        {
            InitializeComponent();
            Lacon = con;
            this.alias = alias;
            this.NumPartie = NumPartie;
            this.tour = tour;
        }

      

        private void Btn_Bleu_Click(object sender, EventArgs e)
        {
           RepondreForm form = new RepondreForm(1, Lacon,alias,NumPartie,tour);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_Green_Click(object sender, EventArgs e)
        {
           RepondreForm form = new RepondreForm(2, Lacon, alias, NumPartie, tour);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_Yellow_Click(object sender, EventArgs e)
        {

           RepondreForm form = new RepondreForm(3, Lacon, alias, NumPartie, tour);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_Orange_Click(object sender, EventArgs e)
        {
           RepondreForm form = new RepondreForm(4, Lacon, alias, NumPartie, tour);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_red_Click(object sender, EventArgs e)
        {
           RepondreForm form = new RepondreForm(5, Lacon, alias, NumPartie, tour);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_Pink_Click(object sender, EventArgs e)
        {
           RepondreForm form = new RepondreForm(6, Lacon, alias, NumPartie, tour);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
