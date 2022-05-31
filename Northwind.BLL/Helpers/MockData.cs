using Northwind.DAL.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL.Helpers
{
    public static class MockData
    {
        public static IEnumerable<ProductCategory> GetSampleCategories(int pageNumber = 1 , int numberOfRows = 20)
        {
            var skip = (pageNumber -1) * numberOfRows;

            var productCategories = new List<ProductCategory>()
            {
                new ProductCategory()
                {
                ProductCategoryId= 1,
                ProductCategoryName= "Beverages",
                ProductCategoryDescription="Soft drinks, coffees, teas, beers, and ales",
                ProductCategoryPicture =Convert.FromBase64String("R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw==")
                },
                new ProductCategory()
                {
                ProductCategoryId = 2,
                ProductCategoryName = "Condiments",
                ProductCategoryDescription = "Sweet and savory sauces, relishes, spreads, and seasonings",
                ProductCategoryPicture=Convert.FromBase64String("R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw==")
                },
                new ProductCategory()
                {
                ProductCategoryId=3,
                ProductCategoryName="Confections",
                ProductCategoryDescription="Desserts, candies, and sweet breads",
                ProductCategoryPicture=Convert.FromBase64String("R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw==")
                },
                new ProductCategory()
                {
                ProductCategoryId=4,
                ProductCategoryName="Dairy Products",
                ProductCategoryDescription="Cheeses",
                ProductCategoryPicture=Convert.FromBase64String("R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw==")
                },
                new ProductCategory()
                {
                ProductCategoryId=5,
                ProductCategoryName="Grains/Cereals",
                ProductCategoryDescription="Breads, crackers, pasta, and cereal",
                ProductCategoryPicture=Convert.FromBase64String("R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw==")
                },
                new ProductCategory()
                {
                ProductCategoryId=6,
                ProductCategoryName="Meat/Poultry",
                ProductCategoryDescription="Prepared meats",
                ProductCategoryPicture=Convert.FromBase64String("R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw==")
                },
                new ProductCategory()
                {
                ProductCategoryId=7,
                ProductCategoryName="Produce",
                ProductCategoryDescription="Dried fruit and bean curd",
                ProductCategoryPicture=Convert.FromBase64String("R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw==")
                },
                new ProductCategory()
                {
                ProductCategoryId=8,
                ProductCategoryName="Seafood",
                ProductCategoryDescription="Seaweed and fish",
                ProductCategoryPicture=Convert.FromBase64String("R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw==")
                }
            };

            return productCategories.Skip(skip).Take(numberOfRows);
        }

        public static IEnumerable<Customer> GetSampleCustomers(int pageNumber = 1, int numberOfRows = 20)
        {
            var skip = (pageNumber - 1) * numberOfRows;

            var customers = new List<Customer>()
            {
                new Customer()
                {
                CustomerId= "ALFKI",
                CustomerName= "Alfreds Futterkiste",
                CustomerContactName= "Maria Anders",
                CustomerContactTitle= "Sales Representative",
                CustomerAddress= "Obere Str. 57",
                CustomerCity= "Berlin",
                RegionId=1,
                CustomerPostalCode= "12209",
                CustomerCountry= "Germany",
                CustomerPhone= "030-0074321",
                CustomerFax= "030-0076545"
                }, 
                new Customer()
                {
                CustomerId= "ANATR",
                CustomerName= "Ana Trujillo Emparedados y helados",
                CustomerContactName= "Ana Trujillo",
                CustomerContactTitle= "Owner",
                CustomerAddress= "Avda. de la Constitución 2222",
                CustomerCity= "México D.F.",
                RegionId=2,
                CustomerPostalCode= "05021",
                CustomerCountry= "Mexico",
                CustomerPhone= "(5) 555-4729",
                CustomerFax= "(5) 555-3745"
                }, 
                new Customer()
                {
                CustomerId= "ANTON",
                CustomerName= "Antonio Moreno Taquería",
                CustomerContactName= "Antonio Moreno",
                CustomerContactTitle= "Owner",
                CustomerAddress= "Mataderos  2312",
                CustomerCity= "México D.F.",
                RegionId=3,
                CustomerPostalCode= "05023",
                CustomerCountry= "Mexico",
                CustomerPhone= "(5) 555-3932",
                CustomerFax= ""
                }, 
                new Customer()
                {
                CustomerId= "AROUT",
                CustomerName= "Around the Horn",
                CustomerContactName= "Thomas Hardy",
                CustomerContactTitle= "Sales Representative",
                CustomerAddress= "120 Hanover Sq.",
                CustomerCity= "London",
                RegionId=4,
                CustomerPostalCode= "WA1 1DP",
                CustomerCountry= "UK",
                CustomerPhone= "(171) 555-7788",
                CustomerFax= "(171) 555-6750"
                }, 
                new Customer()
                {
                CustomerId= "BERGS",
                CustomerName= "Berglunds snabbköp",
                CustomerContactName= "Christina Berglund",
                CustomerContactTitle= "Order Administrator",
                CustomerAddress= "Berguvsvägen  8",
                CustomerCity= "Luleå",
                RegionId=1,
                CustomerPostalCode= "S-958 22",
                CustomerCountry= "Sweden",
                CustomerPhone= "0921-12 34 65",
                CustomerFax= "0921-12 34 67"
                }, 
                new Customer()
                {
                CustomerId= "BLAUS",
                CustomerName= "Blauer See Delikatessen",
                CustomerContactName= "Hanna Moos",
                CustomerContactTitle= "Sales Representative",
                CustomerAddress= "Forsterstr. 57",
                CustomerCity= "Mannheim",
                RegionId=2,
                CustomerPostalCode= "68306",
                CustomerCountry= "Germany",
                CustomerPhone= "0621-08460",
                CustomerFax= "0621-08924"
                }, 
                new Customer()
                {
                CustomerId= "BLONP",
                CustomerName= "Blondesddsl père et fils",
                CustomerContactName= "Frédérique Citeaux",
                CustomerContactTitle= "Marketing Manager",
                CustomerAddress= "24, place Kléber",
                CustomerCity= "Strasbourg",
                RegionId=3,
                CustomerPostalCode= "67000",
                CustomerCountry= "France",
                CustomerPhone= "88.60.15.31",
                CustomerFax= "88.60.15.32"
                }, 
                new Customer()
                {
                CustomerId= "BOLID",
                CustomerName= "Bólido Comidas preparadas",
                CustomerContactName= "Martín Sommer",
                CustomerContactTitle= "Owner",
                CustomerAddress= "C/ Araquil, 67",
                CustomerCity= "Madrid",
                RegionId=4,
                CustomerPostalCode= "28023",
                CustomerCountry= "Spain",
                CustomerPhone= "(91) 555 22 82",
                CustomerFax= "(91) 555 91 99"
                }, 
                new Customer()
                {
                CustomerId= "BONAP",
                CustomerName= "Bon app'",
                CustomerContactName= "Laurence Lebihan",
                CustomerContactTitle= "Owner",
                CustomerAddress= "12, rue des Bouchers",
                CustomerCity= "Marseille",
                RegionId = 2,
                CustomerPostalCode= "13008",
                CustomerCountry= "France",
                CustomerPhone= "91.24.45.40",
                CustomerFax= "91.24.45.41"
                }, 
                new Customer()
                {
                CustomerId= "BOTTM",
                CustomerName= "Bottom-Dollar Markets",
                CustomerContactName= "Elizabeth Lincoln",
                CustomerContactTitle= "Accounting Manager",
                CustomerAddress= "23 Tsawassen Blvd.",
                CustomerCity= "Tsawassen",
                RegionId= 1,
                CustomerPostalCode= "T2F 8M4",
                CustomerCountry= "Canada",
                CustomerPhone= "(604) 555-4729",
                CustomerFax= "(604) 555-3745"
                }, 
                new Customer()
                {
                CustomerId= "BSBEV",
                CustomerName= "B's Beverages",
                CustomerContactName= "Victoria Ashworth",
                CustomerContactTitle= "Sales Representative",
                CustomerAddress= "Fauntleroy Circus",
                CustomerCity= "London",
                RegionId=3,
                CustomerPostalCode= "EC2 5NT",
                CustomerCountry= "UK",
                CustomerPhone= "(171) 555-1212",
                CustomerFax= ""
                }, 
                new Customer()
                {
                CustomerId= "CACTU",
                CustomerName= "Cactus Comidas para llevar",
                CustomerContactName= "Patricio Simpson",
                CustomerContactTitle= "Sales Agent",
                CustomerAddress= "Cerrito 333",
                CustomerCity= "Buenos Aires",
                RegionId=4,
                CustomerPostalCode= "1010",
                CustomerCountry= "Argentina",
                CustomerPhone= "(1) 135-5555",
                CustomerFax= "(1) 135-4892"
                }, 
                new Customer()
                {
                CustomerId= "CENTC",
                CustomerName= "Centro comercial Moctezuma",
                CustomerContactName= "Francisco Chang",
                CustomerContactTitle= "Marketing Manager",
                CustomerAddress= "Sierras de Granada 9993",
                CustomerCity= "México D.F.",
                RegionId=1,
                CustomerPostalCode= "05022",
                CustomerCountry= "Mexico",
                CustomerPhone= "(5) 555-3392",
                CustomerFax= "(5) 555-7293"
                }, 
                new Customer()
                {
                CustomerId= "CHOPS",
                CustomerName= "Chop-suey Chinese",
                CustomerContactName= "Yang Wang",
                CustomerContactTitle= "Owner",
                CustomerAddress= "Hauptstr. 29",
                CustomerCity= "Bern",
                RegionId=1,
                CustomerPostalCode= "3012",
                CustomerCountry= "Switzerland",
                CustomerPhone= "0452-076545",
                CustomerFax= ""
                }, 
                new Customer()
                {
                CustomerId= "COMMI",
                CustomerName= "Comércio Mineiro",
                CustomerContactName= "Pedro Afonso",
                CustomerContactTitle= "Sales Associate",
                CustomerAddress= "Av. dos Lusíadas, 23",
                CustomerCity= "Sao Paulo",
                RegionId=2,
                CustomerPostalCode= "05432-043",
                CustomerCountry= "Brazil",
                CustomerPhone= "(11) 555-7647",
                CustomerFax= ""
                }, 
                new Customer()
                {
                CustomerId= "CONSH",
                CustomerName= "Consolidated Holdings",
                CustomerContactName= "Elizabeth Brown",
                CustomerContactTitle= "Sales Representative",
                CustomerAddress= "Berkeley Gardens 12  Brewery",
                CustomerCity= "London",
                RegionId=1,
                CustomerPostalCode= "WX1 6LT",
                CustomerCountry= "UK",
                CustomerPhone= "(171) 555-2282",
                CustomerFax= "(171) 555-9199"
                }, 
                new Customer()
                {
                CustomerId= "DRACD",
                CustomerName= "Drachenblut Delikatessen",
                CustomerContactName= "Sven Ottlieb",
                CustomerContactTitle= "Order Administrator",
                CustomerAddress= "Walserweg 21",
                CustomerCity= "Aachen",
                RegionId=1,
                CustomerPostalCode= "52066",
                CustomerCountry= "Germany",
                CustomerPhone= "0241-039123",
                CustomerFax= "0241-059428"
                }, 
                new Customer()
                {
                CustomerId= "DUMON",
                CustomerName= "Du monde entier",
                CustomerContactName= "Janine Labrune",
                CustomerContactTitle= "Owner",
                CustomerAddress= "67, rue des Cinquante Otages",
                CustomerCity= "Nantes",
                RegionId=1,
                CustomerPostalCode= "44000",
                CustomerCountry= "France",
                CustomerPhone= "40.67.88.88",
                CustomerFax= "40.67.89.89"
                }, 
                new Customer()
                {
                CustomerId= "EASTC",
                CustomerName= "Eastern Connection",
                CustomerContactName= "Ann Devon",
                CustomerContactTitle= "Sales Agent",
                CustomerAddress= "35 King George",
                CustomerCity= "London",
                RegionId=1,
                CustomerPostalCode= "WX3 6FW",
                CustomerCountry= "UK",
                CustomerPhone= "(171) 555-0297",
                CustomerFax= "(171) 555-3373"
                }, 
                new Customer()
                {
                CustomerId= "ERNSH",
                CustomerName= "Ernst Handel",
                CustomerContactName= "Roland Mendel",
                CustomerContactTitle= "Sales Manager",
                CustomerAddress= "Kirchgasse 6",
                CustomerCity= "Graz",
                RegionId=1,
                CustomerPostalCode= "8010",
                CustomerCountry= "Austria",
                CustomerPhone= "7675-3425",
                CustomerFax= "7675-3426"
                }, 
                new Customer()
                {
                CustomerId= "FAMIA",
                CustomerName= "Familia Arquibaldo",
                CustomerContactName= "Aria Cruz",
                CustomerContactTitle= "Marketing Assistant",
                CustomerAddress= "Rua Orós, 92",
                CustomerCity= "Sao Paulo",
                RegionId=3,
                CustomerPostalCode= "05442-030",
                CustomerCountry= "Brazil",
                CustomerPhone= "(11) 555-9857",
                CustomerFax= ""
                }, 
                new Customer()
                {
                CustomerId= "FISSA",
                CustomerName= "FISSA Fabrica Inter. Salchichas S.A.",
                CustomerContactName= "Diego Roel",
                CustomerContactTitle= "Accounting Manager",
                CustomerAddress= "C/ Moralzarzal, 86",
                CustomerCity= "Madrid",
                RegionId=1,
                CustomerPostalCode= "28034",
                CustomerCountry= "Spain",
                CustomerPhone= "(91) 555 94 44",
                CustomerFax= "(91) 555 55 93"
                }, 
                new Customer()
                {
                CustomerId= "FOLIG",
                CustomerName= "Folies gourmandes",
                CustomerContactName= "Martine Rancé",
                CustomerContactTitle= "Assistant Sales Agent",
                CustomerAddress= "184, chaussée de Tournai",
                CustomerCity= "Lille",
                RegionId=1,
                CustomerPostalCode= "59000",
                CustomerCountry= "France",
                CustomerPhone= "20.16.10.16",
                CustomerFax= "20.16.10.17"
                }, 
                new Customer()
                {
                CustomerId= "FOLKO",
                CustomerName= "Folk och fä HB",
                CustomerContactName= "Maria Larsson",
                CustomerContactTitle= "Owner",
                CustomerAddress= "Åkergatan 24",
                CustomerCity= "Bräcke",
                RegionId=1,
                CustomerPostalCode= "S-844 67",
                CustomerCountry= "Sweden",
                CustomerPhone= "0695-34 67 21",
                CustomerFax= ""
                }, 
                new Customer()
                {
                CustomerId= "FRANK",
                CustomerName= "Frankenversand",
                CustomerContactName= "Peter Franken",
                CustomerContactTitle= "Marketing Manager",
                CustomerAddress= "Berliner Platz 43",
                CustomerCity= "München",
                RegionId=1,
                CustomerPostalCode= "80805",
                CustomerCountry= "Germany",
                CustomerPhone= "089-0877310",
                CustomerFax= "089-0877451"
                }, 
                new Customer()
                {
                CustomerId= "FRANR",
                CustomerName= "France restauration",
                CustomerContactName= "Carine Schmitt",
                CustomerContactTitle= "Marketing Manager",
                CustomerAddress= "54, rue Royale",
                CustomerCity= "Nantes",
                RegionId=1,
                CustomerPostalCode= "44000",
                CustomerCountry= "France",
                CustomerPhone= "40.32.21.21",
                CustomerFax= "40.32.21.20"
                }, 
                new Customer()
                {
                CustomerId= "FRANS",
                CustomerName= "Franchi S.p.A.",
                CustomerContactName= "Paolo Accorti",
                CustomerContactTitle= "Sales Representative",
                CustomerAddress= "Via Monte Bianco 34",
                CustomerCity= "Torino",
                RegionId=1,
                CustomerPostalCode= "10100",
                CustomerCountry= "Italy",
                CustomerPhone= "011-4988260",
                CustomerFax= "011-4988261"
                }, 
                new Customer()
                {
                CustomerId= "FURIB",
                CustomerName= "Furia Bacalhau e Frutos do Mar",
                CustomerContactName= "Lino Rodriguez",
                CustomerContactTitle= "Sales Manager",
                CustomerAddress= "Jardim das rosas n. 32",
                CustomerCity= "Lisboa",
                RegionId=1,
                CustomerPostalCode= "1675",
                CustomerCountry= "Portugal",
                CustomerPhone= "(1) 354-2534",
                CustomerFax= "(1) 354-2535"
                }, 
                new Customer()
                {
                CustomerId= "GALED",
                CustomerName= "Galería del gastrónomo",
                CustomerContactName= "Eduardo Saavedra",
                CustomerContactTitle= "Marketing Manager",
                CustomerAddress= "Rambla de Cataluña, 23",
                CustomerCity= "Barcelona",
                RegionId=1,
                CustomerPostalCode= "08022",
                CustomerCountry= "Spain",
                CustomerPhone= "(93) 203 4560",
                CustomerFax= "(93) 203 4561"
                }, 
                new Customer()
                {
                CustomerId= "GODOS",
                CustomerName= "Godos Cocina Típica",
                CustomerContactName= "José Pedro Freyre",
                CustomerContactTitle= "Sales Manager",
                CustomerAddress= "C/ Romero, 33",
                CustomerCity= "Sevilla",
                RegionId=1,
                CustomerPostalCode= "41101",
                CustomerCountry= "Spain",
                CustomerPhone= "(95) 555 82 82",
                CustomerFax= ""
                }, 
                new Customer()
                {
                CustomerId= "GOURL",
                CustomerName= "Gourmet Lanchonetes",
                CustomerContactName= "André Fonseca",
                CustomerContactTitle= "Sales Associate",
                CustomerAddress= "Av. Brasil, 442",
                CustomerCity= "Campinas",
                RegionId=3,
                CustomerPostalCode= "04876-786",
                CustomerCountry= "Brazil",
                CustomerPhone= "(11) 555-9482",
                CustomerFax= ""
                }, 
                new Customer()
                {
                CustomerId= "GREAL",
                CustomerName= "Great Lakes Food Market",
                CustomerContactName= "Howard Snyder",
                CustomerContactTitle= "Marketing Manager",
                CustomerAddress= "2732 Baker Blvd.",
                CustomerCity= "Eugene",
                RegionId=3,
                CustomerPostalCode= "97403",
                CustomerCountry= "USA",
                CustomerPhone= "(503) 555-7555",
                CustomerFax= ""
                }, 
                new Customer()
                {
                CustomerId= "GROSR",
                CustomerName= "GROSELLA-Restaurante",
                CustomerContactName= "Manuel Pereira",
                CustomerContactTitle= "Owner",
                CustomerAddress= "5ª Ave. Los Palos Grandes",
                CustomerCity= "Caracas",
                RegionId=4,
                CustomerPostalCode= "1081",
                CustomerCountry= "Venezuela",
                CustomerPhone= "(2) 283-2951",
                CustomerFax= "(2) 283-3397"
                }, 
                new Customer()
                {
                CustomerId= "HANAR",
                CustomerName= "Hanari Carnes",
                CustomerContactName= "Mario Pontes",
                CustomerContactTitle= "Accounting Manager",
                CustomerAddress= "Rua do Paço, 67",
                CustomerCity= "Rio de Janeiro",
                RegionId=2,
                CustomerPostalCode= "05454-876",
                CustomerCountry= "Brazil",
                CustomerPhone= "(21) 555-0091",
                CustomerFax= "(21) 555-8765"
                }, 
                new Customer()
                {
                CustomerId= "HILAA",
                CustomerName= "HILARION-Abastos",
                CustomerContactName= "Carlos Hernández",
                CustomerContactTitle= "Sales Representative",
                CustomerAddress= "Carrera 22 con Ave. Carlos Soublette #8-35",
                CustomerCity= "San Cristóbal",
                RegionId=4,
                CustomerPostalCode= "5022",
                CustomerCountry= "Venezuela",
                CustomerPhone= "(5) 555-1340",
                CustomerFax= "(5) 555-1948"
                }, 
                new Customer()
                {
                CustomerId= "HUNGC",
                CustomerName= "Hungry Coyote Import Store",
                CustomerContactName= "Yoshi Latimer",
                CustomerContactTitle= "Sales Representative",
                CustomerAddress= "CustomerCity Center Plaza 516 Main St.",
                CustomerCity= "Elgin",
                RegionId=4,
                CustomerPostalCode= "97827",
                CustomerCountry= "USA",
                CustomerPhone= "(503) 555-6874",
                CustomerFax= "(503) 555-2376"
                }, 
                new Customer()
                {
                CustomerId= "HUNGO",
                CustomerName= "Hungry Owl All-Night Grocers",
                CustomerContactName= "Patricia McKenna",
                CustomerContactTitle= "Sales Associate",
                CustomerAddress= "8 Johnstown Road",
                CustomerCity= "Cork",
                RegionId=4,
                CustomerPostalCode= "",
                CustomerCountry= "Ireland",
                CustomerPhone= "2967 542",
                CustomerFax= "2967 3333"
                }, 
                new Customer()
                {
                CustomerId= "ISLAT",
                CustomerName= "Island Trading",
                CustomerContactName= "Helen Bennett",
                CustomerContactTitle= "Marketing Manager",
                CustomerAddress= "Garden House Crowther Way",
                CustomerCity= "Cowes",
                RegionId=4,
                CustomerPostalCode= "PO31 7PJ",
                CustomerCountry= "UK",
                CustomerPhone= "(198) 555-8888",
                CustomerFax= ""
                }, 
                new Customer()
                {
                CustomerId= "KOENE",
                CustomerName= "Königlich Essen",
                CustomerContactName= "Philip Cramer",
                CustomerContactTitle= "Sales Associate",
                CustomerAddress= "Maubelstr. 90",
                CustomerCity= "Brandenburg",
                RegionId=1,
                CustomerPostalCode= "14776",
                CustomerCountry= "Germany",
                CustomerPhone= "0555-09876",
                CustomerFax= ""
                }, 
                new Customer()
                {
                CustomerId= "LACOR",
                CustomerName= "La corne d'abondance",
                CustomerContactName= "Daniel Tonini",
                CustomerContactTitle= "Sales Representative",
                CustomerAddress= "67, avenue de l'Europe",
                CustomerCity= "Versailles",
                RegionId=1,
                CustomerPostalCode= "78000",
                CustomerCountry= "France",
                CustomerPhone= "30.59.84.10",
                CustomerFax= "30.59.85.11"
                }, 
                new Customer()
                {
                CustomerId= "LAMAI",
                CustomerName= "La maison d'Asie",
                CustomerContactName= "Annette Roulet",
                CustomerContactTitle= "Sales Manager",
                CustomerAddress= "1 rue Alsace-Lorraine",
                CustomerCity= "Toulouse",
                RegionId=1,
                CustomerPostalCode= "31000",
                CustomerCountry= "France",
                CustomerPhone= "61.77.61.10",
                CustomerFax= "61.77.61.11"
                }, 
                new Customer()
                {
                CustomerId= "LAUGB",
                CustomerName= "Laughing Bacchus Wine Cellars",
                CustomerContactName= "Yoshi Tannamuri",
                CustomerContactTitle= "Marketing Assistant",
                CustomerAddress= "1900 Oak St.",
                CustomerCity= "Vancouver",
                RegionId=4,
                CustomerPostalCode= "V3F 2K1",
                CustomerCountry= "Canada",
                CustomerPhone= "(604) 555-3392",
                CustomerFax= "(604) 555-7293"
                }, 
                new Customer()
                {
                CustomerId= "LAZYK",
                CustomerName= "Lazy K Kountry Store",
                CustomerContactName= "John Steel",
                CustomerContactTitle= "Marketing Manager",
                CustomerAddress= "12 Orchestra Terrace",
                CustomerCity= "Walla Walla",
                RegionId=4,
                CustomerPostalCode= "99362",
                CustomerCountry= "USA",
                CustomerPhone= "(509) 555-7969",
                CustomerFax= "(509) 555-6221"
                }, 
                new Customer()
                {
                CustomerId= "LEHMS",
                CustomerName= "Lehmanns Marktstand",
                CustomerContactName= "Renate Messner",
                CustomerContactTitle= "Sales Representative",
                CustomerAddress= "Magazinweg 7",
                CustomerCity= "Frankfurt a.M.",
                RegionId=1,
                CustomerPostalCode= "60528",
                CustomerCountry= "Germany",
                CustomerPhone= "069-0245984",
                CustomerFax= "069-0245874"
                }, 
                new Customer()
                {
                CustomerId= "LETSS",
                CustomerName= "Let's Stop N Shop",
                CustomerContactName= "Jaime Yorres",
                CustomerContactTitle= "Owner",
                CustomerAddress= "87 Polk St. Suite 5",
                CustomerCity= "San Francisco",
                RegionId=4,
                CustomerPostalCode= "94117",
                CustomerCountry= "USA",
                CustomerPhone= "(415) 555-5938",
                CustomerFax= ""
                }, 
                new Customer()
                {
                CustomerId= "LILAS",
                CustomerName= "LILA-Supermercado",
                CustomerContactName= "Carlos González",
                CustomerContactTitle= "Accounting Manager",
                CustomerAddress= "Carrera 52 con Ave. Bolívar #65-98 Llano Largo",
                CustomerCity= "Barquisimeto",
                RegionId=4,
                CustomerPostalCode= "3508",
                CustomerCountry= "Venezuela",
                CustomerPhone= "(9) 331-6954",
                CustomerFax= "(9) 331-7256"
                }, 
                new Customer()
                {
                CustomerId= "LINOD",
                CustomerName= "LINO-Delicateses",
                CustomerContactName= "Felipe Izquierdo",
                CustomerContactTitle= "Owner",
                CustomerAddress= "Ave. 5 de Mayo Porlamar",
                CustomerCity= "I. de Margarita",
                RegionId=4,
                CustomerPostalCode= "4980",
                CustomerCountry= "Venezuela",
                CustomerPhone= "(8) 34-56-12",
                CustomerFax= "(8) 34-93-93"
                }, 
                new Customer()
                {
                CustomerId= "LONEP",
                CustomerName= "Lonesome Pine Restaurant",
                CustomerContactName= "Fran Wilson",
                CustomerContactTitle= "Sales Manager",
                CustomerAddress= "89 Chiaroscuro Rd.",
                CustomerCity= "Portland",
                RegionId=4,
                CustomerPostalCode= "97219",
                CustomerCountry= "USA",
                CustomerPhone= "(503) 555-9573",
                CustomerFax= "(503) 555-9646"
                }, 
                new Customer()
                {
                CustomerId= "MAGAA",
                CustomerName= "Magazzini Alimentari Riuniti",
                CustomerContactName= "Giovanni Rovelli",
                CustomerContactTitle= "Marketing Manager",
                CustomerAddress= "Via Ludovico il Moro 22",
                CustomerCity= "Bergamo",
                RegionId=1,
                CustomerPostalCode= "24100",
                CustomerCountry= "Italy",
                CustomerPhone= "035-640230",
                CustomerFax= "035-640231"
                }, new Customer()
                {
                CustomerId= "MAISD",
                CustomerName= "Maison Dewey",
                CustomerContactName= "Catherine Dewey",
                CustomerContactTitle= "Sales Agent",
                CustomerAddress= "Rue Joseph-Bens 532",
                CustomerCity= "Bruxelles",
                RegionId=1,
                CustomerPostalCode= "B-1180",
                CustomerCountry= "Belgium",
                CustomerPhone= "(02) 201 24 67",
                CustomerFax= "(02) 201 24 68"
                }, new Customer()
                {
                CustomerId= "MEREP",
                CustomerName= "Mère Paillarde",
                CustomerContactName= "Jean Fresnière",
                CustomerContactTitle= "Marketing Assistant",
                CustomerAddress= "43 rue St. Laurent",
                CustomerCity= "Montréal",
                RegionId=3,
                CustomerPostalCode= "H1J 1C3",
                CustomerCountry= "Canada",
                CustomerPhone= "(514) 555-8054",
                CustomerFax= "(514) 555-8055"
                }, new Customer()
                {
                CustomerId= "MORGK",
                CustomerName= "Morgenstern Gesundkost",
                CustomerContactName= "Alexander Feuer",
                CustomerContactTitle= "Marketing Assistant",
                CustomerAddress= "Heerstr. 22",
                CustomerCity= "Leipzig",
                RegionId=1,
                CustomerPostalCode= "04179",
                CustomerCountry= "Germany",
                CustomerPhone= "0342-023176",
                CustomerFax= ""
                }, new Customer()
                {
                CustomerId= "NORTS",
                CustomerName= "North/South",
                CustomerContactName= "Simon Crowther",
                CustomerContactTitle= "Sales Associate",
                CustomerAddress= "South House 300 Queensbridge",
                CustomerCity= "London",
                RegionId=1,
                CustomerPostalCode= "SW7 1RZ",
                CustomerCountry= "UK",
                CustomerPhone= "(171) 555-7733",
                CustomerFax= "(171) 555-2530"
                }, new Customer()
                {
                CustomerId= "OCEAN",
                CustomerName= "Océano Atlántico Ltda.",
                CustomerContactName= "Yvonne Moncada",
                CustomerContactTitle= "Sales Agent",
                CustomerAddress= "Ing. Gustavo Moncada 8585 Piso 20-A",
                CustomerCity= "Buenos Aires",
                RegionId=1,
                CustomerPostalCode= "1010",
                CustomerCountry= "Argentina",
                CustomerPhone= "(1) 135-5333",
                CustomerFax= "(1) 135-5535"
                }, new Customer()
                {
                CustomerId= "OLDWO",
                CustomerName= "Old World Delicatessen",
                CustomerContactName= "Rene Phillips",
                CustomerContactTitle= "Sales Representative",
                CustomerAddress= "2743 Bering St.",
                CustomerCity= "Anchorage",
                RegionId=4,
                CustomerPostalCode= "99508",
                CustomerCountry= "USA",
                CustomerPhone= "(907) 555-7584",
                CustomerFax= "(907) 555-2880"
                }, new Customer()
                {
                CustomerId= "OTTIK",
                CustomerName= "Ottilies Käseladen",
                CustomerContactName= "Henriette Pfalzheim",
                CustomerContactTitle= "Owner",
                CustomerAddress= "Mehrheimerstr. 369",
                CustomerCity= "Köln",
                RegionId=1,
                CustomerPostalCode= "50739",
                CustomerCountry= "Germany",
                CustomerPhone= "0221-0644327",
                CustomerFax= "0221-0765721"
                }, new Customer()
                {
                CustomerId= "PARIS",
                CustomerName= "Paris spécialités",
                CustomerContactName= "Marie Bertrand",
                CustomerContactTitle= "Owner",
                CustomerAddress= "265, boulevard Charonne",
                CustomerCity= "Paris",
                RegionId=1,
                CustomerPostalCode= "75012",
                CustomerCountry= "France",
                CustomerPhone= "(1) 42.34.22.66",
                CustomerFax= "(1) 42.34.22.77"
                }, new Customer()
                {
                CustomerId= "PERIC",
                CustomerName= "Pericles Comidas clásicas",
                CustomerContactName= "Guillermo Fernández",
                CustomerContactTitle= "Sales Representative",
                CustomerAddress= "Calle Dr. Jorge Cash 321",
                CustomerCity= "México D.F.",
                RegionId=1,
                CustomerPostalCode= "05033",
                CustomerCountry= "Mexico",
                CustomerPhone= "(5) 552-3745",
                CustomerFax= "(5) 545-3745"
                }, new Customer()
                {
                CustomerId= "PICCO",
                CustomerName= "Piccolo und mehr",
                CustomerContactName= "Georg Pipps",
                CustomerContactTitle= "Sales Manager",
                CustomerAddress= "Geislweg 14",
                CustomerCity= "Salzburg",
                RegionId=1,
                CustomerPostalCode= "5020",
                CustomerCountry= "Austria",
                CustomerPhone= "6562-9722",
                CustomerFax= "6562-9723"
                }, new Customer()
                {
                CustomerId= "PRINI",
                CustomerName= "Princesa Isabel Vinhos",
                CustomerContactName= "Isabel de Castro",
                CustomerContactTitle= "Sales Representative",
                CustomerAddress= "Estrada da saúde n. 58",
                CustomerCity= "Lisboa",
                RegionId=1,
                CustomerPostalCode= "1756",
                CustomerCountry= "Portugal",
                CustomerPhone= "(1) 356-5634",
                CustomerFax= ""
                }, new Customer()
                {
                CustomerId= "QUEDE",
                CustomerName= "Que Delícia",
                CustomerContactName= "Bernardo Batista",
                CustomerContactTitle= "Accounting Manager",
                CustomerAddress= "Rua da Panificadora, 12",
                CustomerCity= "Rio de Janeiro",
                RegionId=2,
                CustomerPostalCode= "02389-673",
                CustomerCountry= "Brazil",
                CustomerPhone= "(21) 555-4252",
                CustomerFax= "(21) 555-4545"
                }, new Customer()
                {
                CustomerId= "QUEEN",
                CustomerName= "Queen Cozinha",
                CustomerContactName= "Lúcia Carvalho",
                CustomerContactTitle= "Marketing Assistant",
                CustomerAddress= "Alameda dos Canàrios, 891",
                CustomerCity= "Sao Paulo",
                RegionId=3,
                CustomerPostalCode= "05487-020",
                CustomerCountry= "Brazil",
                CustomerPhone= "(11) 555-1189",
                CustomerFax= ""
                }, new Customer()
                {
                CustomerId= "QUICK",
                CustomerName= "QUICK-Stop",
                CustomerContactName= "Horst Kloss",
                CustomerContactTitle= "Accounting Manager",
                CustomerAddress= "Taucherstraße 10",
                CustomerCity= "Cunewalde",
                RegionId=1,
                CustomerPostalCode= "01307",
                CustomerCountry= "Germany",
                CustomerPhone= "0372-035188",
                CustomerFax= ""
                }, new Customer()
                {
                CustomerId= "RANCH",
                CustomerName= "Rancho grande",
                CustomerContactName= "Sergio Gutiérrez",
                CustomerContactTitle= "Sales Representative",
                CustomerAddress= "Av. del Libertador 900",
                CustomerCity= "Buenos Aires",
                RegionId=1,
                CustomerPostalCode= "1010",
                CustomerCountry= "Argentina",
                CustomerPhone= "(1) 123-5555",
                CustomerFax= "(1) 123-5556"
                }, new Customer()
                {
                CustomerId= "RATTC",
                CustomerName= "Rattlesnake Canyon Grocery",
                CustomerContactName= "Paula Wilson",
                CustomerContactTitle= "Assistant Sales Representative",
                CustomerAddress= "2817 Milton Dr.",
                CustomerCity= "Albuquerque",
                RegionId=4,
                CustomerPostalCode= "87110",
                CustomerCountry= "USA",
                CustomerPhone= "(505) 555-5939",
                CustomerFax= "(505) 555-3620"
                }, new Customer()
                {
                CustomerId= "REGGC",
                CustomerName= "Reggiani Caseifici",
                CustomerContactName= "Maurizio Moroni",
                CustomerContactTitle= "Sales Associate",
                CustomerAddress= "Strada Provinciale 124",
                CustomerCity= "Reggio Emilia",
                RegionId=1,
                CustomerPostalCode= "42100",
                CustomerCountry= "Italy",
                CustomerPhone= "0522-556721",
                CustomerFax= "0522-556722"
                }, new Customer()
                {
                CustomerId= "RICAR",
                CustomerName= "Ricardo Adocicados",
                CustomerContactName= "Janete Limeira",
                CustomerContactTitle= "Assistant Sales Agent",
                CustomerAddress= "Av. Copacabana, 267",
                CustomerCity= "Rio de Janeiro",
                RegionId=2,
                CustomerPostalCode= "02389-890",
                CustomerCountry= "Brazil",
                CustomerPhone= "(21) 555-3412",
                CustomerFax= ""
                }, new Customer()
                {
                CustomerId= "RICSU",
                CustomerName= "Richter Supermarkt",
                CustomerContactName= "Michael Holz",
                CustomerContactTitle= "Sales Manager",
                CustomerAddress= "Grenzacherweg 237",
                CustomerCity= "Genève",
                RegionId=1,
                CustomerPostalCode= "1203",
                CustomerCountry= "Switzerland",
                CustomerPhone= "0897-034214",
                CustomerFax= ""
                }, new Customer()
                {
                CustomerId= "ROMEY",
                CustomerName= "Romero y tomillo",
                CustomerContactName= "Alejandra Camino",
                CustomerContactTitle= "Accounting Manager",
                CustomerAddress= "Gran Vía, 1",
                CustomerCity= "Madrid",
                RegionId=1,
                CustomerPostalCode= "28001",
                CustomerCountry= "Spain",
                CustomerPhone= "(91) 745 6200",
                CustomerFax= "(91) 745 6210"
                }, new Customer()
                {
                CustomerId= "SANTG",
                CustomerName= "Santé Gourmet",
                CustomerContactName= "Jonas Bergulfsen",
                CustomerContactTitle= "Owner",
                CustomerAddress= "Erling Skakkes gate 78",
                CustomerCity= "Stavern",
                RegionId=1,
                CustomerPostalCode= "4110",
                CustomerCountry= "Norway",
                CustomerPhone= "07-98 92 35",
                CustomerFax= "07-98 92 47"
                }, new Customer()
                {
                CustomerId= "SAVEA",
                CustomerName= "Save-a-lot Markets",
                CustomerContactName= "Jose Pavarotti",
                CustomerContactTitle= "Sales Representative",
                CustomerAddress= "187 Suffolk Ln.",
                CustomerCity= "Boise",
                RegionId=4,
                CustomerPostalCode= "83720",
                CustomerCountry= "USA",
                CustomerPhone= "(208) 555-8097",
                CustomerFax= ""
                }, new Customer()
                {
                CustomerId= "SEVES",
                CustomerName= "Seven Seas Imports",
                CustomerContactName= "Hari Kumar",
                CustomerContactTitle= "Sales Manager",
                CustomerAddress= "90 Wadhurst Rd.",
                CustomerCity= "London",
                RegionId=1,
                CustomerPostalCode= "OX15 4NB",
                CustomerCountry= "UK",
                CustomerPhone= "(171) 555-1717",
                CustomerFax= "(171) 555-5646"
                }, new Customer()
                {
                CustomerId= "SIMOB",
                CustomerName= "Simons bistro",
                CustomerContactName= "Jytte Petersen",
                CustomerContactTitle= "Owner",
                CustomerAddress= "Vinbæltet 34",
                CustomerCity= "Kobenhavn",
                RegionId=1,
                CustomerPostalCode= "1734",
                CustomerCountry= "Denmark",
                CustomerPhone= "31 12 34 56",
                CustomerFax= "31 13 35 57"
                }, new Customer()
                {
                CustomerId= "SPECD",
                CustomerName= "Spécialités du monde",
                CustomerContactName= "Dominique Perrier",
                CustomerContactTitle= "Marketing Manager",
                CustomerAddress= "25, rue Lauriston",
                CustomerCity= "Paris",
                RegionId=1,
                CustomerPostalCode= "75016",
                CustomerCountry= "France",
                CustomerPhone= "(1) 47.55.60.10",
                CustomerFax= "(1) 47.55.60.20"
                }, new Customer()
                {
                CustomerId= "SPLIR",
                CustomerName= "Split Rail Beer & Ale",
                CustomerContactName= "Art Braunschweiger",
                CustomerContactTitle= "Sales Manager",
                CustomerAddress= "P.O. Box 555",
                CustomerCity= "Lander",
                RegionId=4,
                CustomerPostalCode= "82520",
                CustomerCountry= "USA",
                CustomerPhone= "(307) 555-4680",
                CustomerFax= "(307) 555-6525"
                }, new Customer()
                {
                CustomerId= "SUPRD",
                CustomerName= "Suprêmes délices",
                CustomerContactName= "Pascale Cartrain",
                CustomerContactTitle= "Accounting Manager",
                CustomerAddress= "Boulevard Tirou, 255",
                CustomerCity= "Charleroi",
                RegionId=1,
                CustomerPostalCode= "B-6000",
                CustomerCountry= "Belgium",
                CustomerPhone= "(071) 23 67 22 20",
                CustomerFax= "(071) 23 67 22 21"
                }, new Customer()
                {
                CustomerId= "THEBI",
                CustomerName= "The Big Cheese",
                CustomerContactName= "Liz Nixon",
                CustomerContactTitle= "Marketing Manager",
                CustomerAddress= "89 Jefferson Way Suite 2",
                CustomerCity= "Portland",
                RegionId=4,
                CustomerPostalCode= "97201",
                CustomerCountry= "USA",
                CustomerPhone= "(503) 555-3612",
                CustomerFax= ""
                }, new Customer()
                {
                CustomerId= "THECR",
                CustomerName= "The Cracker Box",
                CustomerContactName= "Liu Wong",
                CustomerContactTitle= "Marketing Assistant",
                CustomerAddress= "55 Grizzly Peak Rd.",
                CustomerCity= "Butte",
                RegionId=4,
                CustomerPostalCode= "59801",
                CustomerCountry= "USA",
                CustomerPhone= "(406) 555-5834",
                CustomerFax= "(406) 555-8083"
                }, new Customer()
                {
                CustomerId= "TOMSP",
                CustomerName= "Toms Spezialitäten",
                CustomerContactName= "Karin Josephs",
                CustomerContactTitle= "Marketing Manager",
                CustomerAddress= "Luisenstr. 48",
                CustomerCity= "Münster",
                RegionId=1,
                CustomerPostalCode= "44087",
                CustomerCountry= "Germany",
                CustomerPhone= "0251-031259",
                CustomerFax= "0251-035695"
                }, new Customer()
                {
                CustomerId= "TORTU",
                CustomerName= "Tortuga Restaurante",
                CustomerContactName= "Miguel Angel Paolino",
                CustomerContactTitle= "Owner",
                CustomerAddress= "Avda. Azteca 123",
                CustomerCity= "México D.F.",
                RegionId=1,
                CustomerPostalCode= "05033",
                CustomerCountry= "Mexico",
                CustomerPhone= "(5) 555-2933",
                CustomerFax= ""
                }, new Customer()
                {
                CustomerId= "TRADH",
                CustomerName= "Tradição Hipermercados",
                CustomerContactName= "Anabela Domingues",
                CustomerContactTitle= "Sales Representative",
                CustomerAddress= "Av. Inês de Castro, 414",
                CustomerCity= "Sao Paulo",
                RegionId=3,
                CustomerPostalCode= "05634-030",
                CustomerCountry= "Brazil",
                CustomerPhone= "(11) 555-2167",
                CustomerFax= "(11) 555-2168"
                }, new Customer()
                {
                CustomerId= "TRAIH",
                CustomerName= "Trail's Head Gourmet Provisioners",
                CustomerContactName= "Helvetius Nagy",
                CustomerContactTitle= "Sales Associate",
                CustomerAddress= "722 DaVinci Blvd.",
                CustomerCity= "Kirkland",
                RegionId=4,
                CustomerPostalCode= "98034",
                CustomerCountry= "USA",
                CustomerPhone= "(206) 555-8257",
                CustomerFax= "(206) 555-2174"
                }, new Customer()
                {
                CustomerId= "VAFFE",
                CustomerName= "Vaffeljernet",
                CustomerContactName= "Palle Ibsen",
                CustomerContactTitle= "Sales Manager",
                CustomerAddress= "Smagsloget 45",
                CustomerCity= "Århus",
                RegionId=1,
                CustomerPostalCode= "8200",
                CustomerCountry= "Denmark",
                CustomerPhone= "86 21 32 43",
                CustomerFax= "86 22 33 44"
                }, new Customer()
                {
                CustomerId= "VICTE",
                CustomerName= "Victuailles en stock",
                CustomerContactName= "Mary Saveley",
                CustomerContactTitle= "Sales Agent",
                CustomerAddress= "2, rue du Commerce",
                CustomerCity= "Lyon",
                RegionId=1,
                CustomerPostalCode= "69004",
                CustomerCountry= "France",
                CustomerPhone= "78.32.54.86",
                CustomerFax= "78.32.54.87"
                }, new Customer()
                {
                CustomerId= "VINET",
                CustomerName= "Vins et alcools Chevalier",
                CustomerContactName= "Paul Henriot",
                CustomerContactTitle= "Accounting Manager",
                CustomerAddress= "59 rue de l'Abbaye",
                CustomerCity= "Reims",
                RegionId=1,
                CustomerPostalCode= "51100",
                CustomerCountry= "France",
                CustomerPhone= "26.47.15.10",
                CustomerFax= "26.47.15.11"
                }, new Customer()
                {
                CustomerId= "WANDK",
                CustomerName= "Die Wandernde Kuh",
                CustomerContactName= "Rita Müller",
                CustomerContactTitle= "Sales Representative",
                CustomerAddress= "Adenauerallee 900",
                CustomerCity= "Stuttgart",
                RegionId=1,
                CustomerPostalCode= "70563",
                CustomerCountry= "Germany",
                CustomerPhone= "0711-020361",
                CustomerFax= "0711-035428"
                }, new Customer()
                {
                CustomerId= "WARTH",
                CustomerName= "Wartian Herkku",
                CustomerContactName= "Pirkko Koskitalo",
                CustomerContactTitle= "Accounting Manager",
                CustomerAddress= "Torikatu 38",
                CustomerCity= "Oulu",
                RegionId=1,
                CustomerPostalCode= "90110",
                CustomerCountry= "Finland",
                CustomerPhone= "981-443655",
                CustomerFax= "981-443655"
                }, new Customer()
                {
                CustomerId= "WELLI",
                CustomerName= "Wellington Importadora",
                CustomerContactName= "Paula Parente",
                CustomerContactTitle= "Sales Manager",
                CustomerAddress= "Rua do Mercado, 12",
                CustomerCity= "Resende",
                RegionId=3,
                CustomerPostalCode= "08737-363",
                CustomerCountry= "Brazil",
                CustomerPhone= "(14) 555-8122",
                CustomerFax= ""
                }, new Customer()
                {
                CustomerId= "WHITC",
                CustomerName= "White Clover Markets",
                CustomerContactName= "Karl Jablonski",
                CustomerContactTitle= "Owner",
                CustomerAddress= "305 - 14th Ave. S. Suite 3B",
                CustomerCity= "Seattle",
                RegionId=4,
                CustomerPostalCode= "98128",
                CustomerCountry= "USA",
                CustomerPhone= "(206) 555-4112",
                CustomerFax= "(206) 555-4115"
                }, new Customer()
                {
                CustomerId= "WILMK",
                CustomerName= "Wilman Kala",
                CustomerContactName= "Matti Karttunen",
                CustomerContactTitle= "Owner/Marketing Assistant",
                CustomerAddress= "Keskuskatu 45",
                CustomerCity= "Helsinki",
                RegionId=1,
                CustomerPostalCode= "21240",
                CustomerCountry= "Finland",
                CustomerPhone= "90-224 8858",
                CustomerFax= "90-224 8858"
                }, new Customer()
                {
                CustomerId= "WOLZA",
                CustomerName= "Wolski  Zajazd",
                CustomerContactName= "Zbyszek Piestrzeniewicz",
                CustomerContactTitle= "Owner",
                CustomerAddress= "ul. Filtrowa 68",
                CustomerCity= "Warszawa",
                RegionId=1,
                CustomerPostalCode= "01-012",
                CustomerCountry= "Poland",
                CustomerPhone= "(26) 642-7012",
                CustomerFax= "(26) 642-7012"
                }
            };

            return customers.Skip(skip).Take(numberOfRows);
        }

        public static IEnumerable<Employee> GetSampleEmployees(int pageNumber =1, int numberOfRows = 20)
        {
            var skip = (pageNumber - 1) * numberOfRows;

            var employees = new List<Employee>()
{
new Employee()
{
EmployeeId= 1,
EmployeeLastName= "Davolio",
EmployeeFirstName= "Nancy",
EmployeeTitle= "Sales Representative",
EmployeeTitleOfCourtesy= "Ms.",
EmployeeBirthDate= new DateTime(1948-12-08),
EmployeeHireDate= new DateTime(1992-05-01),
EmployeeAddress= "507 - 20th Ave. E.\\nApt. 2A",
EmployeeCity= "Seattle",
RegionId=4,
EmployeePostalCode = "98122",
EmployeeCountry= "USA",
EmployeeHomePhone= "(206) 555-9857",
EmployeeExtension = "5467",
EmployeePhoto= Convert.FromBase64String("R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw=="),
EmployeeNotes= "Education includes a BA in psychology from Colorado State University in 1970.  She also completed The Art of the Cold Call.  Nancy is a member of Toastmasters International.",
EmployeeSupervisorId= 2,
EmployeePhotoPath= "http=//accweb/emmployees/davolio.bmp"
}, new Employee()
{
EmployeeId= 2,
EmployeeLastName= "Fuller",
EmployeeFirstName= "Andrew",
EmployeeTitle= "Vice President, Sales",
EmployeeTitleOfCourtesy= "Dr.",
EmployeeBirthDate= new DateTime(1952-02-19),
EmployeeHireDate= new DateTime(1992-08-14),
EmployeeAddress= "908 W. Capital Way",
EmployeeCity= "Tacoma",
RegionId=4,
EmployeePostalCode= "98401",
EmployeeCountry= "USA",
EmployeeHomePhone= "(206) 555-9482",
EmployeeExtension = "3457",
EmployeePhoto= Convert.FromBase64String("R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw=="),
EmployeeNotes= "Andrew received his BTS commercial in 1974 and a Ph.D. in international marketing from the University of Dallas in 1981.  He is fluent in French and Italian and reads German.  He joined the company as a sales representative, was promoted to sales manager in January 1992 and to vice president of sales in March 1993.  Andrew is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association.",
EmployeeSupervisorId= 2,
EmployeePhotoPath= "http=//accweb/emmployees/fuller.bmp"
}, new Employee()
{
EmployeeId= 3,
EmployeeLastName= "Leverling",
EmployeeFirstName= "Janet",
EmployeeTitle= "Sales Representative",
EmployeeTitleOfCourtesy= "Ms.",
EmployeeBirthDate= new DateTime(1963-08-30),
EmployeeHireDate= new DateTime(1992-04-01),
EmployeeAddress= "722 Moss Bay Blvd.",
EmployeeCity= "Kirkland",
RegionId=4,
EmployeePostalCode = "98033",
EmployeeCountry= "USA",
EmployeeHomePhone= "(206) 555-3412",
EmployeeExtension = "3355",
EmployeePhoto= Convert.FromBase64String("R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw=="),
EmployeeNotes= "Janet has a BS degree in chemistry from Boston College (1984).  She has also completed a certificate program in food retailing management.  Janet was hired as a sales associate in 1991 and promoted to sales representative in February 1992.",
EmployeeSupervisorId= 2,
EmployeePhotoPath= "http=//accweb/emmployees/leverling.bmp"
}, new Employee()
{
EmployeeId= 4,
EmployeeLastName= "Peacock",
EmployeeFirstName= "Margaret",
EmployeeTitle= "Sales Representative",
EmployeeTitleOfCourtesy= "Mrs.",
EmployeeBirthDate= new DateTime(1937-09-19),
EmployeeHireDate= new DateTime(1993-05-03),
EmployeeAddress= "4110 Old Redmond Rd.",
EmployeeCity= "Redmond",
RegionId=4,
EmployeePostalCode = "98052",
EmployeeCountry= "USA",
EmployeeHomePhone= "(206) 555-8122",
EmployeeExtension = "5176",
EmployeePhoto= Convert.FromBase64String("R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw=="),
EmployeeNotes= "Margaret holds a BA in English literature from Concordia College (1958) and an MA from the American Institute of Culinary Arts (1966).  She was assigned to the London office temporarily from July through November 1992.",
EmployeeSupervisorId= 2,
EmployeePhotoPath= "http=//accweb/emmployees/peacock.bmp"
}, new Employee()
{
EmployeeId= 5,
EmployeeLastName= "Buchanan",
EmployeeFirstName= "Steven",
EmployeeTitle= "Sales Manager",
EmployeeTitleOfCourtesy= "Mr.",
EmployeeBirthDate= new DateTime(1955-03-04),
EmployeeHireDate= new DateTime(1993-10-17),
EmployeeAddress= "14 Garrett Hill",
EmployeeCity= "London",
RegionId=1,
EmployeePostalCode= "SW1 8JR",
EmployeeCountry= "UK",
EmployeeHomePhone= "(71) 555-4848",
EmployeeExtension = "3453",
EmployeePhoto= Convert.FromBase64String("R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw=="),
EmployeeNotes= "Steven Buchanan graduated from St. Andrews University, Scotland, with a BSC degree in 1976.  Upon joining the company as a sales representative in 1992, he spent 6 months in an orientation program at the Seattle office and then returned to his permanent post in London.  He was promoted to sales manager in March 1993.  Mr. Buchanan has completed the courses Successful Telemarketing and International Sales Management.  He is fluent in French.",
EmployeeSupervisorId= 2,
EmployeePhotoPath= "http=//accweb/emmployees/buchanan.bmp"
}, new Employee()
{
EmployeeId= 6,
EmployeeLastName= "Suyama",
EmployeeFirstName= "Michael",
EmployeeTitle= "Sales Representative",
EmployeeTitleOfCourtesy= "Mr.",
EmployeeBirthDate= new DateTime(1963-07-02),
EmployeeHireDate= new DateTime(1993-10-17),
EmployeeAddress= "Coventry House\\nMiner Rd.",
EmployeeCity= "London",
RegionId=1,
EmployeePostalCode= "EC2 7JR",
EmployeeCountry= "UK",
EmployeeHomePhone= "(71) 555-7773",
EmployeeExtension = "428",
EmployeePhoto= Convert.FromBase64String("R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw=="),
EmployeeNotes= "Michael is a graduate of Sussex University (MA, economics, 1983) and the University of California at Los Angeles (MBA, marketing, 1986).  He has also taken the courses Multi-Cultural Selling and Time Management for the Sales Professional.  He is fluent in Japanese and can read and write French, Portuguese, and Spanish.",
EmployeeSupervisorId= 5,
EmployeePhotoPath= "http=//accweb/emmployees/davolio.bmp"
}, new Employee()
{
EmployeeId= 7,
EmployeeLastName= "King",
EmployeeFirstName= "Robert",
EmployeeTitle= "Sales Representative",
EmployeeTitleOfCourtesy= "Mr.",
EmployeeBirthDate= new DateTime(1960-05-29),
EmployeeHireDate= new DateTime(1994-01-02),
EmployeeAddress= "Edgeham Hollow\\nWinchester Way",
EmployeeCity= "London",
RegionId=1,
EmployeePostalCode= "RG1 9SP",
EmployeeCountry= "UK",
EmployeeHomePhone= "(71) 555-5598",
EmployeeExtension = "465",
EmployeePhoto= Convert.FromBase64String("R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw=="),
EmployeeNotes= "Robert King served in the Peace Corps and traveled extensively before completing his degree in English at the University of Michigan in 1992, the year he joined the company.  After completing a course entitled Selling in Europe, he was transferred to the London office in March 1993.",
EmployeeSupervisorId= 5,
EmployeePhotoPath= "http=//accweb/emmployees/davolio.bmp"
}, new Employee()
{
EmployeeId= 8,
EmployeeLastName= "Callahan",
EmployeeFirstName= "Laura",
EmployeeTitle= "Inside Sales Coordinator",
EmployeeTitleOfCourtesy= "Ms.",
EmployeeBirthDate= new DateTime(1958-01-09),
EmployeeHireDate= new DateTime(1994-03-05),
EmployeeAddress= "4726 - 11th Ave. N.E.",
EmployeeCity= "Seattle",
RegionId=4,
EmployeePostalCode = "98105",
EmployeeCountry= "USA",
EmployeeHomePhone= "(206) 555-1189",
EmployeeExtension = "2344",
EmployeePhoto= Convert.FromBase64String("R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw=="),
EmployeeNotes= "Laura received a BA in psychology from the University of Washington.  She has also completed a course in business French.  She reads and writes French.",
EmployeeSupervisorId= 2,
EmployeePhotoPath= "http=//accweb/emmployees/davolio.bmp"
}, new Employee()
{
EmployeeId= 9,
EmployeeLastName= "Dodsworth",
EmployeeFirstName= "Anne",
EmployeeTitle= "Sales Representative",
EmployeeTitleOfCourtesy= "Ms.",
EmployeeBirthDate= new DateTime(1966-01-27),
EmployeeHireDate = new DateTime(1994-11-15),
EmployeeAddress= "7 Houndstooth Rd.",
EmployeeCity= "London",
RegionId=1,
EmployeePostalCode= "WG2 7LT",
EmployeeCountry= "UK",
EmployeeHomePhone= "(71) 555-4444",
EmployeeExtension = "452",
EmployeePhoto= Convert.FromBase64String("R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw=="),
EmployeeNotes= "Anne has a BA degree in English from St. Lawrence College.  She is fluent in French and German.",
EmployeeSupervisorId= 5,
EmployeePhotoPath= "http=//accweb/emmployees/davolio.bmp"
}
};
            return employees.Skip(skip).Take(numberOfRows);
        }

        public static IEnumerable<Order> GetSampleOrders(int pageNumber = 1, int numberOfRows = 20)
        {
            var skip = (pageNumber - 1) * numberOfRows;

            var orders = new List<Order>()
{
new Order()
{
OrderId= 10248,
CustomerId= "VINET",
EmployeeId= 5,
OrderDate= new DateTime(1996-07-04),
OrderRequiredDate= new DateTime(1996-08-01),
OrderShippedDate= new DateTime(1996-07-16),
ShipperId= 3,
OrderFreight= 32.38F,
OrderShipName= "Vins et alcools Chevalier",
OrderShipAddress= "59 rue de l'Abbaye",
OrderShipCity= "Reims",
OrderShipRegionId=1,
OrderShipPostalCode= "51100",
OrderShipCountry= "France"
}, new Order()
{
OrderId= 10249,
CustomerId= "TOMSP",
EmployeeId= 6,
OrderDate= new DateTime(1996-07-05),
OrderRequiredDate= new DateTime(1996-08-16),
OrderShippedDate= new DateTime(1996-07-10),
ShipperId= 1,
OrderFreight= 11.61F,
OrderShipName= "Toms Spezialitäten",
OrderShipAddress= "Luisenstr. 48",
OrderShipCity= "Münster",
OrderShipRegionId=1,
OrderShipPostalCode= "44087",
OrderShipCountry= "Germany"
}, new Order()
{
OrderId= 10250,
CustomerId= "HANAR",
EmployeeId= 4,
OrderDate= new DateTime(1996-07-08),
OrderRequiredDate= new DateTime(1996-08-05),
OrderShippedDate= new DateTime(1996-07-12),
ShipperId= 2,
OrderFreight= 65.83F,
OrderShipName= "Hanari Carnes",
OrderShipAddress= "Rua do Paço, 67",
OrderShipCity= "Rio de Janeiro",
OrderShipRegionId=2,
OrderShipPostalCode= "05454-876",
OrderShipCountry= "Brazil"
}, new Order()
{
OrderId= 10251,
CustomerId= "VICTE",
EmployeeId= 3,
OrderDate= new DateTime(1996-07-08),
OrderRequiredDate= new DateTime(1996-08-05),
OrderShippedDate= new DateTime(1996-07-15),
ShipperId= 1,
OrderFreight= 41.34F,
OrderShipName= "Victuailles en stock",
OrderShipAddress= "2, rue du Commerce",
OrderShipCity= "Lyon",
OrderShipRegionId=1,
OrderShipPostalCode= "69004",
OrderShipCountry= "France"
}, new Order()
{
OrderId= 10252,
CustomerId= "SUPRD",
EmployeeId= 4,
OrderDate= new DateTime(1996-07-09),
OrderRequiredDate= new DateTime(1996-08-06),
OrderShippedDate= new DateTime(1996-07-11),
ShipperId= 2,
OrderFreight= 51.3F,
OrderShipName= "Suprêmes délices",
OrderShipAddress= "Boulevard Tirou, 255",
OrderShipCity= "Charleroi",
OrderShipRegionId=1,
OrderShipPostalCode= "B-6000",
OrderShipCountry= "Belgium"
}, new Order()
{
OrderId= 10253,
CustomerId= "HANAR",
EmployeeId= 3,
OrderDate= new DateTime(1996-07-10),
OrderRequiredDate= new DateTime(1996-07-24),
OrderShippedDate= new DateTime(1996-07-16),
ShipperId= 2,
OrderFreight= 58.17F,
OrderShipName= "Hanari Carnes",
OrderShipAddress= "Rua do Paço, 67",
OrderShipCity= "Rio de Janeiro",
OrderShipRegionId=2,
OrderShipPostalCode= "05454-876",
OrderShipCountry= "Brazil"
}, new Order()
{
OrderId= 10254,
CustomerId= "CHOPS",
EmployeeId= 5,
OrderDate= new DateTime(1996-07-11),
OrderRequiredDate= new DateTime(1996-08-08),
OrderShippedDate= new DateTime(1996-07-23),
ShipperId= 2,
OrderFreight= 22.98F,
OrderShipName= "Chop-suey Chinese",
OrderShipAddress= "Hauptstr. 31",
OrderShipCity= "Bern",
OrderShipRegionId=1,
OrderShipPostalCode= "3012",
OrderShipCountry= "Switzerland"
}, new Order()
{
OrderId= 10255,
CustomerId= "RICSU",
EmployeeId= 9,
OrderDate= new DateTime(1996-07-12),
OrderRequiredDate= new DateTime(1996-08-09),
OrderShippedDate= new DateTime(1996-07-15),
ShipperId= 3,
OrderFreight= 148.33F,
OrderShipName= "Richter Supermarkt",
OrderShipAddress= "Starenweg 5",
OrderShipCity= "Genève",
OrderShipRegionId=1,
OrderShipPostalCode= "1204",
OrderShipCountry= "Switzerland"
}, new Order()
{
OrderId= 10256,
CustomerId= "WELLI",
EmployeeId= 3,
OrderDate= new DateTime(1996-07-15),
OrderRequiredDate= new DateTime(1996-08-12),
OrderShippedDate= new DateTime(1996-07-17),
ShipperId= 2,
OrderFreight= 13.97F,
OrderShipName= "Wellington Importadora",
OrderShipAddress= "Rua do Mercado, 12",
OrderShipCity= "Resende",
OrderShipRegionId=3,
OrderShipPostalCode= "08737-363",
OrderShipCountry= "Brazil"
}, new Order()
{
OrderId= 10257,
CustomerId= "HILAA",
EmployeeId= 4,
OrderDate= new DateTime(1996-07-16),
OrderRequiredDate= new DateTime(1996-08-13),
OrderShippedDate= new DateTime(1996-07-22),
ShipperId= 3,
OrderFreight= 81.91F,
OrderShipName= "HILARION-Abastos",
OrderShipAddress= "Carrera 22 con Ave. Carlos Soublette #8-35",
OrderShipCity= "San Cristóbal",
OrderShipRegionId=4,
OrderShipPostalCode= "5022",
OrderShipCountry= "Venezuela"
}, new Order()
{
OrderId= 10258,
CustomerId= "ERNSH",
EmployeeId= 1,
OrderDate= new DateTime(1996-07-17),
OrderRequiredDate= new DateTime(1996-08-14),
OrderShippedDate= new DateTime(1996-07-23),
ShipperId= 1,
OrderFreight= 140.51F,
OrderShipName= "Ernst Handel",
OrderShipAddress= "Kirchgasse 6",
OrderShipCity= "Graz",
OrderShipRegionId=1,
OrderShipPostalCode= "8010",
OrderShipCountry= "Austria"
}
};

            return orders.Skip(skip).Take(numberOfRows);
        }

        public static IEnumerable<OrderDetail> GetSampleOrderDetails(int pageNumber = 1, int numberOfRows = 20)
        {
            var skip = (pageNumber - 1) * numberOfRows;

            var orderDetails = new List<OrderDetail>()
{
new OrderDetail()
{
OrderId= 10248,
ProductId= 11,
OrderUnitPrice= 14F,
OrderQuantity= 12,
OrderDiscount= 0F
}, new OrderDetail()
{
OrderId= 10248,
ProductId= 42,
OrderUnitPrice= 9.8F,
OrderQuantity= 10,
OrderDiscount= 0F
}, new OrderDetail()
{
OrderId= 10248,
ProductId= 72,
OrderUnitPrice= 34.8F,
OrderQuantity= 5,
OrderDiscount= 0F
}, new OrderDetail()
{
OrderId= 10249,
ProductId= 14,
OrderUnitPrice= 18.6F,
OrderQuantity= 9,
OrderDiscount= 0F
}, new OrderDetail()
{
OrderId= 10249,
ProductId= 51,
OrderUnitPrice= 42.4F,
OrderQuantity= 40,
OrderDiscount= 0F
}, new OrderDetail()
{
OrderId= 10250,
ProductId= 41,
OrderUnitPrice= 7.7F,
OrderQuantity= 10,
OrderDiscount= 0F
}, new OrderDetail()
{
OrderId= 10250,
ProductId= 51,
OrderUnitPrice= 42.4F,
OrderQuantity= 35,
OrderDiscount= 0.15F
}, new OrderDetail()
{
OrderId= 10250,
ProductId= 65,
OrderUnitPrice= 16.8F,
OrderQuantity= 15,
OrderDiscount= 0.15F
}, new OrderDetail()
{
OrderId= 10251,
ProductId= 22,
OrderUnitPrice= 16.8F,
OrderQuantity= 6,
OrderDiscount= 0.05F
}, new OrderDetail()
{
OrderId= 10251,
ProductId= 57,
OrderUnitPrice= 15.6F,
OrderQuantity= 15,
OrderDiscount= 0.05F
}, new OrderDetail()
{
OrderId= 10251,
ProductId= 65,
OrderUnitPrice= 16.8F,
OrderQuantity= 20,
OrderDiscount= 0F
}, new OrderDetail()
{
OrderId= 10252,
ProductId= 20,
OrderUnitPrice= 64.8F,
OrderQuantity= 40,
OrderDiscount= 0.05F
}, new OrderDetail()
{
OrderId= 10252,
ProductId= 33,
OrderUnitPrice= 2F,
OrderQuantity= 25,
OrderDiscount= 0.05F
}, new OrderDetail()
{
OrderId= 10252,
ProductId= 60,
OrderUnitPrice= 27.2F,
OrderQuantity= 40,
OrderDiscount= 0F
}, new OrderDetail()
{
OrderId= 10253,
ProductId= 31,
OrderUnitPrice= 10F,
OrderQuantity= 20,
OrderDiscount= 0F
}, new OrderDetail()
{
OrderId= 10253,
ProductId= 39,
OrderUnitPrice= 14.4F,
OrderQuantity= 42,
OrderDiscount= 0F
}, new OrderDetail()
{
OrderId= 10253,
ProductId= 49,
OrderUnitPrice= 16F,
OrderQuantity= 40,
OrderDiscount= 0F
}, new OrderDetail()
{
OrderId= 10254,
ProductId= 24,
OrderUnitPrice= 3.6F,
OrderQuantity= 15,
OrderDiscount= 0.15F
}, new OrderDetail()
{
OrderId= 10254,
ProductId= 55,
OrderUnitPrice= 19.2F,
OrderQuantity= 21,
OrderDiscount= 0.15F
}, new OrderDetail()
{
OrderId= 10254,
ProductId= 74,
OrderUnitPrice= 8F,
OrderQuantity= 21,
OrderDiscount= 0F
}, new OrderDetail()
{
OrderId= 10255,
ProductId= 2,
OrderUnitPrice= 15.2F,
OrderQuantity= 20,
OrderDiscount= 0F
}, new OrderDetail()
{
OrderId= 10255,
ProductId= 16,
OrderUnitPrice= 13.9F,
OrderQuantity= 35,
OrderDiscount= 0F
}, new OrderDetail()
{
OrderId= 10255,
ProductId= 36,
OrderUnitPrice= 15.2F,
OrderQuantity= 25,
OrderDiscount= 0F
}, new OrderDetail()
{
OrderId= 10255,
ProductId= 59,
OrderUnitPrice= 44F,
OrderQuantity= 30,
OrderDiscount= 0F
}, new OrderDetail()
{
OrderId= 10256,
ProductId= 53,
OrderUnitPrice= 26.2F,
OrderQuantity= 15,
OrderDiscount= 0F
}, new OrderDetail()
{
OrderId= 10256,
ProductId= 77,
OrderUnitPrice= 10.4F,
OrderQuantity= 12,
OrderDiscount= 0F
}, new OrderDetail()
{
OrderId= 10257,
ProductId= 27,
OrderUnitPrice= 35.1F,
OrderQuantity= 25,
OrderDiscount= 0F
}, new OrderDetail()
{
OrderId= 10257,
ProductId= 39,
OrderUnitPrice= 14.4F,
OrderQuantity= 6,
OrderDiscount= 0F
}, new OrderDetail()
{
OrderId= 10257,
ProductId= 77,
OrderUnitPrice= 10.4F,
OrderQuantity= 15,
OrderDiscount= 0F
}, new OrderDetail()
{
OrderId= 10258,
ProductId= 2,
OrderUnitPrice= 15.2F,
OrderQuantity= 50,
OrderDiscount= 0.2F
}, new OrderDetail()
{
OrderId= 10258,
ProductId= 5,
OrderUnitPrice= 17F,
OrderQuantity= 65,
OrderDiscount= 0.2F
}, new OrderDetail()
{
OrderId= 10258,
ProductId= 32,
OrderUnitPrice= 25.6F,
OrderQuantity= 6,
OrderDiscount= 0.2F
}
};

            return orderDetails.Skip(skip).Take(numberOfRows);
        }

        public static IEnumerable<Product> GetSampleProducts(int pageNumber =1, int numberOfRows = 20)
        {
            var skip = (pageNumber - 1) * numberOfRows;

            var products = new List<Product>()
{
new Product()
{
ProductId= 1,
ProductName= "Chai",
SupplierId= 8,
ProductCategoryId= 1,
ProductQuantityPerUnit= "10 boxes x 30 bags",
ProductUnitPrice= 18F,
ProductUnitsInStock= 39,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 10,
ProductDiscontinued= 1
}, new Product()
{
ProductId= 2,
ProductName= "Chang",
SupplierId= 1,
ProductCategoryId= 1,
ProductQuantityPerUnit= "24 - 12 oz bottles",
ProductUnitPrice= 19F,
ProductUnitsInStock= 17,
ProductUnitsOnOrder= 40,
ProductReorderLevel= 25,
ProductDiscontinued= 1
}, new Product()
{
ProductId= 3,
ProductName= "Aniseed Syrup",
SupplierId= 1,
ProductCategoryId= 2,
ProductQuantityPerUnit= "12 - 550 ml bottles",
ProductUnitPrice= 10F,
ProductUnitsInStock= 13,
ProductUnitsOnOrder= 70,
ProductReorderLevel= 25,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 4,
ProductName= "Chef Anton's Cajun Seasoning",
SupplierId= 2,
ProductCategoryId= 2,
ProductQuantityPerUnit= "48 - 6 oz jars",
ProductUnitPrice= 22F,
ProductUnitsInStock= 53,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 5,
ProductName= "Chef Anton's Gumbo Mix",
SupplierId= 2,
ProductCategoryId= 2,
ProductQuantityPerUnit= "36 boxes",
ProductUnitPrice= 21.35F,
ProductUnitsInStock= 0,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 1
}, new Product()
{
ProductId= 6,
ProductName= "Grandma's Boysenberry Spread",
SupplierId= 3,
ProductCategoryId= 2,
ProductQuantityPerUnit= "12 - 8 oz jars",
ProductUnitPrice= 25F,
ProductUnitsInStock= 120,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 25,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 7,
ProductName= "Uncle Bob's Organic Dried Pears",
SupplierId= 3,
ProductCategoryId= 7,
ProductQuantityPerUnit= "12 - 1 lb pkgs.",
ProductUnitPrice= 30F,
ProductUnitsInStock= 15,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 10,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 8,
ProductName= "Northwoods Cranberry Sauce",
SupplierId= 3,
ProductCategoryId= 2,
ProductQuantityPerUnit= "12 - 12 oz jars",
ProductUnitPrice= 40F,
ProductUnitsInStock= 6,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 9,
ProductName= "Mishi Kobe Niku",
SupplierId= 4,
ProductCategoryId= 6,
ProductQuantityPerUnit= "18 - 500 g pkgs.",
ProductUnitPrice= 97F,
ProductUnitsInStock= 29,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 1
}, new Product()
{
ProductId= 10,
ProductName= "Ikura",
SupplierId= 4,
ProductCategoryId= 8,
ProductQuantityPerUnit= "12 - 200 ml jars",
ProductUnitPrice= 31F,
ProductUnitsInStock= 31,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 11,
ProductName= "Queso Cabrales",
SupplierId= 5,
ProductCategoryId= 4,
ProductQuantityPerUnit= "1 kg pkg.",
ProductUnitPrice= 21F,
ProductUnitsInStock= 22,
ProductUnitsOnOrder= 30,
ProductReorderLevel= 30,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 12,
ProductName= "Queso Manchego La Pastora",
SupplierId= 5,
ProductCategoryId= 4,
ProductQuantityPerUnit= "10 - 500 g pkgs.",
ProductUnitPrice= 38F,
ProductUnitsInStock= 86,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 13,
ProductName= "Konbu",
SupplierId= 6,
ProductCategoryId= 8,
ProductQuantityPerUnit= "2 kg box",
ProductUnitPrice= 6F,
ProductUnitsInStock= 24,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 5,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 14,
ProductName= "Tofu",
SupplierId= 6,
ProductCategoryId= 7,
ProductQuantityPerUnit= "40 - 100 g pkgs.",
ProductUnitPrice= 23.25F,
ProductUnitsInStock= 35,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 15,
ProductName= "Genen Shouyu",
SupplierId= 6,
ProductCategoryId= 2,
ProductQuantityPerUnit= "24 - 250 ml bottles",
ProductUnitPrice= 13F,
ProductUnitsInStock= 39,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 5,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 16,
ProductName= "Pavlova",
SupplierId= 7,
ProductCategoryId= 3,
ProductQuantityPerUnit= "32 - 500 g boxes",
ProductUnitPrice= 17.45F,
ProductUnitsInStock= 29,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 10,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 17,
ProductName= "Alice Mutton",
SupplierId= 7,
ProductCategoryId= 6,
ProductQuantityPerUnit= "20 - 1 kg tins",
ProductUnitPrice= 39F,
ProductUnitsInStock= 0,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 1
}, new Product()
{
ProductId= 18,
ProductName= "Carnarvon Tigers",
SupplierId= 7,
ProductCategoryId= 8,
ProductQuantityPerUnit= "16 kg pkg.",
ProductUnitPrice= 62.5F,
ProductUnitsInStock= 42,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 19,
ProductName= "Teatime Chocolate Biscuits",
SupplierId= 8,
ProductCategoryId= 3,
ProductQuantityPerUnit= "10 boxes x 12 pieces",
ProductUnitPrice= 9.2F,
ProductUnitsInStock= 25,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 5,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 20,
ProductName= "Sir Rodney's Marmalade",
SupplierId= 8,
ProductCategoryId= 3,
ProductQuantityPerUnit= "30 gift boxes",
ProductUnitPrice= 81F,
ProductUnitsInStock= 40,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 21,
ProductName= "Sir Rodney's Scones",
SupplierId= 8,
ProductCategoryId= 3,
ProductQuantityPerUnit= "24 pkgs. x 4 pieces",
ProductUnitPrice= 10F,
ProductUnitsInStock= 3,
ProductUnitsOnOrder= 40,
ProductReorderLevel= 5,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 22,
ProductName= "Gustaf's Knäckebröd",
SupplierId= 9,
ProductCategoryId= 5,
ProductQuantityPerUnit= "24 - 500 g pkgs.",
ProductUnitPrice= 21F,
ProductUnitsInStock= 104,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 25,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 23,
ProductName= "Tunnbröd",
SupplierId= 9,
ProductCategoryId= 5,
ProductQuantityPerUnit= "12 - 250 g pkgs.",
ProductUnitPrice= 9F,
ProductUnitsInStock= 61,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 25,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 24,
ProductName= "Guaraná Fantástica",
SupplierId= 10,
ProductCategoryId= 1,
ProductQuantityPerUnit= "12 - 355 ml cans",
ProductUnitPrice= 4.5F,
ProductUnitsInStock= 20,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 1
}, new Product()
{
ProductId= 25,
ProductName= "NuNuCa Nuß-Nougat-Creme",
SupplierId= 11,
ProductCategoryId= 3,
ProductQuantityPerUnit= "20 - 450 g glasses",
ProductUnitPrice= 14F,
ProductUnitsInStock= 76,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 30,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 26,
ProductName= "Gumbär Gummibärchen",
SupplierId= 11,
ProductCategoryId= 3,
ProductQuantityPerUnit= "100 - 250 g bags",
ProductUnitPrice= 31.23F,
ProductUnitsInStock= 15,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 27,
ProductName= "Schoggi Schokolade",
SupplierId= 11,
ProductCategoryId= 3,
ProductQuantityPerUnit= "100 - 100 g pieces",
ProductUnitPrice= 43.9F,
ProductUnitsInStock= 49,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 30,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 28,
ProductName= "Rössle Sauerkraut",
SupplierId= 12,
ProductCategoryId= 7,
ProductQuantityPerUnit= "25 - 825 g cans",
ProductUnitPrice= 45.6F,
ProductUnitsInStock= 26,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 1
}, new Product()
{
ProductId= 29,
ProductName= "Thüringer Rostbratwurst",
SupplierId= 12,
ProductCategoryId= 6,
ProductQuantityPerUnit= "50 bags x 30 sausgs.",
ProductUnitPrice= 123.79F,
ProductUnitsInStock= 0,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 1
}, new Product()
{
ProductId= 30,
ProductName= "Nord-Ost Matjeshering",
SupplierId= 13,
ProductCategoryId= 8,
ProductQuantityPerUnit= "10 - 200 g glasses",
ProductUnitPrice= 25.89F,
ProductUnitsInStock= 10,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 15,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 31,
ProductName= "Gorgonzola Telino",
SupplierId= 14,
ProductCategoryId= 4,
ProductQuantityPerUnit= "12 - 100 g pkgs",
ProductUnitPrice= 12.5F,
ProductUnitsInStock= 0,
ProductUnitsOnOrder= 70,
ProductReorderLevel= 20,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 32,
ProductName= "Mascarpone Fabioli",
SupplierId= 14,
ProductCategoryId= 4,
ProductQuantityPerUnit= "24 - 200 g pkgs.",
ProductUnitPrice= 32F,
ProductUnitsInStock= 9,
ProductUnitsOnOrder= 40,
ProductReorderLevel= 25,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 33,
ProductName= "Geitost",
SupplierId= 15,
ProductCategoryId= 4,
ProductQuantityPerUnit= "500 g",
ProductUnitPrice= 2.5F,
ProductUnitsInStock= 112,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 20,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 34,
ProductName= "Sasquatch Ale",
SupplierId= 16,
ProductCategoryId= 1,
ProductQuantityPerUnit= "24 - 12 oz bottles",
ProductUnitPrice= 14F,
ProductUnitsInStock= 111,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 15,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 35,
ProductName= "Steeleye Stout",
SupplierId= 16,
ProductCategoryId= 1,
ProductQuantityPerUnit= "24 - 12 oz bottles",
ProductUnitPrice= 18F,
ProductUnitsInStock= 20,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 15,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 36,
ProductName= "Inlagd Sill",
SupplierId= 17,
ProductCategoryId= 8,
ProductQuantityPerUnit= "24 - 250 g  jars",
ProductUnitPrice= 19F,
ProductUnitsInStock= 112,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 20,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 37,
ProductName= "Gravad lax",
SupplierId= 17,
ProductCategoryId= 8,
ProductQuantityPerUnit= "12 - 500 g pkgs.",
ProductUnitPrice= 26F,
ProductUnitsInStock= 11,
ProductUnitsOnOrder= 50,
ProductReorderLevel= 25,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 38,
ProductName= "Côte de Blaye",
SupplierId= 18,
ProductCategoryId= 1,
ProductQuantityPerUnit= "12 - 75 cl bottles",
ProductUnitPrice= 263.5F,
ProductUnitsInStock= 17,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 15,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 39,
ProductName= "Chartreuse verte",
SupplierId= 18,
ProductCategoryId= 1,
ProductQuantityPerUnit= "750 cc per bottle",
ProductUnitPrice= 18F,
ProductUnitsInStock= 69,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 5,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 40,
ProductName= "Boston Crab Meat",
SupplierId= 19,
ProductCategoryId= 8,
ProductQuantityPerUnit= "24 - 4 oz tins",
ProductUnitPrice= 18.4F,
ProductUnitsInStock= 123,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 30,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 41,
ProductName= "Jack's New England Clam Chowder",
SupplierId= 19,
ProductCategoryId= 8,
ProductQuantityPerUnit= "12 - 12 oz cans",
ProductUnitPrice= 9.65F,
ProductUnitsInStock= 85,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 10,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 42,
ProductName= "Singaporean Hokkien Fried Mee",
SupplierId= 20,
ProductCategoryId= 5,
ProductQuantityPerUnit= "32 - 1 kg pkgs.",
ProductUnitPrice= 14F,
ProductUnitsInStock= 26,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 1
}, new Product()
{
ProductId= 43,
ProductName= "Ipoh Coffee",
SupplierId= 20,
ProductCategoryId= 1,
ProductQuantityPerUnit= "16 - 500 g tins",
ProductUnitPrice= 46F,
ProductUnitsInStock= 17,
ProductUnitsOnOrder= 10,
ProductReorderLevel= 25,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 44,
ProductName= "Gula Malacca",
SupplierId= 20,
ProductCategoryId= 2,
ProductQuantityPerUnit= "20 - 2 kg bags",
ProductUnitPrice= 19.45F,
ProductUnitsInStock= 27,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 15,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 45,
ProductName= "Rogede sild",
SupplierId= 21,
ProductCategoryId= 8,
ProductQuantityPerUnit= "1k pkg.",
ProductUnitPrice= 9.5F,
ProductUnitsInStock= 5,
ProductUnitsOnOrder= 70,
ProductReorderLevel= 15,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 46,
ProductName= "Spegesild",
SupplierId= 21,
ProductCategoryId= 8,
ProductQuantityPerUnit= "4 - 450 g glasses",
ProductUnitPrice= 12F,
ProductUnitsInStock= 95,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 47,
ProductName= "Zaanse koeken",
SupplierId= 22,
ProductCategoryId= 3,
ProductQuantityPerUnit= "10 - 4 oz boxes",
ProductUnitPrice= 9.5F,
ProductUnitsInStock= 36,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 48,
ProductName= "Chocolade",
SupplierId= 22,
ProductCategoryId= 3,
ProductQuantityPerUnit= "10 pkgs.",
ProductUnitPrice= 12.75F,
ProductUnitsInStock= 15,
ProductUnitsOnOrder= 70,
ProductReorderLevel= 25,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 49,
ProductName= "Maxilaku",
SupplierId= 23,
ProductCategoryId= 3,
ProductQuantityPerUnit= "24 - 50 g pkgs.",
ProductUnitPrice= 20F,
ProductUnitsInStock= 10,
ProductUnitsOnOrder= 60,
ProductReorderLevel= 15,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 50,
ProductName= "Valkoinen suklaa",
SupplierId= 23,
ProductCategoryId= 3,
ProductQuantityPerUnit= "12 - 100 g bars",
ProductUnitPrice= 16.25F,
ProductUnitsInStock= 65,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 30,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 51,
ProductName= "Manjimup Dried Apples",
SupplierId= 24,
ProductCategoryId= 7,
ProductQuantityPerUnit= "50 - 300 g pkgs.",
ProductUnitPrice= 53F,
ProductUnitsInStock= 20,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 10,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 52,
ProductName= "Filo Mix",
SupplierId= 24,
ProductCategoryId= 5,
ProductQuantityPerUnit= "16 - 2 kg boxes",
ProductUnitPrice= 7F,
ProductUnitsInStock= 38,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 25,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 53,
ProductName= "Perth Pasties",
SupplierId= 24,
ProductCategoryId= 6,
ProductQuantityPerUnit= "48 pieces",
ProductUnitPrice= 32.8F,
ProductUnitsInStock= 0,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 1
}, new Product()
{
ProductId= 54,
ProductName= "Tourtière",
SupplierId= 25,
ProductCategoryId= 6,
ProductQuantityPerUnit= "16 pies",
ProductUnitPrice= 7.45F,
ProductUnitsInStock= 21,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 10,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 55,
ProductName= "Pâté chinois",
SupplierId= 25,
ProductCategoryId= 6,
ProductQuantityPerUnit= "24 boxes x 2 pies",
ProductUnitPrice= 24F,
ProductUnitsInStock= 115,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 20,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 56,
ProductName= "Gnocchi di nonna Alice",
SupplierId= 26,
ProductCategoryId= 5,
ProductQuantityPerUnit= "24 - 250 g pkgs.",
ProductUnitPrice= 38F,
ProductUnitsInStock= 21,
ProductUnitsOnOrder= 10,
ProductReorderLevel= 30,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 57,
ProductName= "Ravioli Angelo",
SupplierId= 26,
ProductCategoryId= 5,
ProductQuantityPerUnit= "24 - 250 g pkgs.",
ProductUnitPrice= 19.5F,
ProductUnitsInStock= 36,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 20,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 58,
ProductName= "Escargots de Bourgogne",
SupplierId= 27,
ProductCategoryId= 8,
ProductQuantityPerUnit= "24 pieces",
ProductUnitPrice= 13.25F,
ProductUnitsInStock= 62,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 20,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 59,
ProductName= "Raclette Courdavault",
SupplierId= 28,
ProductCategoryId= 4,
ProductQuantityPerUnit= "5 kg pkg.",
ProductUnitPrice= 55F,
ProductUnitsInStock= 79,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 60,
ProductName= "Camembert Pierrot",
SupplierId= 28,
ProductCategoryId= 4,
ProductQuantityPerUnit= "15 - 300 g rounds",
ProductUnitPrice= 34F,
ProductUnitsInStock= 19,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 61,
ProductName= "Sirop d'érable",
SupplierId= 29,
ProductCategoryId= 2,
ProductQuantityPerUnit= "24 - 500 ml bottles",
ProductUnitPrice= 28.5F,
ProductUnitsInStock= 113,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 25,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 62,
ProductName= "Tarte au sucre",
SupplierId= 29,
ProductCategoryId= 3,
ProductQuantityPerUnit= "48 pies",
ProductUnitPrice= 49.3F,
ProductUnitsInStock= 17,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 63,
ProductName= "Vegie-spread",
SupplierId= 7,
ProductCategoryId= 2,
ProductQuantityPerUnit= "15 - 625 g jars",
ProductUnitPrice= 43.9F,
ProductUnitsInStock= 24,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 5,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 64,
ProductName= "Wimmers gute Semmelknödel",
SupplierId= 12,
ProductCategoryId= 5,
ProductQuantityPerUnit= "20 bags x 4 pieces",
ProductUnitPrice= 33.25F,
ProductUnitsInStock= 22,
ProductUnitsOnOrder= 80,
ProductReorderLevel= 30,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 65,
ProductName= "Louisiana Fiery Hot Pepper Sauce",
SupplierId= 2,
ProductCategoryId= 2,
ProductQuantityPerUnit= "32 - 8 oz bottles",
ProductUnitPrice= 21.05F,
ProductUnitsInStock= 76,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 66,
ProductName= "Louisiana Hot Spiced Okra",
SupplierId= 2,
ProductCategoryId= 2,
ProductQuantityPerUnit= "24 - 8 oz jars",
ProductUnitPrice= 17F,
ProductUnitsInStock= 4,
ProductUnitsOnOrder= 100,
ProductReorderLevel= 20,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 67,
ProductName= "Laughing Lumberjack Lager",
SupplierId= 16,
ProductCategoryId= 1,
ProductQuantityPerUnit= "24 - 12 oz bottles",
ProductUnitPrice= 14F,
ProductUnitsInStock= 52,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 10,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 68,
ProductName= "Scottish Longbreads",
SupplierId= 8,
ProductCategoryId= 3,
ProductQuantityPerUnit= "10 boxes x 8 pieces",
ProductUnitPrice= 12.5F,
ProductUnitsInStock= 6,
ProductUnitsOnOrder= 10,
ProductReorderLevel= 15,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 69,
ProductName= "Gudbrandsdalsost",
SupplierId= 15,
ProductCategoryId= 4,
ProductQuantityPerUnit= "10 kg pkg.",
ProductUnitPrice= 36F,
ProductUnitsInStock= 26,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 15,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 70,
ProductName= "Outback Lager",
SupplierId= 7,
ProductCategoryId= 1,
ProductQuantityPerUnit= "24 - 355 ml bottles",
ProductUnitPrice= 15F,
ProductUnitsInStock= 15,
ProductUnitsOnOrder= 10,
ProductReorderLevel= 30,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 71,
ProductName= "Flotemysost",
SupplierId= 15,
ProductCategoryId= 4,
ProductQuantityPerUnit= "10 - 500 g pkgs.",
ProductUnitPrice= 21.5F,
ProductUnitsInStock= 26,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 72,
ProductName= "Mozzarella di Giovanni",
SupplierId= 14,
ProductCategoryId= 4,
ProductQuantityPerUnit= "24 - 200 g pkgs.",
ProductUnitPrice= 34.8F,
ProductUnitsInStock= 14,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 0,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 73,
ProductName= "Röd Kaviar",
SupplierId= 17,
ProductCategoryId= 8,
ProductQuantityPerUnit= "24 - 150 g jars",
ProductUnitPrice= 15F,
ProductUnitsInStock= 101,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 5,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 74,
ProductName= "Longlife Tofu",
SupplierId= 4,
ProductCategoryId= 7,
ProductQuantityPerUnit= "5 kg pkg.",
ProductUnitPrice= 10F,
ProductUnitsInStock= 4,
ProductUnitsOnOrder= 20,
ProductReorderLevel= 5,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 75,
ProductName= "Rhönbräu Klosterbier",
SupplierId= 12,
ProductCategoryId= 1,
ProductQuantityPerUnit= "24 - 0.5 l bottles",
ProductUnitPrice= 7.75F,
ProductUnitsInStock= 125,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 25,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 76,
ProductName= "Lakkalikööri",
SupplierId= 23,
ProductCategoryId= 1,
ProductQuantityPerUnit= "500 ml",
ProductUnitPrice= 18F,
ProductUnitsInStock= 57,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 20,
ProductDiscontinued= 0
}, new Product()
{
ProductId= 77,
ProductName= "Original Frankfurter grüne Soße",
SupplierId= 12,
ProductCategoryId= 2,
ProductQuantityPerUnit= "12 boxes",
ProductUnitPrice= 13F,
ProductUnitsInStock= 32,
ProductUnitsOnOrder= 0,
ProductReorderLevel= 15,
ProductDiscontinued= 0
}
};

            return products.Skip(skip).Take(numberOfRows);
        }

        public static IEnumerable<Region> GetSampleRegions(int pageNumber =1, int numberOfRows = 20)
        {
            var skip = (pageNumber - 1) * numberOfRows;

            var regions = new List<Region>()
{
new Region()
{
RegionId= 1,
RegionDescription = "Eastern"
},
new Region()
{
RegionId= 2,
RegionDescription = "Western"
},
new Region()
{
RegionId= 3,
RegionDescription = "Northern"
},
new Region()
{
RegionId= 4,
RegionDescription = "Southern"
}
};

            return regions.Skip(skip).Take(numberOfRows);
        }

        public static IEnumerable<Shipper> GetSampleShippers(int pageNumber = 1, int numberOfRows = 20)
        {
            var skip = (pageNumber - 1) * numberOfRows;

            var shippers = new List<Shipper>()
{
new Shipper()
{
ShipperId= 1,
ShipperName= "Speedy Express",
ShipperPhone= "(503) 555-9831"
}, new Shipper()
{
ShipperId= 2,
ShipperName= "United Package",
ShipperPhone= "(503) 555-3199"
}, new Shipper()
{
ShipperId= 3,
ShipperName= "Federal Shipping",
ShipperPhone= "(503) 555-9931"
}, new Shipper()
{
ShipperId= 4,
ShipperName= "Alliance Shippers",
ShipperPhone= "1-800-222-0451"
}, new Shipper()
{
ShipperId= 5,
ShipperName= "UPS",
ShipperPhone= "1-800-782-7892"
}, new Shipper()
{
ShipperId= 6,
ShipperName= "DHL",
ShipperPhone= "1-800-225-5345"
}
};
            return shippers.Skip(skip).Take(numberOfRows);
        }

        public static IEnumerable<Supplier> GetSampleSuppliers(int pageNumber =1, int numberOfRows = 20)
        {
            var skip = (pageNumber - 1) * numberOfRows;

            var suppliers = new List<Supplier>()
{
new Supplier()
{
SupplierId= 1,
SupplierName= "Exotic Liquids",
SupplierContactName= "Charlotte Cooper",
SupplierContactTitle= "Purchasing Manager",
SupplierAddress= "49 Gilbert St.",
SupplierCity= "London",
RegionId=1,
SupplierPostalCode= "EC1 4SD",
SupplierCountry= "UK",
SupplierPhone= "(171) 555-2222",
SupplierFax= "",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 2,
SupplierName= "New Orleans Cajun Delights",
SupplierContactName= "Shelley Burke",
SupplierContactTitle= "Order Administrator",
SupplierAddress= "P.O. Box 78934",
SupplierCity= "New Orleans",
RegionId=4,
SupplierPostalCode= "70117",
SupplierCountry= "USA",
SupplierPhone= "(100) 555-4822",
SupplierFax= "",
SupplierHomepage= "#CAJUN.HTM#"
}, new Supplier()
{
SupplierId= 3,
SupplierName= "Grandma Kelly's Homestead",
SupplierContactName= "Regina Murphy",
SupplierContactTitle= "Sales Representative",
SupplierAddress= "707 Oxford Rd.",
SupplierCity= "Ann Arbor",
RegionId=4,
SupplierPostalCode= "48104",
SupplierCountry= "USA",
SupplierPhone= "(313) 555-5735",
SupplierFax= "(313) 555-3349",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 4,
SupplierName= "Tokyo Traders",
SupplierContactName= "Yoshi Nagase",
SupplierContactTitle= "Marketing Manager",
SupplierAddress= "9-8 Sekimai Musashino-shi",
SupplierCity= "Tokyo",
RegionId=1,
SupplierPostalCode= "100",
SupplierCountry= "Japan",
SupplierPhone= "(03) 3555-5011",
SupplierFax= "",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 5,
SupplierName= "Cooperativa de Quesos 'Las Cabras'",
SupplierContactName= "Antonio del Valle Saavedra",
SupplierContactTitle= "Export Administrator",
SupplierAddress= "Calle del Rosal 4",
SupplierCity= "Oviedo",
RegionId=4,
SupplierPostalCode= "33007",
SupplierCountry= "Spain",
SupplierPhone= "(98) 598 76 54",
SupplierFax= "",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 6,
SupplierName= "Mayumi's",
SupplierContactName= "Mayumi Ohno",
SupplierContactTitle= "Marketing Representative",
SupplierAddress= "92 Setsuko Chuo-ku",
SupplierCity= "Osaka",
RegionId=1,
SupplierPostalCode= "545",
SupplierCountry= "Japan",
SupplierPhone= "(06) 431-7877",
SupplierFax= "",
SupplierHomepage= "Mayumi's (on the World Wide Web)#http=//www.microsoft.com/accessdev/sampleapps/mayumi.htm#"
}, new Supplier()
{
SupplierId= 7,
SupplierName= "Pavlova, Ltd.",
SupplierContactName= "Ian Devling",
SupplierContactTitle= "Marketing Manager",
SupplierAddress= "74 Rose St. Moonie Ponds",
SupplierCity= "Melbourne",
RegionId=4,
SupplierPostalCode= "3058",
SupplierCountry= "Australia",
SupplierPhone= "(03) 444-2343",
SupplierFax= "(03) 444-6588",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 8,
SupplierName= "Specialty Biscuits, Ltd.",
SupplierContactName= "Peter Wilson",
SupplierContactTitle= "Sales Representative",
SupplierAddress= "29 King's Way",
SupplierCity= "Manchester",
RegionId=1,
SupplierPostalCode= "M14 GSD",
SupplierCountry= "UK",
SupplierPhone= "(161) 555-4448",
SupplierFax= "",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 9,
SupplierName= "PB Knäckebröd AB",
SupplierContactName= "Lars Peterson",
SupplierContactTitle= "Sales Agent",
SupplierAddress= "Kaloadagatan 13",
SupplierCity= "Göteborg",
RegionId=1,
SupplierPostalCode= "S-345 67",
SupplierCountry= "Sweden",
SupplierPhone= "031-987 65 43",
SupplierFax= "031-987 65 91",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 10,
SupplierName= "Refrescos Americanas LTDA",
SupplierContactName= "Carlos Diaz",
SupplierContactTitle= "Marketing Manager",
SupplierAddress= "Av. das Americanas 12.890",
SupplierCity= "Sao Paulo",
RegionId=1,
SupplierPostalCode= "5442",
SupplierCountry= "Brazil",
SupplierPhone= "(11) 555 4640",
SupplierFax= "",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 11,
SupplierName= "Heli Süßwaren GmbH & Co. KG",
SupplierContactName= "Petra Winkler",
SupplierContactTitle= "Sales Manager",
SupplierAddress= "Tiergartenstraße 5",
SupplierCity= "Berlin",
RegionId=1,
SupplierPostalCode= "10785",
SupplierCountry= "Germany",
SupplierPhone= "(010) 9984510",
SupplierFax= "",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 12,
SupplierName= "Plutzer Lebensmittelgroßmärkte AG",
SupplierContactName= "Martin Bein",
SupplierContactTitle= "International Marketing Mgr.",
SupplierAddress= "Bogenallee 51",
SupplierCity= "Frankfurt",
RegionId=1,
SupplierPostalCode= "60439",
SupplierCountry= "Germany",
SupplierPhone= "(069) 992755",
SupplierFax= "",
SupplierHomepage= "Plutzer (on the World Wide Web)#http=//www.microsoft.com/accessdev/sampleapps/plutzer.htm#"
}, new Supplier()
{
SupplierId= 13,
SupplierName= "Nord-Ost-Fisch Handelsgesellschaft mbH",
SupplierContactName= "Sven Petersen",
SupplierContactTitle= "Coordinator Foreign Markets",
SupplierAddress= "Frahmredder 112a",
SupplierCity= "Cuxhaven",
RegionId=1,
SupplierPostalCode= "27478",
SupplierCountry= "Germany",
SupplierPhone= "(04721) 8713",
SupplierFax= "(04721) 8714",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 14,
SupplierName= "Formaggi Fortini s.r.l.",
SupplierContactName= "Elio Rossi",
SupplierContactTitle= "Sales Representative",
SupplierAddress= "Viale Dante, 75",
SupplierCity= "Ravenna",
RegionId=1,
SupplierPostalCode= "48100",
SupplierCountry= "Italy",
SupplierPhone= "(0544) 60323",
SupplierFax= "(0544) 60603",
SupplierHomepage= "#FORMAGGI.HTM#"
}, new Supplier()
{
SupplierId= 15,
SupplierName= "Norske Meierier",
SupplierContactName= "Beate Vileid",
SupplierContactTitle= "Marketing Manager",
SupplierAddress= "Hatlevegen 5",
SupplierCity= "Sandvika",
RegionId=1,
SupplierPostalCode= "1320",
SupplierCountry= "Norway",
SupplierPhone= "(0)2-953010",
SupplierFax= "",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 16,
SupplierName= "Bigfoot Breweries",
SupplierContactName= "Cheryl Saylor",
SupplierContactTitle= "Regional Account Rep.",
SupplierAddress= "3400 - 8th Avenue Suite 210",
SupplierCity= "Bend",
RegionId=4,
SupplierPostalCode= "97101",
SupplierCountry= "USA",
SupplierPhone= "(503) 555-9931",
SupplierFax= "",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 17,
SupplierName= "Svensk Sjöföda AB",
SupplierContactName= "Michael Björn",
SupplierContactTitle= "Sales Representative",
SupplierAddress= "Brovallavägen 231",
SupplierCity= "Stockholm",
RegionId=1,
SupplierPostalCode= "S-123 45",
SupplierCountry= "Sweden",
SupplierPhone= "08-123 45 67",
SupplierFax= "",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 18,
SupplierName= "Aux joyeux ecclésiastiques",
SupplierContactName= "Guylène Nodier",
SupplierContactTitle= "Sales Manager",
SupplierAddress= "203, Rue des Francs-Bourgeois",
SupplierCity= "Paris",
RegionId=1,
SupplierPostalCode= "75004",
SupplierCountry= "France",
SupplierPhone= "(1) 03.83.00.68",
SupplierFax= "(1) 03.83.00.62",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 19,
SupplierName= "New England Seafood Cannery",
SupplierContactName= "Robb Merchant",
SupplierContactTitle= "Wholesale Account Agent",
SupplierAddress= "Order Processing Dept. 2100 Paul Revere Blvd.",
SupplierCity= "Boston",
RegionId=4,
SupplierPostalCode= "02134",
SupplierCountry= "USA",
SupplierPhone= "(617) 555-3267",
SupplierFax= "(617) 555-3389",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 20,
SupplierName= "Leka Trading",
SupplierContactName= "Chandra Leka",
SupplierContactTitle= "Owner",
SupplierAddress= "471 Serangoon Loop, Suite #402",
SupplierCity= "Singapore",
RegionId=1,
SupplierPostalCode= "0512",
SupplierCountry= "Singapore",
SupplierPhone= "555-8787",
SupplierFax= "",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 21,
SupplierName= "Lyngbysild",
SupplierContactName= "Niels Petersen",
SupplierContactTitle= "Sales Manager",
SupplierAddress= "Lyngbysild Fiskebakken 10",
SupplierCity= "Lyngby",
RegionId=1,
SupplierPostalCode= "2800",
SupplierCountry= "Denmark",
SupplierPhone= "43844108",
SupplierFax= "43844115",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 22,
SupplierName= "Zaanse Snoepfabriek",
SupplierContactName= "Dirk Luchte",
SupplierContactTitle= "Accounting Manager",
SupplierAddress= "Verkoop Rijnweg 22",
SupplierCity= "Zaandam",
RegionId=1,
SupplierPostalCode= "9999 ZZ",
SupplierCountry= "Netherlands",
SupplierPhone= "(12345) 1212",
SupplierFax= "(12345) 1210",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 23,
SupplierName= "Karkki Oy",
SupplierContactName= "Anne Heikkonen",
SupplierContactTitle= "Product Manager",
SupplierAddress= "Valtakatu 12",
SupplierCity= "Lappeenranta",
RegionId=1,
SupplierPostalCode= "53120",
SupplierCountry= "Finland",
SupplierPhone= "(953) 10956",
SupplierFax= "",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 24,
SupplierName= "G'day, Mate",
SupplierContactName= "Wendy Mackenzie",
SupplierContactTitle= "Sales Representative",
SupplierAddress= "170 Prince Edward Parade Hunter's Hill",
SupplierCity= "Sydney",
RegionId=3,
SupplierPostalCode= "2042",
SupplierCountry= "Australia",
SupplierPhone= "(02) 555-5914",
SupplierFax= "(02) 555-4873",
SupplierHomepage= "G'day Mate (on the World Wide Web)#http=//www.microsoft.com/accessdev/sampleapps/gdaymate.htm#"
}, new Supplier()
{
SupplierId= 25,
SupplierName= "Ma Maison",
SupplierContactName= "Jean-Guy Lauzon",
SupplierContactTitle= "Marketing Manager",
SupplierAddress= "2960 Rue St. Laurent",
SupplierCity= "Montréal",
RegionId=3,
SupplierPostalCode= "H1J 1C3",
SupplierCountry= "Canada",
SupplierPhone= "(514) 555-9022",
SupplierFax= "",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 26,
SupplierName= "Pasta Buttini s.r.l.",
SupplierContactName= "Giovanni Giudici",
SupplierContactTitle= "Order Administrator",
SupplierAddress= "Via dei Gelsomini, 153",
SupplierCity= "Salerno",
RegionId=1,
SupplierPostalCode= "84100",
SupplierCountry= "Italy",
SupplierPhone= "(089) 6547665",
SupplierFax= "(089) 6547667",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 27,
SupplierName= "Escargots Nouveaux",
SupplierContactName= "Marie Delamare",
SupplierContactTitle= "Sales Manager",
SupplierAddress= "22, rue H. Voiron",
SupplierCity= "Montceau",
RegionId=1,
SupplierPostalCode= "71300",
SupplierCountry= "France",
SupplierPhone= "85.57.00.07",
SupplierFax= "",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 28,
SupplierName= "Gai pâturage",
SupplierContactName= "Eliane Noz",
SupplierContactTitle= "Sales Representative",
SupplierAddress= "Bat. B 3, rue des Alpes",
SupplierCity= "Annecy",
RegionId=1,
SupplierPostalCode= "74000",
SupplierCountry= "France",
SupplierPhone= "38.76.98.06",
SupplierFax= "38.76.98.58",
SupplierHomepage= ""
}, new Supplier()
{
SupplierId= 29,
SupplierName= "Forêts d'érables",
SupplierContactName= "Chantal Goulet",
SupplierContactTitle= "Accounting Manager",
SupplierAddress= "148 rue Chasseur",
SupplierCity= "Ste-Hyacinthe",
RegionId=3,
SupplierPostalCode= "J2S 7S8",
SupplierCountry= "Canada",
SupplierPhone= "(514) 555-2955",
SupplierFax= "(514) 555-2921",
SupplierHomepage= ""
}
};

            return suppliers.Skip(skip).Take(numberOfRows);
        }
}
}

