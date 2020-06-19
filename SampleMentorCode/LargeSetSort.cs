using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMentorCode
{
    class LargeSetSort
    {
        public void Run()
        {
            string inputFilePath = @"";
            string splitFolderPath = @"";
            string outputFilePath = @"";
            var largeDoubleSet = GetLargeSet(inputFilePath);
            Split(largeDoubleSet, splitFolderPath);
            Merge(splitFolderPath, outputFilePath);
        }

        private IEnumerable<double> GetLargeSet(string inputFilePath)
        {
            return File.ReadLines(inputFilePath).Select(x => double.Parse(x));
        }
        private  void Merge(string splitFolderPath, string outputFilePath)
        {
            var list = Enumerable.Range(0, 10)
                .Select(x => Path.Combine(splitFolderPath, x.ToString() + ".txt"))
                .SelectMany(x => File.ReadLines(x));

            File.WriteAllLines(outputFilePath, list);
        }

        private void Split(IEnumerable<double> largeSet, string splitFolderPath)
        {
            // Here we assume the numbers in the set fairly distribute in the range of [0, 50).
            // And we want to split them into 10 subsets to meet the space requirement.
            Dictionary<int, List<double>> internalDict = new Dictionary<int, List<double>>();            
            for(int i = 0; i < 10; i++)
                internalDict.Add(i, new List<double>());
            
            // In this step, we split the data into several subsets.
            // For now we ignore the space requirement.
            foreach(double d in largeSet)            
                internalDict[GetKey(d)].Add(d);
            
            // Output the subset into respective files one by one.
            foreach(var item in internalDict)
            {
                string outputFilePath = Path.Combine(splitFolderPath, item.Key.ToString() + ".txt");
                File.WriteAllLines(outputFilePath, item.Value.Select(x => x.ToString()));
            }
        }

        private int GetKey(double d)
        {
            // This function gives a mapping from the range [0, 50) to integers {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}
            // While the order is preserved.
            // i.e.
            // if i<=j, then GetKey(i)<=GetKey(j)
            return (int)((d / 10) / 0.5);
        }
    }
}
