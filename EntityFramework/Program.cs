using EntityFramework.models;
using EntityFramework.dataEF;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
// using Newtonsoft.Json;
using AutoMapper;
IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

Console.WriteLine(configuration["dbConnectionString:DefaultConnection"]);

// ComputerDataBase  TownSuite = new ComputerDataBase(configuration){};

// Computer linux = new Computer(){};
// linux.MemorySpace = 4.5m;
// linux.Os = "Windows";
// linux.CPUCores=3;
// linux.HasWifi=true;
// linux.ReleaseDate= DateTime.Now;

// TownSuite.Add(linux);
// TownSuite.SaveChanges();

// File.WriteAllText("data.csv","[");
// using StreamWriter file = new ("data.csv",append:true);
// file.WriteLine("Computer ID,OS,CPU CORES,HasWifi,Release Date,MemorySpace");

// IEnumerable<Computer>? result = TownSuite.Computer?.ToList<Computer>();

// Using NewtonSoft Json
// string serialiseNewton = JsonConvert.SerializeObject(result);
// File.WriteAllText("newtonsoft.json",serialiseNewton);



// Using System Text Json  
// string serialise = JsonSerializer.Serialize(result);
// File.WriteAllText("check.json",serialise);


// Console.WriteLine("Computer ID,"+"OS,"+"CPU CORES,"+"HasWifi,"+"Release Date,"+"MemorySpace" );
// foreach(Computer r in result){
//     Console.WriteLine(r.ComputerId+","+ r.Os+","+ r.CPUCores+","+r.HasWifi+","+r.ReleaseDate+","+r.MemorySpace);
//     file.WriteLine(r.ComputerId+","+ r.Os+","+ r.CPUCores+","+r.HasWifi+","+r.ReleaseDate+","+r.MemorySpace);
// }

// file.Close();


// Using System Text Json  
// IEnumerable<Computer> d = JsonSerializer.Deserialize<IEnumerable <Computer>>(serialise);

// Using NewtonSoft Json

// IEnumerable<Computer> d = JsonConvert.DeserializeObject<IEnumerable <Computer>>(serialiseNewton);

// foreach(Computer c in d){
//     Console.WriteLine(c.Os);
// }


// Adding Json to Database 

// string source = File.ReadAllText("check.json");

// IEnumerable<Computer> computersData = JsonConvert.DeserializeObject<IEnumerable<Computer>>(source);  
// ComputerDataBase  NewData = new ComputerDataBase(configuration){};

// foreach(Computer c in computersData){
//     NewData.Add(c);
// }

// NewData.SaveChanges();

// string data = File.ReadAllText("data.csv");
// Console.WriteLine("From File : " + data);

// Auto Mapping 

string snake_data = File.ReadAllText("snake_case.json");
// Mapper mapper = new Mapper(new MapperConfiguration((mapperConfig)=>{
//     mapperConfig.CreateMap<ComputerSnake,Computer>()
//     .ForMember(dest=>dest.ComputerId,options=>
//         options.MapFrom(src=>src.computer_id))
//     .ForMember(dest=>dest.Os,options=>
//         options.MapFrom(src=>src.os))
//     .ForMember(dest=>dest.CPUCores,options=>
//         options.MapFrom(src=>src.cpu_cores))
//     .ForMember(dest=>dest.ReleaseDate,options=>
//         options.MapFrom(src=>src.release_date))
//     .ForMember(dest=>dest.HasWifi,options=>
//         options.MapFrom(src=>src.has_wifi))
//     .ForMember(dest=>dest.MemorySpace,options=>
//     //manipluation
//         options.MapFrom(src=>src.memory_space*0.1m));

// }  ));
// ComputerDataBase  NewData = new ComputerDataBase(configuration){};

// IEnumerable<ComputerSnake> computerSnake = JsonConvert.DeserializeObject<IEnumerable<ComputerSnake>>(snake_data);
// IEnumerable<Computer> convertedComputer = mapper.Map<IEnumerable<Computer>>(computerSnake);
// foreach(Computer c in convertedComputer){
//         NewData.Add(c);
// }
// NewData.SaveChanges();


// Using JsonPropertyName()

ComputerDataBase  NewData = new ComputerDataBase(configuration){};

IEnumerable<Computer> computerConverted = JsonSerializer.Deserialize<IEnumerable<Computer>>(snake_data);

foreach(Computer c in computerConverted){
        NewData.Add(c);
}

NewData.SaveChanges();
