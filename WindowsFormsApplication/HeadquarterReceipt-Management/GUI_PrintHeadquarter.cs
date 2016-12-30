using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.HeadquarterReceipt_Management
{
    public partial class GUI_PrintHeadquarter : Form
    {
        BUS_HeadquarterReceiptDetail Bus_Detail = new BUS_HeadquarterReceiptDetail();
        string id;

        public GUI_PrintHeadquarter(string hID)
        {
            InitializeComponent();
            id = hID;
            LoadPrint();
        }

        private void LoadPrint()
        {
            BindingSource bs = new BindingSource();
            //bs.DataSource = Bus_Detail.printHeadquarterDetail(id);
            bs.DataSource = ToDataSet<SP_PRINT_Headquarter_Result>(Bus_Detail.printHeadquarterDetail(id));
            CrystalReportHeadquarter rp = new CrystalReportHeadquarter();
            rp.SetDataSource(bs);
            //Test
            //rp.SetDataSource(ToDataSet<SP_PRINT_Headquarter_Result>(Bus_Detail.printHeadquarterDetail(id)));
            crvHeadquarter.ReportSource = rp;
            crvHeadquarter.RefreshReport();
        }


        public  DataSet ToDataSet<T>( IList<T> list)
        {
            Type elementType = typeof(T);
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            ds.Tables.Add(t);

            //add a column to table for each public property on T
            foreach (var propInfo in elementType.GetProperties())
            {
                Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;

                t.Columns.Add(propInfo.Name, ColType);
            }

            //go through each property on T and add each value to the table
            foreach (T item in list)
            {
                DataRow row = t.NewRow();

                foreach (var propInfo in elementType.GetProperties())
                {
                    row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                }

                t.Rows.Add(row);
            }

            return ds;
        }
    }
}
