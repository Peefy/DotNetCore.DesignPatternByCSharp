namespace VsCodeProOne.Patterns.MVCPattern
{
    public class StudentController
    {
        Student _model;
        StudentView _view;

        public StudentController(Student model, StudentView view)
        {
            this._model = model;
            this._view = view;
        }

        public string StudentName
        {
            get => _model.Name;
            set => _model.Name = value;
        }

        public string StudentRollNo
        {
            get => _model.RollNo;
            set => _model.RollNo = value;
        }

        public void UpdateView()
        {
            _view.PrintStudentDetails(_model.Name, _model.RollNo);
        }

    }

}
