using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _12_ADONET_1_Giris
{
    public class ProductDal
    {
        public DataTable getAll()
        {
            // @ -> Yazilan her seyi string kabul et demektir. Kacis karakterinden (\)
            // kurtulmak icin kullaniyoruz.
            SqlConnection connection = new SqlConnection
                (@"server=(localdb)\MSSQLLocalDB;
                   initial catalog=ETrade;
                   integrated security=true"
                );
            //Baglanti Kapaliysa Ac
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            //SQL ile iletisim kurmak icin SQL komutlarindan yararlaniriz.
            SqlCommand command = new SqlCommand("Select * from Products",connection);
            SqlDataReader reader =  command.ExecuteReader();//Calistirmak icin EXECUTE BUTONU'na basariz. Bu da bir nevi o demektir.

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            reader.Close();
            connection.Close();

            return dataTable;
        }
    }
}
