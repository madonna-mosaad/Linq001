namespace Linq001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators
            #region Q01
            //var Result = ListGenerator.ProductsList.Where(P => P.UnitsInStock == 0);
            //foreach (var Unit in Result)
            //{
            //    Console.WriteLine(Unit);
            //}
            #endregion
            #region Q02
            //var result = from P in ListGenerator.ProductsList
            //             where P.UnitsInStock > 0 && P.UnitPrice > 3.00M
            //             select P;
            //foreach (var Unit in result)
            //{
            //    Console.WriteLine(Unit);
            //}
            #endregion
            #region Q03
            //string[] AA = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var aa = AA.Where((A, I) => A.Length < I);
            //foreach (var A in aa)
            //{
            //    Console.WriteLine(A);
            //}
            #endregion
            #endregion
            #region  Ordering Operators
            #region Q01
            //var list = ListGenerator.ProductsList.OrderBy(P => P.ProductName);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q02
            //string[] Arr01 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var arr01 = Arr01.OrderBy(A => A);
            //foreach (var A in arr01)
            //{
            //    Console.WriteLine(A);
            //}
            #endregion
            #region Q03
            //var listDes = ListGenerator.ProductsList.OrderByDescending(P => P.UnitsInStock);
            //foreach (var item in listDes)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q04
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Array01 = Arr.OrderBy(A => A.Length).ThenBy(B => B);
            //foreach (var A in Array01)
            //{
            //    Console.WriteLine(A);
            //}

            #endregion
            #region Q05
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var wsort = words.OrderBy(w => w.Length).ThenBy(w => w);
            //foreach (var word in wsort)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region Q06
            //var sortDes=ListGenerator.ProductsList.OrderByDescending(P=>P.Category).ThenByDescending(P=>P.UnitPrice);
            //foreach (var item in sortDes)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q07
            //string[] Arrr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Arrray = Arrr.OrderBy(A=>A.Length).ThenByDescending(B=>B);
            //foreach (var A in Arrray)
            //{
            //    Console.WriteLine(A);
            //}

            #endregion
            #region Q08
            //string[] Ar = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Aray = Ar.Where(A => A[1] == 'i').Reverse();
            //foreach (var A in Aray)
            //{
            //    Console.WriteLine(A);
            //}

            #endregion
            #endregion
            
        }
    }
}
