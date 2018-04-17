using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 
///     Machine learning
///     pjioewro;itj
///    problem statement:If a student made an 80 on the aptitude test, what grade would we expect her to make in statistics?
///     
///    linear regression algorithm using c# program
/// 
///       
///    linear regression using ordinary square method. 
/// 
///      formulas required:-
///      
///          slope = Σ [ (xi - x)(yi - y) ] / Σ [ (xi - x)2]
///          
///          iccntercept = y - b1 * x
///          
///          xi=sum of all x/n;
///          yi=sum of all y/n;
///          
/// 
///          now line equation for slope intercept form
///          
///          y=slope*x+(intercept)  where x=depend value for which we have to calculate the prediction value.
///          
/// 
/// 
///    In this we are feeding the program with the previous dataset and at the end it creates a best fitting line for the dataset so we can get the value.\
///         
///      
///        Coefficient of determination (R) can be found using
///                            
///                                           R2 = { ( 1 / N ) * Σ [ (xi - x) * (yi - y) ] / (σx * σy ) }2 
//       
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// </summary>

namespace streamlined
{
    class Machineleaningblog
    {

        int[] a = new int[5] { 95,85,80,70,60 };
        int[] b = new int[5] { 85,95,70,65,70};
        static double sumx = 0;
        static double sumy = 0;
        static double sigma = 0;
        static double sigmasquare = 0;
        static double slope;


        void calculate()
        {



            for (int i = 0; i < 5; i++)
            {
                sumx += a[i];
                sumy += b[i];

            }

           
            sumx = sumx / 5;
            sumy = sumy / 5;
            //Console.Write(sumx + "" + sumy);


            for (int k = 0; k < 5; k++)
            {
                 //double y = b[k] - sumy;
                 //double g = a[k] - sumx;
                 //double h = y * g;

                double h= (b[k] - sumy)*(a[k] - sumx);
                sigma += h;

            }

            // Console.Write(sigma);


            for (int l = 0; l < 5; l++)
            {
                // int y = b[k] - sumy;
              //double g = a[l] - sumx;


               double h =(a[l] - sumx)*( a[l] - sumx);
               sigmasquare += h;

            }


            //Console.Write(sigmasquare);
            slope = sigma / sigmasquare;
           

            ///calculating intercept of line

            double intercept = sumy - (slope * sumx);
            //Console.Write(slope+""+intercept);


            ////calculatng line equation...

            // if  u have any x value substitue in equation;
            Console.WriteLine("give the x value to get the dependent value:");




            int depend = Convert.ToInt16(Console.ReadLine());

            double predictvalue = slope * depend + intercept;



            Console.Write("predicted value is " + predictvalue);


        }


        static void Main(string[] args)
        {
            Machineleaningblog p = new Machineleaningblog();
            p.calculate();
            //p.slopeofline();
            Console.ReadLine();



        }
    }
}
