using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;

namespace WinFormsApp1.ViewModel
{
    public class TokensViewModel
    {
        public List<Token> Tokens { get; set; }

        public TokensViewModel()
        {
            this.Tokens = new List<Token>();
        }

        public void Append(Token token)
        {
            this.Tokens.Add(token);
        }

        public List<Token> GetAll()
        {
            return this.Tokens.ToList();
        }

        public Token? Get(int id)
        {
            return this.Tokens.FirstOrDefault(x => x.Id == id) ?? null;
        }

        public void Update(int id, Token token)
        {
            var item = this.Tokens.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                item = token;
            }
        }

        public void Remove(int id)
        {
            var item = this.Tokens.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                this.Tokens.Remove(item);
            }            
        }

        public void AddToListView(ListView lv)
        {
            foreach(Token token in this.Tokens)
            {
                ListViewItem item = token.AddToListViewItem();
                lv.Items.Add(item);
            }
        }
    }
}
