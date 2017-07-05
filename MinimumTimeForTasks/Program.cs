using System;

namespace MinimumTimeForTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getMinimumTimeForTasks(new int[]{1, 2, 2, 3, 3, 7}, 11));
        }

        private static int getMinimumTimeForTasks(int[] taskTimes, int availableWorkers)
        {
            Array.Sort(taskTimes); //1 2 2 3 3 7
            if(availableWorkers >= taskTimes.Length)
            {
                return taskTimes[taskTimes.Length - 1];
            }
            int[] sumArray = new int[taskTimes.Length];
            sumArray[0] = taskTimes[0];
            for(int k = 1 ; k < sumArray.Length ; k++)
            {
                sumArray[k] = sumArray[k - 1] + taskTimes[k]; // 1 3 5 8 11 18
            }
            if(availableWorkers == 1)
            {
                return sumArray[sumArray.Length -1];
            }
            if(sumArray[sumArray.Length -2] <= taskTimes[taskTimes.Length - 1])
            {
                return taskTimes[taskTimes.Length - 1];
            }
            int minTimeSoFar = taskTimes[taskTimes.Length  - 1];
            int workersUsedSoFar  = 1;
            int sumOffset = 0;
            int indexIntoSumArray = 0;
            int skipSum = 0;
            int i  = 0;

            while(true)
            {
                while(workersUsedSoFar < availableWorkers && indexIntoSumArray < sumArray.Length - 1)
                {
                    while(sumArray[indexIntoSumArray] - sumOffset - skipSum <= minTimeSoFar)
                    {
                        indexIntoSumArray++;
                    }
                    workersUsedSoFar++;
                    sumOffset = sumArray[indexIntoSumArray - 1] - skipSum;
                }
                if(indexIntoSumArray == sumArray.Length - 1)
                {
                    return minTimeSoFar;
                }
                minTimeSoFar = taskTimes[taskTimes.Length - 1] + taskTimes[i]; // 7 + 1 
                skipSum = taskTimes[i++];
                workersUsedSoFar = 1;
                indexIntoSumArray = 0;
                sumOffset = 0;
        }
    }
    }
}
