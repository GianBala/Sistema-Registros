using System.Collections.Generic;
namespace PROJ_01;

public class Usuario
{
    private int id;
    internal int ID { get; set; }

    private int id_level;
    internal int ID_level 
    { 
      get
      {
            return id_level;
      }
      set 
      {
            if (value >= 0 && value <= 3)
                id_level = value;
            else
                throw new ArgumentException("ID Inválido");
       } 
    }

    private string nome;
    internal string Nome
    {
        get
        {
            return nome;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
                nome = value;
            else
                throw new ArgumentException("Nome Inválido");

        }
    }

    private string login;
    internal string Login
    {
        get
        {
            return login;
        }
        set
        {
            if (!string.IsNullOrEmpty(value) || value.Contains(" "))
                if (value.Length >= 5)
                    login = value;
                else throw new ArgumentException("Login Muito Curto");
            else
                throw new ArgumentException("Login Inválido");

        }
    }

    private string senha;
    internal string Senha
    {
        get
        {
            return senha;
        }
        set
        {
            if (!string.IsNullOrEmpty(value) || value.Contains(" "))
                if (value.Length >= 5)
                    senha = value;
                else throw new ArgumentException("Senha Muito Curta");
            else
                throw new ArgumentException("Senha Inválida");

        }
    }

    private List<Mensagem> listaNotificacao = new List<Mensagem>();
    internal List<Mensagem> ListaNotificacao
    {
        get
        {
            return listaNotificacao;
        }
        set
        {
            listaNotificacao = value;
        }
    }
    public Usuario(string nome, string login, string senha, int id_level)
    {
        this.nome = nome;
        this.login = login;
        this.senha = senha;
        this.id_level = id_level;
    }


}