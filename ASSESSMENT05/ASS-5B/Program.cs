/* 
ASSESSMENT 5B
A University has decided promotion criteria for students. 
According to criteria a student cannot be promoted to next academic year 
if he has less than 4.5 CGPA. A developer is trying to implement this situation 
using exception handling by reading the necessary details of all 6 subjects. 
Hint: CGPA = (Percentage / 9.5)
*/

class Programme {
    public static void Main(string[] args){
        // array : to store the score of 6 subjects 
        int[] Scores = new int[6];
        int SumScores = 0;

        // input : 6 subjects
        for(int i = 0;i < 6;i++){
            Console.Write($"Enter the score{i+1}: ");
            Scores[i] = Convert.ToInt32(Console.ReadLine());
            // calculate : sum of scores 
            SumScores += Scores[i];
        }

        // calculate : percentage 
        float Percentage = (float)((SumScores / 600.00) * 100);

        // calculate : cgpa 
        float CGPA = (float)(Percentage / 9.5);

        // try-catch to handle the students who pass and fail
        try {
            if(CGPA > 4.5){
                Console.WriteLine($"PASS : You are eligible for the next semister(CGPA: {CGPA})");
            }else {
                throw new Exception("You Are Not eligible");
            }
        }catch(Exception e){
            Console.WriteLine($"FAIL : {e.Message}(CGPA: {CGPA})");
        }
        

    }
}