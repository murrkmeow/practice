namespace task3
{
    class MyInfo
    {
        private string name;

        public event EventHandler<string> NameChanged;

        public string Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnNameChanged(name);
                }
            }
        }

        protected virtual void OnNameChanged(string newName)
        {
            NameChanged?.Invoke(this, newName);
        }
    }

}
