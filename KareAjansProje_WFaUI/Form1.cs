using KareAjansProje_Business.Concretes.Managers;
using KareAjansProje_DataAccess.Concretes.EntityFramework;
using KareAjansProje_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KareAjansProje_WFaUI
{
    public partial class Mnkn : Form
    {
        public Mnkn()
        {
            InitializeComponent();
        }
        KareAjansContext _db = new KareAjansContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbAyakkabi.DataSource = new AyakkabiNoManager(new EfAyakkabiNoDal()).GetAyakkabiNos();
            cmbAyakkabi.DisplayMember = "AyakkabiNumarasi";
            cmbAyakkabi.ValueMember = "AyakkabiNoID";
            cmbBeden.DataSource = new BedenManager(new EfBedenDal()).GetBedens();
            cmbBeden.DisplayMember = "BedenNo";
            cmbBeden.ValueMember = "BedenID";
            cmbGoz.DataSource = new GozRengiManager(new EfGozRengiDal()).GetGozRengis();
            cmbGoz.DisplayMember = "Renk";
            cmbGoz.ValueMember = "GozRengiID";
            cmbSac.DataSource = new SacRengiManager(new EfSacRengiDal()).GetSacRengis();
            cmbSac.DisplayMember = "Renk";
            cmbSac.ValueMember = "SacRengiID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KareAjansProje_Entities.Concretes.Manken manken = new KareAjansProje_Entities.Concretes.Manken();
            manken.Ad = mankenAd.Text;
            manken.Soyad = mankenSoyad.Text;
            manken.Adres = mankenAdres.Text;
            manken.Tel = mankenTel.Text;
            manken.AyakkabiNo = (int)cmbAyakkabi.SelectedValue;
            manken.BedenId = (int)cmbBeden.SelectedValue;
            manken.SacRengiId = (int)cmbSac.SelectedValue;
            manken.GozRengiId = (int)cmbGoz.SelectedValue;
            if (rdSehirEvet.Checked)
            {
                manken.SehirDisi = true;
            }
            if (rdSehirHayir.Checked)
            {
                manken.SehirDisi = false;
            }
            if (rdEhliyetEvet.Checked)
            {
                manken.Ehliyet = true;
            }
            if (rdEhliyetHayir.Checked)
            {
                manken.Ehliyet = false;
            }
            if (rdYabanciEvet.Checked)
            {
                manken.YabanciDil = true;
            }
            if (rdYabanciHayir.Checked)
            {
                manken.YabanciDil = false;
            }
            _db.Mankens.Add(manken);
            _db.SaveChanges();
            MessageBox.Show("Kaydedildi");
            this.Close();
        }
    }
}
