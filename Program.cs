using System;
using SimRK;

class Program
{
    static void Main(string[] args)
    {
        double t = 0.0;
        double tEnd = 10.0;
        double dt = 0.02;
        string s;

        SimplePendRK p = new SimplePendRK();
        //--------------------------------------------------------------------
        //  Runge Kutta 4th Order
        //--------------------------------------------------------------------
        while (t < tEnd)
        {
            p.RungeKutta(dt, t, tEnd);
            s = $"{t.ToString("0.####")}   {p.thetaans.ToString("0.####")}   {p.thetaDotans.ToString("0.####")}";
            Console.WriteLine(s);
            
            t += dt;                    
        }   
    } 
}
