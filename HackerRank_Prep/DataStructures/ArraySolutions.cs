namespace HackerRank_Prep.DataStructures
{
    public class ArraySolutions
    {
        public static List<int> ReverseArray(List<int> a)
        {
            int j = 0;
            List<int> res = new();

            for (int i = a.Count - 1; i >= 0; i--, j++)
            {
                res.Add(a[i]);
            }
            return res;
        }
    }
}
