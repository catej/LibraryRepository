using DataStructuresApp;
using datastructures.structures;

namespace datastructures
{
    public class MyQueue : MyDefaultStructure
    {
        public MyQueue()
        {
            this.structureName = "Queue";
            this.methods = new string[] { "Add node", "Remove node" }; // add to UseSelectedMethod() : switch
            SeedData();
        }
        public override void SeedData()
        {
            AddNodeAtEnd(1);
            AddNodeAtEnd(2);
            AddNodeAtEnd(10);
            AddNodeAtEnd(3);
            AddNodeAtEnd(7);
            AddNodeAtEnd(5);
            AddNodeAtEnd(4);
            AddNodeAtEnd(6);
            AddNodeAtEnd(8);
        }
        public override void UseSelectedMethod(int methodChoice)
        {
            int numberToAdd;
            switch (methodChoice)
            {
                case 0:
                    numberToAdd = UI.ValidateInteger();
                    AddNodeAtEnd(numberToAdd);
                    break;
                case 1:
                    RemoveNodeAtBeginning();
                    break;
            }
        }
    }
}
