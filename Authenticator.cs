namespace KPZ_lab2
{
    internal sealed class Authenticator
    {
        private static Authenticator instance;

        private static readonly object lockObj = new object();

        private Authenticator() { }

        public static Authenticator Instance
        {
            get
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new Authenticator();
                    }
                    return instance;
                }
            }
        }

        public void Authenticate()
        {
            Console.WriteLine("Authentication successful.");
        }
    }
}
