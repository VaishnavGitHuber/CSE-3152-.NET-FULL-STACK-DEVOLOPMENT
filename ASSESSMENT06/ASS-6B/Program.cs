class Progarmme {
    // delegate : creation
    delegate void Area(int a, int b);
    public static void Main(string[] args){
        // object of delegates 
        Area TriArea = new Area(AreaTrangle);
        Area TriRect = new Area(AreaRectangle);
        // invoke : delegate 
        TriArea(7,8);
        TriRect(9,6);
    }
    // function : Area of trangle 
    public static void AreaTrangle(int bredth, int height){
        Console.WriteLine($"Area of Trangle: {bredth * height * 0.5}");
    }
    // function : area of the rectangle 
    public static void AreaRectangle(int length, int bredth){
        Console.WriteLine($"Area of Rectangle: {length * bredth}");
    }
}