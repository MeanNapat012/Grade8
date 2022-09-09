public class Grade
{
    public static int ConvertStringtoint(string value)
    {
        if(int.TryParse(value, out int value)) return number;
        else throw new System.Exception("Input score!!");
    }
    public static string ConvertScoreTograde(int score)
    {
        if(score > 100) throw new System.Exception("Score > 100");
        else if(GradeA(score)) return "Grade A";
        else if(GradeBplus(score)) return "Grade B+";
        else if(GradeB(score)) return "Grade B";
        else if(GradeCplus(score)) return "Grade C+";
        else if(GradeC(score)) return "Grade C";
        else if(GradeDplus(score)) return "Grade D+";
        else if(GradeD(score)) return "Grade D";
        else if(GradeF(score)) return "Grade F";
    }

    public static bool GradeA(int score){
        return score >= 80;
    }
    public static bool GradeBplus(int score){
        return score < 80 && score >= 75;
    }
    public static bool GradeB(int score){
        return score < 75 && score >= 70;
    }

    public static bool GradeCplus(int score){
        return score < 70 && score >= 65;
    }
    public static bool GradeC(int score){
        return score < 65 && score >= 60;
    }
    public static bool GradeDplus(int score){
        return score < 60 && score >= 55;
    }
    public static bool GradeD(int score){
        return score < 55 && score >= 50;
    }

    public static bool GradeF(int score){
        return score < 50;
    }
}