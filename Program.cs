using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceQcm
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
     
    class Evaluation
    {
        public string matiére { get; set; } = "matiére";
        public DateTime Duré { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Enonce { get; set; }


        public Evaluation(string matiére, DateTime datedebut, DateTime datefin)
        {
            this.matiére = matiére;
            this.DateDebut = datedebut;
            this.DateFin = datefin;

        }


        public Evaluation(string enonce)
        {
            this.Enonce = enonce;
        }
        class question
        {
            float notereponse;
            string enonce;
        }
        class Qcm : question
        {
            public float Certitude { get; set; } = 0;
            public Qcm(float certitude, string enonce)
            {
                this.Certitude = certitude;
            }

            }

        }

    }
}








