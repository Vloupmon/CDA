namespace SalariesDll {

    using System;

    public class SalaryEventArgs : EventArgs {
        private uint _formerSalary;
        private uint _currentSalary;
        private int _raisePercentage;

        public uint FormerSalary {
            get => _formerSalary;
            set => _formerSalary = value;
        }

        public uint CurrentSalary {
            get => _currentSalary;
            set => _currentSalary = value;
        }

        public int RaisePercentage {
            get => _raisePercentage = (((int)CurrentSalary - (int)FormerSalary) / (int)FormerSalary) * 100;
            set => _raisePercentage = value;
        }
    }
}