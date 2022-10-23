using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    internal class TeDoen
    {
        public int ID { get; set; }
        public int counterId;
        public string Title { get; set; }
        public string[] Informatie { get; set; }

        public DateTime? Tijdstip { get; set; }

        public TeDoen(string title, string[] informatie, DateTime tijdstip)
        {
          
            counterId++;
            ID=counterId;

            Title=title;
            Informatie=informatie;

            if(tijdstip <= DateTime.Now)
            {
                Tijdstip = null;

            }else if (tijdstip >= DateTime.Now)
            {
                Tijdstip=tijdstip;
            }
            
        }

        public override string ToString()
        {
            string content = "";
            foreach (string s in Informatie)
                content += s.ToString() + "/ ";
            return content;
        }
    }
}
