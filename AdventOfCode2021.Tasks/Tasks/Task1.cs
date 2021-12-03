using System.Linq;

namespace AdventOfCode2021.Tasks.Tasks
{
    public class Task1 : TaskBase<int>
    {
        public override int Excercise1()
        {
            var inputData = GetInputData<int>("InputData.Task1").ToList();

            int count = 0;
            for (int i = 1; i < inputData.Count; i++)
            {
                if (inputData[i] > inputData[i - 1])
                    count++;
            }

            return count;
        }

        public override int Excercise2()
        {
            var inputData = GetInputData<int>("InputData.Task1").ToList();

            int count = 0;
            int prevSum = inputData[0] + inputData[1] + inputData[2];
            for (int i = 1; i < inputData.Count - 2; i++)
            {
                int sum = inputData[i] + inputData[i + 1] + inputData[i + 2];
                if (sum > prevSum)
                    count++;
                prevSum = sum;
            }

            return count;
        }
    }
}