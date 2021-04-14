using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;

namespace DemoLocalDataBase
{
    public partial class Form1 : Form
    {
        public static SqlCeDataAdapter sda = null;

        #region Constructor
        public Form1()
        {
            InitializeComponent();

            CurdOperation();
            this.BindGrid();
        }
        #endregion

        #region Create connection to the local database
        /// <summary>
        /// Here i have to use SqlCeConnection Class.
        /// </summary>
        private static void CurdOperation()
        {
            SqlCeConnection con = new SqlCeConnection("Data Source="
                + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "MyDB.sdf"));
            sda = new SqlCeDataAdapter();
            SqlCeCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from MyDemoTable";
            sda.SelectCommand = cmd;

            SqlCeCommandBuilder cb = new SqlCeCommandBuilder(sda);
            sda.InsertCommand = cb.GetInsertCommand();
            sda.UpdateCommand = cb.GetUpdateCommand();
            sda.DeleteCommand = cb.GetDeleteCommand();
        }
        #endregion


        #region Event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Add();
                Reset();
                this.BindGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void brnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAge.Text) || string.IsNullOrEmpty(txtQualification.Text)) { MessageBox.Show("Please Input data."); return; }
                Update(lblId.Text);
                Reset();
                this.BindGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAge.Text) || string.IsNullOrEmpty(txtQualification.Text)) { MessageBox.Show("Please Input data."); return; }
                Delete(lblId.Text);
                Reset();
                this.BindGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void dgvOldData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOldData.Rows.Count > 0 && e.RowIndex != -1)
            {
                if (dgvOldData.Rows[e.RowIndex].Cells[0].Selected)
                {
                    txtName.Text = dgvOldData.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtAge.Text = dgvOldData.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtQualification.Text = dgvOldData.Rows[e.RowIndex].Cells[3].Value.ToString();
                    lblId.Text = dgvOldData.Rows[e.RowIndex].Cells[4].Value.ToString();

                    btnDelete.Enabled = true;
                    brnUpdate.Enabled = true;
                    btnAdd.Enabled = false;

                }
            }
        }
        #endregion

        #region PageSepcific Method

        /// <summary>
        /// this is common method created for Add,Update,Delete case.
        /// In this method normaly fill dataset with olddata.
        /// </summary>
        /// <param name="oldData"></param>
        /// <param name="dr"></param>
        private static void FillDataInDataset(out DataSet oldData, out DataRow dr)
        {
            oldData = new DataSet();
            dr = null;
            sda.Fill(oldData);
        }
        /// <summary>
        /// In this method get all data from table and 
        /// bind grid with data.
        /// </summary>
        private void BindGrid()
        {
            DataSet _ds = new DataSet();
            sda.Fill(_ds);
            if (_ds.Tables.Count > 0)
            {
                dgvOldData.DataSource = _ds.Tables[0];
            }

        }
        /// <summary>
        /// In this method write code for Inserting data in 
        /// this table MyDemoTable.
        /// </summary>
        private void Add()
        {
            DataSet oldData;
            DataRow dr;
            FillDataInDataset(out oldData, out dr);
            //create new row assign value to it.
            dr = oldData.Tables[0].NewRow();
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAge.Text) ||
                string.IsNullOrEmpty(txtQualification.Text)) { MessageBox.Show("Please Input data."); return; }
            dr["name"] = txtName.Text.Trim();
            dr["Age"] = txtAge.Text.Trim();
            dr["Qualification"] = txtQualification.Text.Trim();
            oldData.Tables[0].Rows.Add(dr);
            sda.Update(oldData);

        }
        /// <summary>
        /// In this method write code for updating existing data.
        /// </summary>
        /// <param name="id"></param>
        private void Update(string id)
        {
            DataSet oldData;
            DataRow dr;
            FillDataInDataset(out oldData, out dr);
            //Here get record of specified id.
            DataRow[] tempdata = oldData.Tables[0].AsEnumerable().Where(p => p["id"].ToString() == id).ToArray();
            if (tempdata.Length > 0)
            {
                dr = tempdata[0];
                dr["name"] = txtName.Text.Trim();
                dr["Age"] = txtAge.Text.Trim();
                dr["Qualification"] = txtQualification.Text.Trim();
            }
            sda.Update(oldData);
        }

        /// <summary>
        ///In this method write code for Deleting existing data. 
        /// </summary>
        /// <param name="id"></param>
        private void Delete(string id)
        {
            DataSet oldData;
            DataRow dr;
            FillDataInDataset(out oldData, out dr);
            //Here get record of specified id.
            DataRow[] tempdata = oldData.Tables[0].AsEnumerable().Where(p => p["id"].ToString() == id).ToArray();
            if (tempdata.Length > 0)
            {
                dr = tempdata[0];
                dr["name"] = txtName.Text.Trim();
                dr["Age"] = txtAge.Text.Trim();
                dr["Qualification"] = txtQualification.Text.Trim();
                dr.Delete();
            }
            sda.Update(oldData);

        }
        /// <summary>
        /// Reset All control of Form.
        /// </summary>
        private void Reset()
        {
            txtName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtQualification.Text = string.Empty;
            btnDelete.Enabled = false;
            brnUpdate.Enabled = false;
            btnAdd.Enabled = true;
        }
        #endregion


    }
}
