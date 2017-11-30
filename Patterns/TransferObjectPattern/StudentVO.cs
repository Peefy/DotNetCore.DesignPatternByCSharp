namespace VsCodeProOne.Patterns.TransferObjectPattern
{
    public class StudentVO
    {
        public StudentVO(string name, int roolNo)
        {
            Name = name;
            RollNo = roolNo;
        }

        public string Name {get;set;}
        public int RollNo {get;set;}
    }

}
