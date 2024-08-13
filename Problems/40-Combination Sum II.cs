public class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        var resultList = new List<IList<int>>();

        Array.Sort(candidates);

        FindCombinations(candidates, 0, target, new List<int>(), resultList);

        return resultList;
    }

    void FindCombinations(int[] candidates, int startIndex, int target, List<int> currentCombination, List<IList<int>> resultList)
    {
        if (target == 0)
        {
            resultList.Add(new List<int>(currentCombination));
            return;
        }

        for (var i = startIndex; i < candidates.Length && target >= candidates[i]; i++)
        {
            if (i > startIndex && candidates[i] == candidates[i - 1]) continue;
            if (candidates[i] > target) break;

            currentCombination.Add(candidates[i]);
            FindCombinations(candidates, i + 1, target - candidates[i], currentCombination, resultList);
            currentCombination.RemoveAt(currentCombination.Count - 1);
        }
    }
}