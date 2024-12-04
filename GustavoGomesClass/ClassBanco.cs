using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GustavoGomesClass
{
    internal class Banco();
    public static MySqlCommand Abrir(int cod = 0) // método para abrir conexão
    {
        string strcon = @"server=10.91.45.47;database=systinsdb01;user=aluno;password=senac";
        MySqlConnection cn = new(strcon);
        MySqlCommand cmd = new();
        try
        {
            cn.Open();
            cmd.Connection = cn;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }

        return cmd;
    }
}
