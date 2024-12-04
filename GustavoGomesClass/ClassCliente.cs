using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GustavoGomesClass
{
    public class Cliente
    {
        public int Id_cliente { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set;}
        public string? Telefone { get; set;}
        public string? Endereco { get; set;}
    
   
       public Cliente(int id_cliente, string? nome, string? email, string? telefone, string? endereco)
       {
        Id_cliente = id_cliente;
        Nome = nome;
        Email = email;
        Telefone = telefone;
        Endereco = endereco;
       }
       public Cliente(int id_cliente, string? nome)
       {
        Id_cliente = id_cliente;
        Nome = nome;
       }
       public Cliente(int id_cliente, string? nome,  string? telefone)
       {
        Id_cliente = id_cliente;
        Nome = nome;
        Telefone = telefone;
       }
       public void Inserir()
       {
        var cmd = Banco.Abrir();
        cmd.Parameters.AddwithValue = Id;
        cmd.Parameters.AddWithValue = Nome;
        cmd.Parameters.AddWithValue = Email;
        cmd.Parameters.AddWithValue = Telefone;
        cmd.Parameters.AddWithValue = Endereco;
       }
       public bool Atualizar()
       {
        var cmd = Banco.Abrir();
        cmd.Parameters.AddwithValue = Id;
        cmd.Parameters.AddWithValue = Nome;
       }
        public static cliente ObterPorId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from clientes where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cliente = new(
                    dr.GetInt(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    cliente.ObterPorId(dr.GetInt32(4))
                    );
                
            }
            return cliente;
        }
        public static List<Cliente> ObterLista()
        {
            List<Cliente> Lista= new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from clientes order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Cliente.ObterPorId(dr.GetInt32(4))
            }
        }
    } 
   
}
