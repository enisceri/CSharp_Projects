using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ADONET_2_ListeyleCalismak
{

    class ProductDal
    {
        SqlConnection _connection = new SqlConnection
        (@"server=(localdb)\MSSQLLocalDB;
                       initial catalog=ETrade;
                       integrated security=true"
        );

        private void connectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public List<Product> getAll()
        {
            connectionControl();


            SqlCommand command = new SqlCommand("Select * from Products", _connection);
            SqlDataReader reader =  command.ExecuteReader();

            List<Product> products = new List<Product>();

            while(reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    ProductName = reader["ProductName"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };

                products.Add(product);
                
            }

            reader.Close();
            _connection.Close();

            return products;
        }

        public void addProduct(Product product)
        {
            connectionControl();
            SqlCommand command = new SqlCommand
            (
                "Insert into Products values(@ProductName,@UnitPrice,@StockAmount)",
                _connection
            );
            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);

            int  kayitSayisi = command.ExecuteNonQuery();

            _connection.Close();

            
            
        }

        public void updateProduct(Product product)
        {
            connectionControl();
            SqlCommand command = new SqlCommand
            (
                "Update Products set " +
                "ProductName =@ProductName," +
                "UnitPrice = @UnitPrice," +
                "StockAmount = @StockAmount " +
                "where Id = @Id"
                ,_connection
            );
            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@Id", product.Id);
            int kayitSayisi = command.ExecuteNonQuery();

            _connection.Close();



        }

        public void deleteProduct(int id)
        {
            connectionControl();
            SqlCommand command = new SqlCommand
            (
                "Delete from Products where Id = @Id",_connection
            );

            command.Parameters.AddWithValue("@Id",id);
            command.ExecuteNonQuery();

            _connection.Close();
        
        }
    }
}
