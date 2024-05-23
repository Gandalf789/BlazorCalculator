namespace BlazorApp1;

public class Calculation
{
    public double numberVal { get; set; } = 0;
    
    public string numberStr { get; set; } = "";

    public char? operation { get; set; }

    //If true, the current shown number is the number that must be stored
    public bool numEntered { get; set; } = false;

    public bool IsDecimal { get; set; } = false;

    public void AddNum(int num)
    {
        if (num == -1)
        {
            numberStr += ".";
            IsDecimal = true;
        }
        else
        {
            numberStr += num.ToString();
        }
    }
    
    public void Erase()
    {
        numberStr = String.Empty;
        numEntered = false;
        operation = null;
        numberVal = 0;
    }
}