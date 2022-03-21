using DapperLibrary.Models;
using System;
using System.Windows.Forms;

namespace EindopgaveDapper
{
    public partial class Form1 : Form
    {
        OpleidingenService opleingenService = new OpleidingenService();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

           // var index = combCampus.SelectedIndex + 1;
            //var allDocenten = opleingenService.GetDocentByCampus(index);
            //lstDocent.DataSource = null;
            var allDocenten = opleingenService.GetDocentenByCampus();
            lstDocent.DataSource = allDocenten;
            //var allDocenten = opleingenService.GetDocenten();
            combCampus.DataSource = opleingenService.GetCampus(); 
        }

        private void lblCampusNaam_Click(object sender, EventArgs e)
        {
           
        }

        private void combCampus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combCampus.SelectedItem != null)
            {
                combCampus.Enabled = true;
                lblCampusNaam.Text = " Docent toevoegen aan campus " + combCampus.Text;
            }
            else
                lblCampusNaam.Text = " ";
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            Docent docent = new Docent();

            docent.CampusNr = combCampus.SelectedIndex + 1;
            docent.Voornaam = txtVoornaam.Text;
            docent.Familienaam = txtFamilienaam.Text;
            docent.Wedde = Convert.ToDecimal(txtWedde.Text);

            opleingenService.AddDocent(docent);
            lstDocent.DataSource = opleingenService.GetDocentenByCampus();

            lbl_result.Text = txtVoornaam.Text + " " + txtFamilienaam.Text +"  " +" Verwijderen";

        }

        private void lstDocent_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void lstDocent_DoubleClick(object sender, EventArgs e)
        {
            Docent docent = (Docent)lstDocent.SelectedItem;
            if(docent != null)
            {
                lblResultatVoornaam.Text= docent.Voornaam.ToString();   
                lblResultatFamilienaam.Text=docent.Familienaam.ToString();
                lblResultatWedde.Text = docent.Wedde.ToString();
                
            }
        }
    }
}
