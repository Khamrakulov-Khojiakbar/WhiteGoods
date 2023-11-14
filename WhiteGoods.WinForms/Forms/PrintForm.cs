using System;
using System.Data;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WhiteGoods.WinForms.Forms
{
    public partial class PrintForm : Form
    {
        public string Date = DateTime.Now.ToString("dd.M.yyyy  HH:mm");
        public string Id;
        public string ClientName;
        public string ClientLastName;
        public string ClientAddress;
        public string ClientPhoneNumber;
        public string DeviceType;
        public string DeviceBrand;
        public string DeviceModel;
        public string DeviceSn;
        public string DeviceCause;
        public string Master;

        public PrintForm()
        {
            InitializeComponent();
            panel1.BackColor = System.Drawing.Color.White;
            this.ControlBox = false;
            DataGridDevicePrint.RowHeadersVisible = false;
            DataGridDevicePrint.AllowUserToAddRows = false;
            PrintDataGridView.RowHeadersVisible = false;
            PrintDataGridView.AllowUserToAddRows = false;
            clientNameLabel.Text = "Abdulaziz";
            DataFillToPrint();
        }

        public void ShowBox()
        {

            MessageBox.Show($"ID: {Id}\n" +
                            $"ClientName: {ClientName}\n" +
                            $"ClienLastName: {ClientLastName}\n" +
                            $"ClientAddress: {ClientAddress}");
        }

        public void DataFillToPrint()
        {
            clientNameLabel.Text = ClientName;
            idLabel.Text = $"Квитанция {Id} от {Date}";
        }

        

        public void FillDataGridViewPrint()
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();

            /*dt.Columns.Add("Вид ремонта", typeof(string));
            dt.Columns.Add("Имя клиента", typeof(string));
            dt.Columns.Add("Тел номер клиента", typeof(string));
            dt.Columns.Add("Неисправность со слов клиента", typeof(string));
            dt.Columns.Add("Ориентировочная стоимость", typeof(string));
            dt.Columns.Add("Устройство", typeof(string));
            dt.Columns.Add("Серийный номер (IMEI)", typeof(string));
            dt.Columns.Add("Комплектация", typeof(string));
            dt.Columns.Add("Внешний вид", typeof (string));
            dt.Columns.Add("Предоплата", typeof(string));

            dt.Rows.Add("Платный", "Диана", "+996554546464", "Блокировка", "0.00 сом", "Redmi", "None", "", "", "0.00 сом");
*/

            /*dt.Rows.Add("Вид ремонта", typeof(string));
            dt.Rows.Add("Имя клиента", typeof(string));
            dt.Rows.Add("Тел номер клиента", typeof(string));
            dt.Rows.Add("Неисправность со слов клиента", typeof(string));
            dt.Rows.Add("Ориентировочная стоимость", typeof(string));
            dt.Rows.Add("Устройство", typeof(string));
            dt.Rows.Add("Серийный номер (IMEI)", typeof(string));
            dt.Rows.Add("Комплектация", typeof(string));
            dt.Rows.Add("Внешний вид", typeof(string));
            dt.Rows.Add("Предоплата", typeof(string));*/

            //dt.Columns.Add("Платный", "Диана", "+996554546464", "Блокировка", "0.00 сом", "Redmi", "None", "", "", "0.00 сом");

            //Бу метод бир нарса бирнарса килади

            int rowIndex = 0;
            int columnIndex = 0;

            
            dt.Columns.Add("Тип", typeof(string));
            dt.Columns.Add("Данные", typeof(string));

            dt.Rows.Add("Имя", ClientName);
            dt.Rows.Add("1", ClientName);
            dt.Rows.Add("2Имя", ClientName);
            dt.Rows.Add("3Имя", ClientName);
            

            dt2.Columns.Add("Тип", typeof(string));
            dt2.Columns.Add("Данные", typeof(string));

            dt2.Rows.Add("4Имя", ClientName);
            dt2.Rows.Add("5Имя", ClientName);
            dt2.Rows.Add("6Имя", ClientName);

            

            DataGridDevicePrint.DataSource = dt2;
            PrintDataGridView.DataSource = dt;

            DataGridDevicePrint.Columns[1].Width = 300;
            PrintDataGridView.Columns[1].Width = 300;
            /*foreach (DataGridViewColumn column in dt2.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            foreach (DataGridViewColumn column in dt.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }*/
        }

    }
}
