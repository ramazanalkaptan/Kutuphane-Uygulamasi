using kutuphaneOtomasyon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kutuphaneOtomasyon
{
    public partial class UyePage : Form
    {
        List<Kitap> kitaplarim;
        public UyePage(List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kitaplarim = kitaplarim;
        }
        private void UyePage_Load(object sender, EventArgs e)
        {
            foreach (Kitap kitap in kitaplarim)
            {
                dataGrid_uyekitap.Rows.Add
                    (
                        kitap.getkitapid(),
                        kitap.getkitapisim(),
                        kitap.getkitapYazar(),
                        kitap.getkitapdili(),
                        kitap.getyayinevi(),
                        kitap.gettur(),
                        kitap.getadet(),
                        kitap.getsayfasayisi(),
                        kitap.getbasimyili()
                    );
            }
        }

        private void btn_uyekitapAra_Click(object sender, EventArgs e)
        {
            string searchValue = text_uyekitapara.Text.ToLower().Trim();
            dataGrid_uyekitap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dataGrid_uyekitap.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().ToLower().Trim().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            dataGrid_uyekitap.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }

                }
                if (!valueResult)
                {
                    MessageBox.Show("Bulunamadı " + text_uyekitapara.Text, " Bulunamadı!");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void btn_uyekitapYenile_Click(object sender, EventArgs e)
        {
            
            dataGrid_uyekitap.Rows.Clear();
            foreach (Kitap kitap in kitaplarim)
            {
                dataGrid_uyekitap.Rows.Add
                    (
                        kitap.getkitapid(),
                        kitap.getkitapisim(),
                        kitap.getkitapYazar(),
                        kitap.getkitapdili(),
                        kitap.getyayinevi(),
                        kitap.gettur(),
                        kitap.getadet(),
                        kitap.getsayfasayisi(),
                        kitap.getbasimyili()
                    );
            }
        }
    }
}