using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSimpleState.BlogPostSample.States
{
    public partial class CounterState
    {
        public class Manager
        {
            private readonly CounterState state;

            public Manager(CounterState state)
            {
                this.state = state;
            }

            public void IncrementCounter()
            {
                this.state.CurrentCount++;
                OnCountChanged?.Invoke();
            }

            public void ResetCounter()
            {
                this.state.CurrentCount = 0;
                OnCountChanged?.Invoke();
            }

            public event Action OnCountChanged;
        }
    }
}
