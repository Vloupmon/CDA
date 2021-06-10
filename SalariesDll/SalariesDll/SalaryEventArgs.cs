namespace SalariesDll {

    using System;

    public class SalaryEventArgs : EventArgs {
        private uint _formerSalary;
        private uint _currentSalary;

        public uint FormerSalary {
            get => _formerSalary;
            set => _formerSalary = value;
        }

        public uint CurrentSalary {
            get => _currentSalary;
            set => _currentSalary = value;
        }
    }
}