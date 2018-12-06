using System;
using System.Collections.Generic;
using System.Text;

namespace LambadaThems.Function
{
    class twoParmsFunc:AlphaFunction
    {



       #region calc operation


        /// <summary>
        /// This func sum Two parms type of int 
        /// and return x+y
        /// </summary>
        /// <param name="x">(int)</param>
        /// <param name="y">(int)</param>
        /// <returns></returns>
        public int Add(int x,int y)
        {
            return x + y;
        }



        /// <summary>
        /// This func mul Two parms type of int 
        /// and return x+y
        /// </summary>
        /// <param name="x">(int)</param>
        /// <param name="y">(int)</param>
        /// <returns></returns>
        public int Mull(int x, int y)
        {
            return x * y;
        }


        /// <summary>
        /// This func divide Two parms type of float
        /// and return x/y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public float Divide(float x, float y)
        {
            try
            {
                return x / y;
             
            }
            catch (DivideByZeroException)
            {

                throw;
            }

        }



        #endregion


        #region Distance operation

        /// <summary>
        /// this functiont get two tuples(x,y) and return distance 
        /// </summary>
        /// <param name="from"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        /// 
        public float Distance(Tuple<float, float> from, Tuple<float, float> target)
        {

            float x_from = from.Item1;
            float y_from = from.Item2;

            float x_target = target.Item1;
            float y_target = target.Item2;


            /**/
            return 0;
        }



        #endregion





    }
}
