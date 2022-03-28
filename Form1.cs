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
            lsbPhone.Items.Clear();

            List<Model> Filterresult= _service.GetGetlsPhone(txtDepkeyword.Text,txtRoomkeyword.Text);
            ModelTolsb(Filterresult);

        }

        private void txtRoomkeyword_TextChanged(object sender, EventArgs e)
        {
            if (txtRoomkeyword.Text.Trim() == "")
            {
                return;
            }
            lsbPhone.Items.Clear();
            List<Model> Filterresult = _service.GetGetlsPhone(txtDepkeyword.Text, txtRoomkeyword.Text);
            ModelTolsb(Filterresult);
        }
        public void ModelTolsb( List<Model>Filterresult) 
        {
            foreach (Model _Model in Filterresult)
            {

                foreach (Unit _unit in _Model.lsUnit)
                {
                    foreach (string phone in _unit.Phones)
                    {
                        string stringResult = "";
                        stringResult += _Model.Dep + "_" + _unit.Name + phone;
                        lsbPhone.Items.Add(stringResult);
                    }
                }
            }
        }

    }
}
