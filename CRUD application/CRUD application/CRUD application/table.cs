namespace CRUD_implementation
{
    //Inheritance
    class table :database
    {
        public List<user> users;
        private int table_id;
        private string table_name;
        public table()
        {
            users = new List<user>();
            table_ID();
        }
        
        //Polymorphism
        public override void table_ID()
        {
            table_id = Table_id;
            Table_id++;
        }
        public void set_table_name()
        {
            Console.Write("table name is :");
            table_name = Console.ReadLine();
        }
        public void add_table()
        {
            DB.Add(this);
        }
        public int get_id()
        {
            return table_id;
        }
        
    }
}
