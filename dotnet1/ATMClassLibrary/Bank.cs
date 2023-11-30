using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMClassLibrary
{
    public class Bank
    {
        private string bankName;
        private List<AutomatedTellerMachine_> _automatedTellerMachines;

        public Bank(string bankName, List<AutomatedTellerMachine_> _automatedTellerMachines)
        {
            this.bankName = bankName;
            this._automatedTellerMachines = _automatedTellerMachines;
        }

        public string _bankName
        {
            get { return bankName; }
        }

        public List<AutomatedTellerMachine_> AutomatedTellerMachines
        {
            get { return _automatedTellerMachines; }
        }
    }
}
