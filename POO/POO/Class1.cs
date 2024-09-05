using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Class1
    {

        private string _nome;
        private int _quantidade;
        private decimal _preco;


         /*PODE SE USAR TBM PORÉM SEM TRATAMENTO
            public string Nome {get; set;} 
       
        */
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Nome está vazio");
                }
                _nome = value;
            }
        }

        //usar para quando não preciso de tratamento, então posso usar sem criar a variavel a cima chamada _quantidade
        public int Quantidade
        {
            get
            {
                return _quantidade;
            }
            set
            {
                if(value > 0)
                {
                    _quantidade = value;
                }

                _quantidade = 1;
            }
        }

        public class1()
        {
            _quantidade = 1;
        }
    }
}



        //public string getNome()
        //{
        //    return _nome;
        // }
        //public void setNome(string nome)
        //{
        //
        //   if (string.IsNullOrEmpty(nome))
        //   {
        //      throw new ArgumentNullException("nome está vazio");
        // }; 
        // this._nome = nome;
        //}
        // }
        //}
