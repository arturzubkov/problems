using System;

class ANGLE {
    static int computeAngle(double H, double M)
    {
    if (H < 0 || M < 0)
    Console.Write("Incorrect time format, please change your input");
    if (H == 12)
        H = 0;
    if (M == 60)
    {
        M=0;
        H += 1;
        if(H>12)
        H = H-12;
    }
    // Computing angles
    int Theta_H = (int)(0.5 * (H*60 + M));
    int Theta_M = (int) (6 * M);
    
    // Difference
    int Diff = Math.Abs(Theta_H - Theta_M);
    Diff = Math.Min(360 - Diff,Diff);
    return Diff;
}
public static void Main ()
{
    Console.WriteLine("Please enter Hours");
    string HOURS = Console.ReadLine();
    int H_int = Convert.ToInt32(HOURS);
    Console.WriteLine("Please enter Minutes");
    string MINUTES = Console.ReadLine();
    int M_int = Convert.ToInt32(MINUTES);
    Console.Write("The angle between hours arrow and minutes arrow is : ");
    Console.WriteLine(computeAngle(H_int,M_int));
}
}