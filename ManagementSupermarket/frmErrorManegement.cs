using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace ManagementSupermarket
{
    public partial class frmErrorManegement : Form
    {
        private string s_role;
        public frmErrorManegement()
        {
            InitializeComponent();
        }
        public frmErrorManegement(string role)
        {
            this.s_role = role;
            InitializeComponent();
        }
        private void frmErrorManegement_Load(object sender, EventArgs e)
        {
            LoadData();
            if(s_role != "QLCC")
            {
                grp_Error.Visible = false;
            }
            if (dgv_Errors.Rows.Count > 0)
            {
                lbl_Error.Visible = true;
            }
        }

        private void btn_Fix_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Errors.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Vui lòng chọn một dòng lỗi trước khi thao tác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int stt = (int)dgv_Errors.SelectedRows[0].Cells["STT"].Value;

                DialogResult = MessageBox.Show($"Cập nhật trạng thái của lỗi thứ {stt}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.Yes)
                {
                    int numAffected = BLL_ManagementError.UpdateStatusError(stt, chk_StatusOfError.Checked);

                    if (numAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(chk_StatusListError.Checked);

                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BLL_ManagementError.InsertError(err.Message, "Form Error Manegement" + " - Nút cập nhật lỗi");
            }
            
        }

        private void dgv_Errors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Errors.SelectedRows.Count > 0)
            {
                chk_StatusOfError.Checked = (bool)dgv_Errors.SelectedRows[0].Cells["TrangThai"].Value;
            }
        }
        private void LoadData(bool status = true)
        {
            dgv_Errors.DataSource = BLL_ManagementError.GetError(status);
        }
        

        private void chk_StatusListError_CheckedChanged(object sender, EventArgs e)
        {
            LoadData(chk_StatusListError.Checked);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            chk_StatusListError.Checked = true;
            chk_StatusOfError.Checked = false;
            LoadData(true);

            if (dgv_Errors.Rows.Count > 0)
            {
                lbl_Error.Visible = true;
            }
            else
            {
                lbl_Error.Visible = false;
            }
        }
    }
}
