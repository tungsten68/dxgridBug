using System;
using System.Collections.ObjectModel;
using dxgridBug.Models;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;

namespace dxgridBug.ViewModels
{
    [POCOViewModel]
    public class ContactViewModel
    {
        public ContactViewModel()
        {
            Items = Seed("JG", "Jennifer Grogl", "Schladming");
            ItemsWithAtt = SeedWithAtt("JGWA", "Jennifer Grogl With Att", "Schladming");
        }

        public virtual ObservableCollection<Contact> Items { get; set; }
        public virtual Contact Current { get; set; }
        public virtual ObservableCollection<ContactWithAtt> ItemsWithAtt { get; set; }
        public virtual Contact CurrentWittAtt { get; set; }

        public void Search()
        {
            Items = Seed("WS", "Wolfram Steiner", "Groebming");
            ItemsWithAtt = SeedWithAtt("WSWA", "Wolfram Steiner With Att", "Groebming");
        }

        private ObservableCollection<Contact> Seed(string code, string name, string city)
        {
            var coll = new ObservableCollection<Contact>();
            for (int i = 1; i < 50; i++)
            {
                coll.Add(new Contact { Code = code + i, Name = name + i, City = city });
            }

            return coll;
        }

        private ObservableCollection<ContactWithAtt> SeedWithAtt(string code, string name, string city)
        {
            var coll = new ObservableCollection<ContactWithAtt>();
            for (int i = 1; i < 50; i++)
            {
                coll.Add(new ContactWithAtt { Code = code + i, Name = name + i, City = city });
            }
            return coll;
        }
    }
}