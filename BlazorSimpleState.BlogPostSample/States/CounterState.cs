using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSimpleState.BlogPostSample.States
{
    public class CounterState
    {
        public int CurrentCount { get; private set; }
        public void IncrementCounter()
        {
            CurrentCount++;
            OnCountChanged?.Invoke();
        }

        public void ResetCounter()
        {
            CurrentCount = 0;
            OnCountChanged?.Invoke();
        }

        public event Action OnCountChanged;
    }
}
