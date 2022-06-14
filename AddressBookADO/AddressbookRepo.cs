using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace AddressBookADO
{
    public class AddressbookRepo
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DMPB7U8\MSSQLSERVER01; Initial Catalog =Addressbook_system; Integrated Security = True;");
        AddressBookModel Model = new AddressBookModel();

        public void GetAllData()
        {
            try
            {



                using (this.connection)
                {
                    string query = @"SELECT Firstname,Lastname,Address,City,State,Zip,Email,phone,Type from Addressbook;";

                    //define the SqlCommand Object
                    SqlCommand cmd = new SqlCommand(query, this.connection);

                    this.connection.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    //check if there are records

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            Model.Firstname = dr.GetString(0);
                            Model.Lastname = dr.GetString(1);
                            Model.Address = dr.GetString(2);
                            Model.City = dr.GetString(3);
                            Model.State = dr.GetString(4);
                            Model.Zip = dr.GetInt32(5);
                            Model.Email = dr.GetString(6);
                            Model.phone = dr.GetInt64(7);
                            Model.Type = dr.GetString(8);


                            //display retrieve record
                            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}", Model.Firstname, Model.Lastname, Model.Address, Model.City, Model.State, Model.Zip, Model.Email, Model.phone, Model.Type);
                            Console.WriteLine("\n");

                        }
                    }
                    else
                    {
                        Console.WriteLine("No data found");
                    }
                    //close data reader
                    dr.Close();

                    this.connection.Close();
                }
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }

        }

        public bool UpdateContact(AddressBookModel model)
        {
            try
            {

                using (this.connection)
                {
                    SqlCommand cmd = new SqlCommand("SpAddressBookUpdate", this.connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Firstname", model.Firstname);
                    cmd.Parameters.AddWithValue("@LastName", model.Lastname);
                    cmd.Parameters.AddWithValue("@Address", model.Address);
                    cmd.Parameters.AddWithValue("@City", model.City);
                    cmd.Parameters.AddWithValue("@State", model.State);
                    cmd.Parameters.AddWithValue("@Zip", model.Zip);
                    cmd.Parameters.AddWithValue("@Email", model.Email);
                    cmd.Parameters.AddWithValue("@phone", model.phone);
                    cmd.Parameters.AddWithValue("@Type", model.Type);

                    this.connection.Open();
                    var result = cmd.ExecuteNonQuery();
                    this.connection.Close();
                    if (result != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
            return false;
        }
    

    public void GetAllContactByState()
    {
        try
            { 
        
            using (this.connection)
            {
                string Query = @"Select * from AddressBook where State='UP';";
                SqlCommand cmd = new SqlCommand(Query, this.connection);
                this.connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Model.Firstname = dr.GetString(0);
                        Model.Lastname = dr.GetString(1);
                        Model.Address = dr.GetString(2);
                        Model.City = dr.GetString(3);
                        Model.State = dr.GetString(4);
                        Model.Zip = dr.GetInt32(5);
                        Model.Email = dr.GetString(6);
                        Model.phone = dr.GetInt64(7);
                        Model.Type = dr.GetString(8);
                        Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}", Model.Firstname, Model.Lastname, Model.Address, Model.City, Model.State, Model.Zip, Model.Email, Model.phone, Model.Type);
                        Console.WriteLine("\n");
                    }

                    }
                }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public void GetAllContactByCity()
    {
        try
        
            { 
        
            using (this.connection)
            {
                string Query = @"Select * from AddressBook where city='Kanpur';";
                SqlCommand cmd = new SqlCommand(Query, this.connection);
                this.connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Model.Firstname = dr.GetString(0);
                        Model.Lastname = dr.GetString(1);
                        Model.Address = dr.GetString(2);
                        Model.City = dr.GetString(3);
                        Model.State = dr.GetString(4);
                        Model.Zip = dr.GetInt32(5);
                        Model.Email = dr.GetString(6);
                        Model.phone = dr.GetInt64(7);
                        Model.Type = dr.GetString(8);
                        Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}", Model.Firstname, Model.Lastname, Model.Address, Model.City, Model.State, Model.Zip, Model.Email, Model.phone, Model.Type);
                        Console.WriteLine("\n");
                    }

                    }
                }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
}
       
        
            


  
