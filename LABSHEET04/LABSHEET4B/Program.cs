/* 
LABSHEET 4B 
Create a Class called Rectangle and store length, width using constructor. 
Calculate the area using that.

Create tabletop using rectangle class and calculate the cost of painting that table top. 
(Use single inheritance)
*/

namespace Labsheet4B {
    // class : Rectangle 
    class Rectangle {
        // attributes : length, width
        public double length, width, area;
        // function : calculate area 
        public Rectangle(){
            this.length = 0;
            this.width = 0;
        }
        // function : area of the rectangle 
        public void CalculateArea(){
            this.area = length * width;
        }

    }

    // class : TableTop
    class TableTop : Rectangle{
        public TableTop(double length, double width){
            this.length = length;
            this.width = width;
        }

        // function : calculate the cost of painting 
        public void CostPainting(){
            // calculate the area
            this.CalculateArea();
            double CostPerArea = 10000;
            double cost = CostPerArea * this.area;
            // print: output
            Console.WriteLine($"Cost of painting: {cost}");
        }
    }

    // class : programme 
    class Programme {
        public static void Main(string[] args){
            // object : Table top
            TableTop tp = new TableTop(7,8);
            tp.CostPainting();
        }
    }
}