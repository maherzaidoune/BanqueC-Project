# Banque C# Project
this program was created as a essths c# project
a simple banking project written in **c#** using visual studio 2015,use it as **a blueprint ** for your projects development 
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

user name and password to use on testing :
**user maher**
**pass 12346**
        
        
[Download it from here](https://github.com/maherzaidoune/BanqueC-Project/blob/master/Banque.exe)



