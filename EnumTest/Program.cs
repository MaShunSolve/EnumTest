internal class Program
{
    private static void Main(string[] args)
    {
        List<MailTarget> mailTargets = new List<MailTarget>() { MailTarget.LI, MailTarget.GI };
        if (mailTargets.IndexOf(MailTarget.LI) != -1)
        {
            Console.WriteLine("LI");
        }
        if (mailTargets.IndexOf(MailTarget.GI) != -1)
        {
            Console.WriteLine("GI");
        }
        if (mailTargets.IndexOf(MailTarget.U) != -1)
        {
            Console.WriteLine("U");
        }
    }
    public enum MailTarget
    {

        /// <summary>
        /// Local IT
        /// </summary>
        LI = 1,
        /// <summary>
        /// Globle IT
        /// </summary>
        GI = 2,
        /// <summary>
        /// User
        /// </summary>
        U = 3,
        /// <summary>
        /// All
        /// </summary>
        A = 4
    }
}