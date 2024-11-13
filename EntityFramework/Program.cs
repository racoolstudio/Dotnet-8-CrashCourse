using EntityFramework.models;
using EntityFramework.dataEF;

ComputerDataBase  TownSuite = new ComputerDataBase(){};

Computer linux = new Computer(){};
linux.MemorySpace = 4.5m;
linux.Os = "Windows";
linux.CPUCores=3;
linux.HasWifi=true;
linux.ReleaseDate= DateTime.Now;

TownSuite.Add(linux);
TownSuite.SaveChanges();

IEnumerable<Computer>? result = TownSuite.Computer?.ToList<Computer>();
Console.WriteLine("Computer ID "+" OS "+" CPU CORES"+ " HasWifi "+" Release Date "+ "  MemorySpace" );
foreach(Computer r in result){
    Console.WriteLine(r.ComputerId+"  "+ r.Os+"  "+ r.CPUCores+" "+r.HasWifi+" "+r.ReleaseDate+" "+r.MemorySpace);
}