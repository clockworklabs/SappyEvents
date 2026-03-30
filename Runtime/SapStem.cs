namespace Sappy
{
    public class SapStem
    {
        public SapTargets Targets { get; }
        private bool CreateMulticastDelegate { get; }

        public SapStem(int? initialSize = null, bool createMulticastDelegate = false)
        {
            Targets = new SapTargets(initialSize);
            CreateMulticastDelegate = createMulticastDelegate;
        }

        public void Send()
        {
            if (CreateMulticastDelegate)
            {
                Targets.Resolved?.Invoke();
            }
            else
            {
                for (var i = Targets.Count - 1; i >= 0; i--)
                {
                    Targets[i].Invoke();
                }
            }
        }
    }

    public class SapStem<T>
    {
        public SapTargets<T> Targets { get; }
        private bool CreateMulticastDelegate { get; }

        public SapStem(int? initialSize = null, bool createMulticastDelegate = false)
        {
            Targets = new SapTargets<T>(initialSize);
            CreateMulticastDelegate = createMulticastDelegate;
        }

        public void Send(T value)
        {
            if (CreateMulticastDelegate)
            {
                Targets.Resolved?.Invoke(value);
            }
            else
            {
                for (var i = Targets.Count - 1; i >= 0; i--)
                {
                    Targets[i].Invoke(value);
                }
            }
        }
    }

    public class SapStem<T1, T2>
    {
        public SapTargets<T1, T2> Targets { get; }
        private bool CreateMulticastDelegate { get; }

        public SapStem(int? initialSize = null, bool createMulticastDelegate = false)
        {
            Targets = new SapTargets<T1, T2>(initialSize);
            CreateMulticastDelegate = createMulticastDelegate;
        }

        public void Send(T1 v1, T2 v2)
        {
            if (CreateMulticastDelegate)
            {
                Targets.Resolved?.Invoke(v1, v2);
            }
            else
            {
                for (var i = Targets.Count - 1; i >= 0; i--)
                {
                    Targets[i].Invoke(v1, v2);
                }
            }
        }
    }

    public class SapStem<T1, T2, T3>
    {
        public SapTargets<T1, T2, T3> Targets { get; }
        private bool CreateMulticastDelegate { get; }

        public SapStem(int? initialSize = null, bool createMulticastDelegate = false)
        {
            Targets = new SapTargets<T1, T2, T3>(initialSize);
            CreateMulticastDelegate = createMulticastDelegate;
        }

        public void Send(T1 v1, T2 v2, T3 v3)
        {
            if (CreateMulticastDelegate)
            {
                Targets.Resolved?.Invoke(v1, v2, v3);
            }
            else
            {
                for (var i = Targets.Count - 1; i >= 0; i--)
                {
                    Targets[i].Invoke(v1, v2, v3);
                }
            }
        }
    }

    public class SapStem<T1, T2, T3, T4>
    {
        public SapTargets<T1, T2, T3, T4> Targets { get; }
        private bool CreateMulticastDelegate { get; }

        public SapStem(int? initialSize = null, bool createMulticastDelegate = false)
        {
            Targets = new SapTargets<T1, T2, T3, T4>(initialSize);
            CreateMulticastDelegate = createMulticastDelegate;
        }

        public void Send(T1 v1, T2 v2, T3 v3, T4 v4)
        {
            if (CreateMulticastDelegate)
            {
                Targets.Resolved?.Invoke(v1, v2, v3, v4);
            }
            else
            {
                for (var i = Targets.Count - 1; i >= 0; i--)
                {
                    Targets[i].Invoke(v1, v2, v3, v4);
                }
            }
        }
    }

    public class SapStem<T1, T2, T3, T4, T5>
    {
        public SapTargets<T1, T2, T3, T4, T5> Targets { get; }
        private bool CreateMulticastDelegate { get; }

        public SapStem(int? initialSize = null, bool createMulticastDelegate = false)
        {
            Targets = new SapTargets<T1, T2, T3, T4, T5>(initialSize);
            CreateMulticastDelegate = createMulticastDelegate;
        }

        public void Send(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5)
        {
            if (CreateMulticastDelegate)
            {
                Targets.Resolved?.Invoke(v1, v2, v3, v4, v5);
            }
            else
            {
                for (var i = Targets.Count - 1; i >= 0; i--)
                {
                    Targets[i].Invoke(v1, v2, v3, v4, v5);
                }
            }
        }
    }
}