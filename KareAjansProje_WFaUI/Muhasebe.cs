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
    public partial class Muhasebe : Form
    {
        public Muhasebe()
        {
            InitializeComponent();
        }
        KareAjansContext _db = new KareAjansContext();
        int _id;
        int _ktg;
        
        private void ListOrganizasyonManken()
        {
            dataGridView1.DataSource = _db.OrganizasyonMankens.Select(m => new
            {
                m.OrganizyonMankenID,
                m.OrganizasyonId,
                m.Manken.Ad,
                m.Baslangic,
                m.Bitis,
                m.Manken.KategoriId
            }).ToList();
        }
        private void Muhasebe_Load(object sender, EventArgs e)
        {

            ListOrganizasyonManken();
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblManken.Text = (string)dataGridView1.CurrentRow.Cells[2].Value;
            _id = (int)dataGridView1.CurrentRow.Cells[2].Value;
            _ktg = (int)dataGridView1.CurrentRow.Cells[5].Value;
            if(_ktg==1)
            {
                int baslangic;
                int bitis;
                baslangic = (int)dataGridView1.CurrentRow.Cells[3].Value;
                bitis = (int)dataGridView1.CurrentRow.Cells[4].Value;
                int gün = bitis - baslangic;
                int odeme = (gün * 100) + 40;
                lblUcret.Text = odeme.ToString();
            }
            if(_ktg==2)
            {
                int baslangic;
                int bitis;
                baslangic = (int)dataGridView1.CurrentRow.Cells[3].Value;
                bitis = (int)dataGridView1.CurrentRow.Cells[4].Value;
                int gün = bitis - baslangic;
                int odeme = (gün * 100) + 100;
                lblUcret.Text = odeme.ToString();
            }
            int orgPara = Convert.ToInt32(txtOrganizasyonPara.Text);
            if(_ktg==3)
            {
                int baslangic;
                int bitis;
                baslangic = (int)dataGridView1.CurrentRow.Cells[3].Value;
                bitis = (int)dataGridView1.CurrentRow.Cells[4].Value;
                int gün = bitis - baslangic;
                int odeme = (gün * 100) + (orgPara*20/100);
                lblUcret.Text = odeme.ToString();
            }
        }
    }
}
