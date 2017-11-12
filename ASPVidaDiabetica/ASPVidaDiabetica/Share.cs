using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPVidaDiabetica
{
    public class Share
    {
        public string nome;
        public string rg;
        public string cpf;
        public string endereco;
        public string tel;
        public string email;
        public string datanasc;
        public string cel;
        public string func;

        public void setNome (string val)
        {
            nome = val;
        }
        public string getNome()
        {
            return nome;
        }
        public void setRG(string val)
        {
            rg = val;
        }
        public string getRG()
        {
            return rg;
        }
        public void setCPF(string val)
        {
            cpf = val;
        }
        public string getCPF()
        {
            return cpf;
        }
        public void setEmail(string val)
        {
            email = val;
        }
        public string getEmail()
        {
            return email;
        }
        public void setEndereco(string val)
        {
            endereco = val;
        }
        public string getEndereco()
        {
            return endereco;
        }
        public void setTel(string val)
        {
            tel = val;
        }
        public string getTel()
        {
            return tel;
        }
        public void setCel(string val)
        {
            cel = val;
        }
        public string getCel()
        {
            return cel;
        }
        public void setDataNasc(string val)
        {
            datanasc = val;
        }
        public string getDataNasc()
        {
            return datanasc;
        }

        public void setFunc(string val)
        {
            func = val;
        }

        public string getFunc()
        {
            return func;
        }
    }
}