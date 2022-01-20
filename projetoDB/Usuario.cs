using System;

namespace projetoDB
{

    class Usuario {
        
        // USAR DPS EM JULIO PNC

        private String nome { get; set; }
        private String login { get; set; }
        private String senha { get; set; }

        private Tipo tipo { get; set; }

        public Usuario(string nome, string login, string senha, Tipo tipo)
        {
            this.nome = nome;
            this.login = login;
            this.senha = senha;
            this.tipo = tipo;
        }

        public enum Tipo {

             USUARIO,
            ADMINISTRADOR
        }
    }
}
