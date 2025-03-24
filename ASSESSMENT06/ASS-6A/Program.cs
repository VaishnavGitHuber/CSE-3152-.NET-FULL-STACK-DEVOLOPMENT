namespace Assessment6A {
    class Student {
        // variables : student rollnumber, name and Specialisation
        private int stdRoll = 25;
        private string name = "VAISHNAV KRISHNA P", specialisation = "CSE";

        // properties : get & set 
        public int StdRoll {
            get {
                return stdRoll;
            }
            set {
                stdRoll = value;
            }
        }
        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }
        public string Specialisation {
            get {
                return specialisation;
            }
            set {
                specialisation = value;
            }
        }
        
    }

    // class Programme 
    class Programme {
        public static void Main(string[] args){
            // object : student class 
            Student std1 = new Student();
            
            // get properties
            Console.WriteLine($"Enter the student Roll Number: {std1.StdRoll}");
            Console.WriteLine($"Enter the student Name: {std1.Name}");
            Console.WriteLine($"Enter the student Specialisation: {std1.Specialisation}");

            // set properties 
            std1.Name = "Kiran P";
            std1.Specialisation = "DA";
            std1.StdRoll = 54;

            // get after set 
            Console.WriteLine($"\n\nEnter the student Roll Number(after setting): {std1.StdRoll}");
            Console.WriteLine($"Enter the student Name(after setting): {std1.Name}");
            Console.WriteLine($"Enter the student Specialisation(after setting): {std1.Specialisation}");
        }
    }
}