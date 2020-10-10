using DataStructuresApp;

namespace datastructures.structures
{
    public abstract class MyDefaultStructure
    {
        public Node head;
        public int count;
        string[] methods;
        string structureName;
        static MyDefaultStructure() {}

        public void Exe()
        {
            string prompt = $"You are using a: {structureName}.\n\nWhat would you like to do? ";
            string menu = UI.DisplayMenu(methods, prompt);
            int methodChoice = UI.ValidateInteger(0, methods.Length, menu);
            while(!methodChoice.Equals(methods.Length))
            {
                UseSelectedMethod(methodChoice);
                methodChoice = UI.ValidateInteger(0, methods.Length, menu);
            }
        }
        public abstract void SeedData();
        public abstract void UseSelectedMethod(int methodChoice);
    }
}