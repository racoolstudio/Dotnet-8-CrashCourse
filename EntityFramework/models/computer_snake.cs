namespace EntityFramework.models{
    public class ComputerSnake{
        public int computer_id {get;set;}
        public string os{get;set;}= "";

        public int cpu_cores {get;set;}
        public DateTime release_date {get;set;}
        public bool has_wifi {get;set;}
        public decimal memory_space {get;set;}


    }
}