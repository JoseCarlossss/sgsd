using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
using XMLtoDatabase.Processors;

namespace XMLtoDatabase
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var connectionString = "sua_connection_string_aqui";
            var connection = new SqlConnection(connectionString);
            var processor = new AccessoryRollStatusProcessor(connection);
            processor.Import("caminho_para_o_arquivo/AccessoryStatusInfo.xml");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
