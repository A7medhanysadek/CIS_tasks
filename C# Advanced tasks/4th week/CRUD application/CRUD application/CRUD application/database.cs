namespace CRUD_implementation
{
    //Abstraction
    abstract class database
    {
        protected List<table> DB=new List<table>();
        protected static int Table_id=0;
        public abstract void table_ID();
    }
}
