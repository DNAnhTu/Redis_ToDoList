using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceStack.Redis;
using ServiceStack.Redis.Generic;

namespace RedisTodoList
{
    public partial class fMain : MetroFramework.Forms.MetroForm
    {

        public fMain()
        {
            InitializeComponent();
        }

        #region Methods
        void Edit(bool value)//Kéo con trỏ về các textbox
        {
            //txtID.ReadOnly = value;
            txtMyJob.ReadOnly = value;
            //dtStartDay.Value = DateTime.Now;
            //dtEndDate.Value = DateTime.Now;
            txtContent.ReadOnly = value;
        }
        void EditID(bool value)
        {
            txtID.ReadOnly = value;
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            using (RedisClient client = new RedisClient("localhost", 6379))
            {
                IRedisTypedClient<Work> work = client.As<Work>();
                workBindingSource.DataSource = work.GetAll();
                Edit(true);//Read only
                EditID(true);
                Count();
                Timesetoff();
            }

        }
        void Count()
        {
            label1.Text = dgvWork.Rows.Count.ToString();
        }

        void Timesetoff()
        {
            this.dtStartDay.Enabled = false;
            this.dtEndDate.Enabled = false;
        }
        void Timeseton()
        {
            this.dtStartDay.Enabled = true;
            this.dtEndDate.Enabled = true;
        }
        void ClearText()
        {
            txtID.Text = string.Empty;
            txtMyJob.Text = string.Empty;
            txtContent.Text = string.Empty;
        }
        #endregion

        #region Events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearText();
            workBindingSource.Add(new Work());
            workBindingSource.MoveLast();

            int count = 0;
            count = dgvWork.Rows.Count;
            if (count == 1)
            {
                txtID.Text = count.ToString();
            }
            else
            {
                string index = "";
                int index1 = 0;
                index = Convert.ToString(dgvWork.Rows[count - 2].Cells[0].Value);
                index1 = Convert.ToInt32(index);
                txtID.Text = (index1 + 1).ToString();
            }

            txtMyJob.ReadOnly = false;
            dtStartDay.Value = DateTime.Now;
            dtEndDate.Value = DateTime.Now;
            txtContent.ReadOnly = false;
            txtID.Focus();
            Count();
            Timeseton();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit(false);//Allow edit
            EditID(true);//No Allow edit with ID
            txtMyJob.Focus();//đặt con trỏ vào textbox đó
            Timeseton();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            /*Edit(true);//Read only
            workBindingSource.ResetBindings(false);
            txtID.Text = string.Empty;
            txtMyJob.Text = string.Empty;
            txtContent.Text = string.Empty;*/
            ClearText();
            Edit(true); //Read only
            EditID(true);//Read only
            workBindingSource.ResetBindings(false);
            if (MetroFramework.MetroMessageBox.Show(this, "Bạn có chắc muốn xóa tất cả các dach sách chưa lưu", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (RedisClient client = new RedisClient("localhost", 6379))
                {
                    IRedisTypedClient<Work> work = client.As<Work>();
                    workBindingSource.DataSource = work.GetAll();
                    Count();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Bạn có chắc muốn xóa dữ liệu này", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Work w = workBindingSource.Current as Work;
                if (w != null)
                {
                    using (RedisClient client = new RedisClient("localhost", 6379))
                    {
                        IRedisTypedClient<Work> work = client.As<Work>();
                        work.DeleteById(w.ID);
                        workBindingSource.RemoveCurrent();
                        Count();
                    }

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)//lưu data về server
        {
            using (RedisClient client = new RedisClient("localhost", 6379))
            {
                DateTime startDate = dtStartDay.Value;
                DateTime endDate = dtEndDate.Value;
                int result = DateTime.Compare(startDate, endDate);
                if (startDate < DateTime.Today.AddDays(-3))
                {
                    MessageBox.Show(this, "Ngày bắt đầu không được trễ hơn ngày hiện tại ít nhất 3 ngày!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (endDate < startDate)
                {
                    MessageBox.Show(this, "Ngày kết thúc không được nhỏ hơn ngày bắt đầu!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtMyJob.Text) || string.IsNullOrEmpty(txtContent.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    workBindingSource.EndEdit();
                    IRedisTypedClient<Work> work = client.As<Work>();
                    work.StoreAll(workBindingSource.DataSource as List<Work>);
                    MetroFramework.MetroMessageBox.Show(this, "Dữ liệu đã lưu thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Edit(true);//Readonly
                    EditID(true);//Readonly
                    Count();
                    Timesetoff();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (RedisClient client = new RedisClient("localhost", 6379))
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    MessageBox.Show(this, "Vui lòng nhập từ khóa!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                bool Search = false;
                foreach (DataGridViewRow row in dgvWork.Rows)
                {
                    if (row.Cells[1].Value.ToString().ToUpper().Trim().Contains(txtSearch.Text.ToUpper().Trim()))
                    {
                        /*bool flag = dgvWork.CurrentCell.Selected;
                        if (flag)
                        {
                            Search = true;
                            row.Selected = true;
                        }*/
                        Search = true;
                        row.Selected = true;
                    }
                }
                if (Search == false)
                {
                    MessageBox.Show(this, "Không tìm thấy công việc", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void dgvWork_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (RedisClient client = new RedisClient("localhost", 6379))
            {
                var senderGrid = (DataGridView)sender;
                senderGrid.EndEdit();
                DateTime startDate = dtStartDay.Value;
                DateTime endDate = dtEndDate.Value;
                int result = DateTime.Compare(startDate, endDate);
                CountRowColor();
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
                { 
                    var cbxCell = (DataGridViewCheckBoxCell)senderGrid.Rows[e.RowIndex].Cells["Status"];
                    if ((bool)cbxCell.Value)
                    {
                        if (endDate < startDate)
                        {
                            MessageBox.Show(this, "Ngày kết thúc không nhỏ hơn bắt đầu", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cbxCell.Value = false;
                        }
                        else if (startDate > DateTime.Today)
                        {
                            MessageBox.Show(this, "Chưa tới hạn ngày bắt đầu theo kế hoạch", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cbxCell.Value = false;
                        }
                        else if (endDate < DateTime.Today )
                        {
                            MessageBox.Show(this, "Quá hạn!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvWork.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red; 
                        }
                        else
                        {
                            MessageBox.Show(this,"Hoàn thành đúng hạn", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvWork.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                    }
                    else
                    {
                        dgvWork.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        return;
                    }
                    
                }
              
            }
        }

        public void CountRowColor()
        {
            using (RedisClient client = new RedisClient("localhost", 6379))
            {
                int Red = 0, LightGreen = 0;
                foreach (DataGridViewRow row in dgvWork.Rows)
                {
                    if (row.DefaultCellStyle.BackColor == Color.Red)
                    {
                        Red++;
                    }
                 
                    if (row.DefaultCellStyle.BackColor == Color.LightGreen)
                    {
                        LightGreen++;
                    }    
                }

                label4.Text = LightGreen.ToString();
                label6.Text = Red.ToString();
            }   
        }
        #endregion

    }

}
