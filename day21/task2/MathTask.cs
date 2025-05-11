namespace task2
{
    class MathTask
    {
        public double Result { get; private set; }
        private double b;
        private int taskType;
        private int delay;
    
        public MathTask(double b, int type, int delayMs)
        {
            this.b = b;
            this.taskType = type;
            this.delay = delayMs;
        }
    
        public void Compute()
        {
            if (taskType == 1)
            {
                double insideRoot = b * b - 4;
                double numerator = Math.Sqrt(2 * b + 2 * Math.Sqrt(insideRoot));
                double denominator = Math.Sqrt(insideRoot + b + 2);
                Result = numerator / denominator;
            }
            else if (taskType == 2)
            {
                Result = 1 / Math.Sqrt(b + 2);
            }
    
            Thread.Sleep(delay);
        }
    }
}
