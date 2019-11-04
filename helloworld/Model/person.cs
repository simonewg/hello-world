using System;
using System.Collections.Generic;
using System.Text;

namespace helloworld.Model
{
    class Person
    {
        string nome;
        string cognome;
        public int eta;
        string sesso;
        int altezza;
        double peso;

        public Person(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.sesso = "sconosciuto";

        }

     
        public string Anagrafica()
            {
            string anagrafica = this.nome + this.cognome;
            return anagrafica;

               
            }
        


    }
}
