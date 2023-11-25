using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;

namespace WinFormsApp1.Infrastucture
{
    public class TokensCreator
    {
        private static int globalId;

        static TokensCreator()
        {
            globalId = 1;
        }

        private string[] types = new string[] {"ФЛ", "ЮЛ", "ДЛ"};
        private string[] fios = new string[] { "ФИО_1", "ФИО_2", "ФИО_3"};
        private string[] departments = new string[] {"Отдел_1", "Отдел2", "Отдел3"};
        private string[] destinys = new string[] {"ФИР", "СООН", "ЕУПС"};
        private string[] actions = new string[] {"Авторизация", "Подпись" };
        private string[] certCenters = new string[] { "УЦ ФНС", "УЦ ФК"};
        private string[] statuses = new string[] {"Выдан" , "Изъят", "Срок истек"};

        public Token GetContact()
        {
            string type = this.types[Random.Shared.Next(this.types.Length)]; ;
            string fio = this.fios[Random.Shared.Next(this.fios.Length)];
            string department = this.departments[Random.Shared.Next(this.departments.Length)];
            string destiny = this.destinys[Random.Shared.Next(this.destinys.Length)];
            string action = this.actions[Random.Shared.Next(this.actions.Length)];
            string certCenter = this.certCenters[Random.Shared.Next(this.certCenters.Length)];
            string status = this.statuses[Random.Shared.Next(this.statuses.Length)];

            Token token = new();
            token.Id = globalId++;
            token.Type = type;
            token.FIO = fio;
            token.Department = department;
            token.Destiny = destiny;
            token.Action = action;
            token.SerialNumber = " ";
            token.InterCertCenter = certCenter;
            token.RootCertCenter = certCenter;
            token.Status = status;
            token.DateStart = GetDate();
            token.DateEnd = GetDate();

            return token;
        }

        public DateTime GetDate()
        {
            Random random = new();
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }
    }
}
