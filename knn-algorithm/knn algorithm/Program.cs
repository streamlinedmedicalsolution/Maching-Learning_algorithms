using System;
using System.Collections;


namespace Streamlined
{

    /*
     * K-nearest neighbor (Knn) algorithm pseudocode:
      Let(Xi, Ci) where i = 1, 2……., n be data points.Xi denotes feature values & Ci denotes labels for Xi for each i.
      Assuming the number of classes as ‘c’
       Ci ∈ { 1, 2, 3, ……, c} for all values of i

      Let x be a point for which label is not known, and we would like to find the label class using k-nearest neighbor algorithms.

        
        
        Knn Algorithm Pseudocode:

        Calculate “d(x, xi)” i =1, 2, ….., n; where d denotes the Euclidean distance between the points.
        Arrange the calculated n Euclidean distances in non-decreasing order.
        Let k be a +ve integer, take the first k distances from this sorted list.
        Find those k-points corresponding to these k-distances.
        */





    class knnAlgoforblog
    {


      // static int[] a = {3,-1,2,0 };
       //static int[] b = { 3,-4,3,-5 };
       //static String[] classify = { "happy", "sad", "happy", "sad" };

        static int[] a = { 7,7,3,1 };
        static int[] b = {7,4,4,4 };

        static String[] classify = { "bad", "bad", "good", "good" };

        static double[] c = new double[4];
        static int[] rank = new int[4];


        static void Main(string[] args)
        {
            knnAlgoforblog p = new knnAlgoforblog();
            Console.WriteLine("the values for which we have to predict the classifier it belongs ");
            Console.WriteLine("Enter the x value");
            int k =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y value");
            int l= int.Parse(Console.ReadLine());
            p.Calculatedistance(k,l);
            p.Rank();
            Console.WriteLine("rankings of data sets based on distance from given userdefined values  ");
            for (int i = 0; i < 4; i++) Console.WriteLine("rank of {0} dataset is {1} and classifier is {2}",i,rank[i],classify[i]);
            p.Classify();
            Console.Read();
        }

        //calculates distance betweeen 
        void Calculatedistance(int k,int l)
        {
            for (int i = 0; i < 4; i++)
            {

                //calculating distance between the given point and everypoint and storing the value of distance between them in seperate array.
                double radius;
                 radius = ( ( (k - a[i]) * (k - a[i]) ) + ( (l - b[i]) * (l - b[i]) ) );
                c[i] = radius;

            }

            //for(int j=0;j<4;j++) { Console.Write(c[j]);  }

            //now to rank elements in the radius array.


            ///
           
        }


        void Rank()
        {

            //giving rank based on the distance between the point and the given data.
            int n = 4;
            for (int z = 0; z < 4; z++)
            {
                double[] c1 = c;
                double max = 0;
                int k = 0;


                for (int i = 0; i < 4; i++)
                {
                    if (c1[i] > max) { max = c1[i]; k = i; }

                }
                rank[k] = n--;
                c1[k] = 0;
               // Console.Write(rank[k] + " " + k);
                //Console.Read();
            }

        }


        //classifying the given data to which class it belongs based on the k nearest neighbhors given by the user. 
       //if the given value is like 1 we see the nearest neighbors and assign the same class of that.
       //if the user gives like k=3 and we see the 3 nearest neighbors and assign the same class of the majority of them belongs.
        void Classify()

        {

            //asking the user to give the kvalue.

            Console.WriteLine("enter the value for k");



            int knn = int.Parse(Console.ReadLine());

            int good = 0;
            int bad = 0;
            
            for(int i=1;i<=knn;i++)
            {
                int j = 0;
                while (rank[j] != i) j++;

                if (classify[j] == "good") good++;
                else bad++;

            }
            //Console.WriteLine(good + "" + bad);
            if (good >=
                bad) Console.WriteLine("happy tissue good");
            else Console.WriteLine("sad bad");

        }



    }
}
