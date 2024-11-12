namespace HelloWorld.models{
    public class Computer{
        public int ComputerId {get;set;}
        public string Os{get;set;}= "";

        public int CPUCores {get;set;}
        public DateTime ReleaseDate {get;set;}
        public bool HasWifi {get;set;}
        public decimal MemorySpace {get;set;}


    }
}