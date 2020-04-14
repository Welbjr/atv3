﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCarimbo
{
    class Carimbo:Interacao
    {
        //Atributos
        private string cor;
        private string texto;
        private int carga;

        //Construtor
        public Carimbo(string Ptexto)
        {
            trocarTexto(Ptexto);
        }

        //Metodos GET SET
        private string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        private string Texto
        {
            get { return texto; }
            set { texto = value; }
        }
        private int Carga
        {
            get { return carga; }
            set { carga = value; }
        }

        //Metodos do CONTRATO (interface)
        public void usar()
        {
            if (carga >= 1)
            {
                if (!String.IsNullOrEmpty(Texto))
                {
                    if (!String.IsNullOrEmpty(Cor))
                    {
                        Console.WriteLine("(" + texto + ") na cor" + Cor);
                        carga--;
                    }
                    else
                    {
                        Console.WriteLine("Impossível Carimbar - Carimbo está sem Cor.");
                    }
                    else 
                    {
                        Console.WriteLine("Impossível Carimbar - Carimbo está sem texto");
                    }
                    else 
                    {
                        Console.WriteLine("Impossível Carimbar - Carimbo está sem Carga");
                    }
                }

                public void carregar(string Pcor, int Pcarga)
                {
                    trocarCor(Pcor);
                    if((Pcarga < 1 && Pcarga > 10) && ((Carga + Pcarga) > 10))
                    {
                        Console.WriteLine("Carga atual" + Carga + ", A carga deve ser entre 1 e 10");
                    }
                    else
                    {
                        Carga = Pcarga;
                    }
                }

                public void trocarCor(string Pcor)
                {
                    if (Pcor == Cor)
                    {
                        Console.WriteLine("Carimbo já está com esta cor!");
                    }
                    else
                    {
                        Cor = Pcor;
                    }
                }

                public void trocarTexto(string Ptexto)
                {                                        
                    if (Ptexto == Texto)
                    {
                        Console.WriteLine("Carimbo já está com este texto.");
                    }
                    else
                    {
                        Texto = Ptexto;
                    }                    
                }
            }
        }
}
