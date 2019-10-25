using MySql.Data.MySqlClient;
using System;
using System.Data;
using vv_api.Services.Interface;

namespace vv_api.Services.Service
{
    public class PontoService : IPontoService
    {
        public string[] ObterPontos()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=mysql942.umbler.com; Port=41890; Database=vvcorp; Uid=u_sys; Pwd=Qwerty010203;");
                connection.Open();
            }
            catch (Exception ex)
            {

                throw;
            }
            


            return new string[] { "Ponto 1", "Ponto 2", "Ponto 3" };
        }
    }
}
