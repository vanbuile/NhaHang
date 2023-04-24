using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class FMain : Form
    {
        
        public FMain()
        {
            InitializeComponent();
            LoadFoodTables();
        }
        
        private void LoadFoodTables()
        {
            List<FoodTable> listFoodTable  = FoodTableDAO.LoadTableList();
            foreach (FoodTable item in listFoodTable)
            {
                Button btn = new Button() { Width = 50, Height= 50 };
                btn.Text = item.Name + Environment.NewLine + item.Empty;
                btn.Click += btn_Click;
                btn.Tag = item;
                FlowList.Controls.Add(btn);
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as FoodTable).Id;
            LoadBillOnMenu(tableID);
        }
        private void LoadBillOnMenu(int idBill)
        {
           // Bill bill = BillDAO.LoadBill(idBill);
            //
            
        }

    }
}
