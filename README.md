# Banque C# Project
this program was created as a essths c# project
a simple banking project written in **c#** using visual studio 2015,use it as a blueprint for your projects development 
this an oop project

*code Exemple :*

code from dbManip class (data base manipulation)

```
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
```

code from Withdraw class 

```
private void withdrawW_Click(object sender, EventArgs e)
        {
            
            dbManip db = new dbManip();
            try
            {
                float a = float.Parse(amountW.Text);
                int id = int.Parse(idW.Text);
            
            if (float.Parse(amountW.Text) < db.getBalance(id))
            {
                db.withdraw(float.Parse(amountW.Text), id);
                MessageBox.Show("Withdraw " + amountW.Text + " !");
            }else
            {
                MessageBox.Show("Insufficient Funds");
            }
            }
            catch (Exception ex) { MessageBox.Show("Enter a valid amount"); }
        }
```
add data base files [here](https://github.com/maherzaidoune/BanqueC-Project/blob/master/Banque/bdb.mdf) and [here](https://github.com/maherzaidoune/BanqueC-Project/blob/master/Banque/bdb_log.ldf) to the project directory and change dbManip constructor with your dirctory 
c:\users\user\documents\visual studio 2015\Projects\Banque\Banque\bdb.mdf to yourDirectory/bdb.mdf here :
```
public dbManip()
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\user\documents\visual studio 2015\Projects\Banque\Banque\bdb.mdf;Integrated Security=True");
        }
   ```     
   or create your own data base and name it **bdb** with 2 table : admin and 
   ```
   CREATE TABLE [dbo].[admin] (
    [userid] VARCHAR (50) NOT NULL,
    [pass]   VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_admin] PRIMARY KEY CLUSTERED ([userid] ASC)
);
   ```
   ```
   CREATE TABLE [dbo].[client] (
    [Id]       INT          NOT NULL,
    [name]     VARCHAR (50) NULL,
    [lastName] VARCHAR (50) NULL,
    [phone]    VARCHAR (50) NULL,
    [NCI]      INT          NULL,
    [balance]  FLOAT (53)   NULL,
    CONSTRAINT [PK_client] PRIMARY KEY CLUSTERED ([Id] ASC)
);
   ```
   and refer to it in the dbManip constructor
   
user name and password to use on testing :

**user maher** ||
**pass 12346**

when you add a new customer , the ID is automatically generated and copied to BanqueC-Project/Banque/info.txt 
use that id to access to the account later
        
        
[Download it from here](https://github.com/maherzaidoune/BanqueC-Project/blob/master/Banque.exe)




