using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete.Ado_Net
{
  public  class Connection
    {
        public static SqlConnection bgl()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RecipeSitee;Integrated Security=True");
            connect.Open();
            return connect;
        }
    }
}
