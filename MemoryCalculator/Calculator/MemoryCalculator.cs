using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    // Decided to not add exception hanlding in the calculator class and this class. All exception handling should be done outside
    // the class anyways. The calculaor class should not mess with any sort of exception handling.
    public class MemoryCalculator : Calculator
    {
        public bool MemoryActive { get; private set; }

        private decimal memoryValue = 0m;

        public MemoryCalculator() : base() { }

        public void MemoryStore(decimal value) { memoryValue = value; MemoryActive = true; }
        public void MemoryRecall() { CurrentValue = memoryValue; }
        public void MemoryAdd(decimal value) { memoryValue += value; MemoryActive = true; }
        public void MemoryClear() { memoryValue = 0m; MemoryActive = false; }
    }
}
