using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace Banque
{
    class dbManip
    {
        SqlConnection connection;

        public dbManip()
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\user\documents\visual studio 2015\Projects\Banque\Banque\bdb.mdf;Integrated Security=True");
        }

        public void openConnection()
        {
            
             connection.Open();
            
        }

        public void closeConnection()
        {
            connection.Close();
            
        }
        public SqlConnection getConnection()
        {
            return connection;
        }

        // manipulation du base de donné

        public int verifConnection(String user,String pass)
        {
            //dbManip db = new dbManip();
            SqlCommand cmd = new SqlCommand("Select Count(*) from admin where userid = @username and pass = @password", getConnection());
            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@password", pass);
            openConnection();
            //MessageBox.Show(userField.Text + password.Text);
            int result = (int)cmd.ExecuteScalar();
            closeConnection();
            return result;
        }

        public void deposit(float amount,int id)
        {

            SqlCommand cmd = new SqlCommand("update client set balance = @solde where Id = @id", getConnection());
            float solde = getBalance(id) + amount;
            cmd.Parameters.AddWithValue("@solde", solde);
            cmd.Parameters.AddWithValue("@Id", id);
            openConnection();
                cmd.ExecuteNonQuery();
                closeConnection();

        }
        public void withdraw(float amount, int id)
        {

            SqlCommand cmd = new SqlCommand("update client set balance = @solde where Id = @id", getConnection());
            float solde = getBalance(id) - amount;
            cmd.Parameters.AddWithValue("@solde", solde);
            cmd.Parameters.AddWithValue("@Id", id);
            openConnection();
            cmd.ExecuteNonQuery();
            closeConnection();
        }

        public void addClient(string name, string lastn, int phone, int nci)
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO client VALUES(@id, @name, @lastName, @phone, @NCI, @balance)", getConnection());
            int id = (new Random().Next(100000, 1000000));
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@lastName", lastn);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@NCI", nci);
            cmd.Parameters.AddWithValue("@balance", 0);
            try
            {
                openConnection();
                cmd.ExecuteNonQuery();
                closeConnection();
            }catch(Exception e) { }
            string path = @"C:\Users\User\Documents\Visual Studio 2015\Projects\Banque\Banque\info.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(name + " " + lastn + " id = " + id + "\n");
            }
        }
        public String getName(int id)
        {

            SqlCommand cmd = new SqlCommand("Select name from client where Id = @id", getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            openConnection();
            var name = cmd.ExecuteScalar();
            closeConnection();
            if (name != null)
            {
                return name.ToString();
            }else { return "vide"; }
            
        }
        public String getLname(int id)
        {

            SqlCommand cmd = new SqlCommand("Select lastName from client where Id = @id", getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            openConnection();
            var name = cmd.ExecuteScalar();
            closeConnection();
            if (name != null)
            {
                return name.ToString();
            }
            else { return "vide"; }

        }
        public int getNci(int id)
        {

            SqlCommand cmd = new SqlCommand("Select NCI from client where Id = @id", getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            openConnection();
            var name = cmd.ExecuteScalar();
            closeConnection();
            if (name != null)
            {
                return (int)name;
            }
            else { return 0; }

        }
        public float getBalance(int id)
        {

            SqlCommand cmd = new SqlCommand("Select balance from client where Id = @id", getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            openConnection();
            var name = cmd.ExecuteScalar();
            closeConnection();
            if (name != null)
            {
                return float.Parse(name.ToString());
            }
            else { return 0; }

        }



    }
}
