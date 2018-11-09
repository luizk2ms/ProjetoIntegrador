using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Digudão.Validacoes
{
    class exReg
    {
        public void ValidarValor(string valor)
        {
            if (valor == string.Empty)
                throw new ArgumentException("O valor não pode estar em branco.");

            Regex regra1 = new Regex(@"^\d{0,}(,\d{2})?$");

            if (regra1.IsMatch(valor) == false)
                throw new ArgumentException("O valor não está num formato válido.");
        }

        public void ValidarEmail(string email)
        {
            if (email == string.Empty)
                throw new ArgumentException("O email não pode estar em branco.");

            Regex regra1 = new Regex(@"^[a-z0-9.]+@[a-z0-9]+\.[a-z]+(\.[a-z]+)?$");

            if (regra1.IsMatch(email) == false)
                throw new ArgumentException("O email não parece ser válido.");
        }

        public void ValidarNome(string nome)
        {
            if (nome == string.Empty)
                throw new ArgumentException("O nome não pode estar em branco.");

            Regex regra1 = new Regex(@"^[A-Za-z ]{0,}$");

            if (regra1.IsMatch(nome) == false)
                throw new ArgumentException("O nome pode conter apenas letras e espaços.");
        }

        public void ValidarTelefoneFixo(string telefone)
        {

            if (telefone != "(  )     -")
            {
                if (telefone.Length != 14)
                    throw new ArgumentException("Digite o telefone corretamente");

                if (telefone.Substring(0, 4).Contains(" "))
                    throw new ArgumentException("Digite o telefone corretamente");

                if (telefone.Substring(5).Contains(" "))
                    throw new ArgumentException("Digite o telefone corretamente");

                Regex regra1 = new Regex(@"^\([0-9]{2}\)$");
                Regex regra2 = new Regex(@"^\([0-9]{2}\)[0-9]{4}-[0-9]{4}$");

                if (regra1.IsMatch(telefone.Substring(1, 2)) != false)
                    throw new ArgumentException("DD é inválido!");

                if (regra2.IsMatch(telefone) != false)
                    throw new ArgumentException("O telefone é invalido!"); 
            }
        }

        public void ValidarTelefoneCelular(string telefone)
        {

            if (telefone != "(  )      -")
            {
                if (telefone.Length != 15)
                    throw new ArgumentException("Digite o celular corretamente");

                if (telefone.Substring(0, 4).Contains(" "))
                    throw new ArgumentException("Digite o celular corretamente");

                if (telefone.Substring(5).Contains(" "))
                    throw new ArgumentException("Digite o celular corretamente");

                Regex regra1 = new Regex(@"^\([0-9]{2}\)$");
                Regex regra2 = new Regex(@"^\([0-9]{2}\)[0-9]{4}-[0-9]{4}$");

                if (regra1.IsMatch(telefone.Substring(1, 2)) != false)
                    throw new ArgumentException("DD é inválido!");

                if (regra2.IsMatch(telefone) != false)
                    throw new ArgumentException("O telefone é invalido!"); 
            }
        }

        public bool ValidarSenha(string senha)
        {
            if (senha.Contains(" "))
                throw new ArgumentException("Não utilize espaço na senha!");

            if (senha.Length >= 16 || senha.Length < 5)
                throw new ArgumentException("A senha deve ter entre 4 e 16 caractéres");

            return true;
        }

        public bool ValidarSalario(string salario)
        {
            Regex regra1 = new Regex(@"^[0-9]{1,10}(,[0-9]{2})?$");

            if (regra1.IsMatch(salario) == false)
                throw new ArgumentException("Formato de salario inválido!");

            return true;
        }
    }
}
