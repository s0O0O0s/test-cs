public class test{
    static int score = 0;
    
    public static void Main(){
        string input = System.Console.ReadLine();
        if (int.TryParse(input, out int inp))
        {
            int newScore = AddScore(inp);
            System.Console.WriteLine("現在の合計スコア: " + newScore);
        }
        else
        {
            System.Console.WriteLine("数字を入力してください。");
        }        int score = AddScore(inp);
    }
    
    
    static int AddScore(int user){
        score += user;
        return score;
    }
    
    
    
    
    
    
    
}
