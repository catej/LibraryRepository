using DataStructuresApp;
using datastructures.structures;

namespace datastructures
{
    public class MyStack : MyDefaultStructure
    {
        public MyStack()
        {
            this.structureName = "Stack";
            this.methods = new string[] { "Add node", "Remove node" }; // add to UseSelectedMethod() : switch
            SeedData();
        }
        public override void SeedData()
        {
            AddNodeAtBeginning(1);
            AddNodeAtBeginning(2);
            AddNodeAtBeginning(10);
            AddNodeAtBeginning(3);
            AddNodeAtBeginning(7);
            AddNodeAtBeginning(5);
            AddNodeAtBeginning(4);
            AddNodeAtBeginning(6);
            AddNodeAtBeginning(8);
        }
        public override void UseSelectedMethod(int methodChoice)
        {
            int numberToAdd;
            switch (methodChoice)
            {
                case 0:
                    numberToAdd = UI.ValidateInteger();
                    AddNodeAtBeginning(numberToAdd);
                    break;
                case 1:
                    RemoveNodeAtBeginning();
                    break;
            }
        }
    }
}