using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roustabout.Tools.Chance
{
    public class LookupData
    {


        public FistNameData FirstName = new FistNameData
        {
            Male = new string[]
            {
                "James", "John", "Robert", "Michael", "William", "David", "Richard", "Joseph", "Charles", "Thomas", "Christopher", "Daniel", "Matthew", "George", "Donald", "Anthony", "Paul", "Mark", "Edward", "Steven", "Kenneth", "Andrew", "Brian", "Joshua", "Kevin", "Ronald", "Timothy", "Jason", "Jeffrey", "Frank", "Gary", "Ryan", "Nicholas", "Eric", "Stephen", "Jacob", "Larry", "Jonathan", "Scott", "Raymond", "Justin", "Brandon", "Gregory", "Samuel", "Benjamin", "Patrick", "Jack", "Henry", "Walter", "Dennis", "Jerry", "Alexander", "Peter", "Tyler", "Douglas", "Harold", "Aaron", "Jose", "Adam", "Arthur", "Zachary", "Carl", "Nathan", "Albert", "Kyle", "Lawrence", "Joe", "Willie", "Gerald", "Roger", "Keith", "Jeremy", "Terry", "Harry", "Ralph", "Sean", "Jesse", "Roy", "Louis", "Billy", "Austin", "Bruce", "Eugene", "Christian", "Bryan", "Wayne", "Russell", "Howard", "Fred", "Ethan", "Jordan", "Philip", "Alan", "Juan", "Randy", "Vincent", "Bobby", "Dylan", "Johnny", "Phillip", "Victor", "Clarence", "Ernest", "Martin", "Craig", "Stanley", "Shawn", "Travis", "Bradley", "Leonard", "Earl", "Gabriel", "Jimmy", "Francis", "Todd", "Noah", "Danny", "Dale", "Cody", "Carlos", "Allen", "Frederick", "Logan", "Curtis", "Alex", "Joel", "Luis", "Norman", "Marvin", "Glenn", "Tony", "Nathaniel", "Rodney", "Melvin", "Alfred", "Steve", "Cameron", "Chad", "Edwin", "Caleb", "Evan", "Antonio", "Lee", "Herbert", "Jeffery", "Isaac", "Derek", "Ricky", "Marcus", "Theodore", "Elijah", "Luke", "Jesus", "Eddie", "Troy", "Mike", "Dustin", "Ray", "Adrian", "Bernard", "Leroy", "Angel", "Randall", "Wesley", "Ian", "Jared", "Mason", "Hunter", "Calvin", "Oscar", "Clifford", "Jay", "Shane", "Ronnie", "Barry", "Lucas", "Corey", "Manuel", "Leo", "Tommy", "Warren", "Jackson", "Isaiah", "Connor", "Don", "Dean", "Jon", "Julian", "Miguel", "Bill", "Lloyd", "Charlie", "Mitchell", "Leon", "Jerome", "Darrell", "Jeremiah", "Alvin", "Brett", "Seth", "Floyd", "Jim", "Blake", "Micheal", "Gordon", "Trevor", "Lewis", "Erik", "Edgar", "Vernon", "Devin", "Gavin", "Jayden", "Chris", "Clyde", "Tom", "Derrick", "Mario", "Brent", "Marc", "Herman", "Chase", "Dominic", "Ricardo", "Franklin", "Maurice", "Max", "Aiden", "Owen", "Lester", "Gilbert", "Elmer", "Gene", "Francisco", "Glen", "Cory", "Garrett", "Clayton", "Sam", "Jorge", "Chester", "Alejandro", "Jeff", "Harvey", "Milton", "Cole", "Ivan", "Andre", "Duane", "Landon"
            },
            Female = new string[]
            {
                "Mary", "Emma", "Elizabeth", "Minnie", "Margaret", "Ida", "Alice", "Bertha", "Sarah", "Annie", "Clara", "Ella", "Florence", "Cora", "Martha", "Laura", "Nellie", "Grace", "Carrie", "Maude", "Mabel", "Bessie", "Jennie", "Gertrude", "Julia", "Hattie", "Edith", "Mattie", "Rose", "Catherine", "Lillian", "Ada", "Lillie", "Helen", "Jessie", "Louise", "Ethel", "Lula", "Myrtle", "Eva", "Frances", "Lena", "Lucy", "Edna", "Maggie", "Pearl", "Daisy", "Fannie", "Josephine", "Dora", "Rosa", "Katherine", "Agnes", "Marie", "Nora", "May", "Mamie", "Blanche", "Stella", "Ellen", "Nancy", "Effie", "Sallie", "Nettie", "Della", "Lizzie", "Flora", "Susie", "Maud", "Mae", "Etta", "Harriet", "Sadie", "Caroline", "Katie", "Lydia", "Elsie", "Kate", "Susan", "Mollie", "Alma", "Addie", "Georgia", "Eliza", "Lulu", "Nannie", "Lottie", "Amanda", "Belle", "Charlotte", "Rebecca", "Ruth", "Viola", "Olive", "Amelia", "Hannah", "Jane", "Virginia", "Emily", "Matilda", "Irene", "Kathryn", "Esther", "Willie", "Henrietta", "Ollie", "Amy", "Rachel", "Sara", "Estella", "Theresa", "Augusta", "Ora", "Pauline", "Josie", "Lola", "Sophia", "Leona", "Anne", "Mildred", "Ann", "Beulah", "Callie", "Lou", "Delia", "Eleanor", "Barbara", "Iva", "Louisa", "Maria", "Mayme", "Evelyn", "Estelle", "Nina", "Betty", "Marion", "Bettie", "Dorothy", "Luella", "Inez", "Lela", "Rosie", "Allie", "Millie", "Janie", "Cornelia", "Victoria", "Ruby", "Winifred", "Alta", "Celia", "Christine", "Beatrice", "Birdie", "Harriett", "Mable", "Myra", "Sophie", "Tillie", "Isabel", "Sylvia", "Carolyn", "Isabelle", "Leila", "Sally", "Ina", "Essie", "Bertie", "Nell", "Alberta", "Katharine", "Lora", "Rena", "Mina", "Rhoda", "Mathilda", "Abbie", "Eula", "Dollie", "Hettie", "Eunice", "Fanny", "Ola", "Lenora", "Adelaide", "Christina", "Lelia", "Nelle", "Sue", "Johanna", "Lilly", "Lucinda", "Minerva", "Lettie", "Roxie", "Cynthia", "Helena", "Hilda", "Hulda", "Bernice", "Genevieve", "Jean", "Cordelia", "Marian", "Francis", "Jeanette", "Adeline", "Gussie", "Leah", "Lois", "Lura", "Mittie", "Hallie", "Isabella", "Olga", "Phoebe", "Teresa", "Hester", "Lida", "Lina", "Winnie", "Claudia", "Marguerite", "Vera", "Cecelia", "Bess", "Emilie", "John", "Rosetta", "Verna", "Myrtie", "Cecilia", "Elva", "Olivia", "Ophelia", "Georgie", "Elnora", "Violet", "Adele", "Lily", "Linnie", "Loretta", "Madge", "Polly", "Virgie", "Eugenia", "Lucile", "Lucille", "Mabelle", "Rosalie"
            }
        };
        //    firstNames: {
        //        "male": ["James", "John", "Robert", "Michael", "William", "David", "Richard", "Joseph", "Charles", "Thomas", "Christopher", "Daniel", "Matthew", "George", "Donald", "Anthony", "Paul", "Mark", "Edward", "Steven", "Kenneth", "Andrew", "Brian", "Joshua", "Kevin", "Ronald", "Timothy", "Jason", "Jeffrey", "Frank", "Gary", "Ryan", "Nicholas", "Eric", "Stephen", "Jacob", "Larry", "Jonathan", "Scott", "Raymond", "Justin", "Brandon", "Gregory", "Samuel", "Benjamin", "Patrick", "Jack", "Henry", "Walter", "Dennis", "Jerry", "Alexander", "Peter", "Tyler", "Douglas", "Harold", "Aaron", "Jose", "Adam", "Arthur", "Zachary", "Carl", "Nathan", "Albert", "Kyle", "Lawrence", "Joe", "Willie", "Gerald", "Roger", "Keith", "Jeremy", "Terry", "Harry", "Ralph", "Sean", "Jesse", "Roy", "Louis", "Billy", "Austin", "Bruce", "Eugene", "Christian", "Bryan", "Wayne", "Russell", "Howard", "Fred", "Ethan", "Jordan", "Philip", "Alan", "Juan", "Randy", "Vincent", "Bobby", "Dylan", "Johnny", "Phillip", "Victor", "Clarence", "Ernest", "Martin", "Craig", "Stanley", "Shawn", "Travis", "Bradley", "Leonard", "Earl", "Gabriel", "Jimmy", "Francis", "Todd", "Noah", "Danny", "Dale", "Cody", "Carlos", "Allen", "Frederick", "Logan", "Curtis", "Alex", "Joel", "Luis", "Norman", "Marvin", "Glenn", "Tony", "Nathaniel", "Rodney", "Melvin", "Alfred", "Steve", "Cameron", "Chad", "Edwin", "Caleb", "Evan", "Antonio", "Lee", "Herbert", "Jeffery", "Isaac", "Derek", "Ricky", "Marcus", "Theodore", "Elijah", "Luke", "Jesus", "Eddie", "Troy", "Mike", "Dustin", "Ray", "Adrian", "Bernard", "Leroy", "Angel", "Randall", "Wesley", "Ian", "Jared", "Mason", "Hunter", "Calvin", "Oscar", "Clifford", "Jay", "Shane", "Ronnie", "Barry", "Lucas", "Corey", "Manuel", "Leo", "Tommy", "Warren", "Jackson", "Isaiah", "Connor", "Don", "Dean", "Jon", "Julian", "Miguel", "Bill", "Lloyd", "Charlie", "Mitchell", "Leon", "Jerome", "Darrell", "Jeremiah", "Alvin", "Brett", "Seth", "Floyd", "Jim", "Blake", "Micheal", "Gordon", "Trevor", "Lewis", "Erik", "Edgar", "Vernon", "Devin", "Gavin", "Jayden", "Chris", "Clyde", "Tom", "Derrick", "Mario", "Brent", "Marc", "Herman", "Chase", "Dominic", "Ricardo", "Franklin", "Maurice", "Max", "Aiden", "Owen", "Lester", "Gilbert", "Elmer", "Gene", "Francisco", "Glen", "Cory", "Garrett", "Clayton", "Sam", "Jorge", "Chester", "Alejandro", "Jeff", "Harvey", "Milton", "Cole", "Ivan", "Andre", "Duane", "Landon"],
        //        "female": ["Mary", "Emma", "Elizabeth", "Minnie", "Margaret", "Ida", "Alice", "Bertha", "Sarah", "Annie", "Clara", "Ella", "Florence", "Cora", "Martha", "Laura", "Nellie", "Grace", "Carrie", "Maude", "Mabel", "Bessie", "Jennie", "Gertrude", "Julia", "Hattie", "Edith", "Mattie", "Rose", "Catherine", "Lillian", "Ada", "Lillie", "Helen", "Jessie", "Louise", "Ethel", "Lula", "Myrtle", "Eva", "Frances", "Lena", "Lucy", "Edna", "Maggie", "Pearl", "Daisy", "Fannie", "Josephine", "Dora", "Rosa", "Katherine", "Agnes", "Marie", "Nora", "May", "Mamie", "Blanche", "Stella", "Ellen", "Nancy", "Effie", "Sallie", "Nettie", "Della", "Lizzie", "Flora", "Susie", "Maud", "Mae", "Etta", "Harriet", "Sadie", "Caroline", "Katie", "Lydia", "Elsie", "Kate", "Susan", "Mollie", "Alma", "Addie", "Georgia", "Eliza", "Lulu", "Nannie", "Lottie", "Amanda", "Belle", "Charlotte", "Rebecca", "Ruth", "Viola", "Olive", "Amelia", "Hannah", "Jane", "Virginia", "Emily", "Matilda", "Irene", "Kathryn", "Esther", "Willie", "Henrietta", "Ollie", "Amy", "Rachel", "Sara", "Estella", "Theresa", "Augusta", "Ora", "Pauline", "Josie", "Lola", "Sophia", "Leona", "Anne", "Mildred", "Ann", "Beulah", "Callie", "Lou", "Delia", "Eleanor", "Barbara", "Iva", "Louisa", "Maria", "Mayme", "Evelyn", "Estelle", "Nina", "Betty", "Marion", "Bettie", "Dorothy", "Luella", "Inez", "Lela", "Rosie", "Allie", "Millie", "Janie", "Cornelia", "Victoria", "Ruby", "Winifred", "Alta", "Celia", "Christine", "Beatrice", "Birdie", "Harriett", "Mable", "Myra", "Sophie", "Tillie", "Isabel", "Sylvia", "Carolyn", "Isabelle", "Leila", "Sally", "Ina", "Essie", "Bertie", "Nell", "Alberta", "Katharine", "Lora", "Rena", "Mina", "Rhoda", "Mathilda", "Abbie", "Eula", "Dollie", "Hettie", "Eunice", "Fanny", "Ola", "Lenora", "Adelaide", "Christina", "Lelia", "Nelle", "Sue", "Johanna", "Lilly", "Lucinda", "Minerva", "Lettie", "Roxie", "Cynthia", "Helena", "Hilda", "Hulda", "Bernice", "Genevieve", "Jean", "Cordelia", "Marian", "Francis", "Jeanette", "Adeline", "Gussie", "Leah", "Lois", "Lura", "Mittie", "Hallie", "Isabella", "Olga", "Phoebe", "Teresa", "Hester", "Lida", "Lina", "Winnie", "Claudia", "Marguerite", "Vera", "Cecelia", "Bess", "Emilie", "John", "Rosetta", "Verna", "Myrtie", "Cecilia", "Elva", "Olivia", "Ophelia", "Georgie", "Elnora", "Violet", "Adele", "Lily", "Linnie", "Loretta", "Madge", "Polly", "Virgie", "Eugenia", "Lucile", "Lucille", "Mabelle", "Rosalie"]
        //},


        public string[] LastNames = new string[]
        {
            "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor", "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson", "Clark", "Rodriguez", "Lewis", "Lee", "Walker", "Hall", "Allen", "Young", "Hernandez", "King", "Wright", "Lopez", "Hill", "Scott", "Green", "Adams", "Baker", "Gonzalez", "Nelson", "Carter", "Mitchell", "Perez", "Roberts", "Turner", "Phillips", "Campbell", "Parker", "Evans", "Edwards", "Collins", "Stewart", "Sanchez", "Morris", "Rogers", "Reed", "Cook", "Morgan", "Bell", "Murphy", "Bailey", "Rivera", "Cooper", "Richardson", "Cox", "Howard", "Ward", "Torres", "Peterson", "Gray", "Ramirez", "James", "Watson", "Brooks", "Kelly", "Sanders", "Price", "Bennett", "Wood", "Barnes", "Ross", "Henderson", "Coleman", "Jenkins", "Perry", "Powell", "Long", "Patterson", "Hughes", "Flores", "Washington", "Butler", "Simmons", "Foster", "Gonzales", "Bryant", "Alexander", "Russell", "Griffin", "Diaz", "Hayes", "Myers", "Ford", "Hamilton", "Graham", "Sullivan", "Wallace", "Woods", "Cole", "West", "Jordan", "Owens", "Reynolds", "Fisher", "Ellis", "Harrison", "Gibson", "McDonald", "Cruz", "Marshall", "Ortiz", "Gomez", "Murray", "Freeman", "Wells", "Webb", "Simpson", "Stevens", "Tucker", "Porter", "Hunter", "Hicks", "Crawford", "Henry", "Boyd", "Mason", "Morales", "Kennedy", "Warren", "Dixon", "Ramos", "Reyes", "Burns", "Gordon", "Shaw", "Holmes", "Rice", "Robertson", "Hunt", "Black", "Daniels", "Palmer", "Mills", "Nichols", "Grant", "Knight", "Ferguson", "Rose", "Stone", "Hawkins", "Dunn", "Perkins", "Hudson", "Spencer", "Gardner", "Stephens", "Payne", "Pierce", "Berry", "Matthews", "Arnold", "Wagner", "Willis", "Ray", "Watkins", "Olson", "Carroll", "Duncan", "Snyder", "Hart", "Cunningham", "Bradley", "Lane", "Andrews", "Ruiz", "Harper", "Fox", "Riley", "Armstrong", "Carpenter", "Weaver", "Greene", "Lawrence", "Elliott", "Chavez", "Sims", "Austin", "Peters", "Kelley", "Franklin", "Lawson", "Fields", "Gutierrez", "Ryan", "Schmidt", "Carr", "Vasquez", "Castillo", "Wheeler", "Chapman", "Oliver", "Montgomery", "Richards", "Williamson", "Johnston", "Banks", "Meyer", "Bishop", "McCoy", "Howell", "Alvarez", "Morrison", "Hansen", "Fernandez", "Garza", "Harvey", "Little", "Burton", "Stanley", "Nguyen", "George", "Jacobs", "Reid", "Kim", "Fuller", "Lynch", "Dean", "Gilbert", "Garrett", "Romero", "Welch", "Larson", "Frazier", "Burke", "Hanson", "Day", "Mendoza", "Moreno", "Bowman", "Medina", "Fowler", "Brewer", "Hoffman", "Carlson", "Silva", "Pearson", "Holland", "Douglas", "Fleming", "Jensen", "Vargas", "Byrd", "Davidson", "Hopkins", "May", "Terry", "Herrera", "Wade", "Soto", "Walters", "Curtis", "Neal", "Caldwell", "Lowe", "Jennings", "Barnett", "Graves", "Jimenez", "Horton", "Shelton", "Barrett", "Obrien", "Castro", "Sutton", "Gregory", "McKinney", "Lucas", "Miles", "Craig", "Rodriquez", "Chambers", "Holt", "Lambert", "Fletcher", "Watts", "Bates", "Hale", "Rhodes", "Pena", "Beck", "Newman", "Haynes", "McDaniel", "Mendez", "Bush", "Vaughn", "Parks", "Dawson", "Santiago", "Norris", "Hardy", "Love", "Steele", "Curry", "Powers", "Schultz", "Barker", "Guzman", "Page", "Munoz", "Ball", "Keller", "Chandler", "Weber", "Leonard", "Walsh", "Lyons", "Ramsey", "Wolfe", "Schneider", "Mullins", "Benson", "Sharp", "Bowen", "Daniel", "Barber", "Cummings", "Hines", "Baldwin", "Griffith", "Valdez", "Hubbard", "Salazar", "Reeves", "Warner", "Stevenson", "Burgess", "Santos", "Tate", "Cross", "Garner", "Mann", "Mack", "Moss", "Thornton", "Dennis", "McGee", "Farmer", "Delgado", "Aguilar", "Vega", "Glover", "Manning", "Cohen", "Harmon", "Rodgers", "Robbins", "Newton", "Todd", "Blair", "Higgins", "Ingram", "Reese", "Cannon", "Strickland", "Townsend", "Potter", "Goodwin", "Walton", "Rowe", "Hampton", "Ortega", "Patton", "Swanson", "Joseph", "Francis", "Goodman", "Maldonado", "Yates", "Becker", "Erickson", "Hodges", "Rios", "Conner", "Adkins", "Webster", "Norman", "Malone", "Hammond", "Flowers", "Cobb", "Moody", "Quinn", "Blake", "Maxwell", "Pope", "Floyd", "Osborne", "Paul", "McCarthy", "Guerrero", "Lindsey", "Estrada", "Sandoval", "Gibbs", "Tyler", "Gross", "Fitzgerald", "Stokes", "Doyle", "Sherman", "Saunders", "Wise", "Colon", "Gill", "Alvarado", "Greer", "Padilla", "Simon", "Waters", "Nunez", "Ballard", "Schwartz", "McBride", "Houston", "Christensen", "Klein", "Pratt", "Briggs", "Parsons", "McLaughlin", "Zimmerman", "French", "Buchanan", "Moran", "Copeland", "Roy", "Pittman", "Brady", "McCormick", "Holloway", "Brock", "Poole", "Frank", "Logan", "Owen", "Bass", "Marsh", "Drake", "Wong", "Jefferson", "Park", "Morton", "Abbott", "Sparks", "Patrick", "Norton", "Huff", "Clayton", "Massey", "Lloyd", "Figueroa", "Carson", "Bowers", "Roberson", "Barton", "Tran", "Lamb", "Harrington", "Casey", "Boone", "Cortez", "Clarke", "Mathis", "Singleton", "Wilkins", "Cain", "Bryan", "Underwood", "Hogan", "McKenzie", "Collier", "Luna", "Phelps", "McGuire", "Allison", "Bridges", "Wilkerson", "Nash", "Summers", "Atkins"
        };
        //lastNames: ['Smith', 'Johnson', 'Williams', 'Jones', 'Brown', 'Davis', 'Miller', 'Wilson', 'Moore', 'Taylor', 'Anderson', 'Thomas', 'Jackson', 'White', 'Harris', 'Martin', 'Thompson', 'Garcia', 'Martinez', 'Robinson', 'Clark', 'Rodriguez', 'Lewis', 'Lee', 'Walker', 'Hall', 'Allen', 'Young', 'Hernandez', 'King', 'Wright', 'Lopez', 'Hill', 'Scott', 'Green', 'Adams', 'Baker', 'Gonzalez', 'Nelson', 'Carter', 'Mitchell', 'Perez', 'Roberts', 'Turner', 'Phillips', 'Campbell', 'Parker', 'Evans', 'Edwards', 'Collins', 'Stewart', 'Sanchez', 'Morris', 'Rogers', 'Reed', 'Cook', 'Morgan', 'Bell', 'Murphy', 'Bailey', 'Rivera', 'Cooper', 'Richardson', 'Cox', 'Howard', 'Ward', 'Torres', 'Peterson', 'Gray', 'Ramirez', 'James', 'Watson', 'Brooks', 'Kelly', 'Sanders', 'Price', 'Bennett', 'Wood', 'Barnes', 'Ross', 'Henderson', 'Coleman', 'Jenkins', 'Perry', 'Powell', 'Long', 'Patterson', 'Hughes', 'Flores', 'Washington', 'Butler', 'Simmons', 'Foster', 'Gonzales', 'Bryant', 'Alexander', 'Russell', 'Griffin', 'Diaz', 'Hayes', 'Myers', 'Ford', 'Hamilton', 'Graham', 'Sullivan', 'Wallace', 'Woods', 'Cole', 'West', 'Jordan', 'Owens', 'Reynolds', 'Fisher', 'Ellis', 'Harrison', 'Gibson', 'McDonald', 'Cruz', 'Marshall', 'Ortiz', 'Gomez', 'Murray', 'Freeman', 'Wells', 'Webb', 'Simpson', 'Stevens', 'Tucker', 'Porter', 'Hunter', 'Hicks', 'Crawford', 'Henry', 'Boyd', 'Mason', 'Morales', 'Kennedy', 'Warren', 'Dixon', 'Ramos', 'Reyes', 'Burns', 'Gordon', 'Shaw', 'Holmes', 'Rice', 'Robertson', 'Hunt', 'Black', 'Daniels', 'Palmer', 'Mills', 'Nichols', 'Grant', 'Knight', 'Ferguson', 'Rose', 'Stone', 'Hawkins', 'Dunn', 'Perkins', 'Hudson', 'Spencer', 'Gardner', 'Stephens', 'Payne', 'Pierce', 'Berry', 'Matthews', 'Arnold', 'Wagner', 'Willis', 'Ray', 'Watkins', 'Olson', 'Carroll', 'Duncan', 'Snyder', 'Hart', 'Cunningham', 'Bradley', 'Lane', 'Andrews', 'Ruiz', 'Harper', 'Fox', 'Riley', 'Armstrong', 'Carpenter', 'Weaver', 'Greene', 'Lawrence', 'Elliott', 'Chavez', 'Sims', 'Austin', 'Peters', 'Kelley', 'Franklin', 'Lawson', 'Fields', 'Gutierrez', 'Ryan', 'Schmidt', 'Carr', 'Vasquez', 'Castillo', 'Wheeler', 'Chapman', 'Oliver', 'Montgomery', 'Richards', 'Williamson', 'Johnston', 'Banks', 'Meyer', 'Bishop', 'McCoy', 'Howell', 'Alvarez', 'Morrison', 'Hansen', 'Fernandez', 'Garza', 'Harvey', 'Little', 'Burton', 'Stanley', 'Nguyen', 'George', 'Jacobs', 'Reid', 'Kim', 'Fuller', 'Lynch', 'Dean', 'Gilbert', 'Garrett', 'Romero', 'Welch', 'Larson', 'Frazier', 'Burke', 'Hanson', 'Day', 'Mendoza', 'Moreno', 'Bowman', 'Medina', 'Fowler', 'Brewer', 'Hoffman', 'Carlson', 'Silva', 'Pearson', 'Holland', 'Douglas', 'Fleming', 'Jensen', 'Vargas', 'Byrd', 'Davidson', 'Hopkins', 'May', 'Terry', 'Herrera', 'Wade', 'Soto', 'Walters', 'Curtis', 'Neal', 'Caldwell', 'Lowe', 'Jennings', 'Barnett', 'Graves', 'Jimenez', 'Horton', 'Shelton', 'Barrett', 'Obrien', 'Castro', 'Sutton', 'Gregory', 'McKinney', 'Lucas', 'Miles', 'Craig', 'Rodriquez', 'Chambers', 'Holt', 'Lambert', 'Fletcher', 'Watts', 'Bates', 'Hale', 'Rhodes', 'Pena', 'Beck', 'Newman', 'Haynes', 'McDaniel', 'Mendez', 'Bush', 'Vaughn', 'Parks', 'Dawson', 'Santiago', 'Norris', 'Hardy', 'Love', 'Steele', 'Curry', 'Powers', 'Schultz', 'Barker', 'Guzman', 'Page', 'Munoz', 'Ball', 'Keller', 'Chandler', 'Weber', 'Leonard', 'Walsh', 'Lyons', 'Ramsey', 'Wolfe', 'Schneider', 'Mullins', 'Benson', 'Sharp', 'Bowen', 'Daniel', 'Barber', 'Cummings', 'Hines', 'Baldwin', 'Griffith', 'Valdez', 'Hubbard', 'Salazar', 'Reeves', 'Warner', 'Stevenson', 'Burgess', 'Santos', 'Tate', 'Cross', 'Garner', 'Mann', 'Mack', 'Moss', 'Thornton', 'Dennis', 'McGee', 'Farmer', 'Delgado', 'Aguilar', 'Vega', 'Glover', 'Manning', 'Cohen', 'Harmon', 'Rodgers', 'Robbins', 'Newton', 'Todd', 'Blair', 'Higgins', 'Ingram', 'Reese', 'Cannon', 'Strickland', 'Townsend', 'Potter', 'Goodwin', 'Walton', 'Rowe', 'Hampton', 'Ortega', 'Patton', 'Swanson', 'Joseph', 'Francis', 'Goodman', 'Maldonado', 'Yates', 'Becker', 'Erickson', 'Hodges', 'Rios', 'Conner', 'Adkins', 'Webster', 'Norman', 'Malone', 'Hammond', 'Flowers', 'Cobb', 'Moody', 'Quinn', 'Blake', 'Maxwell', 'Pope', 'Floyd', 'Osborne', 'Paul', 'McCarthy', 'Guerrero', 'Lindsey', 'Estrada', 'Sandoval', 'Gibbs', 'Tyler', 'Gross', 'Fitzgerald', 'Stokes', 'Doyle', 'Sherman', 'Saunders', 'Wise', 'Colon', 'Gill', 'Alvarado', 'Greer', 'Padilla', 'Simon', 'Waters', 'Nunez', 'Ballard', 'Schwartz', 'McBride', 'Houston', 'Christensen', 'Klein', 'Pratt', 'Briggs', 'Parsons', 'McLaughlin', 'Zimmerman', 'French', 'Buchanan', 'Moran', 'Copeland', 'Roy', 'Pittman', 'Brady', 'McCormick', 'Holloway', 'Brock', 'Poole', 'Frank', 'Logan', 'Owen', 'Bass', 'Marsh', 'Drake', 'Wong', 'Jefferson', 'Park', 'Morton', 'Abbott', 'Sparks', 'Patrick', 'Norton', 'Huff', 'Clayton', 'Massey', 'Lloyd', 'Figueroa', 'Carson', 'Bowers', 'Roberson', 'Barton', 'Tran', 'Lamb', 'Harrington', 'Casey', 'Boone', 'Cortez', 'Clarke', 'Mathis', 'Singleton', 'Wilkins', 'Cain', 'Bryan', 'Underwood', 'Hogan', 'McKenzie', 'Collier', 'Luna', 'Phelps', 'McGuire', 'Allison', 'Bridges', 'Wilkerson', 'Nash', 'Summers', 'Atkins'],



        public NameAbbreviation[] Countries = new NameAbbreviation[]
        {
            new NameAbbreviation{Name ="Afghanistan",Abbreviation ="AF"},new NameAbbreviation{Name ="Albania",Abbreviation ="AL"},new NameAbbreviation{Name ="Algeria",Abbreviation ="DZ"},new NameAbbreviation{Name ="American Samoa",Abbreviation ="AS"},new NameAbbreviation{Name ="Andorra",Abbreviation ="AD"},new NameAbbreviation{Name ="Angola",Abbreviation ="AO"},new NameAbbreviation{Name ="Anguilla",Abbreviation ="AI"},new NameAbbreviation{Name ="Antarctica",Abbreviation ="AQ"},new NameAbbreviation{Name ="Antigua and Barbuda",Abbreviation ="AG"},new NameAbbreviation{Name ="Argentina",Abbreviation ="AR"},new NameAbbreviation{Name ="Armenia",Abbreviation ="AM"},            new NameAbbreviation{Name ="Aruba",Abbreviation ="AW"},            new NameAbbreviation{Name ="Australia",Abbreviation ="AU"},            new NameAbbreviation{Name ="Austria",Abbreviation ="AT"},new NameAbbreviation{Name ="Azerbaijan",Abbreviation ="AZ"},new NameAbbreviation{Name ="Bahamas",Abbreviation ="BS"},new NameAbbreviation{Name ="Bahrain",Abbreviation ="BH"},new NameAbbreviation{Name ="Bangladesh",Abbreviation ="BD"},new NameAbbreviation{Name ="Barbados",Abbreviation ="BB"},new NameAbbreviation{Name ="Belarus",Abbreviation ="BY"},new NameAbbreviation{Name ="Belgium",Abbreviation ="BE"},new NameAbbreviation{Name ="Belize",Abbreviation ="BZ"},new NameAbbreviation{Name ="Benin",Abbreviation ="BJ"},new NameAbbreviation{Name ="Bermuda",Abbreviation ="BM"},new NameAbbreviation{Name ="Bhutan",Abbreviation ="BT"},new NameAbbreviation{Name ="Bolivia",Abbreviation ="BO"},new NameAbbreviation{Name ="Bosnia and Herzegovina",Abbreviation ="BA"},new NameAbbreviation{Name ="Botswana",Abbreviation ="BW"},new NameAbbreviation{Name ="Bouvet Island",Abbreviation ="BV"},new NameAbbreviation{Name ="Brazil",Abbreviation ="BR"},new NameAbbreviation{Name ="British Antarctic Territory",Abbreviation ="BQ"},new NameAbbreviation{Name ="British Indian Ocean Territory",Abbreviation ="IO"},new NameAbbreviation{Name ="British Virgin Islands",Abbreviation ="VG"},new NameAbbreviation{Name ="Brunei",Abbreviation ="BN"},new NameAbbreviation{Name ="Bulgaria",Abbreviation ="BG"},new NameAbbreviation{Name ="Burkina Faso",Abbreviation ="BF"},new NameAbbreviation{Name ="Burundi",Abbreviation ="BI"},new NameAbbreviation{Name ="Cambodia",Abbreviation ="KH"},new NameAbbreviation{Name ="Cameroon",Abbreviation ="CM"},new NameAbbreviation{Name ="Canada",Abbreviation ="CA"},new NameAbbreviation{Name ="Canton and Enderbury Islands",Abbreviation ="CT"},new NameAbbreviation{Name ="Cape Verde",Abbreviation ="CV"},new NameAbbreviation{Name ="Cayman Islands",Abbreviation ="KY"},new NameAbbreviation{Name ="Central African Republic",Abbreviation ="CF"},new NameAbbreviation{Name ="Chad",Abbreviation ="TD"},new NameAbbreviation{Name ="Chile",Abbreviation ="CL"},new NameAbbreviation{Name ="China",Abbreviation ="CN"},new NameAbbreviation{Name ="Christmas Island",Abbreviation ="CX"},new NameAbbreviation{Name ="Cocos [Keeling] Islands",Abbreviation ="CC"},new NameAbbreviation{Name ="Colombia",Abbreviation ="CO"},new NameAbbreviation{Name ="Comoros",Abbreviation ="KM"},new NameAbbreviation{Name ="Congo - Brazzaville",Abbreviation ="CG"},new NameAbbreviation{Name ="Congo - Kinshasa",Abbreviation ="CD"},new NameAbbreviation{Name ="Cook Islands",Abbreviation ="CK"},new NameAbbreviation{Name ="Costa Rica",Abbreviation ="CR"},new NameAbbreviation{Name ="Croatia",Abbreviation ="HR"},new NameAbbreviation{Name ="Cuba",Abbreviation ="CU"},new NameAbbreviation{Name ="Cyprus",Abbreviation ="CY"},new NameAbbreviation{Name ="Czech Republic",Abbreviation ="CZ"},new NameAbbreviation{Name ="Côte d’Ivoire",Abbreviation ="CI"},new NameAbbreviation{Name ="Denmark",Abbreviation ="DK"},new NameAbbreviation{Name ="Djibouti",Abbreviation ="DJ"},new NameAbbreviation{Name ="Dominica",Abbreviation ="DM"},new NameAbbreviation{Name ="Dominican Republic",Abbreviation ="DO"},new NameAbbreviation{Name ="Dronning Maud Land",Abbreviation ="NQ"},new NameAbbreviation{Name ="East Germany",Abbreviation ="DD"},new NameAbbreviation{Name ="Ecuador",Abbreviation ="EC"},new NameAbbreviation{Name ="Egypt",Abbreviation ="EG"},new NameAbbreviation{Name ="El Salvador",Abbreviation ="SV"},new NameAbbreviation{Name ="Equatorial Guinea",Abbreviation ="GQ"},new NameAbbreviation{Name ="Eritrea",Abbreviation ="ER"},new NameAbbreviation{Name ="Estonia",Abbreviation ="EE"},new NameAbbreviation{Name ="Ethiopia",Abbreviation ="ET"},new NameAbbreviation{Name ="Falkland Islands",Abbreviation ="FK"},new NameAbbreviation{Name ="Faroe Islands",Abbreviation ="FO"},new NameAbbreviation{Name ="Fiji",Abbreviation ="FJ"},new NameAbbreviation{Name ="Finland",Abbreviation ="FI"},new NameAbbreviation{Name ="France",Abbreviation ="FR"},new NameAbbreviation{Name ="French Guiana",Abbreviation ="GF"},new NameAbbreviation{Name ="French Polynesia",Abbreviation ="PF"},new NameAbbreviation{Name ="French Southern Territories",Abbreviation ="TF"},new NameAbbreviation{Name ="French Southern and Antarctic Territories",Abbreviation ="FQ"},new NameAbbreviation{Name ="Gabon",Abbreviation ="GA"},new NameAbbreviation{Name ="Gambia",Abbreviation ="GM"},new NameAbbreviation{Name ="Georgia",Abbreviation ="GE"},new NameAbbreviation{Name ="Germany",Abbreviation ="DE"},new NameAbbreviation{Name ="Ghana",Abbreviation ="GH"},new NameAbbreviation{Name ="Gibraltar",Abbreviation ="GI"},new NameAbbreviation{Name ="Greece",Abbreviation ="GR"},new NameAbbreviation{Name ="Greenland",Abbreviation ="GL"},new NameAbbreviation{Name ="Grenada",Abbreviation ="GD"},new NameAbbreviation{Name ="Guadeloupe",Abbreviation ="GP"},new NameAbbreviation{Name ="Guam",Abbreviation ="GU"},new NameAbbreviation{Name ="Guatemala",Abbreviation ="GT"},new NameAbbreviation{Name ="Guernsey",Abbreviation ="GG"},new NameAbbreviation{Name ="Guinea",Abbreviation ="GN"},new NameAbbreviation{Name ="Guinea-Bissau",Abbreviation ="GW"},new NameAbbreviation{Name ="Guyana",Abbreviation ="GY"},new NameAbbreviation{Name ="Haiti",Abbreviation ="HT"},new NameAbbreviation{Name ="Heard Island and McDonald Islands",Abbreviation ="HM"},new NameAbbreviation{Name ="Honduras",Abbreviation ="HN"},new NameAbbreviation{Name ="Hong Kong SAR China",Abbreviation ="HK"},new NameAbbreviation{Name ="Hungary",Abbreviation ="HU"},new NameAbbreviation{Name ="Iceland",Abbreviation ="IS"},new NameAbbreviation{Name ="India",Abbreviation ="IN"},new NameAbbreviation{Name ="Indonesia",Abbreviation ="ID"},new NameAbbreviation{Name ="Iran",Abbreviation ="IR"},new NameAbbreviation{Name ="Iraq",Abbreviation ="IQ"},new NameAbbreviation{Name ="Ireland",Abbreviation ="IE"},new NameAbbreviation{Name ="Isle of Man",Abbreviation ="IM"},new NameAbbreviation{Name ="Israel",Abbreviation ="IL"},new NameAbbreviation{Name ="Italy",Abbreviation ="IT"},new NameAbbreviation{Name ="Jamaica",Abbreviation ="JM"},new NameAbbreviation{Name ="Japan",Abbreviation ="JP"},new NameAbbreviation{Name ="Jersey",Abbreviation ="JE"},new NameAbbreviation{Name ="Johnston Island",Abbreviation ="JT"},new NameAbbreviation{Name ="Jordan",Abbreviation ="JO"},new NameAbbreviation{Name ="Kazakhstan",Abbreviation ="KZ"},new NameAbbreviation{Name ="Kenya",Abbreviation ="KE"},new NameAbbreviation{Name ="Kiribati",Abbreviation ="KI"},new NameAbbreviation{Name ="Kuwait",Abbreviation ="KW"},new NameAbbreviation{Name ="Kyrgyzstan",Abbreviation ="KG"},new NameAbbreviation{Name ="Laos",Abbreviation ="LA"},new NameAbbreviation{Name ="Latvia",Abbreviation ="LV"},new NameAbbreviation{Name ="Lebanon",Abbreviation ="LB"},new NameAbbreviation{Name ="Lesotho",Abbreviation ="LS"},new NameAbbreviation{Name ="Liberia",Abbreviation ="LR"},new NameAbbreviation{Name ="Libya",Abbreviation ="LY"},new NameAbbreviation{Name ="Liechtenstein",Abbreviation ="LI"},new NameAbbreviation{Name ="Lithuania",Abbreviation ="LT"},new NameAbbreviation{Name ="Luxembourg",Abbreviation ="LU"},new NameAbbreviation{Name ="Macau SAR China",Abbreviation ="MO"},new NameAbbreviation{Name ="Macedonia",Abbreviation ="MK"},new NameAbbreviation{Name ="Madagascar",Abbreviation ="MG"},new NameAbbreviation{Name ="Malawi",Abbreviation ="MW"},new NameAbbreviation{Name ="Malaysia",Abbreviation ="MY"},new NameAbbreviation{Name ="Maldives",Abbreviation ="MV"},new NameAbbreviation{Name ="Mali",Abbreviation ="ML"},new NameAbbreviation{Name ="Malta",Abbreviation ="MT"},new NameAbbreviation{Name ="Marshall Islands",Abbreviation ="MH"},new NameAbbreviation{Name ="Martinique",Abbreviation ="MQ"},new NameAbbreviation{Name ="Mauritania",Abbreviation ="MR"},new NameAbbreviation{Name ="Mauritius",Abbreviation ="MU"},new NameAbbreviation{Name ="Mayotte",Abbreviation ="YT"},new NameAbbreviation{Name ="Metropolitan France",Abbreviation ="FX"},new NameAbbreviation{Name ="Mexico",Abbreviation ="MX"},new NameAbbreviation{Name ="Micronesia",Abbreviation ="FM"},new NameAbbreviation{Name ="Midway Islands",Abbreviation ="MI"},new NameAbbreviation{Name ="Moldova",Abbreviation ="MD"},new NameAbbreviation{Name ="Monaco",Abbreviation ="MC"},new NameAbbreviation{Name ="Mongolia",Abbreviation ="MN"},new NameAbbreviation{Name ="Montenegro",Abbreviation ="ME"},new NameAbbreviation{Name ="Montserrat",Abbreviation ="MS"},new NameAbbreviation{Name ="Morocco",Abbreviation ="MA"},new NameAbbreviation{Name ="Mozambique",Abbreviation ="MZ"},new NameAbbreviation{Name ="Myanmar [Burma]",Abbreviation ="MM"},new NameAbbreviation{Name ="Namibia",Abbreviation ="NA"},new NameAbbreviation{Name ="Nauru",Abbreviation ="NR"},new NameAbbreviation{Name ="Nepal",Abbreviation ="NP"},new NameAbbreviation{Name ="Netherlands",Abbreviation ="NL"},new NameAbbreviation{Name ="Netherlands Antilles",Abbreviation ="AN"},new NameAbbreviation{Name ="Neutral Zone",Abbreviation ="NT"},new NameAbbreviation{Name ="New Caledonia",Abbreviation ="NC"},new NameAbbreviation{Name ="New Zealand",Abbreviation ="NZ"},new NameAbbreviation{Name ="Nicaragua",Abbreviation ="NI"},new NameAbbreviation{Name ="Niger",Abbreviation ="NE"},new NameAbbreviation{Name ="Nigeria",Abbreviation ="NG"},new NameAbbreviation{Name ="Niue",Abbreviation ="NU"},new NameAbbreviation{Name ="Norfolk Island",Abbreviation ="NF"},new NameAbbreviation{Name ="North Korea",Abbreviation ="KP"},new NameAbbreviation{Name ="North Vietnam",Abbreviation ="VD"},new NameAbbreviation{Name ="Northern Mariana Islands",Abbreviation ="MP"},new NameAbbreviation{Name ="Norway",Abbreviation ="NO"},new NameAbbreviation{Name ="Oman",Abbreviation ="OM"},new NameAbbreviation{Name ="Pacific Islands Trust Territory",Abbreviation ="PC"},new NameAbbreviation{Name ="Pakistan",Abbreviation ="PK"},new NameAbbreviation{Name ="Palau",Abbreviation ="PW"},new NameAbbreviation{Name ="Palestinian Territories",Abbreviation ="PS"},new NameAbbreviation{Name ="Panama",Abbreviation ="PA"},new NameAbbreviation{Name ="Panama Canal Zone",Abbreviation ="PZ"},new NameAbbreviation{Name ="Papua New Guinea",Abbreviation ="PG"},new NameAbbreviation{Name ="Paraguay",Abbreviation ="PY"},new NameAbbreviation{Name ="People's Democratic Republic of Yemen",Abbreviation ="YD"},new NameAbbreviation{Name ="Peru",Abbreviation ="PE"},new NameAbbreviation{Name ="Philippines",Abbreviation ="PH"},new NameAbbreviation{Name ="Pitcairn Islands",Abbreviation ="PN"},new NameAbbreviation{Name ="Poland",Abbreviation ="PL"},new NameAbbreviation{Name ="Portugal",Abbreviation ="PT"},new NameAbbreviation{Name ="Puerto Rico",Abbreviation ="PR"},new NameAbbreviation{Name ="Qatar",Abbreviation ="QA"},new NameAbbreviation{Name ="Romania",Abbreviation ="RO"},new NameAbbreviation{Name ="Russia",Abbreviation ="RU"},new NameAbbreviation{Name ="Rwanda",Abbreviation ="RW"},new NameAbbreviation{Name ="Réunion",Abbreviation ="RE"},new NameAbbreviation{Name ="Saint Barthélemy",Abbreviation ="BL"},new NameAbbreviation{Name ="Saint Helena",Abbreviation ="SH"},new NameAbbreviation{Name ="Saint Kitts and Nevis",Abbreviation ="KN"},new NameAbbreviation{Name ="Saint Lucia",Abbreviation ="LC"},new NameAbbreviation{Name ="Saint Martin",Abbreviation ="MF"},new NameAbbreviation{Name ="Saint Pierre and Miquelon",Abbreviation ="PM"},new NameAbbreviation{Name ="Saint Vincent and the Grenadines",Abbreviation ="VC"},new NameAbbreviation{Name ="Samoa",Abbreviation ="WS"},new NameAbbreviation{Name ="San Marino",Abbreviation ="SM"},new NameAbbreviation{Name ="Saudi Arabia",Abbreviation ="SA"},new NameAbbreviation{Name ="Senegal",Abbreviation ="SN"},new NameAbbreviation{Name ="Serbia",Abbreviation ="RS"},new NameAbbreviation{Name ="Serbia and Montenegro",Abbreviation ="CS"},new NameAbbreviation{Name ="Seychelles",Abbreviation ="SC"},new NameAbbreviation{Name ="Sierra Leone",Abbreviation ="SL"},new NameAbbreviation{Name ="Singapore",Abbreviation ="SG"},new NameAbbreviation{Name ="Slovakia",Abbreviation ="SK"},new NameAbbreviation{Name ="Slovenia",Abbreviation ="SI"},new NameAbbreviation{Name ="Solomon Islands",Abbreviation ="SB"},new NameAbbreviation{Name ="Somalia",Abbreviation ="SO"},new NameAbbreviation{Name ="South Africa",Abbreviation ="ZA"},new NameAbbreviation{Name ="South Georgia and the South Sandwich Islands",Abbreviation ="GS"},new NameAbbreviation{Name ="South Korea",Abbreviation ="KR"},new NameAbbreviation{Name ="Spain",Abbreviation ="ES"},new NameAbbreviation{Name ="Sri Lanka",Abbreviation ="LK"},new NameAbbreviation{Name ="Sudan",Abbreviation ="SD"},new NameAbbreviation{Name ="Suriname",Abbreviation ="SR"},new NameAbbreviation{Name ="Svalbard and Jan Mayen",Abbreviation ="SJ"},new NameAbbreviation{Name ="Swaziland",Abbreviation ="SZ"},new NameAbbreviation{Name ="Sweden",Abbreviation ="SE"},new NameAbbreviation{Name ="Switzerland",Abbreviation ="CH"},new NameAbbreviation{Name ="Syria",Abbreviation ="SY"},new NameAbbreviation{Name ="São Tomé and Príncipe",Abbreviation ="ST"},new NameAbbreviation{Name ="Taiwan",Abbreviation ="TW"},new NameAbbreviation{Name ="Tajikistan",Abbreviation ="TJ"},new NameAbbreviation{Name ="Tanzania",Abbreviation ="TZ"},new NameAbbreviation{Name ="Thailand",Abbreviation ="TH"},new NameAbbreviation{Name ="Timor-Leste",Abbreviation ="TL"},new NameAbbreviation{Name ="Togo",Abbreviation ="TG"},new NameAbbreviation{Name ="Tokelau",Abbreviation ="TK"},new NameAbbreviation{Name ="Tonga",Abbreviation ="TO"},new NameAbbreviation{Name ="Trinidad and Tobago",Abbreviation ="TT"},new NameAbbreviation{Name ="Tunisia",Abbreviation ="TN"},new NameAbbreviation{Name ="Turkey",Abbreviation ="TR"},new NameAbbreviation{Name ="Turkmenistan",Abbreviation ="TM"},new NameAbbreviation{Name ="Turks and Caicos Islands",Abbreviation ="TC"},new NameAbbreviation{Name ="Tuvalu",Abbreviation ="TV"},new NameAbbreviation{Name ="U.S. Minor Outlying Islands",Abbreviation ="UM"},new NameAbbreviation{Name ="U.S. Miscellaneous Pacific Islands",Abbreviation ="PU"},new NameAbbreviation{Name ="U.S. Virgin Islands",Abbreviation ="VI"},new NameAbbreviation{Name ="Uganda",Abbreviation ="UG"},new NameAbbreviation{Name ="Ukraine",Abbreviation ="UA"},new NameAbbreviation{Name ="Union of Soviet Socialist Republics",Abbreviation ="SU"},new NameAbbreviation{Name ="United Arab Emirates",Abbreviation ="AE"},new NameAbbreviation{Name ="United Kingdom",Abbreviation ="GB"},new NameAbbreviation{Name ="United States",Abbreviation ="US"},new NameAbbreviation{Name ="Unknown or Invalid Region",Abbreviation ="ZZ"},new NameAbbreviation{Name ="Uruguay",Abbreviation ="UY"},new NameAbbreviation{Name ="Uzbekistan",Abbreviation ="UZ"},new NameAbbreviation{Name ="Vanuatu",Abbreviation ="VU"},new NameAbbreviation{Name ="Vatican City",Abbreviation ="VA"},new NameAbbreviation{Name ="Venezuela",Abbreviation ="VE"},new NameAbbreviation{Name ="Vietnam",Abbreviation ="VN"},new NameAbbreviation{Name ="Wake Island",Abbreviation ="WK"},new NameAbbreviation{Name ="Wallis and Futuna",Abbreviation ="WF"},new NameAbbreviation{Name ="Western Sahara",Abbreviation ="EH"},new NameAbbreviation{Name ="Yemen",Abbreviation ="YE"},new NameAbbreviation{Name ="Zambia",Abbreviation ="ZM"},new NameAbbreviation{Name ="Zimbabwe",Abbreviation ="ZW"},new NameAbbreviation{Name ="Åland Islands",Abbreviation ="AX"}
        };

        //// Data taken from https://github.com/umpirsky/country-list/blob/master/country/cldr/en_US/country.json
        //countries: [{"name":"Afghanistan","abbreviation":"AF"},{"name":"Albania","abbreviation":"AL"},{"name":"Algeria","abbreviation":"DZ"},{"name":"American Samoa","abbreviation":"AS"},{"name":"Andorra","abbreviation":"AD"},{"name":"Angola","abbreviation":"AO"},{"name":"Anguilla","abbreviation":"AI"},{"name":"Antarctica","abbreviation":"AQ"},{"name":"Antigua and Barbuda","abbreviation":"AG"},{"name":"Argentina","abbreviation":"AR"},{"name":"Armenia","abbreviation":"AM"},{"name":"Aruba","abbreviation":"AW"},{"name":"Australia","abbreviation":"AU"},{"name":"Austria","abbreviation":"AT"},{"name":"Azerbaijan","abbreviation":"AZ"},{"name":"Bahamas","abbreviation":"BS"},{"name":"Bahrain","abbreviation":"BH"},{"name":"Bangladesh","abbreviation":"BD"},{"name":"Barbados","abbreviation":"BB"},{"name":"Belarus","abbreviation":"BY"},{"name":"Belgium","abbreviation":"BE"},{"name":"Belize","abbreviation":"BZ"},{"name":"Benin","abbreviation":"BJ"},{"name":"Bermuda","abbreviation":"BM"},{"name":"Bhutan","abbreviation":"BT"},{"name":"Bolivia","abbreviation":"BO"},{"name":"Bosnia and Herzegovina","abbreviation":"BA"},{"name":"Botswana","abbreviation":"BW"},{"name":"Bouvet Island","abbreviation":"BV"},{"name":"Brazil","abbreviation":"BR"},{"name":"British Antarctic Territory","abbreviation":"BQ"},{"name":"British Indian Ocean Territory","abbreviation":"IO"},{"name":"British Virgin Islands","abbreviation":"VG"},{"name":"Brunei","abbreviation":"BN"},{"name":"Bulgaria","abbreviation":"BG"},{"name":"Burkina Faso","abbreviation":"BF"},{"name":"Burundi","abbreviation":"BI"},{"name":"Cambodia","abbreviation":"KH"},{"name":"Cameroon","abbreviation":"CM"},{"name":"Canada","abbreviation":"CA"},{"name":"Canton and Enderbury Islands","abbreviation":"CT"},{"name":"Cape Verde","abbreviation":"CV"},{"name":"Cayman Islands","abbreviation":"KY"},{"name":"Central African Republic","abbreviation":"CF"},{"name":"Chad","abbreviation":"TD"},{"name":"Chile","abbreviation":"CL"},{"name":"China","abbreviation":"CN"},{"name":"Christmas Island","abbreviation":"CX"},{"name":"Cocos [Keeling] Islands","abbreviation":"CC"},{"name":"Colombia","abbreviation":"CO"},{"name":"Comoros","abbreviation":"KM"},{"name":"Congo - Brazzaville","abbreviation":"CG"},{"name":"Congo - Kinshasa","abbreviation":"CD"},{"name":"Cook Islands","abbreviation":"CK"},{"name":"Costa Rica","abbreviation":"CR"},{"name":"Croatia","abbreviation":"HR"},{"name":"Cuba","abbreviation":"CU"},{"name":"Cyprus","abbreviation":"CY"},{"name":"Czech Republic","abbreviation":"CZ"},{"name":"Côte d’Ivoire","abbreviation":"CI"},{"name":"Denmark","abbreviation":"DK"},{"name":"Djibouti","abbreviation":"DJ"},{"name":"Dominica","abbreviation":"DM"},{"name":"Dominican Republic","abbreviation":"DO"},{"name":"Dronning Maud Land","abbreviation":"NQ"},{"name":"East Germany","abbreviation":"DD"},{"name":"Ecuador","abbreviation":"EC"},{"name":"Egypt","abbreviation":"EG"},{"name":"El Salvador","abbreviation":"SV"},{"name":"Equatorial Guinea","abbreviation":"GQ"},{"name":"Eritrea","abbreviation":"ER"},{"name":"Estonia","abbreviation":"EE"},{"name":"Ethiopia","abbreviation":"ET"},{"name":"Falkland Islands","abbreviation":"FK"},{"name":"Faroe Islands","abbreviation":"FO"},{"name":"Fiji","abbreviation":"FJ"},{"name":"Finland","abbreviation":"FI"},{"name":"France","abbreviation":"FR"},{"name":"French Guiana","abbreviation":"GF"},{"name":"French Polynesia","abbreviation":"PF"},{"name":"French Southern Territories","abbreviation":"TF"},{"name":"French Southern and Antarctic Territories","abbreviation":"FQ"},{"name":"Gabon","abbreviation":"GA"},{"name":"Gambia","abbreviation":"GM"},{"name":"Georgia","abbreviation":"GE"},{"name":"Germany","abbreviation":"DE"},{"name":"Ghana","abbreviation":"GH"},{"name":"Gibraltar","abbreviation":"GI"},{"name":"Greece","abbreviation":"GR"},{"name":"Greenland","abbreviation":"GL"},{"name":"Grenada","abbreviation":"GD"},{"name":"Guadeloupe","abbreviation":"GP"},{"name":"Guam","abbreviation":"GU"},{"name":"Guatemala","abbreviation":"GT"},{"name":"Guernsey","abbreviation":"GG"},{"name":"Guinea","abbreviation":"GN"},{"name":"Guinea-Bissau","abbreviation":"GW"},{"name":"Guyana","abbreviation":"GY"},{"name":"Haiti","abbreviation":"HT"},{"name":"Heard Island and McDonald Islands","abbreviation":"HM"},{"name":"Honduras","abbreviation":"HN"},{"name":"Hong Kong SAR China","abbreviation":"HK"},{"name":"Hungary","abbreviation":"HU"},{"name":"Iceland","abbreviation":"IS"},{"name":"India","abbreviation":"IN"},{"name":"Indonesia","abbreviation":"ID"},{"name":"Iran","abbreviation":"IR"},{"name":"Iraq","abbreviation":"IQ"},{"name":"Ireland","abbreviation":"IE"},{"name":"Isle of Man","abbreviation":"IM"},{"name":"Israel","abbreviation":"IL"},{"name":"Italy","abbreviation":"IT"},{"name":"Jamaica","abbreviation":"JM"},{"name":"Japan","abbreviation":"JP"},{"name":"Jersey","abbreviation":"JE"},{"name":"Johnston Island","abbreviation":"JT"},{"name":"Jordan","abbreviation":"JO"},{"name":"Kazakhstan","abbreviation":"KZ"},{"name":"Kenya","abbreviation":"KE"},{"name":"Kiribati","abbreviation":"KI"},{"name":"Kuwait","abbreviation":"KW"},{"name":"Kyrgyzstan","abbreviation":"KG"},{"name":"Laos","abbreviation":"LA"},{"name":"Latvia","abbreviation":"LV"},{"name":"Lebanon","abbreviation":"LB"},{"name":"Lesotho","abbreviation":"LS"},{"name":"Liberia","abbreviation":"LR"},{"name":"Libya","abbreviation":"LY"},{"name":"Liechtenstein","abbreviation":"LI"},{"name":"Lithuania","abbreviation":"LT"},{"name":"Luxembourg","abbreviation":"LU"},{"name":"Macau SAR China","abbreviation":"MO"},{"name":"Macedonia","abbreviation":"MK"},{"name":"Madagascar","abbreviation":"MG"},{"name":"Malawi","abbreviation":"MW"},{"name":"Malaysia","abbreviation":"MY"},{"name":"Maldives","abbreviation":"MV"},{"name":"Mali","abbreviation":"ML"},{"name":"Malta","abbreviation":"MT"},{"name":"Marshall Islands","abbreviation":"MH"},{"name":"Martinique","abbreviation":"MQ"},{"name":"Mauritania","abbreviation":"MR"},{"name":"Mauritius","abbreviation":"MU"},{"name":"Mayotte","abbreviation":"YT"},{"name":"Metropolitan France","abbreviation":"FX"},{"name":"Mexico","abbreviation":"MX"},{"name":"Micronesia","abbreviation":"FM"},{"name":"Midway Islands","abbreviation":"MI"},{"name":"Moldova","abbreviation":"MD"},{"name":"Monaco","abbreviation":"MC"},{"name":"Mongolia","abbreviation":"MN"},{"name":"Montenegro","abbreviation":"ME"},{"name":"Montserrat","abbreviation":"MS"},{"name":"Morocco","abbreviation":"MA"},{"name":"Mozambique","abbreviation":"MZ"},{"name":"Myanmar [Burma]","abbreviation":"MM"},{"name":"Namibia","abbreviation":"NA"},{"name":"Nauru","abbreviation":"NR"},{"name":"Nepal","abbreviation":"NP"},{"name":"Netherlands","abbreviation":"NL"},{"name":"Netherlands Antilles","abbreviation":"AN"},{"name":"Neutral Zone","abbreviation":"NT"},{"name":"New Caledonia","abbreviation":"NC"},{"name":"New Zealand","abbreviation":"NZ"},{"name":"Nicaragua","abbreviation":"NI"},{"name":"Niger","abbreviation":"NE"},{"name":"Nigeria","abbreviation":"NG"},{"name":"Niue","abbreviation":"NU"},{"name":"Norfolk Island","abbreviation":"NF"},{"name":"North Korea","abbreviation":"KP"},{"name":"North Vietnam","abbreviation":"VD"},{"name":"Northern Mariana Islands","abbreviation":"MP"},{"name":"Norway","abbreviation":"NO"},{"name":"Oman","abbreviation":"OM"},{"name":"Pacific Islands Trust Territory","abbreviation":"PC"},{"name":"Pakistan","abbreviation":"PK"},{"name":"Palau","abbreviation":"PW"},{"name":"Palestinian Territories","abbreviation":"PS"},{"name":"Panama","abbreviation":"PA"},{"name":"Panama Canal Zone","abbreviation":"PZ"},{"name":"Papua New Guinea","abbreviation":"PG"},{"name":"Paraguay","abbreviation":"PY"},{"name":"People's Democratic Republic of Yemen","abbreviation":"YD"},{"name":"Peru","abbreviation":"PE"},{"name":"Philippines","abbreviation":"PH"},{"name":"Pitcairn Islands","abbreviation":"PN"},{"name":"Poland","abbreviation":"PL"},{"name":"Portugal","abbreviation":"PT"},{"name":"Puerto Rico","abbreviation":"PR"},{"name":"Qatar","abbreviation":"QA"},{"name":"Romania","abbreviation":"RO"},{"name":"Russia","abbreviation":"RU"},{"name":"Rwanda","abbreviation":"RW"},{"name":"Réunion","abbreviation":"RE"},{"name":"Saint Barthélemy","abbreviation":"BL"},{"name":"Saint Helena","abbreviation":"SH"},{"name":"Saint Kitts and Nevis","abbreviation":"KN"},{"name":"Saint Lucia","abbreviation":"LC"},{"name":"Saint Martin","abbreviation":"MF"},{"name":"Saint Pierre and Miquelon","abbreviation":"PM"},{"name":"Saint Vincent and the Grenadines","abbreviation":"VC"},{"name":"Samoa","abbreviation":"WS"},{"name":"San Marino","abbreviation":"SM"},{"name":"Saudi Arabia","abbreviation":"SA"},{"name":"Senegal","abbreviation":"SN"},{"name":"Serbia","abbreviation":"RS"},{"name":"Serbia and Montenegro","abbreviation":"CS"},{"name":"Seychelles","abbreviation":"SC"},{"name":"Sierra Leone","abbreviation":"SL"},{"name":"Singapore","abbreviation":"SG"},{"name":"Slovakia","abbreviation":"SK"},{"name":"Slovenia","abbreviation":"SI"},{"name":"Solomon Islands","abbreviation":"SB"},{"name":"Somalia","abbreviation":"SO"},{"name":"South Africa","abbreviation":"ZA"},{"name":"South Georgia and the South Sandwich Islands","abbreviation":"GS"},{"name":"South Korea","abbreviation":"KR"},{"name":"Spain","abbreviation":"ES"},{"name":"Sri Lanka","abbreviation":"LK"},{"name":"Sudan","abbreviation":"SD"},{"name":"Suriname","abbreviation":"SR"},{"name":"Svalbard and Jan Mayen","abbreviation":"SJ"},{"name":"Swaziland","abbreviation":"SZ"},{"name":"Sweden","abbreviation":"SE"},{"name":"Switzerland","abbreviation":"CH"},{"name":"Syria","abbreviation":"SY"},{"name":"São Tomé and Príncipe","abbreviation":"ST"},{"name":"Taiwan","abbreviation":"TW"},{"name":"Tajikistan","abbreviation":"TJ"},{"name":"Tanzania","abbreviation":"TZ"},{"name":"Thailand","abbreviation":"TH"},{"name":"Timor-Leste","abbreviation":"TL"},{"name":"Togo","abbreviation":"TG"},{"name":"Tokelau","abbreviation":"TK"},{"name":"Tonga","abbreviation":"TO"},{"name":"Trinidad and Tobago","abbreviation":"TT"},{"name":"Tunisia","abbreviation":"TN"},{"name":"Turkey","abbreviation":"TR"},{"name":"Turkmenistan","abbreviation":"TM"},{"name":"Turks and Caicos Islands","abbreviation":"TC"},{"name":"Tuvalu","abbreviation":"TV"},{"name":"U.S. Minor Outlying Islands","abbreviation":"UM"},{"name":"U.S. Miscellaneous Pacific Islands","abbreviation":"PU"},{"name":"U.S. Virgin Islands","abbreviation":"VI"},{"name":"Uganda","abbreviation":"UG"},{"name":"Ukraine","abbreviation":"UA"},{"name":"Union of Soviet Socialist Republics","abbreviation":"SU"},{"name":"United Arab Emirates","abbreviation":"AE"},{"name":"United Kingdom","abbreviation":"GB"},{"name":"United States","abbreviation":"US"},{"name":"Unknown or Invalid Region","abbreviation":"ZZ"},{"name":"Uruguay","abbreviation":"UY"},{"name":"Uzbekistan","abbreviation":"UZ"},{"name":"Vanuatu","abbreviation":"VU"},{"name":"Vatican City","abbreviation":"VA"},{"name":"Venezuela","abbreviation":"VE"},{"name":"Vietnam","abbreviation":"VN"},{"name":"Wake Island","abbreviation":"WK"},{"name":"Wallis and Futuna","abbreviation":"WF"},{"name":"Western Sahara","abbreviation":"EH"},{"name":"Yemen","abbreviation":"YE"},{"name":"Zambia","abbreviation":"ZM"},{"name":"Zimbabwe","abbreviation":"ZW"},{"name":"Åland Islands","abbreviation":"AX"}],

        public NameAbbreviation[] Provinces = new NameAbbreviation[]
      {
          new NameAbbreviation {Name= "Alberta", Abbreviation= "AB"},
          new NameAbbreviation {Name= "British Columbia", Abbreviation= "BC"},
          new NameAbbreviation {Name= "Manitoba", Abbreviation= "MB"},
          new NameAbbreviation {Name= "New Brunswick", Abbreviation= "NB"},
          new NameAbbreviation {Name= "Newfoundland and Labrador", Abbreviation= "NL"},
          new NameAbbreviation {Name= "Nova Scotia", Abbreviation= "NS"},
          new NameAbbreviation {Name= "Ontario", Abbreviation= "ON"},
          new NameAbbreviation {Name= "Prince Edward Island", Abbreviation= "PE"},
          new NameAbbreviation {Name= "Quebec", Abbreviation= "QC"},
          new NameAbbreviation {Name= "Saskatchewan", Abbreviation= "SK"},
          new NameAbbreviation {Name= "Northwest Territories", Abbreviation= "NT"},
          new NameAbbreviation {Name= "Nunavut", Abbreviation= "NU"},
          new NameAbbreviation {Name= "Yukon", Abbreviation= "YT"}
      };


        public NameAbbreviation[] us_states_and_dc = new NameAbbreviation[]
{

    new NameAbbreviation {Name= "Alabama", Abbreviation= "AL"},
    new NameAbbreviation {Name= "Alaska", Abbreviation= "AK"},
    new NameAbbreviation {Name= "Arizona", Abbreviation= "AZ"},
    new NameAbbreviation {Name= "Arkansas", Abbreviation= "AR"},
    new NameAbbreviation {Name= "California", Abbreviation= "CA"},
    new NameAbbreviation {Name= "Colorado", Abbreviation= "CO"},
    new NameAbbreviation {Name= "Connecticut", Abbreviation= "CT"},
    new NameAbbreviation {Name= "Delaware", Abbreviation= "DE"},
    new NameAbbreviation {Name= "District of Columbia", Abbreviation= "DC"},
    new NameAbbreviation {Name= "Florida", Abbreviation= "FL"},
    new NameAbbreviation {Name= "Georgia", Abbreviation= "GA"},
    new NameAbbreviation {Name= "Hawaii", Abbreviation= "HI"},
    new NameAbbreviation {Name= "Idaho", Abbreviation= "ID"},
    new NameAbbreviation {Name= "Illinois", Abbreviation= "IL"},
    new NameAbbreviation {Name= "Indiana", Abbreviation= "IN"},
    new NameAbbreviation {Name= "Iowa", Abbreviation= "IA"},
    new NameAbbreviation {Name= "Kansas", Abbreviation= "KS"},
    new NameAbbreviation {Name= "Kentucky", Abbreviation= "KY"},
    new NameAbbreviation {Name= "Louisiana", Abbreviation= "LA"},
    new NameAbbreviation {Name= "Maine", Abbreviation= "ME"},
    new NameAbbreviation {Name= "Maryland", Abbreviation= "MD"},
    new NameAbbreviation {Name= "Massachusetts", Abbreviation= "MA"},
    new NameAbbreviation {Name= "Michigan", Abbreviation= "MI"},
    new NameAbbreviation {Name= "Minnesota", Abbreviation= "MN"},
    new NameAbbreviation {Name= "Mississippi", Abbreviation= "MS"},
    new NameAbbreviation {Name= "Missouri", Abbreviation= "MO"},
    new NameAbbreviation {Name= "Montana", Abbreviation= "MT"},
    new NameAbbreviation {Name= "Nebraska", Abbreviation= "NE"},
    new NameAbbreviation {Name= "Nevada", Abbreviation= "NV"},
    new NameAbbreviation {Name= "New Hampshire", Abbreviation= "NH"},
    new NameAbbreviation {Name= "New Jersey", Abbreviation= "NJ"},
    new NameAbbreviation {Name= "New Mexico", Abbreviation= "NM"},
    new NameAbbreviation {Name= "New York", Abbreviation= "NY"},
    new NameAbbreviation {Name= "North Carolina", Abbreviation= "NC"},
    new NameAbbreviation {Name= "North Dakota", Abbreviation= "ND"},
    new NameAbbreviation {Name= "Ohio", Abbreviation= "OH"},
    new NameAbbreviation {Name= "Oklahoma", Abbreviation= "OK"},
    new NameAbbreviation {Name= "Oregon", Abbreviation= "OR"},
    new NameAbbreviation {Name= "Pennsylvania", Abbreviation= "PA"},
    new NameAbbreviation {Name= "Rhode Island", Abbreviation= "RI"},
    new NameAbbreviation {Name= "South Carolina", Abbreviation= "SC"},
    new NameAbbreviation {Name= "South Dakota", Abbreviation= "SD"},
    new NameAbbreviation {Name= "Tennessee", Abbreviation= "TN"},
    new NameAbbreviation {Name= "Texas", Abbreviation= "TX"},
    new NameAbbreviation {Name= "Utah", Abbreviation= "UT"},
    new NameAbbreviation {Name= "Vermont", Abbreviation= "VT"},
    new NameAbbreviation {Name= "Virginia", Abbreviation= "VA"},
    new NameAbbreviation {Name= "Washington", Abbreviation= "WA"},
    new NameAbbreviation {Name= "West Virginia", Abbreviation= "WV"},
    new NameAbbreviation {Name= "Wisconsin", Abbreviation= "WI"},
    new NameAbbreviation {Name= "Wyoming", Abbreviation= "WY"}

};

        //territories: [
        //    {name: 'American Samoa', abbreviation: 'AS'},
        //    {name: 'Federated States of Micronesia', abbreviation: 'FM'},
        //    {name: 'Guam', abbreviation: 'GU'},
        //    {name: 'Marshall Islands', abbreviation: 'MH'},
        //    {name: 'Northern Mariana Islands', abbreviation: 'MP'},
        //    {name: 'Puerto Rico', abbreviation: 'PR'},
        //    {name: 'Virgin Islands, U.S.', abbreviation: 'VI'}
        //],

        //armed_forces: [
        //    {name: 'Armed Forces Europe', abbreviation: 'AE'},
        //    {name: 'Armed Forces Pacific', abbreviation: 'AP'},
        //    {name: 'Armed Forces the Americas', abbreviation: 'AA'}
        //],

        public NameAbbreviation[] street_suffixes = new NameAbbreviation[]
{
    new NameAbbreviation {Name= "Avenue", Abbreviation= "Ave"},
    new NameAbbreviation {Name= "Boulevard", Abbreviation= "Blvd"},
    new NameAbbreviation {Name= "Center", Abbreviation= "Ctr"},
    new NameAbbreviation {Name= "Circle", Abbreviation= "Cir"},
    new NameAbbreviation {Name= "Court", Abbreviation= "Ct"},
    new NameAbbreviation {Name= "Drive", Abbreviation= "Dr"},
    new NameAbbreviation {Name= "Extension", Abbreviation= "Ext"},
    new NameAbbreviation {Name= "Glen", Abbreviation= "Gln"},
    new NameAbbreviation {Name= "Grove", Abbreviation= "Grv"},
    new NameAbbreviation {Name= "Heights", Abbreviation= "Hts"},
    new NameAbbreviation {Name= "Highway", Abbreviation= "Hwy"},
    new NameAbbreviation {Name= "Junction", Abbreviation= "Jct"},
    new NameAbbreviation {Name= "Key", Abbreviation= "Key"},
    new NameAbbreviation {Name= "Lane", Abbreviation= "Ln"},
    new NameAbbreviation {Name= "Loop", Abbreviation= "Loop"},
    new NameAbbreviation {Name= "Manor", Abbreviation= "Mnr"},
    new NameAbbreviation {Name= "Mill", Abbreviation= "Mill"},
    new NameAbbreviation {Name= "Park", Abbreviation= "Park"},
    new NameAbbreviation {Name= "Parkway", Abbreviation= "Pkwy"},
    new NameAbbreviation {Name= "Pass", Abbreviation= "Pass"},
    new NameAbbreviation {Name= "Path", Abbreviation= "Path"},
    new NameAbbreviation {Name= "Pike", Abbreviation= "Pike"},
    new NameAbbreviation {Name= "Place", Abbreviation= "Pl"},
    new NameAbbreviation {Name= "Plaza", Abbreviation= "Plz"},
    new NameAbbreviation {Name= "Point", Abbreviation= "Pt"},
    new NameAbbreviation {Name= "Ridge", Abbreviation= "Rdg"},
    new NameAbbreviation {Name= "River", Abbreviation= "Riv"},
    new NameAbbreviation {Name= "Road", Abbreviation= "Rd"},
    new NameAbbreviation {Name= "Square", Abbreviation= "Sq"},
    new NameAbbreviation {Name= "Street", Abbreviation= "St"},
    new NameAbbreviation {Name= "Terrace", Abbreviation= "Ter"},
    new NameAbbreviation {Name= "Trail", Abbreviation= "Trl"},
    new NameAbbreviation {Name= "Turnpike", Abbreviation= "Tpke"},
    new NameAbbreviation {Name= "View", Abbreviation= "Vw"},
    new NameAbbreviation {Name= "Way", Abbreviation= "Way"}
};


        public MonthInfo[] months = new MonthInfo[]
        {
          
            new MonthInfo {name= "January", short_name= "Jan", numeric= 1, days= 31},
            new MonthInfo {name= "February", short_name= "Feb", numeric= 2, days= 28},
            new MonthInfo {name= "March", short_name= "Mar", numeric= 3, days= 31},
            new MonthInfo {name= "April", short_name= "Apr", numeric= 4, days= 30},
            new MonthInfo {name= "May", short_name= "May", numeric= 5, days= 31},
            new MonthInfo {name= "June", short_name= "Jun", numeric= 6, days= 30},
            new MonthInfo {name= "July", short_name= "Jul", numeric= 7, days= 31},
            new MonthInfo {name= "August", short_name= "Aug", numeric= 8, days= 31},
            new MonthInfo {name= "September", short_name= "Sep", numeric= 9, days= 30},
            new MonthInfo {name= "October", short_name= "Oct", numeric= 10, days= 31},
            new MonthInfo {name= "November", short_name= "Nov", numeric= 11, days= 30},
            new MonthInfo {name= "December", short_name= "Dec", numeric= 12, days= 31}
          
        };

        //months: [
        //    {name: 'January', short_name: 'Jan', numeric: '01', days: 31},
        //    // Not messing with leap years...
        //    {name: 'February', short_name: 'Feb', numeric: '02', days: 28},
        //    {name: 'March', short_name: 'Mar', numeric: '03', days: 31},
        //    {name: 'April', short_name: 'Apr', numeric: '04', days: 30},
        //    {name: 'May', short_name: 'May', numeric: '05', days: 31},
        //    {name: 'June', short_name: 'Jun', numeric: '06', days: 30},
        //    {name: 'July', short_name: 'Jul', numeric: '07', days: 31},
        //    {name: 'August', short_name: 'Aug', numeric: '08', days: 31},
        //    {name: 'September', short_name: 'Sep', numeric: '09', days: 30},
        //    {name: 'October', short_name: 'Oct', numeric: '10', days: 31},
        //    {name: 'November', short_name: 'Nov', numeric: '11', days: 30},
        //    {name: 'December', short_name: 'Dec', numeric: '12', days: 31}
        //],

        public CCInfo[] cc_types = new CCInfo[]
        {
            new CCInfo {name= "American Express", short_name= "amex", prefix= "34", length= 15},
            new CCInfo {name= "Bankcard", short_name= "bankcard", prefix= "5610", length= 16},
            new CCInfo {name= "China UnionPay", short_name= "chinaunion", prefix= "62", length= 16},
            new CCInfo {name= "Diners Club Carte Blanche", short_name= "dccarte", prefix= "300", length= 14},
            new CCInfo {name= "Diners Club enRoute", short_name= "dcenroute", prefix= "2014", length= 15},
            new CCInfo {name= "Diners Club International", short_name= "dcintl", prefix= "36", length= 14},
            new CCInfo {name= "Diners Club United States & Canada", short_name= "dcusc", prefix= "54", length= 16},
            new CCInfo {name= "Discover Card", short_name= "discover", prefix= "6011", length= 16},
            new CCInfo {name= "InstaPayment", short_name= "instapay", prefix= "637", length= 16},
            new CCInfo {name= "JCB", short_name= "jcb", prefix= "3528", length= 16},
            new CCInfo {name= "Laser", short_name= "laser", prefix= "6304", length= 16},
            new CCInfo {name= "Maestro", short_name= "maestro", prefix= "5018", length= 16},
            new CCInfo {name= "Mastercard", short_name= "mc", prefix= "51", length= 16},
            new CCInfo {name= "Solo", short_name= "solo", prefix= "6334", length= 16},
            new CCInfo {name= "Switch", short_name= "switch", prefix= "4903", length= 16},
            new CCInfo {name= "Visa", short_name= "visa", prefix= "4", length= 16},
            new CCInfo {name= "Visa Electron", short_name= "electron", prefix= "4026", length= 16}
        };

            ////return all world currency by ISO 4217
            //currency_types: [
            //    {'code' : 'AED', 'name' : 'United Arab Emirates Dirham'},
            //    {'code' : 'AFN', 'name' : 'Afghanistan Afghani'},
            //    {'code' : 'ALL', 'name' : 'Albania Lek'},
            //    {'code' : 'AMD', 'name' : 'Armenia Dram'},
            //    {'code' : 'ANG', 'name' : 'Netherlands Antilles Guilder'},
            //    {'code' : 'AOA', 'name' : 'Angola Kwanza'},
            //    {'code' : 'ARS', 'name' : 'Argentina Peso'},
            //    {'code' : 'AUD', 'name' : 'Australia Dollar'},
            //    {'code' : 'AWG', 'name' : 'Aruba Guilder'},
            //    {'code' : 'AZN', 'name' : 'Azerbaijan New Manat'},
            //    {'code' : 'BAM', 'name' : 'Bosnia and Herzegovina Convertible Marka'},
            //    {'code' : 'BBD', 'name' : 'Barbados Dollar'},
            //    {'code' : 'BDT', 'name' : 'Bangladesh Taka'},
            //    {'code' : 'BGN', 'name' : 'Bulgaria Lev'},
            //    {'code' : 'BHD', 'name' : 'Bahrain Dinar'},
            //    {'code' : 'BIF', 'name' : 'Burundi Franc'},
            //    {'code' : 'BMD', 'name' : 'Bermuda Dollar'},
            //    {'code' : 'BND', 'name' : 'Brunei Darussalam Dollar'},
            //    {'code' : 'BOB', 'name' : 'Bolivia Boliviano'},
            //    {'code' : 'BRL', 'name' : 'Brazil Real'},
            //    {'code' : 'BSD', 'name' : 'Bahamas Dollar'},
            //    {'code' : 'BTN', 'name' : 'Bhutan Ngultrum'},
            //    {'code' : 'BWP', 'name' : 'Botswana Pula'},
            //    {'code' : 'BYR', 'name' : 'Belarus Ruble'},
            //    {'code' : 'BZD', 'name' : 'Belize Dollar'},
            //    {'code' : 'CAD', 'name' : 'Canada Dollar'},
            //    {'code' : 'CDF', 'name' : 'Congo/Kinshasa Franc'},
            //    {'code' : 'CHF', 'name' : 'Switzerland Franc'},
            //    {'code' : 'CLP', 'name' : 'Chile Peso'},
            //    {'code' : 'CNY', 'name' : 'China Yuan Renminbi'},
            //    {'code' : 'COP', 'name' : 'Colombia Peso'},
            //    {'code' : 'CRC', 'name' : 'Costa Rica Colon'},
            //    {'code' : 'CUC', 'name' : 'Cuba Convertible Peso'},
            //    {'code' : 'CUP', 'name' : 'Cuba Peso'},
            //    {'code' : 'CVE', 'name' : 'Cape Verde Escudo'},
            //    {'code' : 'CZK', 'name' : 'Czech Republic Koruna'},
            //    {'code' : 'DJF', 'name' : 'Djibouti Franc'},
            //    {'code' : 'DKK', 'name' : 'Denmark Krone'},
            //    {'code' : 'DOP', 'name' : 'Dominican Republic Peso'},
            //    {'code' : 'DZD', 'name' : 'Algeria Dinar'},
            //    {'code' : 'EGP', 'name' : 'Egypt Pound'},
            //    {'code' : 'ERN', 'name' : 'Eritrea Nakfa'},
            //    {'code' : 'ETB', 'name' : 'Ethiopia Birr'},
            //    {'code' : 'EUR', 'name' : 'Euro Member Countries'},
            //    {'code' : 'FJD', 'name' : 'Fiji Dollar'},
            //    {'code' : 'FKP', 'name' : 'Falkland Islands (Malvinas) Pound'},
            //    {'code' : 'GBP', 'name' : 'United Kingdom Pound'},
            //    {'code' : 'GEL', 'name' : 'Georgia Lari'},
            //    {'code' : 'GGP', 'name' : 'Guernsey Pound'},
            //    {'code' : 'GHS', 'name' : 'Ghana Cedi'},
            //    {'code' : 'GIP', 'name' : 'Gibraltar Pound'},
            //    {'code' : 'GMD', 'name' : 'Gambia Dalasi'},
            //    {'code' : 'GNF', 'name' : 'Guinea Franc'},
            //    {'code' : 'GTQ', 'name' : 'Guatemala Quetzal'},
            //    {'code' : 'GYD', 'name' : 'Guyana Dollar'},
            //    {'code' : 'HKD', 'name' : 'Hong Kong Dollar'},
            //    {'code' : 'HNL', 'name' : 'Honduras Lempira'},
            //    {'code' : 'HRK', 'name' : 'Croatia Kuna'},
            //    {'code' : 'HTG', 'name' : 'Haiti Gourde'},
            //    {'code' : 'HUF', 'name' : 'Hungary Forint'},
            //    {'code' : 'IDR', 'name' : 'Indonesia Rupiah'},
            //    {'code' : 'ILS', 'name' : 'Israel Shekel'},
            //    {'code' : 'IMP', 'name' : 'Isle of Man Pound'},
            //    {'code' : 'INR', 'name' : 'India Rupee'},
            //    {'code' : 'IQD', 'name' : 'Iraq Dinar'},
            //    {'code' : 'IRR', 'name' : 'Iran Rial'},
            //    {'code' : 'ISK', 'name' : 'Iceland Krona'},
            //    {'code' : 'JEP', 'name' : 'Jersey Pound'},
            //    {'code' : 'JMD', 'name' : 'Jamaica Dollar'},
            //    {'code' : 'JOD', 'name' : 'Jordan Dinar'},
            //    {'code' : 'JPY', 'name' : 'Japan Yen'},
            //    {'code' : 'KES', 'name' : 'Kenya Shilling'},
            //    {'code' : 'KGS', 'name' : 'Kyrgyzstan Som'},
            //    {'code' : 'KHR', 'name' : 'Cambodia Riel'},
            //    {'code' : 'KMF', 'name' : 'Comoros Franc'},
            //    {'code' : 'KPW', 'name' : 'Korea (North) Won'},
            //    {'code' : 'KRW', 'name' : 'Korea (South) Won'},
            //    {'code' : 'KWD', 'name' : 'Kuwait Dinar'},
            //    {'code' : 'KYD', 'name' : 'Cayman Islands Dollar'},
            //    {'code' : 'KZT', 'name' : 'Kazakhstan Tenge'},
            //    {'code' : 'LAK', 'name' : 'Laos Kip'},
            //    {'code' : 'LBP', 'name' : 'Lebanon Pound'},
            //    {'code' : 'LKR', 'name' : 'Sri Lanka Rupee'},
            //    {'code' : 'LRD', 'name' : 'Liberia Dollar'},
            //    {'code' : 'LSL', 'name' : 'Lesotho Loti'},
            //    {'code' : 'LTL', 'name' : 'Lithuania Litas'},
            //    {'code' : 'LYD', 'name' : 'Libya Dinar'},
            //    {'code' : 'MAD', 'name' : 'Morocco Dirham'},
            //    {'code' : 'MDL', 'name' : 'Moldova Leu'},
            //    {'code' : 'MGA', 'name' : 'Madagascar Ariary'},
            //    {'code' : 'MKD', 'name' : 'Macedonia Denar'},
            //    {'code' : 'MMK', 'name' : 'Myanmar (Burma) Kyat'},
            //    {'code' : 'MNT', 'name' : 'Mongolia Tughrik'},
            //    {'code' : 'MOP', 'name' : 'Macau Pataca'},
            //    {'code' : 'MRO', 'name' : 'Mauritania Ouguiya'},
            //    {'code' : 'MUR', 'name' : 'Mauritius Rupee'},
            //    {'code' : 'MVR', 'name' : 'Maldives (Maldive Islands) Rufiyaa'},
            //    {'code' : 'MWK', 'name' : 'Malawi Kwacha'},
            //    {'code' : 'MXN', 'name' : 'Mexico Peso'},
            //    {'code' : 'MYR', 'name' : 'Malaysia Ringgit'},
            //    {'code' : 'MZN', 'name' : 'Mozambique Metical'},
            //    {'code' : 'NAD', 'name' : 'Namibia Dollar'},
            //    {'code' : 'NGN', 'name' : 'Nigeria Naira'},
            //    {'code' : 'NIO', 'name' : 'Nicaragua Cordoba'},
            //    {'code' : 'NOK', 'name' : 'Norway Krone'},
            //    {'code' : 'NPR', 'name' : 'Nepal Rupee'},
            //    {'code' : 'NZD', 'name' : 'New Zealand Dollar'},
            //    {'code' : 'OMR', 'name' : 'Oman Rial'},
            //    {'code' : 'PAB', 'name' : 'Panama Balboa'},
            //    {'code' : 'PEN', 'name' : 'Peru Nuevo Sol'},
            //    {'code' : 'PGK', 'name' : 'Papua New Guinea Kina'},
            //    {'code' : 'PHP', 'name' : 'Philippines Peso'},
            //    {'code' : 'PKR', 'name' : 'Pakistan Rupee'},
            //    {'code' : 'PLN', 'name' : 'Poland Zloty'},
            //    {'code' : 'PYG', 'name' : 'Paraguay Guarani'},
            //    {'code' : 'QAR', 'name' : 'Qatar Riyal'},
            //    {'code' : 'RON', 'name' : 'Romania New Leu'},
            //    {'code' : 'RSD', 'name' : 'Serbia Dinar'},
            //    {'code' : 'RUB', 'name' : 'Russia Ruble'},
            //    {'code' : 'RWF', 'name' : 'Rwanda Franc'},
            //    {'code' : 'SAR', 'name' : 'Saudi Arabia Riyal'},
            //    {'code' : 'SBD', 'name' : 'Solomon Islands Dollar'},
            //    {'code' : 'SCR', 'name' : 'Seychelles Rupee'},
            //    {'code' : 'SDG', 'name' : 'Sudan Pound'},
            //    {'code' : 'SEK', 'name' : 'Sweden Krona'},
            //    {'code' : 'SGD', 'name' : 'Singapore Dollar'},
            //    {'code' : 'SHP', 'name' : 'Saint Helena Pound'},
            //    {'code' : 'SLL', 'name' : 'Sierra Leone Leone'},
            //    {'code' : 'SOS', 'name' : 'Somalia Shilling'},
            //    {'code' : 'SPL', 'name' : 'Seborga Luigino'},
            //    {'code' : 'SRD', 'name' : 'Suriname Dollar'},
            //    {'code' : 'STD', 'name' : 'São Tomé and Príncipe Dobra'},
            //    {'code' : 'SVC', 'name' : 'El Salvador Colon'},
            //    {'code' : 'SYP', 'name' : 'Syria Pound'},
            //    {'code' : 'SZL', 'name' : 'Swaziland Lilangeni'},
            //    {'code' : 'THB', 'name' : 'Thailand Baht'},
            //    {'code' : 'TJS', 'name' : 'Tajikistan Somoni'},
            //    {'code' : 'TMT', 'name' : 'Turkmenistan Manat'},
            //    {'code' : 'TND', 'name' : 'Tunisia Dinar'},
            //    {'code' : 'TOP', 'name' : 'Tonga Pa\'anga'},
            //    {'code' : 'TRY', 'name' : 'Turkey Lira'},
            //    {'code' : 'TTD', 'name' : 'Trinidad and Tobago Dollar'},
            //    {'code' : 'TVD', 'name' : 'Tuvalu Dollar'},
            //    {'code' : 'TWD', 'name' : 'Taiwan New Dollar'},
            //    {'code' : 'TZS', 'name' : 'Tanzania Shilling'},
            //    {'code' : 'UAH', 'name' : 'Ukraine Hryvnia'},
            //    {'code' : 'UGX', 'name' : 'Uganda Shilling'},
            //    {'code' : 'USD', 'name' : 'United States Dollar'},
            //    {'code' : 'UYU', 'name' : 'Uruguay Peso'},
            //    {'code' : 'UZS', 'name' : 'Uzbekistan Som'},
            //    {'code' : 'VEF', 'name' : 'Venezuela Bolivar'},
            //    {'code' : 'VND', 'name' : 'Viet Nam Dong'},
            //    {'code' : 'VUV', 'name' : 'Vanuatu Vatu'},
            //    {'code' : 'WST', 'name' : 'Samoa Tala'},
            //    {'code' : 'XAF', 'name' : 'Communauté Financière Africaine (BEAC) CFA Franc BEAC'},
            //    {'code' : 'XCD', 'name' : 'East Caribbean Dollar'},
            //    {'code' : 'XDR', 'name' : 'International Monetary Fund (IMF) Special Drawing Rights'},
            //    {'code' : 'XOF', 'name' : 'Communauté Financière Africaine (BCEAO) Franc'},
            //    {'code' : 'XPF', 'name' : 'Comptoirs Français du Pacifique (CFP) Franc'},
            //    {'code' : 'YER', 'name' : 'Yemen Rial'},
            //    {'code' : 'ZAR', 'name' : 'South Africa Rand'},
            //    {'code' : 'ZMW', 'name' : 'Zambia Kwacha'},
            //    {'code' : 'ZWD', 'name' : 'Zimbabwe Dollar'}
            //]

        }

    public class NameAbbreviation
    {
        public string Abbreviation { get; internal set; }
        public string Name { get; internal set; }
    }

    public class FistNameData
    {
        public string[] Female { get; set; }
        public string[] Male { get; set; }
    }
}
