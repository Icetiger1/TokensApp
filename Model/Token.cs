using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    public class Token
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string FIO { get; set; }
        public string Department { get; set; }
        public string Destiny { get; set; }
        public string Action { get; set; }
        public string SerialNumber { get; set; }
        public string InterCertCenter { get; set; }
        public string RootCertCenter { get; set; }
        public string Status { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        public Token() :
            this(Int32.MinValue,
                String.Empty,
                String.Empty,
                String.Empty,
                String.Empty,
                String.Empty,
                String.Empty,
                String.Empty,
                String.Empty,
                String.Empty,
                DateTime.MinValue,
                DateTime.MaxValue)
        { }
        public Token(
            int id, 
            string type, 
            string fio, 
            string department, 
            string destiny, 
            string action, 
            string serialNumber,
            string interCertCenter,
            string rootCertCenter,
            string status,
            DateTime dateStart,
            DateTime dateEnd
            )
        {
            this.Id = id;
            this.Type = type;
            this.FIO = fio;
            this.Department = department;
            this.Destiny = destiny;
            this.Action = action;
            this.SerialNumber = serialNumber;
            this.InterCertCenter = interCertCenter;
            this.RootCertCenter = rootCertCenter;
            this.Status = status;
            this.DateStart = dateStart;
            this.DateEnd = dateEnd;
        }

        public ListViewItem AddToListViewItem()
        {
            ListViewItem item = new ListViewItem(this.Id.ToString());
            //ListViewItem.ListViewSubItem sub = new();
            ListViewItem.ListViewSubItem sub2 = new();
            ListViewItem.ListViewSubItem sub3 = new();
            ListViewItem.ListViewSubItem sub4 = new();
            ListViewItem.ListViewSubItem sub5 = new();
            ListViewItem.ListViewSubItem sub6 = new();
            ListViewItem.ListViewSubItem sub7 = new();
            ListViewItem.ListViewSubItem sub8 = new();
            ListViewItem.ListViewSubItem sub9 = new();
            ListViewItem.ListViewSubItem sub10 = new();
            ListViewItem.ListViewSubItem sub11 = new();
            ListViewItem.ListViewSubItem sub12 = new();

            //sub.Text = this.Id.ToString();
            sub2.Text = this.Type;
            sub3.Text = this.FIO;
            sub4.Text = this.Department;
            sub5.Text = this.Destiny;
            sub6.Text = this.Action;
            sub7.Text = this.SerialNumber;
            sub8.Text = this.InterCertCenter;
            sub9.Text = this.RootCertCenter;
            sub10.Text = this.Status;
            sub11.Text = this.DateStart.ToString();
            sub12.Text = this.DateEnd.ToString();

            item.SubItems.AddRange(new[] { 
                //sub, 
                sub2, 
                sub3, 
                sub4, 
                sub5, 
                sub6, 
                sub7, 
                sub8, 
                sub9, 
                sub10, 
                sub11, 
                sub12 });

            return item;
        }

    }
}
