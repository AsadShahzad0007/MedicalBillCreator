using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class reportbill : Form
    {
        List<product_data> item;
        string p_name, add_1, addr_2, cellnumb, lic, pos, inv, datetime, cashname, cust, remarks, total_amt, payable_amt, total_qty;
        public reportbill(string _p_name, string _add_1, string _add_2, string cell, string lic, string pos, string inv,
            string datetime, string cash_name, string cust, string remarks, string toatl_amount, string payable_amt, string total_qty, List<product_data> item)
        {
            this.p_name = _p_name;
            this.add_1 = _add_1;
            this.addr_2 = _add_2;
            this.cellnumb = cell;
            this.lic = lic;
            this.inv = inv;
            this.pos = pos;
            this.datetime = datetime;
            this.cashname = cash_name;
            this.cust = cust;
            this.remarks = remarks;
            this.total_amt = toatl_amount;
            this.payable_amt = payable_amt;
            this.total_qty = total_qty;
            this.item = item;
            InitializeComponent();
        }

        private void reportbill_Load(object sender, EventArgs e)
        {
            ReportParameterCollection reportparameter = new ReportParameterCollection();
            reportparameter.Add(new ReportParameter("pharmacy", p_name));
            reportparameter.Add(new ReportParameter("add1", add_1));
            reportparameter.Add(new ReportParameter("add2", addr_2));
            reportparameter.Add(new ReportParameter("cell", cellnumb));
            reportparameter.Add(new ReportParameter("lics", lic));
            reportparameter.Add(new ReportParameter("pos", pos));
            reportparameter.Add(new ReportParameter("inv", inv));
            reportparameter.Add(new ReportParameter("datetime", datetime));
            reportparameter.Add(new ReportParameter("cashname", cashname));
            reportparameter.Add(new ReportParameter("cust", cust));
            reportparameter.Add(new ReportParameter("remarks", remarks));
            reportparameter.Add(new ReportParameter("total_bill", total_amt));
            reportparameter.Add(new ReportParameter("payable", payable_amt));
            ReportDataSource rds = new ReportDataSource("DataSet1", item);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(reportparameter);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
