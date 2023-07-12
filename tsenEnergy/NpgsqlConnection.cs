namespace tsenEnergy
{
    internal class NpgsqlConnection
    {
        private string connectionString;

        public NpgsqlConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}