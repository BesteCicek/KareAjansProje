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
    public partial class orgnzsyn : Form
    {
        public orgnzsyn()
        {
            InitializeComponent();
        }
        KareAjansContext _db = new KareAjansContext();
        private void Form2_Load(object sender, EventArgs e)
        {
            cmbSehir.DataSource = new SehirManager(new EfSehirDal()).GetSehirs();
            cmbSehir.DisplayMember = "SehirAd";
            cmbSehir.ValueMember = "SehirID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrganizasyonManken organizasyonManken = new OrganizasyonManken();
            Organizasyon organizasyon = new Organizasyon();
            organizasyonManken.Baslangic = dateTimePicker1.Value.ToString();
            organizasyonManken.Bitis = dateTimePicker2.Value.ToString();
            int hostes = Convert.ToInt32(cmbHostes.SelectedItem);
            organizasyon.SehirId = (int)cmbSehir.SelectedValue;
            _db.Organizasyons.Add(organizasyon);
            _db.OrganizasyonMankens.Add(organizasyonManken);
            _db.SaveChanges();
            Mnkn form1 = new Mnkn();
            form1.Show();
            this.Hide();
        }
    }
}
