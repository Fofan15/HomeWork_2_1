using System;
using System.IO;

namespace CodeHomework_2_1
{
    public class Result
    {
        private bool _status;
        public string _result = "I broke a logic";

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }

    }
}
