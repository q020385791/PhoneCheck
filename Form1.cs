using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneCheck
{
    public partial class Form1 : Form
    {
        Service _service;
        public Form1()
        {
            InitializeComponent();
            _service = new Service();
        }

        private void txtDepkeyword_TextChanged(object sender, EventArgs e)
        {
            if (txtDepkeyword.Text.Trim()=="")
            {
                return;
            }

            try
            {
                lsbPhone.Items.Clear();
                List<Model> filterResult = _service.GetFilteredPhoneList(txtDepkeyword.Text, txtRoomkeyword.Text);
                DisplayResultsInListBox(filterResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRoomkeyword_TextChanged(object sender, EventArgs e)
        {
            if (txtRoomkeyword.Text.Trim() == "")
            {
                return;
            }

            try
            {
                lsbPhone.Items.Clear();
                List<Model> filterResult = _service.GetFilteredPhoneList(txtDepkeyword.Text, txtRoomkeyword.Text);
                DisplayResultsInListBox(filterResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Model倒入結果的ListBox  部門_姓名_電話
        /// </summary>
        /// <param name="filterResult"></param>
        public void DisplayResultsInListBox( List<Model> filterResult) 
        {
            var formattedResults = filterResult
            .SelectMany(m => m.lsUnit, (model, unit) => new { model.Dep, unit })
            .SelectMany(x => x.unit.Phones, (x, phone) => $"{x.Dep}_{x.unit.Name}_{phone}")
            .ToList();

            lsbPhone.Items.AddRange(formattedResults.ToArray());
        }

    }
}
