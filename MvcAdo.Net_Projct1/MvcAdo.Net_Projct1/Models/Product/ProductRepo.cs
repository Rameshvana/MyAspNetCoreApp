
using Microsoft.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace MvcAdo.Net_Projct1.Models.Product
{
    public class ProductRepo

    {
        public readonly string _ConnectionString;

        public ProductRepo(IConfiguration configuration)
        {
            _ConnectionString = configuration.GetConnectionString("DefaultConnection");
        }


        public List<Product> GetProducts()
        {
            List<Product> productsList = new List<Product>();

            try
            {
                using (var conn = new SqlConnection(_ConnectionString))
                {
                    conn.Open();
                    var command = new SqlCommand("sp_GetAllProducts", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        productsList.Add(new Product
                        {
                            Id = reader["Id"] != DBNull.Value ? (int)reader["Id"] : 0,
                            Name = reader["Name"].ToString(),
                            Description = reader["Description"] != DBNull.Value ? reader["Description"].ToString() : null,
                            Price = reader["Price"] != DBNull.Value ? Convert.ToDecimal(reader["Price"]) : 0,
                            StockQuantity = reader["StockQuantity"] != DBNull.Value ? (int)reader["StockQuantity"] : 0,
                            Category = reader["Category"] != DBNull.Value ? reader["Category"].ToString() : null
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching products: " + ex.Message);
                // You can also log this or rethrow it
            }

            return productsList;
        }

        public string InsertProduct(Product data)
        {

            try
            {
                using (var conn = new SqlConnection(_ConnectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand("sp_AddProduct", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@Name", data.Name);
                    cmd.Parameters.AddWithValue("@Description", data.Description);
                    cmd.Parameters.AddWithValue("@Price", data.Price);
                    cmd.Parameters.AddWithValue("@StockQuantity", data.StockQuantity);
                    cmd.Parameters.AddWithValue("@Category", data.Category);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        return "Product added successfully.";
                    else
                        return "Product could not be added. No rows affected.";

                }
            }
            catch (SqlException ex)
            {
                return "SQL Error while adding product: " + ex.Message;
            }
            catch (Exception ex)
            {
                return "Unexpected error: " + ex.Message;
            }



        }

        public string DeleteProduct(int id)
        {
            try
            {
                using (var conn = new SqlConnection(_ConnectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand("sp_DeleteProduct", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@Id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        return "Product deleted successfully..!";
                    else
                        return "Product could not be deleted. No rows affected.";
                }
            }
            catch (SqlException ex)
            {
                return "SQL Error while adding product: " + ex.Message;
            }
            catch (Exception ex)
            {
                return "Unexpected error: " + ex.Message;
            }
        }

        public string UpdateProduct(Product data)
        {
            try
            {
                using (var conn = new SqlConnection(_ConnectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand("sp_UpdateProduct", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@Id", data.Id);
                    cmd.Parameters.AddWithValue("@Name", data.Name);
                    cmd.Parameters.AddWithValue("@Description", data.Description);
                    cmd.Parameters.AddWithValue("@Price", data.Price);
                    cmd.Parameters.AddWithValue("@StockQuantity", data.StockQuantity);
                    cmd.Parameters.AddWithValue("@Category", data.Category);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        return "Product Updated successfully..!";
                    else
                        return "Product could not be Updated. No rows affected.";
                }
                }
                catch (SqlException ex)
                {
                    return "SQL Error while adding product: " + ex.Message;
                }
                catch (Exception ex)
                {
                    return "Unexpected error: " + ex.Message;
                }
        }
    }
}
