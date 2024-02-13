namespace POS
{
    internal class DBConnection
    {
        public string MyConnection()
        {
            string con = @"Data Source=.;Initial Catalog=POSSystem;Integrated Security=True;Encrypt=False";
            return con;
        }
    }
}
