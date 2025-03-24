namespace LABSHEET06 {
    public class Properties {
        // private attribute : Name
        private string name = "Vaishnav Krishna P";

        // properties in c# : get & set for the attribute Name 
        public string Name{
            get {
                return name;
            }
            set {
                name = value;
            }
        }

    }
    public class Programme {
        // main method : Main 
        public static void Main(string[] args){
            // create object : Properties 
            Properties class1 = new Properties();

            // Get the Name : using get property 
            Console.WriteLine($"Name of the person: {class1.Name}");

            // set the Name : using set property
            class1.Name = "Santhosh";
            Console.WriteLine($"Name of the person after updating: {class1.Name}");
        }
    }
}